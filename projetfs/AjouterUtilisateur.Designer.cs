namespace projetfs
{
    partial class AjouterUtilisateur
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
            panel3 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            txtmotdepasse = new TextBox();
            panel5 = new Panel();
            txtutilisateur = new TextBox();
            label1 = new Label();
            btnquiter = new Button();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel7 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 505);
            panel3.TabIndex = 13;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 2);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(430, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 507);
            panel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(178, 8, 55);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(50, 441);
            button2.Name = "button2";
            button2.Size = new Size(325, 43);
            button2.TabIndex = 23;
            button2.Text = "Enregistrer ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Motdepasse_32;
            pictureBox2.Location = new Point(50, 278);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login_32;
            pictureBox1.Location = new Point(50, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 34);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(87, 311);
            panel6.Name = "panel6";
            panel6.Size = new Size(312, 1);
            panel6.TabIndex = 20;
            // 
            // txtmotdepasse
            // 
            txtmotdepasse.BackColor = Color.FromArgb(30, 28, 38);
            txtmotdepasse.BorderStyle = BorderStyle.None;
            txtmotdepasse.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtmotdepasse.ForeColor = Color.FromArgb(224, 224, 224);
            txtmotdepasse.Location = new Point(87, 278);
            txtmotdepasse.Name = "txtmotdepasse";
            txtmotdepasse.Size = new Size(330, 27);
            txtmotdepasse.TabIndex = 19;
            txtmotdepasse.Text = "Mot de Passe";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(87, 235);
            panel5.Name = "panel5";
            panel5.Size = new Size(312, 1);
            panel5.TabIndex = 18;
            // 
            // txtutilisateur
            // 
            txtutilisateur.BackColor = Color.FromArgb(30, 28, 38);
            txtutilisateur.BorderStyle = BorderStyle.None;
            txtutilisateur.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtutilisateur.ForeColor = Color.FromArgb(224, 224, 224);
            txtutilisateur.Location = new Point(87, 202);
            txtutilisateur.Name = "txtutilisateur";
            txtutilisateur.Size = new Size(312, 27);
            txtutilisateur.TabIndex = 17;
            txtutilisateur.Text = "Nom d'utilisateur";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 51);
            label1.Name = "label1";
            label1.Size = new Size(252, 36);
            label1.TabIndex = 16;
            label1.Text = "Ajouter Utilisateur";
            // 
            // btnquiter
            // 
            btnquiter.FlatAppearance.BorderSize = 0;
            btnquiter.FlatStyle = FlatStyle.Flat;
            btnquiter.Image = Properties.Resources.Button_Delete_icon;
            btnquiter.Location = new Point(393, 3);
            btnquiter.Name = "btnquiter";
            btnquiter.Size = new Size(36, 41);
            btnquiter.TabIndex = 15;
            btnquiter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 507);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 2);
            panel4.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Motdepasse_32;
            pictureBox3.Location = new Point(50, 363);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 34);
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(87, 396);
            panel7.Name = "panel7";
            panel7.Size = new Size(312, 1);
            panel7.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 28, 38);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(87, 363);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 24;
            textBox1.Text = " Confirmer Mot de Passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(32, 124);
            label2.Name = "label2";
            label2.Size = new Size(62, 28);
            label2.TabIndex = 27;
            label2.Text = "Type:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrateur", "Normal" });
            comboBox1.Location = new Point(100, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 28);
            comboBox1.TabIndex = 28;
            // 
            // AjouterUtilisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(432, 509);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(panel7);
            Controls.Add(textBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel6);
            Controls.Add(txtmotdepasse);
            Controls.Add(panel5);
            Controls.Add(txtutilisateur);
            Controls.Add(label1);
            Controls.Add(btnquiter);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjouterUtilisateur";
            Text = "AjouterUtilisateur";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel6;
        private TextBox txtmotdepasse;
        private Panel panel5;
        private TextBox txtutilisateur;
        private Label label1;
        private Button btnquiter;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Panel panel7;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
    }
}