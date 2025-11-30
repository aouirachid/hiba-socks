
namespace FD_STOCK.COMPOSANT
{
    partial class sortieComposant
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tsg = new System.Windows.Forms.ComboBox();
            this.sp = new System.Windows.Forms.TextBox();
            this.qu = new System.Windows.Forms.TextBox();
            this.nc = new System.Windows.Forms.TextBox();
            this.npro = new System.Windows.Forms.ComboBox();
            this.dds = new System.Windows.Forms.DateTimePicker();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.Label();
            this.dde = new System.Windows.Forms.Label();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 718);
            this.panel5.TabIndex = 293;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 720);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 2);
            this.panel2.TabIndex = 291;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 2);
            this.panel1.TabIndex = 290;
            // 
            // btnNa
            // 
            this.btnNa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.btnNa.FlatAppearance.BorderSize = 0;
            this.btnNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNa.ForeColor = System.Drawing.Color.White;
            this.btnNa.Location = new System.Drawing.Point(11, 235);
            this.btnNa.Name = "btnNa";
            this.btnNa.Size = new System.Drawing.Size(148, 22);
            this.btnNa.TabIndex = 289;
            this.btnNa.Text = "Rechercher";
            this.btnNa.UseVisualStyleBackColor = false;
            this.btnNa.Click += new System.EventHandler(this.btnNa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 285;
            this.label7.Text = "Type d\'article";
            // 
            // tsg
            // 
            this.tsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsg.FormattingEnabled = true;
            this.tsg.Items.AddRange(new object[] {
            "Matiére 1 ére",
            "Emballage",
            "Piéce de rechange"});
            this.tsg.Location = new System.Drawing.Point(120, 66);
            this.tsg.Name = "tsg";
            this.tsg.Size = new System.Drawing.Size(368, 24);
            this.tsg.TabIndex = 286;
            this.tsg.SelectedIndexChanged += new System.EventHandler(this.tsg_SelectedIndexChanged);
            // 
            // sp
            // 
            this.sp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp.Location = new System.Drawing.Point(120, 124);
            this.sp.Name = "sp";
            this.sp.ReadOnly = true;
            this.sp.Size = new System.Drawing.Size(368, 22);
            this.sp.TabIndex = 255;
            this.sp.Text = "admin";
            // 
            // qu
            // 
            this.qu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qu.Location = new System.Drawing.Point(620, 235);
            this.qu.Name = "qu";
            this.qu.Size = new System.Drawing.Size(338, 22);
            this.qu.TabIndex = 264;
            this.qu.Text = "0.00";
            // 
            // nc
            // 
            this.nc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.Location = new System.Drawing.Point(276, 235);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(338, 22);
            this.nc.TabIndex = 263;
            // 
            // npro
            // 
            this.npro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npro.FormattingEnabled = true;
            this.npro.Location = new System.Drawing.Point(165, 234);
            this.npro.Name = "npro";
            this.npro.Size = new System.Drawing.Size(105, 23);
            this.npro.TabIndex = 262;
            this.npro.SelectedIndexChanged += new System.EventHandler(this.npro_SelectedIndexChanged);
            // 
            // dds
            // 
            this.dds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dds.Location = new System.Drawing.Point(119, 96);
            this.dds.Name = "dds";
            this.dds.Size = new System.Drawing.Size(368, 22);
            this.dds.TabIndex = 261;
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.Enregistrer.FlatAppearance.BorderSize = 0;
            this.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer.ForeColor = System.Drawing.Color.White;
            this.Enregistrer.Location = new System.Drawing.Point(120, 152);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(368, 28);
            this.Enregistrer.TabIndex = 258;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.Ajouter.FlatAppearance.BorderSize = 0;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(964, 235);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(148, 22);
            this.Ajouter.TabIndex = 257;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1132, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 722);
            this.panel3.TabIndex = 292;
            // 
            // button36
            // 
            this.button36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button36.BackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.button36.Location = new System.Drawing.Point(21, 19);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 269;
            this.button36.Text = "-";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.button1.Location = new System.Drawing.Point(1097, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 268;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(881, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 18);
            this.label8.TabIndex = 267;
            this.label8.Text = "Nouvelle sortie composant";
            // 
            // ep
            // 
            this.ep.AutoSize = true;
            this.ep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ep.Location = new System.Drawing.Point(8, 130);
            this.ep.Name = "ep";
            this.ep.Size = new System.Drawing.Size(76, 16);
            this.ep.TabIndex = 253;
            this.ep.Text = "Sortie par";
            // 
            // dde
            // 
            this.dde.AutoSize = true;
            this.dde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dde.Location = new System.Drawing.Point(8, 102);
            this.dde.Name = "dde";
            this.dde.Size = new System.Drawing.Size(106, 16);
            this.dde.TabIndex = 252;
            this.dde.Text = "Date de sortie";
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Supprimer});
            this.tableau.Location = new System.Drawing.Point(11, 272);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 436);
            this.tableau.TabIndex = 256;
            this.tableau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de composant";
            this.Column1.Name = "Column1";
            this.Column1.Width = 220;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom de composant";
            this.Column2.Name = "Column2";
            this.Column2.Width = 345;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            this.Column3.Width = 345;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer colone";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 130;
            // 
            // sortieComposant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tsg);
            this.Controls.Add(this.sp);
            this.Controls.Add(this.qu);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.npro);
            this.Controls.Add(this.dds);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ep);
            this.Controls.Add(this.dde);
            this.Controls.Add(this.tableau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sortieComposant";
            this.Text = "sortieComposant";
            this.Load += new System.EventHandler(this.sortieComposant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tsg;
        public System.Windows.Forms.TextBox sp;
        private System.Windows.Forms.TextBox qu;
        private System.Windows.Forms.TextBox nc;
        private System.Windows.Forms.ComboBox npro;
        private System.Windows.Forms.DateTimePicker dds;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ep;
        private System.Windows.Forms.Label dde;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
    }
}