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
    public partial class FRM_Ajouter_Modifie : Form
    {
        private readonly ApplicationDbContext _dbContext;
        private Produit? _produitToEdit;
        private bool _isEditMode;
        private byte[]? _imageBytes;
        private readonly ErrorProvider errorProvider = new ErrorProvider();

        public FRM_Ajouter_Modifie(ApplicationDbContext dbContext, Produit? produit = null)
        {
            InitializeComponent();
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _produitToEdit = produit;
            _isEditMode = produit != null;
            InitializeForm();

        }

        private void InitializeForm()
        {
            Text = _isEditMode ? "Modifier Produit" : "Ajouter Produit";
            btnEnregister.Text = _isEditMode ? "Modifier" : "Enregistrer";
            LoadCategories();
            ConfigureValidation();
            if (_isEditMode) LoadProductData();
        }

        private void LoadCategories()
        {
            combocategorie.DataSource = _dbContext.Categories.ToList();
            combocategorie.DisplayMember = "Nom";
            combocategorie.ValueMember = "Id";
        }

        private void LoadProductData()
        {
            txtnomproduit.Text = _produitToEdit?.Nom;
            txtquantite.Text = _produitToEdit?.Stock.ToString();
            txtprix.Text = _produitToEdit?.Prix.ToString("0.00");
            combocategorie.SelectedValue = _produitToEdit?.CategorieId;

            if (_produitToEdit?.ImageData != null)
            {
                using (var ms = new MemoryStream(_produitToEdit.ImageData))
                {
                    pictureProduit.Image = Image.FromStream(ms);
                    _imageBytes = _produitToEdit.ImageData;
                }
            }
        }

        private void btnEnregister_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            try
            {
                if (_isEditMode && _produitToEdit != null)
                {
                    _produitToEdit.Nom = txtnomproduit.Text;
                    _produitToEdit.Stock = int.Parse(txtquantite.Text);
                    _produitToEdit.Prix = decimal.Parse(txtprix.Text);
                    _produitToEdit.CategorieId = (int)combocategorie.SelectedValue;
                    _produitToEdit.ImageData = _imageBytes;
                }
                else
                {
                    var produit = new Produit
                    {
                        Nom = txtnomproduit.Text,
                        Stock = int.Parse(txtquantite.Text),
                        Prix = decimal.Parse(txtprix.Text),
                        CategorieId = (int)combocategorie.SelectedValue,
                        ImageData = _imageBytes
                    };
                    _dbContext.Produits.Add(produit);
                }

                _dbContext.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'enregistrement: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        
        private void ConfigureValidation()
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            txtnomproduit.Validating += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtnomproduit.Text))
                {
                    errorProvider.SetError(txtnomproduit, "Le nom du produit est obligatoire.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtnomproduit, null);
                }
            };

            txtquantite.Validating += (s, e) =>
            {
                if (!int.TryParse(txtquantite.Text, out int qte) || qte < 0)
                {
                    errorProvider.SetError(txtquantite, "La quantité doit être un nombre entier positif.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtquantite, null);
                }
            };

            txtprix.Validating += (s, e) =>
            {
                if (!decimal.TryParse(txtprix.Text, out decimal prix) || prix <= 0)
                {
                    errorProvider.SetError(txtprix, "Le prix doit être un nombre valide supérieur à zéro.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtprix, null);
                }
            };
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                _dbContext?.Dispose();
                errorProvider.Dispose();
            }
            base.Dispose(disposing);
        }

        private void pictureProduit_Click_1(object sender, EventArgs e)
       
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
    }
}
