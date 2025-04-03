namespace projetfs
{
    partial class FRM_Modifier_Ajouter_Produit
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dvglclient = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel1 = new Panel();
            btnmodifierclient = new Button();
            btnsupprimerclient = new Button();
            btnajouterclient = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnafficheIm = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvglclient).BeginInit();
            SuspendLayout();
            // 
            // dvglclient
            // 
            dvglclient.AllowUserToAddRows = false;
            dvglclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvglclient.BackgroundColor = SystemColors.Control;
            dvglclient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvglclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvglclient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvglclient.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column2, Column3, Column4, Column5 });
            dvglclient.EnableHeadersVisualStyles = false;
            dvglclient.Location = new Point(3, 168);
            dvglclient.Name = "dvglclient";
            dvglclient.RowHeadersVisible = false;
            dvglclient.RowHeadersWidth = 51;
            dvglclient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvglclient.Size = new Size(1081, 383);
            dvglclient.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "Select";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column9
            // 
            Column9.HeaderText = "Id";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nom";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantité";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Prix";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Catégorie";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(246, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(526, 3);
            panel3.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(320, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 33);
            textBox1.TabIndex = 14;
            textBox1.Text = "Recherche";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(20, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 3);
            panel1.TabIndex = 12;
            // 
            // btnmodifierclient
            // 
            btnmodifierclient.BackColor = Color.FromArgb(30, 28, 38);
            btnmodifierclient.FlatAppearance.BorderSize = 0;
            btnmodifierclient.FlatStyle = FlatStyle.Flat;
            btnmodifierclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmodifierclient.ForeColor = SystemColors.ControlLightLight;
            btnmodifierclient.Image = Properties.Resources.Recycle_iconaaa;
            btnmodifierclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnmodifierclient.Location = new Point(271, 14);
            btnmodifierclient.Name = "btnmodifierclient";
            btnmodifierclient.Size = new Size(233, 53);
            btnmodifierclient.TabIndex = 11;
            btnmodifierclient.Text = "Modifier";
            btnmodifierclient.UseVisualStyleBackColor = false;
            btnmodifierclient.Click += btnmodifierclient_Click;
            // 
            // btnsupprimerclient
            // 
            btnsupprimerclient.BackColor = Color.FromArgb(30, 28, 38);
            btnsupprimerclient.FlatAppearance.BorderSize = 0;
            btnsupprimerclient.FlatStyle = FlatStyle.Flat;
            btnsupprimerclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsupprimerclient.ForeColor = SystemColors.ControlLightLight;
            btnsupprimerclient.Image = Properties.Resources.Close_2_icon;
            btnsupprimerclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnsupprimerclient.Location = new Point(526, 13);
            btnsupprimerclient.Name = "btnsupprimerclient";
            btnsupprimerclient.Size = new Size(246, 53);
            btnsupprimerclient.TabIndex = 10;
            btnsupprimerclient.Text = "Supprimer";
            btnsupprimerclient.UseVisualStyleBackColor = false;
            // 
            // btnajouterclient
            // 
            btnajouterclient.BackColor = Color.FromArgb(30, 28, 38);
            btnajouterclient.FlatAppearance.BorderSize = 0;
            btnajouterclient.FlatStyle = FlatStyle.Flat;
            btnajouterclient.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnajouterclient.ForeColor = SystemColors.ControlLightLight;
            btnajouterclient.Image = Properties.Resources.Actions_list_add_icon;
            btnajouterclient.ImageAlign = ContentAlignment.MiddleLeft;
            btnajouterclient.Location = new Point(20, 13);
            btnajouterclient.Name = "btnajouterclient";
            btnajouterclient.Size = new Size(222, 53);
            btnajouterclient.TabIndex = 9;
            btnajouterclient.Text = "Ajouter";
            btnajouterclient.UseVisualStyleBackColor = false;
            btnajouterclient.Click += btnajouterclient_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 28, 38);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.Imprimer;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(407, 568);
            button1.Name = "button1";
            button1.Size = new Size(294, 53);
            button1.TabIndex = 20;
            button1.Text = "Imprimer Toutes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 28, 38);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.Excel_icon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(764, 568);
            button2.Name = "button2";
            button2.Size = new Size(320, 53);
            button2.TabIndex = 19;
            button2.Text = "   Sauvegarder dans Excel";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 28, 38);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = Properties.Resources.Imprimer;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(20, 568);
            button3.Name = "button3";
            button3.Size = new Size(301, 53);
            button3.TabIndex = 18;
            button3.Text = "   Imprimer PR cocher";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnafficheIm
            // 
            btnafficheIm.BackColor = Color.FromArgb(30, 28, 38);
            btnafficheIm.FlatAppearance.BorderSize = 0;
            btnafficheIm.FlatStyle = FlatStyle.Flat;
            btnafficheIm.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnafficheIm.ForeColor = SystemColors.ControlLightLight;
            btnafficheIm.Image = Properties.Resources.Pictures_icon;
            btnafficheIm.ImageAlign = ContentAlignment.MiddleLeft;
            btnafficheIm.Location = new Point(793, 14);
            btnafficheIm.Name = "btnafficheIm";
            btnafficheIm.Size = new Size(278, 53);
            btnafficheIm.TabIndex = 21;
            btnafficheIm.Text = "   Afficher Photo";
            btnafficheIm.UseVisualStyleBackColor = false;
            btnafficheIm.Click += btnafficheIm_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(30, 28, 38);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = Properties.Resources.Refresh_icon;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(806, 94);
            button5.Name = "button5";
            button5.Size = new Size(242, 53);
            button5.TabIndex = 22;
            button5.Text = "Actualiser";
            button5.UseVisualStyleBackColor = false;
            // 
            // FRM_Modifier_Ajouter_Produit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(btnafficheIm);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dvglclient);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(btnmodifierclient);
            Controls.Add(btnsupprimerclient);
            Controls.Add(btnajouterclient);
            Name = "FRM_Modifier_Ajouter_Produit";
            Size = new Size(1088, 626);
            ((System.ComponentModel.ISupportInitialize)dvglclient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvglclient;
        private Panel panel3;
        private TextBox textBox1;
        private Panel panel1;
        private Button btnmodifierclient;
        private Button btnsupprimerclient;
        private Button btnajouterclient;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnafficheIm;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button5;
    }
}