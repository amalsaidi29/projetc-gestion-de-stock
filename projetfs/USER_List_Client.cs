using System;
using System.Drawing;
using System.Windows.Forms;

namespace projetfs
{
    public partial class USER_List_Client : UserControl

    {
        private static USER_List_Client Userclient;
        // Creer un instance pour le usercontrole
        public static USER_List_Client Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new USER_List_Client();
                }
                return Userclient;
            }
        }

        public USER_List_Client()
        {
            InitializeComponent();



        }

        private void USER_List_Client_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
           P
        }
    }
}
