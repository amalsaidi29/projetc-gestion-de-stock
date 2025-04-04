using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using projetfs.Models; // Assurez-vous d'importer votre modèle de produit

namespace projetfs
{
    public partial class FRM_Details_Produit : Form
    {
        // Constructeur qui reçoit un produit pour afficher ses détails
        public FRM_Details_Produit(Produit produit)
        {
            InitializeComponent();
            ShowProductDetails(produit);
        }

        private void ShowProductDetails(Produit produit)
        {
            // Affichage des détails du produit dans les labels
            lblNom.Text = produit.Nom;
            lblCategorie.Text = produit.Categorie?.Nom ?? "Non spécifiée";
            lblStock.Text = produit.Stock.ToString();
            lblPrix.Text = $"{produit.Prix} €";

            // Affichage de l'image si disponible
            if (produit.ImageData != null)
            {
                using MemoryStream ms = new(produit.ImageData);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null; // Ne pas afficher d'image si elle est absente
            }
        }

       
    }
}