using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using projetfs.DAL;
using projetfs.Models;

namespace projetfs
{
    public partial class FRM_Modifier_Ajouter_Produit : UserControl
    {
        private readonly ApplicationDbContext _dbContext;
        private DataGridView dvgclient = new DataGridView();

        public FRM_Modifier_Ajouter_Produit(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            InitializeComponent();

            // Configuration du DataGridView
            dvgclient.Name = "dvgclient";
            dvgclient.Dock = DockStyle.Fill;
            this.Controls.Add(dvgclient);

            ConfigureDataGridView();
            LoadProducts();
        }

        private void ConfigureDataGridView()
        {
            dvgclient.EnableHeadersVisualStyles = false;
            dvgclient.AutoGenerateColumns = false;
            dvgclient.AllowUserToAddRows = false;
            dvgclient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgclient.RowHeadersVisible = false;
            dvgclient.BackgroundColor = Color.White;
            dvgclient.GridColor = Color.LightGray;
            dvgclient.BorderStyle = BorderStyle.None;

            dvgclient.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Black,
                BackColor = Color.White,
                SelectionForeColor = Color.Black,
                SelectionBackColor = Color.LightGray,
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(3, 2, 3, 2)
            };

            dvgclient.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.LightGray,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            dvgclient.Columns.Clear();
            AddColumn("Id", "ID", 50);
            AddColumn("Nom", "Nom Produit", 120);
            AddColumn("Stock", "Quantité", 80, DataGridViewContentAlignment.MiddleCenter);
            AddColumn("Prix", "Prix (€)", 80, DataGridViewContentAlignment.MiddleRight, "C2");
            AddColumn("CategorieNom", "Catégorie", 120);

            dvgclient.Columns.Add(new DataGridViewImageColumn
            {
                DataPropertyName = "Image",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            });

            dvgclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void AddColumn(string name, string headerText, int width, DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleLeft, string format = null)
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
            {
                column.DefaultCellStyle.Format = format;
            }

            dvgclient.Columns.Add(column);
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

                dvgclient.DataSource = produitsAvecImages;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static Image? SafeByteArrayToImage(byte[]? byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        

        private void btnafficheIm_Click_1(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedId = (int)dvgclient.SelectedRows[0].Cells["Id"].Value;
            var produit = _dbContext.Produits.Find(selectedId);

            if (produit?.ImageData == null)
            {
                MessageBox.Show("Aucune image disponible", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var ms = new MemoryStream(produit.ImageData))
                {
                    var image = Image.FromStream(ms);
                    using (var viewer = new Form())
                    {
                        viewer.Text = $"Image du produit: {produit.Nom}";
                        viewer.Size = new Size(600, 600);
                        viewer.StartPosition = FormStartPosition.CenterScreen;
                        viewer.Controls.Add(new PictureBox { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom, Image = image });
                        viewer.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnajouterclient_Click_1(object sender, EventArgs e)
        {
            using (var frm = new FRM_Ajouter_Modifie(_dbContext))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadProducts();
            }
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0) return;

            var selectedId = (int?)dvgclient.SelectedRows[0].Cells["Id"].Value;
            if (selectedId == null) return;

            var produit = _dbContext.Produits.Find(selectedId);
            if (produit == null) return;

            using (var frm = new FRM_Ajouter_Modifie(_dbContext, produit))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    LoadProducts();
            }
        }
    }
}
