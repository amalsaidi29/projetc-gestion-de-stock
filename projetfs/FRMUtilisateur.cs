
using System;
using System.Windows.Forms;

namespace projetfs
{
    public partial class FRMUtilisateur : UserControl
    {
        private static FRMUtilisateur _instance;

        public static FRMUtilisateur Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FRMUtilisateur();
                }
                return _instance;
            }
        }

        private FRMUtilisateur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                AjouterUtilisateur frmutilisateur = new AjouterUtilisateur();
                frmutilisateur.ShowDialog();
            }
        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            {
                ModifierUtilisateur frmutilisateur = new ModifierUtilisateur();
                frmutilisateur.ShowDialog();
            }
        }
    }

}

// 3️⃣ Constructeur privé pour empêcher la création d'autres instances


