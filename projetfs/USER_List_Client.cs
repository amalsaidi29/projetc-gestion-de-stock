using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using projetfs.DAL;
using projetfs.Models;

namespace projetfs
{
    public partial class USER_List_Client : UserControl
    {
        private ApplicationDbContext _dbContext;

        public USER_List_Client()
        {
            InitializeComponent();
            InitializeDbContext();
            ConfigureDataGridView();
            LoadClients();
        }

        private void InitializeDbContext()
        {
            _dbContext = new ApplicationDbContext();
            _dbContext.Database.EnsureCreated();
        }

        private void ConfigureDataGridView()
        {
            // Désactiver les styles visuels par défaut (pour supprimer le bleu)
            dvgclient.EnableHeadersVisualStyles = false;

            // Configuration de base
            dvgclient.AutoGenerateColumns = false;
            dvgclient.AllowUserToAddRows = false;
            dvgclient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgclient.RowHeadersVisible = false;
            dvgclient.BackgroundColor = Color.White;
            dvgclient.GridColor = Color.LightGray;
            dvgclient.BorderStyle = BorderStyle.None;

            // Style des cellules
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

            // Style des en-têtes
            dvgclient.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.LightGray,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            // Configuration des colonnes
            dvgclient.Columns.Clear();

            // Colonne de sélection (checkbox)
            dvgclient.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "Select",
                Width = 50,
                FlatStyle = FlatStyle.Standard
            });

            // Colonnes principales
            AddColumn("Id", "ID", 50);
            AddColumn("Nom", "Nom", 120);
            AddColumn("Prenom", "Prénom", 120);
            AddColumn("Email", "Email", 200);
            AddColumn("Adresse", "Adresse", 200);
            AddColumn("Telephone", "Téléphone", 100);
            AddColumn("Ville", "Ville", 100);
            AddColumn("Pays", "Pays", 100);

            // Optionnel : Redimensionnement automatique des colonnes
            dvgclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void AddColumn(string name, string headerText, int width)
        {
            dvgclient.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                DataPropertyName = name,
                Width = width
            });
        }

        private void LoadClients()
        {
            try
            {
                _dbContext.Clients.Load();
                dvgclient.DataSource = _dbContext.Clients.Local.ToBindingList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de chargement: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0) return;

            var id = (int)dvgclient.SelectedRows[0].Cells["Id"].Value;
            var client = _dbContext.Clients.Find(id);

            if (client != null)
            {
                using var formModif = new FRM_Modifier_Client(client);
                if (formModif.ShowDialog() == DialogResult.OK)
                {
                    _dbContext.SaveChanges();
                    LoadClients();
                }
            }
        }

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0) return;

            var id = (int)dvgclient.SelectedRows[0].Cells["Id"].Value;
            var client = _dbContext.Clients.Find(id);

            if (client != null && MessageBox.Show("Confirmer la suppression ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _dbContext.Clients.Remove(client);
                _dbContext.SaveChanges();
                LoadClients();
            }
        }

        private void btnajouterclient_Click_1(object sender, EventArgs e)
        {
            using var formAjout = new AjouterClient();
            if (formAjout.ShowDialog() == DialogResult.OK)
            {
                LoadClients();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnmodifierclient_Click_1(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)dvgclient.SelectedRows[0].Cells["Id"].Value;
            var client = _dbContext.Clients.Find(id);

            if (client != null)
            {
                using var formModif = new FRM_Modifier_Client(client);
                if (formModif.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _dbContext.SaveChanges();
                        LoadClients();
                        MessageBox.Show("Client modifié avec succès", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la modification: {ex.Message}", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnsupprimerclient_Click_1(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer", "Avertissement",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var id = (int)dvgclient.SelectedRows[0].Cells["Id"].Value;
            var client = _dbContext.Clients.Find(id);

            if (client != null)
            {
                var confirmation = MessageBox.Show($"Voulez-vous vraiment supprimer {client.Nom} {client.Prenom} ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        _dbContext.Clients.Remove(client);
                        _dbContext.SaveChanges();
                        LoadClients();
                        MessageBox.Show("Client supprimé avec succès", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression: {ex.Message}", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filtrer les clients en fonction du critère sélectionné dans la ComboBox
            try
            {
                // Vérifier qu'un élément est sélectionné
                if (comboBox1.SelectedItem == null) return;

                // Récupérer le critère de filtrage sélectionné
                string filterCriteria = comboBox1.SelectedItem.ToString();

                // Appliquer le filtre en fonction du critère
                switch (filterCriteria)
                {
                    case "Tous les clients":
                        dvgclient.DataSource = _dbContext.Clients.Local.ToBindingList();
                        break;
                    case "Clients de Tunisie":
                        dvgclient.DataSource = _dbContext.Clients
                            .Where(c => c.Pays == "Tunisie")
                            .ToList();
                        break;
                    case "Clients avec email":
                        dvgclient.DataSource = _dbContext.Clients
                            .Where(c => !string.IsNullOrEmpty(c.Email))
                            .ToList();
                        break;
                    // Ajouter d'autres critères au besoin
                    default:
                        break;
                }

                // Actualiser l'affichage
                dvgclient.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du filtrage: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
            
            
            
            // Recherche en temps réel des clients selon le texte saisi
            try
            {
                // Récupérer le texte de recherche
                string searchText = textBox1.Text.Trim();

                // Si le champ est vide, afficher tous les clients
                if (string.IsNullOrEmpty(searchText))
                {
                    dvgclient.DataSource = _dbContext.Clients.Local.ToBindingList();
                    return;
                }

                // Filtrer les clients dont le nom, prénom ou email contient le texte recherché
                var filteredClients = _dbContext.Clients
                    .Where(c => c.Nom.Contains(searchText) ||
                               c.Prenom.Contains(searchText) ||
                               c.Email.Contains(searchText))
                    .ToList();

                // Mettre à jour la source de données du DataGridView
                dvgclient.DataSource = filteredClients;

                // Si aucun résultat, afficher un message
                if (filteredClients.Count == 0)
                {
                    MessageBox.Show("Aucun client trouvé", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}