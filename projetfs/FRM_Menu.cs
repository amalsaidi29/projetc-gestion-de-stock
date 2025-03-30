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
            pnlbutn.Top = btnclient.Top;
            if (!pnlaficher.Controls.Contains(USER_List_Client.Instance))
            {
                pnlaficher.Controls.Add(USER_List_Client.Instance);
                USER_List_Client.Instance.Dock = DockStyle.Fill;
                USER_List_Client.Instance.BringToFront();
            }
            else
            {
                USER_List_Client.Instance.BringToFront();
            }
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlbutn.Top = btnproduit.Top;
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlbutn.Top = btncategorie.Top;
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
            if (panel1.Width == 229)
            {
                panel1.Size = new Size(82, 657);
            }
            else
            {
                panel1.Size = new Size(229, 657);
            }
            panel1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panelParametre_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FRM_Connexion frmc = new FRM_Connexion();
            frmc.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (panel1.Width == 229)
            {
                panel1.Size = new Size(82, 657);
            }
            else
            {
                panel1.Size = new Size(229, 657);
            }
            panel1.Refresh();

        }

        private void btnparam_Click_1(object sender, EventArgs e)
        {

            panelParametre.Size = new Size(388, 208);
            panelParametre.Visible = !panelParametre.Visible;


        }

        private void btncommande_Click(object sender, EventArgs e)
        {

        }

        private void pnlaficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}