﻿namespace projetfs
{
    partial class USER_List_Client
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnajouterclient = new Button();
            btnsupprimerclient = new Button();
            btnmodifierclient = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            dvgclient = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgclient).BeginInit();
            SuspendLayout();
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
            btnajouterclient.Location = new Point(20, 25);
            btnajouterclient.Name = "btnajouterclient";
            btnajouterclient.Size = new Size(269, 53);
            btnajouterclient.TabIndex = 0;
            btnajouterclient.Text = "Ajouter";
            btnajouterclient.UseVisualStyleBackColor = false;
            btnajouterclient.Click += btnajouterclient_Click;
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
            btnsupprimerclient.Location = new Point(635, 25);
            btnsupprimerclient.Name = "btnsupprimerclient";
            btnsupprimerclient.Size = new Size(267, 53);
            btnsupprimerclient.TabIndex = 1;
            btnsupprimerclient.Text = "Supprimer";
            btnsupprimerclient.UseVisualStyleBackColor = false;
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
            btnmodifierclient.Location = new Point(322, 25);
            btnmodifierclient.Name = "btnmodifierclient";
            btnmodifierclient.Size = new Size(272, 53);
            btnmodifierclient.TabIndex = 2;
            btnmodifierclient.Text = "Modifier";
            btnmodifierclient.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(20, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 3);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(30, 28, 38);
            panel2.Location = new Point(20, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(885, 3);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(513, 109);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 33);
            textBox1.TabIndex = 5;
            textBox1.Text = "Recherche";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(513, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 3);
            panel3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nom", "Prenom", "Age", "Teléphone", "Email", "Ville", "Pays" });
            comboBox1.Location = new Point(196, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(291, 43);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dvgclient
            // 
            dvgclient.AllowUserToAddRows = false;
            dvgclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgclient.BackgroundColor = SystemColors.Control;
            dvgclient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dvgclient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgclient.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dvgclient.EnableHeadersVisualStyles = false;
            dvgclient.Location = new Point(6, 180);
            dvgclient.Name = "dvgclient";
            dvgclient.RowHeadersVisible = false;
            dvgclient.RowHeadersWidth = 51;
            dvgclient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgclient.Size = new Size(960, 299);
            dvgclient.TabIndex = 8;
            dvgclient.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Select";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nom";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Prenom";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.HeaderText = "Adresse";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telephone";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ville";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            Column7.HeaderText = "Pays";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // USER_List_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dvgclient);
            Controls.Add(comboBox1);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnmodifierclient);
            Controls.Add(btnsupprimerclient);
            Controls.Add(btnajouterclient);
            Name = "USER_List_Client";
            Size = new Size(966, 479);
            Load += USER_List_Client_Load;
            ((System.ComponentModel.ISupportInitialize)dvgclient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnajouterclient;
        private Button btnsupprimerclient;
        private Button btnmodifierclient;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private ComboBox comboBox1;
        private DataGridView dvgclient;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
