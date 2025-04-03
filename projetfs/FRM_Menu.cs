using Microsoft.EntityFrameworkCore;
using projetfs.DAL;
using projetfs.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetfs
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 657);
            panelParametre.Visible = false;
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlaficher.Controls.Clear();
            var clientControl = new USER_List_Client();
            clientControl.Dock = DockStyle.Fill;
            pnlaficher.Controls.Add(clientControl);
        }


        private void btnproduit_Click_1(object sender, EventArgs e)
        {
            pnlbutn.Top = btnproduit.Top;

            // Créez une nouvelle instance au lieu d'utiliser un singleton
            var dbContext = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite("Data Source=dbclient.db")
                .Options);

            var produitControl = new FRM_Modifier_Ajouter_Produit(dbContext);

            // Supprimez les contrôles existants
            pnlaficher.Controls.Clear();

            // Ajoutez le nouveau contrôle
            produitControl.Dock = DockStyle.Fill;
            pnlaficher.Controls.Add(produitControl);
            produitControl.BringToFront();
        }
        

        private void btncategorie_Click(object sender, EventArgs e)
        {

        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlbutn.Top = btnutilisateur.Top;
        }

        private void btncommande_Click_1(object sender, EventArgs e)
        {
            pnlbutn.Top = btncommande.Top;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel1.Size = panel1.Width == 229 ? new Size(82, 657) : new Size(229, 657);
            panel1.Refresh();
        }

        private void btnparam_Click(object sender, EventArgs e)
        {
            panelParametre.Size = new Size(388, 208);
            panelParametre.Visible = !panelParametre.Visible;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FRM_Connexion frmc = new FRM_Connexion();
            frmc.ShowDialog();
        }

        private void pnlaficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncategorie_Click_1(object sender, EventArgs e)
        {
            pnlbutn.Top = btncategorie.Top;

            if (!pnlaficher.Controls.Contains(FRM_Categorie.Instance))
            {
                pnlaficher.Controls.Add(FRM_Categorie.Instance);
                FRM_Categorie.Instance.Dock = DockStyle.Fill; // Adapter au panel
                FRM_Categorie.Instance.BringToFront();
            }
            else
            {
                FRM_Categorie.Instance.BringToFront();
            }
        }

        private void btnutilisateur_Click_1(object sender, EventArgs e)
        {
            pnlbutn.Top = btnutilisateur.Top;

            if (!pnlaficher.Controls.Contains(FRMUtilisateur.Instance))
            {
                pnlaficher.Controls.Add(FRMUtilisateur.Instance);
                FRMUtilisateur.Instance.Dock = DockStyle.Fill; // Adapter au panel
                FRMUtilisateur.Instance.BringToFront();
            }
            else
            {
                FRMUtilisateur.Instance.BringToFront();
            }
        }
    }

}


