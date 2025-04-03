namespace projetfs
{
    partial class FRM_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            btncommande = new Button();
            pnlbutn = new Panel();
            btnproduit = new Button();
            btncategorie = new Button();
            btnutilisateur = new Button();
            btnclient = new Button();
            panelParametre = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnparam = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pnlaficher = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panelParametre.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btncommande);
            panel1.Controls.Add(pnlbutn);
            panel1.Controls.Add(btnproduit);
            panel1.Controls.Add(btncategorie);
            panel1.Controls.Add(btnutilisateur);
            panel1.Controls.Add(btnclient);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 694);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.Menu_32;
            button3.Location = new Point(161, 15);
            button3.Name = "button3";
            button3.Size = new Size(29, 23);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // btncommande
            // 
            btncommande.BackColor = Color.FromArgb(41, 39, 40);
            btncommande.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btncommande.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btncommande.FlatStyle = FlatStyle.Flat;
            btncommande.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncommande.ForeColor = SystemColors.ControlLightLight;
            btncommande.Image = Properties.Resources.shopping_icon;
            btncommande.ImageAlign = ContentAlignment.MiddleLeft;
            btncommande.Location = new Point(12, 449);
            btncommande.Name = "btncommande";
            btncommande.Size = new Size(205, 55);
            btncommande.TabIndex = 6;
            btncommande.Text = "       Commande";
            btncommande.UseVisualStyleBackColor = false;
            // 
            // pnlbutn
            // 
            pnlbutn.BackColor = Color.FromArgb(178, 8, 55);
            pnlbutn.Location = new Point(3, 81);
            pnlbutn.Name = "pnlbutn";
            pnlbutn.Size = new Size(10, 56);
            pnlbutn.TabIndex = 4;
            // 
            // btnproduit
            // 
            btnproduit.BackColor = Color.FromArgb(41, 39, 40);
            btnproduit.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnproduit.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnproduit.FlatStyle = FlatStyle.Flat;
            btnproduit.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproduit.ForeColor = SystemColors.ControlLightLight;
            btnproduit.Image = Properties.Resources.shop_cart_add_icon;
            btnproduit.ImageAlign = ContentAlignment.MiddleLeft;
            btnproduit.Location = new Point(12, 205);
            btnproduit.Name = "btnproduit";
            btnproduit.Size = new Size(214, 55);
            btnproduit.TabIndex = 4;
            btnproduit.Text = "    Produit";
            btnproduit.UseVisualStyleBackColor = false;
            btnproduit.Click += btnproduit_Click_1;
            // 
            // btncategorie
            // 
            btncategorie.BackColor = Color.FromArgb(41, 39, 40);
            btncategorie.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btncategorie.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btncategorie.FlatStyle = FlatStyle.Flat;
            btncategorie.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncategorie.ForeColor = SystemColors.ControlLightLight;
            btncategorie.Image = Properties.Resources.Categorie;
            btncategorie.ImageAlign = ContentAlignment.MiddleLeft;
            btncategorie.Location = new Point(12, 326);
            btncategorie.Name = "btncategorie";
            btncategorie.Size = new Size(214, 55);
            btncategorie.TabIndex = 3;
            btncategorie.Text = "    Categorie";
            btncategorie.UseVisualStyleBackColor = false;
            btncategorie.Click += btncategorie_Click_1;
            // 
            // btnutilisateur
            // 
            btnutilisateur.BackColor = Color.FromArgb(41, 39, 40);
            btnutilisateur.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnutilisateur.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnutilisateur.FlatStyle = FlatStyle.Flat;
            btnutilisateur.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnutilisateur.ForeColor = SystemColors.ControlLightLight;
            btnutilisateur.Image = Properties.Resources.customer_service_icon;
            btnutilisateur.ImageAlign = ContentAlignment.MiddleLeft;
            btnutilisateur.Location = new Point(12, 558);
            btnutilisateur.Name = "btnutilisateur";
            btnutilisateur.Size = new Size(214, 55);
            btnutilisateur.TabIndex = 2;
            btnutilisateur.Text = "   Utilisateur";
            btnutilisateur.UseVisualStyleBackColor = false;
            btnutilisateur.Click += btnutilisateur_Click_1;
            // 
            // btnclient
            // 
            btnclient.BackColor = Color.FromArgb(41, 39, 40);
            btnclient.FlatAppearance.BorderColor = Color.FromArgb(41, 39, 40);
            btnclient.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            btnclient.FlatStyle = FlatStyle.Flat;
            btnclient.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclient.ForeColor = SystemColors.ControlLightLight;
            btnclient.Image = Properties.Resources.Office_Client_Male_Light_icon;
            btnclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnclient.Location = new Point(12, 82);
            btnclient.Name = "btnclient";
            btnclient.Size = new Size(214, 55);
            btnclient.TabIndex = 0;
            btnclient.Text = "    Client";
            btnclient.UseVisualStyleBackColor = false;
            btnclient.Click += btnclient_Click;
            // 
            // panelParametre
            // 
            panelParametre.BackColor = Color.FromArgb(41, 39, 40);
            panelParametre.Controls.Add(button7);
            panelParametre.Controls.Add(button6);
            panelParametre.Controls.Add(button5);
            panelParametre.Controls.Add(button4);
            panelParametre.Location = new Point(49, 12);
            panelParametre.Name = "panelParametre";
            panelParametre.Size = new Size(359, 21);
            panelParametre.TabIndex = 9;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(41, 39, 40);
            button7.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLight;
            button7.Image = Properties.Resources.Deconnecte;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 156);
            button7.Name = "button7";
            button7.Size = new Size(352, 45);
            button7.TabIndex = 3;
            button7.Text = "Déonnecter";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(41, 39, 40);
            button6.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLight;
            button6.Image = Properties.Resources.Download;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 105);
            button6.Name = "button6";
            button6.Size = new Size(352, 45);
            button6.TabIndex = 2;
            button6.Text = "      Réstaurer une copie de l'application";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(41, 39, 40);
            button5.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLight;
            button5.Image = Properties.Resources.Copier;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 54);
            button5.Name = "button5";
            button5.Size = new Size(352, 45);
            button5.TabIndex = 1;
            button5.Text = "Créer une copie de l'application";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 39, 40);
            button4.FlatAppearance.BorderColor = Color.FromArgb(178, 8, 55);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 8, 55);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLight;
            button4.Image = Properties.Resources.Connected_16;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(352, 45);
            button4.TabIndex = 0;
            button4.Text = "Connecter";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnparam
            // 
            btnparam.FlatAppearance.BorderSize = 0;
            btnparam.FlatStyle = FlatStyle.Flat;
            btnparam.Image = Properties.Resources.Settings_32;
            btnparam.Location = new Point(254, 15);
            btnparam.Name = "btnparam";
            btnparam.Size = new Size(37, 36);
            btnparam.TabIndex = 8;
            btnparam.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.Subtract_32;
            button2.Location = new Point(1251, 13);
            button2.Name = "button2";
            button2.Size = new Size(29, 23);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Shutdown_32;
            button1.Location = new Point(1286, 11);
            button1.Name = "button1";
            button1.Size = new Size(37, 27);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Controls.Add(panelParametre);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(202, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1121, 10);
            panel2.TabIndex = 1;
            // 
            // pnlaficher
            // 
            pnlaficher.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlaficher.BackColor = SystemColors.Control;
            pnlaficher.Location = new Point(232, 57);
            pnlaficher.Name = "pnlaficher";
            pnlaficher.Size = new Size(1091, 636);
            pnlaficher.TabIndex = 10;
            pnlaficher.Paint += pnlaficher_Paint;
            // 
            // panel3
            // 
            panel3.Location = new Point(232, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(1071, 653);
            panel3.TabIndex = 2;
            // 
            // FRM_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 694);
            Controls.Add(pnlaficher);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(btnparam);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Menu";
            Text = "FRM_Menu";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            panelParametre.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        
        private Button btnclient;
        private Button btnproduit;
        private Button btncategorie;
        private Button btnutilisateur;
        private Panel pnlbutn;
        private Button btncommande;
        private Button button3;
  
        private Panel panelParametre;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button btnparam;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Panel pnlaficher;
        private Panel panel3;
    }
}