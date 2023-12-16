
namespace FD_STOCK
{
    partial class nsm
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
            this.npe = new System.Windows.Forms.TextBox();
            this.ndee = new System.Windows.Forms.TextBox();
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
            this.epe = new System.Windows.Forms.TextBox();
            this.pah = new System.Windows.Forms.TextBox();
            this.qu = new System.Windows.Forms.TextBox();
            this.nc = new System.Windows.Forms.TextBox();
            this.npro = new System.Windows.Forms.ComboBox();
            this.ddee = new System.Windows.Forms.DateTimePicker();
            this.tdee = new System.Windows.Forms.ComboBox();
            this.Femer = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.nde = new System.Windows.Forms.Label();
            this.ttva = new System.Windows.Forms.TextBox();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // npe
            // 
            this.npe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.npe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npe.Location = new System.Drawing.Point(164, 175);
            this.npe.Name = "npe";
            this.npe.Size = new System.Drawing.Size(309, 26);
            this.npe.TabIndex = 165;
            // 
            // ndee
            // 
            this.ndee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ndee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndee.Location = new System.Drawing.Point(164, 111);
            this.ndee.Name = "ndee";
            this.ndee.Size = new System.Drawing.Size(309, 26);
            this.ndee.TabIndex = 164;
            // 
            // ep
            // 
            this.ep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ep.AutoSize = true;
            this.ep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ep.Location = new System.Drawing.Point(12, 247);
            this.ep.Name = "ep";
            this.ep.Size = new System.Drawing.Size(82, 18);
            this.ep.TabIndex = 163;
            this.ep.Text = "Sortie par";
            // 
            // dde
            // 
            this.dde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dde.AutoSize = true;
            this.dde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dde.Location = new System.Drawing.Point(12, 215);
            this.dde.Name = "dde";
            this.dde.Size = new System.Drawing.Size(114, 18);
            this.dde.TabIndex = 162;
            this.dde.Text = "Date de sortie";
            // 
            // np
            // 
            this.np.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.np.AutoSize = true;
            this.np.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np.Location = new System.Drawing.Point(12, 183);
            this.np.Name = "np";
            this.np.Size = new System.Drawing.Size(95, 18);
            this.np.TabIndex = 161;
            this.np.Text = "N° de piéce";
            // 
            // tde
            // 
            this.tde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tde.AutoSize = true;
            this.tde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tde.Location = new System.Drawing.Point(12, 151);
            this.tde.Name = "tde";
            this.tde.Size = new System.Drawing.Size(112, 18);
            this.tde.TabIndex = 160;
            this.tde.Text = "Type de piéce";
            // 
            // tableau
            // 
            this.tableau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Supprimer});
            this.tableau.Location = new System.Drawing.Point(15, 363);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 350);
            this.tableau.TabIndex = 167;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de référence";
            this.Column1.Name = "Column1";
            this.Column1.Width = 177;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom du matiére 1 ére";
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
            this.Column4.HeaderText = "Prix d\'achat HT";
            this.Column4.Name = "Column4";
            this.Column4.Width = 177;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Taux de la tva (%)";
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
            // epe
            // 
            this.epe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.epe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epe.Location = new System.Drawing.Point(164, 239);
            this.epe.Name = "epe";
            this.epe.Size = new System.Drawing.Size(309, 26);
            this.epe.TabIndex = 166;
            // 
            // pah
            // 
            this.pah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pah.Location = new System.Drawing.Point(587, 330);
            this.pah.Name = "pah";
            this.pah.Size = new System.Drawing.Size(171, 26);
            this.pah.TabIndex = 178;
            // 
            // qu
            // 
            this.qu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.qu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qu.Location = new System.Drawing.Point(416, 331);
            this.qu.Name = "qu";
            this.qu.Size = new System.Drawing.Size(166, 26);
            this.qu.TabIndex = 177;
            this.qu.Text = "0";
            // 
            // nc
            // 
            this.nc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.Location = new System.Drawing.Point(233, 331);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(177, 26);
            this.nc.TabIndex = 176;
            // 
            // npro
            // 
            this.npro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.npro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npro.FormattingEnabled = true;
            this.npro.Location = new System.Drawing.Point(16, 331);
            this.npro.Name = "npro";
            this.npro.Size = new System.Drawing.Size(211, 26);
            this.npro.TabIndex = 175;
            this.npro.SelectedIndexChanged += new System.EventHandler(this.npro_SelectedIndexChanged);
            // 
            // ddee
            // 
            this.ddee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddee.Location = new System.Drawing.Point(164, 207);
            this.ddee.Name = "ddee";
            this.ddee.Size = new System.Drawing.Size(309, 26);
            this.ddee.TabIndex = 173;
            // 
            // tdee
            // 
            this.tdee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tdee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdee.FormattingEnabled = true;
            this.tdee.Items.AddRange(new object[] {
            "FACTURE",
            "BON DE LIVRAISON"});
            this.tdee.Location = new System.Drawing.Point(164, 141);
            this.tdee.Name = "tdee";
            this.tdee.Size = new System.Drawing.Size(309, 28);
            this.tdee.TabIndex = 172;
            // 
            // Femer
            // 
            this.Femer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Femer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Femer.FlatAppearance.BorderSize = 0;
            this.Femer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Femer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Femer.ForeColor = System.Drawing.Color.White;
            this.Femer.Location = new System.Drawing.Point(629, 207);
            this.Femer.Name = "Femer";
            this.Femer.Size = new System.Drawing.Size(160, 34);
            this.Femer.TabIndex = 171;
            this.Femer.Text = "Fermer";
            this.Femer.UseVisualStyleBackColor = false;
            this.Femer.Click += new System.EventHandler(this.Femer_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Nouveau.FlatAppearance.BorderSize = 0;
            this.Nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.ForeColor = System.Drawing.Color.White;
            this.Nouveau.Location = new System.Drawing.Point(629, 127);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(160, 34);
            this.Nouveau.TabIndex = 170;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = false;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Enregistrer.FlatAppearance.BorderSize = 0;
            this.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer.ForeColor = System.Drawing.Color.White;
            this.Enregistrer.Location = new System.Drawing.Point(629, 167);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(160, 34);
            this.Enregistrer.TabIndex = 169;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = false;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Ajouter.FlatAppearance.BorderSize = 0;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(956, 329);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(160, 26);
            this.Ajouter.TabIndex = 168;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // nde
            // 
            this.nde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nde.AutoSize = true;
            this.nde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nde.Location = new System.Drawing.Point(12, 119);
            this.nde.Name = "nde";
            this.nde.Size = new System.Drawing.Size(98, 18);
            this.nde.TabIndex = 159;
            this.nde.Text = "N° de sortie";
            // 
            // ttva
            // 
            this.ttva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ttva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttva.Location = new System.Drawing.Point(763, 330);
            this.ttva.Name = "ttva";
            this.ttva.Size = new System.Drawing.Size(171, 26);
            this.ttva.TabIndex = 179;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button36.Location = new System.Drawing.Point(1066, 12);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 182;
            this.button36.Text = "-";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button1.Location = new System.Drawing.Point(1097, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 181;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.label8.Location = new System.Drawing.Point(821, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 20);
            this.label8.TabIndex = 180;
            this.label8.Text = "Nouvelle sortie matiére 1ére";
            // 
            // nsm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 725);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.npe);
            this.Controls.Add(this.ndee);
            this.Controls.Add(this.ep);
            this.Controls.Add(this.dde);
            this.Controls.Add(this.np);
            this.Controls.Add(this.tde);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.epe);
            this.Controls.Add(this.pah);
            this.Controls.Add(this.qu);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.npro);
            this.Controls.Add(this.ddee);
            this.Controls.Add(this.tdee);
            this.Controls.Add(this.Femer);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.nde);
            this.Controls.Add(this.ttva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nsm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle sortie matiére 1ére";
            this.Load += new System.EventHandler(this.nsm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox npe;
        private System.Windows.Forms.TextBox ndee;
        private System.Windows.Forms.Label ep;
        private System.Windows.Forms.Label dde;
        private System.Windows.Forms.Label np;
        private System.Windows.Forms.Label tde;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.TextBox epe;
        private System.Windows.Forms.TextBox pah;
        private System.Windows.Forms.TextBox qu;
        private System.Windows.Forms.TextBox nc;
        private System.Windows.Forms.ComboBox npro;
        private System.Windows.Forms.DateTimePicker ddee;
        private System.Windows.Forms.ComboBox tdee;
        private System.Windows.Forms.Button Femer;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label nde;
        private System.Windows.Forms.TextBox ttva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}