namespace projetfs
{
    partial class FRM_Details_Produit
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
            label1 = new Label();
            lblCategorie = new Label();
            lblNom = new Label();
            lblStock = new Label();
            lblPrix = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 50);
            label1.TabIndex = 0;
            label1.Text = "Rapport de produit";
            // 
            // lblCategorie
            // 
            lblCategorie.AutoSize = true;
            lblCategorie.Location = new Point(293, 132);
            lblCategorie.Name = "lblCategorie";
            lblCategorie.Size = new Size(0, 20);
            lblCategorie.TabIndex = 1;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(293, 184);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(0, 20);
            lblNom.TabIndex = 2;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(293, 223);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(0, 20);
            lblStock.TabIndex = 3;
            // 
            // lblPrix
            // 
            lblPrix.AutoSize = true;
            lblPrix.Location = new Point(293, 276);
            lblPrix.Name = "lblPrix";
            lblPrix.Size = new Size(0, 20);
            lblPrix.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.IndianRed;
            label6.Location = new Point(454, 92);
            label6.Name = "label6";
            label6.Size = new Size(76, 27);
            label6.TabIndex = 5;
            label6.Text = "Image";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(437, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 111);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(87, 132);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 11;
            label2.Text = "Categorie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(87, 184);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 12;
            label3.Text = "Nom Produit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(87, 223);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 13;
            label4.Text = "Quantité";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(87, 276);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 14;
            label5.Text = "Prix";
            // 
            // FRM_Details_Produit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(lblPrix);
            Controls.Add(lblStock);
            Controls.Add(lblNom);
            Controls.Add(lblCategorie);
            Controls.Add(label1);
            Name = "FRM_Details_Produit";
            Text = "FRM_Details_Produit";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCategorie;
        private Label lblNom;
        private Label lblStock;
        private Label lblPrix;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}