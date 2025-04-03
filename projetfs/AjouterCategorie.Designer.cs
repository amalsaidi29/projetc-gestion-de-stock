namespace projetfs
{
    partial class AjouterCategorie
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
            panel5 = new Panel();
            txtutilisateur = new TextBox();
            label1 = new Label();
            btnquiter = new Button();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(2, 252);
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
            panel2.Size = new Size(412, 2);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(412, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 254);
            panel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(178, 8, 55);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(52, 196);
            button2.Name = "button2";
            button2.Size = new Size(277, 43);
            button2.TabIndex = 23;
            button2.Text = "Enregistrer";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(89, 148);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 18;
            // 
            // txtutilisateur
            // 
            txtutilisateur.BackColor = Color.FromArgb(30, 28, 38);
            txtutilisateur.BorderStyle = BorderStyle.None;
            txtutilisateur.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtutilisateur.ForeColor = Color.FromArgb(224, 224, 224);
            txtutilisateur.Location = new Point(89, 115);
            txtutilisateur.Name = "txtutilisateur";
            txtutilisateur.Size = new Size(222, 27);
            txtutilisateur.TabIndex = 17;
            txtutilisateur.Text = "Nom de Catégorie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 18);
            label1.Name = "label1";
            label1.Size = new Size(247, 36);
            label1.TabIndex = 16;
            label1.Text = "Ajouter Catégorie";
            // 
            // btnquiter
            // 
            btnquiter.FlatAppearance.BorderSize = 0;
            btnquiter.FlatStyle = FlatStyle.Flat;
            btnquiter.Image = Properties.Resources.Button_Delete_icon;
            btnquiter.Location = new Point(279, -68);
            btnquiter.Name = "btnquiter";
            btnquiter.Size = new Size(36, 41);
            btnquiter.TabIndex = 15;
            btnquiter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 254);
            panel4.Name = "panel4";
            panel4.Size = new Size(414, 2);
            panel4.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.Categorize_32;
            pictureBox1.Image = Properties.Resources.Categorize_32;
            pictureBox1.Location = new Point(52, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 34);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.Button_Delete_icon;
            button3.Location = new Point(376, 3);
            button3.Name = "button3";
            button3.Size = new Size(36, 41);
            button3.TabIndex = 24;
            button3.UseVisualStyleBackColor = true;
            // 
            // AjouterCategorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 38);
            ClientSize = new Size(414, 256);
            Controls.Add(button3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(panel5);
            Controls.Add(txtutilisateur);
            Controls.Add(label1);
            Controls.Add(btnquiter);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjouterCategorie";
            Text = "AjouterCategorie";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private Panel panel5;
        private TextBox txtutilisateur;
        private Label label1;
        private Button btnquiter;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Button button3;
    }
}