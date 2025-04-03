
using System;
using System.Windows.Forms;

namespace projetfs
{
    public partial class FRM_Categorie : UserControl
    {
        private static FRM_Categorie _instance;

        public static FRM_Categorie Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FRM_Categorie();
                }
                return _instance;
            }
        }

        private FRM_Categorie()
        {
            InitializeComponent();
        }

        private void btnajoutercategorie_Click(object sender, EventArgs e)
        {
            {
                AjouterCategorie frmcategorie = new AjouterCategorie();
                frmcategorie.ShowDialog();
            }
        }
    }

}

// 3️⃣ Constructeur privé pour empêcher la création d'autres instances


       