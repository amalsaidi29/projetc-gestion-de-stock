namespace projetfs.Resources
{
    partial class FRM_Connexion
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
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            btnquiter = new Button();
            label1 = new Label();
            txtutilisateur = new TextBox();
            panel5 = new Panel();
            txtmotdepasse = new TextBox();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(319, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 384);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 2);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 380);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 382);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 2);
            panel4.TabIndex = 1;
            // 
            // btnquiter
            // 
            btnquiter.FlatAppearance.BorderSize = 0;
            btnquiter.FlatStyle = FlatStyle.Flat;
            btnquiter.Image = Properties.Resources.Button_Delete_icon;
            btnquiter.Location = new Point(279, 3);
            btnquiter.Name = "btnquiter";
            btnquiter.Size = new Size(36, 41);
            btnquiter.TabIndex = 2;
            btnquiter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 64);
            label1.Name = "label1";
            label1.Size = new Size(218, 42);
            label1.TabIndex = 3;
            label1.Text = "Connexion ";
            // 
            // txtutilisateur
            // 
            txtutilisateur.BackColor = Color.FromArgb(30, 28, 38);
            txtutilisateur.BorderStyle = BorderStyle.None;
            txtutilisateur.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtutilisateur.ForeColor = Color.FromArgb(224, 224, 224);
            txtutilisateur.Location = new Point(51, 150);
            txtutilisateur.Name = "txtutilisateur";
            txtutilisateur.Size = new Size(222, 27);
            txtutilisateur.TabIndex = 4;
            txtutilisateur.Text = "Nom d'utilisateur";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(51, 183);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 5;
            // 
            // txtmotdepasse
            // 
            txtmotdepasse.BackColor = Color.FromArgb(30, 28, 38);
            txtmotdepasse.BorderStyle = BorderStyle.None;
            txtmotdepasse.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmotdepasse.ForeColor = Color.FromArgb(224, 224, 224);
            txtmotdepasse.Location = new Point(51, 226);
            txtmotdepasse.Name = "txtmotdepasse";
            txtmotdepasse.Size = new Size(240, 27);
            txtmotdepasse.TabIndex = 6;
            txtmotdepasse.Text = "Mot de Passe";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(51, 259);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 1);
            panel6.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_32;
            pictureBox1.Location = new Point(14, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 34);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Motdepasse_32;
            pictureBox2.Location = new Point(14, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(178, 8, 55);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(14, 302);
            button2.Name = "button2";
            button2.Size = new Size(277, 43);
            button2.TabIndex = 10;
            button2.Text = "Se Connecter";
            button2.UseVisualStyleBackColor = false;
            // 
            // FRM_Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(321, 384);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(txtmotdepasse);
            Controls.Add(panel5);
            Controls.Add(txtutilisateur);
            Controls.Add(label1);
            Controls.Add(btnquiter);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Connexion";
            Text = "FRM_Connexion";
            Load += FRM_Connexion_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button btnquiter;
        private Label label1;
        private TextBox txtutilisateur;
        private Panel panel5;
        private TextBox txtmotdepasse;
        private Panel panel6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}