using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using projetfs.DAL;
using projetfs.Models;

namespace projetfs
{
    public partial class AjouterClient : Form
    {
        public AjouterClient()
        {
            InitializeComponent();
        }



        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textNom.Text))
            {
                MessageBox.Show("Le nom est obligatoire", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textprenon.Text))
            {
                MessageBox.Show("Le prénom est obligatoire", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textEmail.Text) || !new EmailAddressAttribute().IsValid(textEmail.Text))
            {
                MessageBox.Show("Email invalide", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                using var db = new ApplicationDbContext();
                var client = new Client
                {
                    Nom = textNom.Text,
                    Prenom = textprenon.Text,
                    Email = textEmail.Text,
                    Adresse = textAdresse.Text,
                    Telephone = texttelephone.Text,
                    Pays = textPays.Text
                };

                db.Clients.Add(client);
                db.SaveChanges();

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AjouterClient_Load(object sender, EventArgs e)
        {

        }
    }
}