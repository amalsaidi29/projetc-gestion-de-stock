using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using projetfs.DAL;
using projetfs.Models;

// iText imports
using iText.Kernel.Pdf;
using iText.Layout;
using iText.IO.Image;
using iText.Kernel.Font;
using iTextImage = iText.Layout.Element.Image;       // Alias pour éviter conflit avec System.Drawing.Image
using iTextParagraph = iText.Layout.Element.Paragraph;

using System.Diagnostics;
using iText.Kernel.Exceptions;

namespace projetfs
{
    public partial class FRM_Modifier_Ajouter_Produit : UserControl
    {
        private readonly ApplicationDbContext _dbContext;

        // Constructeur avec injection du DbContext
        public FRM_Modifier_Ajouter_Produit(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            InitializeComponent();
            ConfigureDataGridView();
            LoadProducts();
        }

        // Configuration du style du DataGridView
        private void ConfigureDataGridView()
        {
            dvglclient.EnableHeadersVisualStyles = false;
            dvglclient.AllowUserToAddRows = false;
            dvglclient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvglclient.RowHeadersVisible = false;
            dvglclient.BackgroundColor = Color.White;
            dvglclient.GridColor = Color.WhiteSmoke;
            dvglclient.BorderStyle = BorderStyle.FixedSingle;
            dvglclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dvglclient.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Black,
                BackColor = Color.White,
                SelectionForeColor = Color.White,
                SelectionBackColor = Color.Gray,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(3)
            };

            dvglclient.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Gray,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            dvglclient.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White
            };

            dvglclient.Columns.Clear();
            AddColumn("Id", "ID", 50);
            AddColumn("Nom", "Nom Produit", 150);
            AddColumn("Stock", "Quantité", 80, DataGridViewContentAlignment.MiddleCenter);
            AddColumn("Prix", "Prix (€)", 100, DataGridViewContentAlignment.MiddleRight, "C2");
            AddColumn("CategorieNom", "Catégorie", 150);

            var imageColumn = new DataGridViewImageColumn
            {
                DataPropertyName = "Image",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100
            };
            dvglclient.Columns.Add(imageColumn);
        }

        private void AddColumn(string name, string headerText, int width, DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleLeft, string? format = null)
        {
            var column = new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                DataPropertyName = name,
                Width = width,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = alignment }
            };

            if (!string.IsNullOrEmpty(format))
                column.DefaultCellStyle.Format = format;

            dvglclient.Columns.Add(column);
        }

        private void LoadProducts()
        {
            try
            {
                var produits = _dbContext.Produits.Include(p => p.Categorie).ToList();

                var produitsAvecImages = produits.Select(p => new
                {
                    p.Id,
                    p.Nom,
                    p.Stock,
                    p.Prix,
                    CategorieNom = p.Categorie?.Nom ?? "Non classé",
                    Image = p.ImageData != null && p.ImageData.Length > 0 ? SafeByteArrayToImage(p.ImageData) : null
                }).ToList();

                dvglclient.DataSource = produitsAvecImages;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Convertit un tableau d'octets en Image System.Drawing.Image
        public static Image? SafeByteArrayToImage(byte[]? byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using MemoryStream ms = new(byteArray);
            return Image.FromStream(ms);
        }

        private void btnafficheIm_Click_1(object sender, EventArgs e)
        {
            if (dvglclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedId = (int)dvglclient.SelectedRows[0].Cells["Id"].Value;
            var produit = _dbContext.Produits.Find(selectedId);

            if (produit?.ImageData == null)
            {
                MessageBox.Show("Aucune image disponible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using MemoryStream ms = new(produit.ImageData);
                Image img = Image.FromStream(ms);
                using Form viewer = new()
                {
                    Text = $"Image du produit: {produit.Nom}",
                    Size = new Size(600, 600),
                    StartPosition = FormStartPosition.CenterScreen
                };
                viewer.Controls.Add(new PictureBox { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom, Image = img });
                viewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnajouterclient_Click_1(object sender, EventArgs e)
        {
            using var frm = new FRM_Ajouter_Modifie(_dbContext);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            if (dvglclient.SelectedRows.Count == 0) return;

            int selectedId = (int)dvglclient.SelectedRows[0].Cells["Id"].Value;
            var produit = _dbContext.Produits.Find(selectedId);
            if (produit == null) return;

            using var frm = new FRM_Modifier_Produit(_dbContext, produit);
            if (frm.ShowDialog() == DialogResult.OK)
                LoadProducts();
        }

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            if (dvglclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit à supprimer", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dvglclient.SelectedRows[0].Cells["Id"].Value;
            var produit = _dbContext.Produits.Find(id);

            if (produit != null)
            {
                var confirmation = MessageBox.Show($"Voulez-vous vraiment supprimer le produit {produit.Nom} ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        _dbContext.Produits.Remove(produit);
                        _dbContext.SaveChanges();
                        LoadProducts();
                        MessageBox.Show("Produit supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Produit non trouvé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            RechercherProduit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RechercherProduit();
        }

        private void RechercherProduit()
        {
            string recherche = textBox1.Text.ToLower();

            var produitsFiltres = _dbContext.Produits
                .Include(p => p.Categorie)
                .Where(p =>
                    p.Nom.ToLower().Contains(recherche) ||
                    p.Stock.ToString().Contains(recherche) ||
                    p.Prix.ToString().Contains(recherche))
                .Select(p => new
                {
                    p.Id,
                    p.Nom,
                    p.Stock,
                    p.Prix,
                    CategorieNom = p.Categorie.Nom
                })
                .ToList();

            dvglclient.DataSource = produitsFiltres;
        }

       
        private void buttIprimer_Click(object sender, EventArgs e)
        
{
    if (dvglclient.SelectedRows.Count == 0)
    {
        MessageBox.Show("Sélectionnez un produit avant d'imprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    int produitId = (int)dvglclient.SelectedRows[0].Cells["Id"].Value;
    var produit = _dbContext.Produits.Include(p => p.Categorie).FirstOrDefault(p => p.Id == produitId);

    if (produit == null)
    {
        MessageBox.Show("Produit introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    // Ouvrir le formulaire de détails du produit
    using var detailsForm = new FRM_Details_Produit(produit);
    detailsForm.ShowDialog(); // Afficher la fenêtre en modal
}
        } } 