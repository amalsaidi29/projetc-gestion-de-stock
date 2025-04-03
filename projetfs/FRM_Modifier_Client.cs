using System;
using System.Windows.Forms;
using projetfs.Models;

namespace projetfs
{
    public partial class FRM_Modifier_Client : Form
    {
        private readonly Client _client;

        public FRM_Modifier_Client(Client client)
        {
            InitializeComponent();
            _client = client;
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            // Chargement des données dans les champs
            textNom.Text = _client.Nom;
            textprenon.Text = _client.Prenom;
            textEmail.Text = _client.Email;
            texttelephone.Text = _client.Telephone ?? "";
            textAdresse.Text = _client.Adresse ?? "";
            textPays.Text = _client.Pays ?? "";
        }

       
            

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(textNom.Text) ||
                string.IsNullOrWhiteSpace(textprenon.Text) ||
                string.IsNullOrWhiteSpace(textEmail.Text))
            {
                MessageBox.Show("Les champs Nom, Prénom et Email sont obligatoires",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Mise à jour de l'objet client
            _client.Nom = textNom.Text.Trim();
            _client.Prenom = textprenon.Text.Trim();
            _client.Email = textEmail.Text.Trim();
            _client.Telephone = string.IsNullOrWhiteSpace(texttelephone.Text) ? null : texttelephone.Text.Trim();
            _client.Adresse = string.IsNullOrWhiteSpace(textAdresse.Text) ? null : textAdresse.Text.Trim();
            _client.Pays = string.IsNullOrWhiteSpace(textPays.Text) ? null : textPays.Text.Trim();

            // Fermeture du formulaire
            DialogResult = DialogResult.OK;
            Close();
        }
    }
    }
