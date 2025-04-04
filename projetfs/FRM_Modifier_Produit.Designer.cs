namespace projetfs
{
    partial class FRM_Modifier_Produit
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
            btnquiter = new Button();
            combocategorie = new ComboBox();
            label2 = new Label();
            btnEnregister = new Button();
            pictureBox4 = new PictureBox();
            panel7 = new Panel();
            txtprix = new TextBox();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            txtquantite = new TextBox();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            txtnomproduit = new TextBox();
            label1 = new Label();
            pictureProduit = new PictureBox();
            btnajouterclient = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduit).BeginInit();
            SuspendLayout();
            // 
            // btnquiter
            // 
            btnquiter.FlatAppearance.BorderSize = 0;
            btnquiter.FlatStyle = FlatStyle.Flat;
            btnquiter.Image = Properties.Resources.Button_Delete_icon;
            btnquiter.Location = new Point(693, 3);
            btnquiter.Name = "btnquiter";
            btnquiter.Size = new Size(36, 41);
            btnquiter.TabIndex = 44;
            btnquiter.UseVisualStyleBackColor = true;
            // 
            // combocategorie
            // 
            combocategorie.FormattingEnabled = true;
            combocategorie.Location = new Point(486, 107);
            combocategorie.Name = "combocategorie";
            combocategorie.Size = new Size(222, 28);
            combocategorie.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(366, 106);
            label2.Name = "label2";
            label2.Size = new Size(114, 24);
            label2.TabIndex = 42;
            label2.Text = "Categorie:";
            // 
            // btnEnregister
            // 
            btnEnregister.BackColor = Color.FromArgb(178, 8, 55);
            btnEnregister.FlatAppearance.BorderSize = 0;
            btnEnregister.FlatStyle = FlatStyle.Flat;
            btnEnregister.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnregister.ForeColor = SystemColors.ControlLightLight;
            btnEnregister.Location = new Point(232, 386);
            btnEnregister.Name = "btnEnregister";
            btnEnregister.Size = new Size(248, 43);
            btnEnregister.TabIndex = 41;
            btnEnregister.Text = "Enregistrer";
            btnEnregister.UseVisualStyleBackColor = false;
            btnEnregister.Click += btnEnregister_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.prix_32;
            pictureBox4.Location = new Point(449, 306);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 34);
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(486, 339);
            panel7.Name = "panel7";
            panel7.Size = new Size(222, 1);
            panel7.TabIndex = 38;
            // 
            // txtprix
            // 
            txtprix.BackColor = Color.FromArgb(30, 28, 38);
            txtprix.BorderStyle = BorderStyle.None;
            txtprix.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtprix.ForeColor = Color.FromArgb(224, 224, 224);
            txtprix.Location = new Point(486, 306);
            txtprix.Name = "txtprix";
            txtprix.Size = new Size(222, 27);
            txtprix.TabIndex = 37;
            txtprix.Text = "Prix";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Quantie_32;
            pictureBox3.Location = new Point(449, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 34);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(486, 263);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 1);
            panel6.TabIndex = 35;
            // 
            // txtquantite
            // 
            txtquantite.BackColor = Color.FromArgb(30, 28, 38);
            txtquantite.BorderStyle = BorderStyle.None;
            txtquantite.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtquantite.ForeColor = Color.FromArgb(224, 224, 224);
            txtquantite.Location = new Point(486, 230);
            txtquantite.Name = "txtquantite";
            txtquantite.Size = new Size(222, 27);
            txtquantite.TabIndex = 34;
            txtquantite.Text = "Quantité";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.product_32;
            pictureBox2.Location = new Point(449, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 34);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(486, 202);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 32;
            // 
            // txtnomproduit
            // 
            txtnomproduit.BackColor = Color.FromArgb(30, 28, 38);
            txtnomproduit.BorderStyle = BorderStyle.None;
            txtnomproduit.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtnomproduit.ForeColor = Color.FromArgb(224, 224, 224);
            txtnomproduit.Location = new Point(486, 169);
            txtnomproduit.Name = "txtnomproduit";
            txtnomproduit.Size = new Size(222, 27);
            txtnomproduit.TabIndex = 31;
            txtnomproduit.Text = "Nom Produit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(9, 99);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 30;
            label1.Text = "Image:";
            // 
            // pictureProduit
            // 
            pictureProduit.BackColor = Color.FromArgb(224, 224, 224);
            pictureProduit.Location = new Point(118, 109);
            pictureProduit.Name = "pictureProduit";
            pictureProduit.Size = new Size(221, 148);
            pictureProduit.TabIndex = 29;
            pictureProduit.TabStop = false;
            pictureProduit.Click += pictureProduit_Click;
            // 
            // btnajouterclient
            // 
            btnajouterclient.BackColor = Color.FromArgb(30, 28, 38);
            btnajouterclient.FlatAppearance.BorderSize = 0;
            btnajouterclient.FlatStyle = FlatStyle.Flat;
            btnajouterclient.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnajouterclient.ForeColor = SystemColors.ControlLightLight;
            btnajouterclient.Location = new Point(211, 12);
            btnajouterclient.Name = "btnajouterclient";
            btnajouterclient.Size = new Size(324, 54);
            btnajouterclient.TabIndex = 28;
            btnajouterclient.Text = "Modifier Produit";
            btnajouterclient.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 8, 55);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 449);
            panel2.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(729, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(3, 449);
            panel3.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(178, 8, 55);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 452);
            panel4.Name = "panel4";
            panel4.Size = new Size(732, 3);
            panel4.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(178, 8, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(732, 3);
            panel1.TabIndex = 24;
            // 
            // FRM_Modifier_Produit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 20, 28);
            ClientSize = new Size(732, 455);
            Controls.Add(btnquiter);
            Controls.Add(combocategorie);
            Controls.Add(label2);
            Controls.Add(btnEnregister);
            Controls.Add(pictureBox4);
            Controls.Add(panel7);
            Controls.Add(txtprix);
            Controls.Add(pictureBox3);
            Controls.Add(panel6);
            Controls.Add(txtquantite);
            Controls.Add(pictureBox2);
            Controls.Add(panel5);
            Controls.Add(txtnomproduit);
            Controls.Add(label1);
            Controls.Add(pictureProduit);
            Controls.Add(btnajouterclient);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Modifier_Produit";
            Text = "Modifier_Produit";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnquiter;
        private ComboBox combocategorie;
        private Label label2;
        private Button btnEnregister;
        private PictureBox pictureBox4;
        private Panel panel7;
        private TextBox txtprix;
        private PictureBox pictureBox3;
        private Panel panel6;
        private TextBox txtquantite;
        private PictureBox pictureBox2;
        private Panel panel5;
        private TextBox txtnomproduit;
        private Label label1;
        private PictureBox pictureProduit;
        private Button btnajouterclient;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
    }
}