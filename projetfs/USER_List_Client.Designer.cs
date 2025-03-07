namespace projetfs
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
            btnajouterclient = new Button();
            btnsupprimerclient = new Button();
            btnmodifierclient = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
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
            btnajouterclient.Location = new Point(60, 25);
            btnajouterclient.Name = "btnajouterclient";
            btnajouterclient.Size = new Size(320, 53);
            btnajouterclient.TabIndex = 0;
            btnajouterclient.Text = "Ajouter";
            btnajouterclient.UseVisualStyleBackColor = false;
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
            btnsupprimerclient.Location = new Point(768, 25);
            btnsupprimerclient.Name = "btnsupprimerclient";
            btnsupprimerclient.Size = new Size(320, 53);
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
            btnmodifierclient.Location = new Point(408, 25);
            btnmodifierclient.Name = "btnmodifierclient";
            btnmodifierclient.Size = new Size(320, 53);
            btnmodifierclient.TabIndex = 2;
            btnmodifierclient.Text = "Modifier";
            btnmodifierclient.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 28, 38);
            panel1.Location = new Point(60, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 3);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(30, 28, 38);
            panel2.Location = new Point(60, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 3);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DimGray;
            textBox1.Location = new Point(551, 108);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 33);
            textBox1.TabIndex = 5;
            textBox1.Text = "Recherche";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 28, 38);
            panel3.Location = new Point(551, 147);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 3);
            panel3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nom", "Prenom", "Age", "Teleohone", "Payer" });
            comboBox1.Location = new Point(243, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(291, 43);
            comboBox1.TabIndex = 7;
            // 
            // USER_List_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(panel3);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnmodifierclient);
            Controls.Add(btnsupprimerclient);
            Controls.Add(btnajouterclient);
            Name = "USER_List_Client";
            Size = new Size(1137, 720);
            
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
    }
}
