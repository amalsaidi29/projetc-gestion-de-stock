using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using projetfs.Models;
using projetfs.DAL; // Assurez-vous d'importer l'espace de noms de votre `ApplicationDbContext`

namespace projetfs
{
    public partial class FRM_Modifier_Produit : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly Produit _produit;
        private byte[]? _imageBytes;

        public FRM_Modifier_Produit(ApplicationDbContext dbContext, Produit produit)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _produit = produit ?? throw new ArgumentNullException(nameof(produit));

            LoadCategories();
            LoadProductData();
        }

        private void LoadCategories()
        {
            // Chargement des catégories dans le ComboBox
            combocategorie.DataSource = _dbContext.Categories.ToList();
            combocategorie.DisplayMember = "Nom";
            combocategorie.ValueMember = "Id";
        }

        private void LoadProductData()
        {
            txtnomproduit.Text = _produit.Nom;
            txtquantite.Text = _produit.Stock.ToString();
            txtprix.Text = _produit.Prix.ToString("0.00");
            combocategorie.SelectedValue = _produit.CategorieId;

            if (_produit.ImageData != null)
            {
                using (var ms = new MemoryStream(_produit.ImageData))
                {
                    pictureProduit.Image = Image.FromStream(ms);
                    _imageBytes = _produit.ImageData;
                }
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtnomproduit.Text))
            {
                MessageBox.Show("Le nom du produit est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtquantite.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("La quantité doit être un nombre entier positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtprix.Text, out decimal prix) || prix <= 0)
            {
                MessageBox.Show("Le prix doit être un nombre valide supérieur à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (combocategorie.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_imageBytes == null)
            {
                MessageBox.Show("Veuillez sélectionner une image pour le produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }




        private void pictureProduit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _imageBytes = File.ReadAllBytes(ofd.FileName);
                    pictureProduit.Image = Image.FromFile(ofd.FileName);
                }
            }
        }





        private void btnEnregister_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            try
            {
                _produit.Nom = txtnomproduit.Text;
                _produit.Stock = int.Parse(txtquantite.Text);
                _produit.Prix = decimal.Parse(txtprix.Text);
                _produit.CategorieId = (int)combocategorie.SelectedValue;
                _produit.ImageData = _imageBytes;

                _dbContext.SaveChanges();

                MessageBox.Show("Produit modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } }
     
    
