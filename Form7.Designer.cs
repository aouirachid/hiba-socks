
namespace FD_STOCK
{
    partial class ne
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
            this.ttva = new System.Windows.Forms.TextBox();
            this.pah = new System.Windows.Forms.TextBox();
            this.qu = new System.Windows.Forms.TextBox();
            this.nc = new System.Windows.Forms.TextBox();
            this.npro = new System.Windows.Forms.ComboBox();
            this.ddee = new System.Windows.Forms.DateTimePicker();
            this.tdee = new System.Windows.Forms.ComboBox();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.epe = new System.Windows.Forms.TextBox();
            this.npe = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.Label();
            this.dde = new System.Windows.Forms.Label();
            this.np = new System.Windows.Forms.Label();
            this.tde = new System.Windows.Forms.Label();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nde = new System.Windows.Forms.Label();
            this.ndee = new System.Windows.Forms.TextBox();
            this.btnNa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // ttva
            // 
            this.ttva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttva.Location = new System.Drawing.Point(772, 289);
            this.ttva.Name = "ttva";
            this.ttva.Size = new System.Drawing.Size(172, 26);
            this.ttva.TabIndex = 135;
            // 
            // pah
            // 
            this.pah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pah.Location = new System.Drawing.Point(594, 289);
            this.pah.Name = "pah";
            this.pah.Size = new System.Drawing.Size(172, 26);
            this.pah.TabIndex = 134;
            // 
            // qu
            // 
            this.qu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qu.Location = new System.Drawing.Point(416, 289);
            this.qu.Name = "qu";
            this.qu.Size = new System.Drawing.Size(172, 26);
            this.qu.TabIndex = 133;
            this.qu.Text = "0";
            // 
            // nc
            // 
            this.nc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.Location = new System.Drawing.Point(238, 289);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(172, 26);
            this.nc.TabIndex = 132;
            // 
            // npro
            // 
            this.npro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npro.FormattingEnabled = true;
            this.npro.Location = new System.Drawing.Point(120, 289);
            this.npro.Name = "npro";
            this.npro.Size = new System.Drawing.Size(112, 26);
            this.npro.TabIndex = 131;
            this.npro.SelectedIndexChanged += new System.EventHandler(this.npro_SelectedIndexChanged);
            // 
            // ddee
            // 
            this.ddee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddee.Location = new System.Drawing.Point(180, 69);
            this.ddee.Name = "ddee";
            this.ddee.Size = new System.Drawing.Size(326, 26);
            this.ddee.TabIndex = 129;
            // 
            // tdee
            // 
            this.tdee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdee.FormattingEnabled = true;
            this.tdee.Items.AddRange(new object[] {
            "FACTURE",
            "BON DE LIVRAISON"});
            this.tdee.Location = new System.Drawing.Point(784, 138);
            this.tdee.Name = "tdee";
            this.tdee.Size = new System.Drawing.Size(326, 28);
            this.tdee.TabIndex = 128;
            this.tdee.Visible = false;
            // 
            // Nouveau
            // 
            this.Nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Nouveau.FlatAppearance.BorderSize = 0;
            this.Nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.ForeColor = System.Drawing.Color.White;
            this.Nouveau.Location = new System.Drawing.Point(621, 61);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(160, 34);
            this.Nouveau.TabIndex = 126;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = false;
            this.Nouveau.Visible = false;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Enregistrer.FlatAppearance.BorderSize = 0;
            this.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer.ForeColor = System.Drawing.Color.White;
            this.Enregistrer.Location = new System.Drawing.Point(180, 143);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(326, 34);
            this.Enregistrer.TabIndex = 125;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Ajouter.FlatAppearance.BorderSize = 0;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(950, 289);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(168, 26);
            this.Ajouter.TabIndex = 124;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // epe
            // 
            this.epe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epe.Location = new System.Drawing.Point(180, 101);
            this.epe.Name = "epe";
            this.epe.ReadOnly = true;
            this.epe.Size = new System.Drawing.Size(326, 26);
            this.epe.TabIndex = 122;
            // 
            // npe
            // 
            this.npe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npe.Location = new System.Drawing.Point(784, 172);
            this.npe.Name = "npe";
            this.npe.Size = new System.Drawing.Size(326, 26);
            this.npe.TabIndex = 121;
            this.npe.Visible = false;
            // 
            // ep
            // 
            this.ep.AutoSize = true;
            this.ep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ep.Location = new System.Drawing.Point(14, 109);
            this.ep.Name = "ep";
            this.ep.Size = new System.Drawing.Size(86, 18);
            this.ep.TabIndex = 119;
            this.ep.Text = "Entrée par";
            // 
            // dde
            // 
            this.dde.AutoSize = true;
            this.dde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dde.Location = new System.Drawing.Point(14, 77);
            this.dde.Name = "dde";
            this.dde.Size = new System.Drawing.Size(108, 18);
            this.dde.TabIndex = 118;
            this.dde.Text = "Date d\'entrée";
            // 
            // np
            // 
            this.np.AutoSize = true;
            this.np.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np.Location = new System.Drawing.Point(618, 180);
            this.np.Name = "np";
            this.np.Size = new System.Drawing.Size(95, 18);
            this.np.TabIndex = 117;
            this.np.Text = "N° de piéce";
            this.np.Visible = false;
            // 
            // tde
            // 
            this.tde.AutoSize = true;
            this.tde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tde.Location = new System.Drawing.Point(618, 148);
            this.tde.Name = "tde";
            this.tde.Size = new System.Drawing.Size(112, 18);
            this.tde.TabIndex = 116;
            this.tde.Text = "Type de piéce";
            this.tde.Visible = false;
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Supprimer});
            this.tableau.Location = new System.Drawing.Point(17, 323);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 385);
            this.tableau.TabIndex = 123;
            this.tableau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de produit";
            this.Column1.Name = "Column1";
            this.Column1.Width = 177;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom de produit";
            this.Column2.Name = "Column2";
            this.Column2.Width = 177;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            this.Column3.Width = 177;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix de vente HT";
            this.Column4.Name = "Column4";
            this.Column4.Width = 177;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Taux tva %";
            this.Column5.Name = "Column5";
            this.Column5.Width = 177;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Text = "Supprimer colone";
            this.Supprimer.UseColumnTextForButtonValue = true;
            this.Supprimer.Width = 171;
            // 
            // button36
            // 
            this.button36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button36.BackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button36.Location = new System.Drawing.Point(1066, 12);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 138;
            this.button36.Text = "-";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button1.Location = new System.Drawing.Point(1097, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 137;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.label8.Location = new System.Drawing.Point(868, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 136;
            this.label8.Text = "Nouvelle entrée produit";
            // 
            // nde
            // 
            this.nde.AutoSize = true;
            this.nde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nde.Location = new System.Drawing.Point(618, 116);
            this.nde.Name = "nde";
            this.nde.Size = new System.Drawing.Size(92, 18);
            this.nde.TabIndex = 115;
            this.nde.Text = "N° d\'entrée";
            this.nde.Visible = false;
            // 
            // ndee
            // 
            this.ndee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndee.Location = new System.Drawing.Point(784, 108);
            this.ndee.Name = "ndee";
            this.ndee.Size = new System.Drawing.Size(326, 26);
            this.ndee.TabIndex = 120;
            this.ndee.Visible = false;
            // 
            // btnNa
            // 
            this.btnNa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.btnNa.FlatAppearance.BorderSize = 0;
            this.btnNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNa.ForeColor = System.Drawing.Color.White;
            this.btnNa.Location = new System.Drawing.Point(17, 289);
            this.btnNa.Name = "btnNa";
            this.btnNa.Size = new System.Drawing.Size(97, 26);
            this.btnNa.TabIndex = 139;
            this.btnNa.Text = "Rechercher";
            this.btnNa.UseVisualStyleBackColor = false;
            this.btnNa.Click += new System.EventHandler(this.btnNa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 2);
            this.panel2.TabIndex = 140;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 141;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel3.Location = new System.Drawing.Point(1132, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 718);
            this.panel3.TabIndex = 142;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 718);
            this.panel4.TabIndex = 143;
            // 
            // ne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNa);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ttva);
            this.Controls.Add(this.pah);
            this.Controls.Add(this.qu);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.npro);
            this.Controls.Add(this.ddee);
            this.Controls.Add(this.tdee);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.nde);
            this.Controls.Add(this.epe);
            this.Controls.Add(this.npe);
            this.Controls.Add(this.ndee);
            this.Controls.Add(this.ep);
            this.Controls.Add(this.dde);
            this.Controls.Add(this.np);
            this.Controls.Add(this.tde);
            this.Controls.Add(this.tableau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle entrée produit";
            this.Load += new System.EventHandler(this.ne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttva;
        private System.Windows.Forms.TextBox pah;
        private System.Windows.Forms.TextBox qu;
        private System.Windows.Forms.TextBox nc;
        private System.Windows.Forms.ComboBox npro;
        private System.Windows.Forms.DateTimePicker ddee;
        private System.Windows.Forms.ComboBox tdee;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox npe;
        private System.Windows.Forms.Label ep;
        private System.Windows.Forms.Label dde;
        private System.Windows.Forms.Label np;
        private System.Windows.Forms.Label tde;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nde;
        private System.Windows.Forms.TextBox ndee;
        public System.Windows.Forms.TextBox epe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Button btnNa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}