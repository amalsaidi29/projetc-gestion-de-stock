namespace projetfs
{
    partial class FRM_Categorie
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            textBox1 = new TextBox();
            btnajoutercategorie = new Button();
            dvgclient = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dvgclient).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(523, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 3);
            panel3.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(523, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 33);
            textBox1.TabIndex = 14;
            textBox1.Text = "Recherche";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnajoutercategorie
            // 
            btnajoutercategorie.BackColor = Color.FromArgb(30, 28, 38);
            btnajoutercategorie.FlatAppearance.BorderSize = 0;
            btnajoutercategorie.FlatStyle = FlatStyle.Flat;
            btnajoutercategorie.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnajoutercategorie.ForeColor = SystemColors.ControlLightLight;
            btnajoutercategorie.Image = Properties.Resources.Actions_list_add_icon;
            btnajoutercategorie.ImageAlign = ContentAlignment.MiddleLeft;
            btnajoutercategorie.Location = new Point(37, 55);
            btnajoutercategorie.Name = "btnajoutercategorie";
            btnajoutercategorie.Size = new Size(290, 53);
            btnajoutercategorie.TabIndex = 9;
            btnajoutercategorie.Text = "Ajouter";
            btnajoutercategorie.UseVisualStyleBackColor = false;
            btnajoutercategorie.Click += btnajoutercategorie_Click;
            // 
            // dvgclient
            // 
            dvgclient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgclient.BackgroundColor = SystemColors.Control;
            dvgclient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 28, 38);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dvgclient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgclient.Columns.AddRange(new DataGridViewColumn[] { Column1, Column9, Column2, Column7, Column3 });
            dvgclient.EnableHeadersVisualStyles = false;
            dvgclient.Location = new Point(37, 127);
            dvgclient.Name = "dvgclient";
            dvgclient.RowHeadersVisible = false;
            dvgclient.RowHeadersWidth = 51;
            dvgclient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dvgclient.Size = new Size(1006, 321);
            dvgclient.TabIndex = 17;
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
            Column2.HeaderText = "NomCategorie";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            Column7.HeaderText = "Modifier";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.HeaderText = "Supprimer";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // FRM_Categorie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dvgclient);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(btnajoutercategorie);
            Name = "FRM_Categorie";
            Size = new Size(1080, 605);
            ((System.ComponentModel.ISupportInitialize)dvgclient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private TextBox textBox1;
        private Button btnajoutercategorie;
        private DataGridView dvgclient;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column3;
    }
}