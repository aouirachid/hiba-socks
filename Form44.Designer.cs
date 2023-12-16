
namespace FD_STOCK
{
    partial class sg
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.teg = new System.Windows.Forms.ComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nouveau = new System.Windows.Forms.Button();
            this.tdee = new System.Windows.Forms.ComboBox();
            this.epe = new System.Windows.Forms.TextBox();
            this.pah = new System.Windows.Forms.TextBox();
            this.qu = new System.Windows.Forms.TextBox();
            this.nc = new System.Windows.Forms.TextBox();
            this.npro = new System.Windows.Forms.ComboBox();
            this.ddee = new System.Windows.Forms.DateTimePicker();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.ttva = new System.Windows.Forms.TextBox();
            this.Femer = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.npe = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.Label();
            this.dde = new System.Windows.Forms.Label();
            this.np = new System.Windows.Forms.Label();
            this.tde = new System.Windows.Forms.Label();
            this.tableau = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            this.Column3.Width = 177;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 252;
            this.label7.Text = "Type d\'article";
            // 
            // teg
            // 
            this.teg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teg.FormattingEnabled = true;
            this.teg.Items.AddRange(new object[] {
            "Matiére 1 ére",
            "Emballage",
            "Piéce de rechange"});
            this.teg.Location = new System.Drawing.Point(237, 57);
            this.teg.Name = "teg";
            this.teg.Size = new System.Drawing.Size(309, 28);
            this.teg.TabIndex = 253;
            this.teg.SelectedIndexChanged += new System.EventHandler(this.teg_SelectedIndexChanged);
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
            // Nouveau
            // 
            this.Nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Nouveau.FlatAppearance.BorderSize = 0;
            this.Nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau.ForeColor = System.Drawing.Color.White;
            this.Nouveau.Location = new System.Drawing.Point(6, 379);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(175, 34);
            this.Nouveau.TabIndex = 225;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = false;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // tdee
            // 
            this.tdee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdee.FormattingEnabled = true;
            this.tdee.Items.AddRange(new object[] {
            "FACTURE",
            "BON DE LIVRAISON"});
            this.tdee.Location = new System.Drawing.Point(237, 91);
            this.tdee.Name = "tdee";
            this.tdee.Size = new System.Drawing.Size(309, 28);
            this.tdee.TabIndex = 227;
            // 
            // epe
            // 
            this.epe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epe.Location = new System.Drawing.Point(237, 189);
            this.epe.Name = "epe";
            this.epe.Size = new System.Drawing.Size(309, 26);
            this.epe.TabIndex = 221;
            // 
            // pah
            // 
            this.pah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pah.Location = new System.Drawing.Point(578, 459);
            this.pah.Name = "pah";
            this.pah.Size = new System.Drawing.Size(171, 26);
            this.pah.TabIndex = 232;
            // 
            // qu
            // 
            this.qu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qu.Location = new System.Drawing.Point(407, 460);
            this.qu.Name = "qu";
            this.qu.Size = new System.Drawing.Size(166, 26);
            this.qu.TabIndex = 231;
            this.qu.Text = "0";
            // 
            // nc
            // 
            this.nc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nc.Location = new System.Drawing.Point(224, 460);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(177, 26);
            this.nc.TabIndex = 230;
            // 
            // npro
            // 
            this.npro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npro.FormattingEnabled = true;
            this.npro.Location = new System.Drawing.Point(7, 460);
            this.npro.Name = "npro";
            this.npro.Size = new System.Drawing.Size(211, 26);
            this.npro.TabIndex = 229;
            this.npro.SelectedIndexChanged += new System.EventHandler(this.npro_SelectedIndexChanged);
            // 
            // ddee
            // 
            this.ddee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddee.Location = new System.Drawing.Point(237, 157);
            this.ddee.Name = "ddee";
            this.ddee.Size = new System.Drawing.Size(309, 26);
            this.ddee.TabIndex = 228;
            // 
            // Enregistrer
            // 
            this.Enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Enregistrer.FlatAppearance.BorderSize = 0;
            this.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregistrer.ForeColor = System.Drawing.Color.White;
            this.Enregistrer.Location = new System.Drawing.Point(189, 379);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(175, 34);
            this.Enregistrer.TabIndex = 224;
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
            this.Ajouter.Location = new System.Drawing.Point(947, 458);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(160, 26);
            this.Ajouter.TabIndex = 223;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // ttva
            // 
            this.ttva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttva.Location = new System.Drawing.Point(754, 459);
            this.ttva.Name = "ttva";
            this.ttva.Size = new System.Drawing.Size(171, 26);
            this.ttva.TabIndex = 233;
            // 
            // Femer
            // 
            this.Femer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.Femer.FlatAppearance.BorderSize = 0;
            this.Femer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Femer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Femer.ForeColor = System.Drawing.Color.White;
            this.Femer.Location = new System.Drawing.Point(371, 379);
            this.Femer.Name = "Femer";
            this.Femer.Size = new System.Drawing.Size(175, 34);
            this.Femer.TabIndex = 226;
            this.Femer.Text = "Fermer";
            this.Femer.UseVisualStyleBackColor = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom du matiére 1 ére";
            this.Column2.Name = "Column2";
            this.Column2.Width = 177;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de référence";
            this.Column1.Name = "Column1";
            this.Column1.Width = 177;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button36.Location = new System.Drawing.Point(1050, 12);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 236;
            this.button36.Text = "-";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button1.Location = new System.Drawing.Point(1081, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 235;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.label8.Location = new System.Drawing.Point(833, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 20);
            this.label8.TabIndex = 234;
            this.label8.Text = "Nouvelle sortie générale";
            // 
            // npe
            // 
            this.npe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npe.Location = new System.Drawing.Point(237, 125);
            this.npe.Name = "npe";
            this.npe.Size = new System.Drawing.Size(309, 26);
            this.npe.TabIndex = 220;
            // 
            // ep
            // 
            this.ep.AutoSize = true;
            this.ep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ep.Location = new System.Drawing.Point(3, 197);
            this.ep.Name = "ep";
            this.ep.Size = new System.Drawing.Size(86, 18);
            this.ep.TabIndex = 219;
            this.ep.Text = "Entrée par";
            // 
            // dde
            // 
            this.dde.AutoSize = true;
            this.dde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dde.Location = new System.Drawing.Point(3, 165);
            this.dde.Name = "dde";
            this.dde.Size = new System.Drawing.Size(108, 18);
            this.dde.TabIndex = 218;
            this.dde.Text = "Date d\'entrée";
            // 
            // np
            // 
            this.np.AutoSize = true;
            this.np.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.np.Location = new System.Drawing.Point(3, 133);
            this.np.Name = "np";
            this.np.Size = new System.Drawing.Size(95, 18);
            this.np.TabIndex = 217;
            this.np.Text = "N° de piéce";
            // 
            // tde
            // 
            this.tde.AutoSize = true;
            this.tde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tde.Location = new System.Drawing.Point(3, 101);
            this.tde.Name = "tde";
            this.tde.Size = new System.Drawing.Size(112, 18);
            this.tde.TabIndex = 216;
            this.tde.Text = "Type de piéce";
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
            this.tableau.Location = new System.Drawing.Point(6, 492);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 200);
            this.tableau.TabIndex = 222;
            // 
            // sg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 686);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.teg);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.tdee);
            this.Controls.Add(this.epe);
            this.Controls.Add(this.pah);
            this.Controls.Add(this.qu);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.npro);
            this.Controls.Add(this.ddee);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.ttva);
            this.Controls.Add(this.Femer);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.npe);
            this.Controls.Add(this.ep);
            this.Controls.Add(this.dde);
            this.Controls.Add(this.np);
            this.Controls.Add(this.tde);
            this.Controls.Add(this.tableau);
            this.Name = "sg";
            this.Text = "Nouvelle sortie générale";
            this.Load += new System.EventHandler(this.sg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox teg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.ComboBox tdee;
        private System.Windows.Forms.TextBox epe;
        private System.Windows.Forms.TextBox pah;
        private System.Windows.Forms.TextBox qu;
        private System.Windows.Forms.TextBox nc;
        private System.Windows.Forms.ComboBox npro;
        private System.Windows.Forms.DateTimePicker ddee;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox ttva;
        private System.Windows.Forms.Button Femer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox npe;
        private System.Windows.Forms.Label ep;
        private System.Windows.Forms.Label dde;
        private System.Windows.Forms.Label np;
        private System.Windows.Forms.Label tde;
        private System.Windows.Forms.DataGridView tableau;
    }
}