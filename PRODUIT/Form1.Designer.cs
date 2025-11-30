
namespace FD_STOCK
{
    partial class np
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pvh = new System.Windows.Forms.TextBox();
            this.pv = new System.Windows.Forms.Label();
            this.ttva = new System.Windows.Forms.ComboBox();
            this.tt = new System.Windows.Forms.Label();
            this.supprimer = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.TextBox();
            this.rechercher = new System.Windows.Forms.Button();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st = new System.Windows.Forms.TextBox();
            this.ndpr = new System.Windows.Forms.TextBox();
            this.nr = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.ndp = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNa = new System.Windows.Forms.Button();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txts = new System.Windows.Forms.TextBox();
            this.Taille = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // pvh
            // 
            this.pvh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pvh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pvh.Location = new System.Drawing.Point(158, 213);
            this.pvh.Margin = new System.Windows.Forms.Padding(4);
            this.pvh.Name = "pvh";
            this.pvh.Size = new System.Drawing.Size(328, 22);
            this.pvh.TabIndex = 73;
            // 
            // pv
            // 
            this.pv.AutoSize = true;
            this.pv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv.Location = new System.Drawing.Point(17, 219);
            this.pv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pv.Name = "pv";
            this.pv.Size = new System.Drawing.Size(123, 16);
            this.pv.TabIndex = 72;
            this.pv.Text = "Prix de vente HT";
            // 
            // ttva
            // 
            this.ttva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttva.FormattingEnabled = true;
            this.ttva.Items.AddRange(new object[] {
            "20",
            "14",
            "10",
            "  7",
            "  0"});
            this.ttva.Location = new System.Drawing.Point(158, 243);
            this.ttva.Margin = new System.Windows.Forms.Padding(4);
            this.ttva.Name = "ttva";
            this.ttva.Size = new System.Drawing.Size(328, 24);
            this.ttva.TabIndex = 71;
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.Location = new System.Drawing.Point(17, 251);
            this.tt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(133, 16);
            this.tt.TabIndex = 70;
            this.tt.Text = "Taux de la tva (%)";
            // 
            // supprimer
            // 
            this.supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.supprimer.FlatAppearance.BorderSize = 0;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(885, 206);
            this.supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(213, 42);
            this.supprimer.TabIndex = 68;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Visible = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // nouveau
            // 
            this.nouveau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.nouveau.FlatAppearance.BorderSize = 0;
            this.nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.Color.White;
            this.nouveau.Location = new System.Drawing.Point(885, 157);
            this.nouveau.Margin = new System.Windows.Forms.Padding(4);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(213, 42);
            this.nouveau.TabIndex = 67;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = false;
            this.nouveau.Visible = false;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.modifier.FlatAppearance.BorderSize = 0;
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(158, 275);
            this.modifier.Margin = new System.Windows.Forms.Padding(4);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(160, 28);
            this.modifier.TabIndex = 66;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.enregistrer.FlatAppearance.BorderSize = 0;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(326, 275);
            this.enregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(160, 28);
            this.enregistrer.TabIndex = 65;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // rec
            // 
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(176, 356);
            this.rec.Margin = new System.Windows.Forms.Padding(4);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(945, 22);
            this.rec.TabIndex = 64;
            this.rec.TextChanged += new System.EventHandler(this.rec_TextChanged);
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.rechercher.FlatAppearance.BorderSize = 0;
            this.rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.Location = new System.Drawing.Point(20, 356);
            this.rechercher.Margin = new System.Windows.Forms.Padding(4);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(148, 22);
            this.rechercher.TabIndex = 63;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.re_Click);
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column4,
            this.Column6,
            this.Column3,
            this.Column5,
            this.Column8});
            this.tableau.Location = new System.Drawing.Point(20, 387);
            this.tableau.Margin = new System.Windows.Forms.Padding(4);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 322);
            this.tableau.TabIndex = 62;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de produit";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "N° de référence";
            this.Column10.Name = "Column10";
            this.Column10.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom de produit";
            this.Column2.Name = "Column2";
            this.Column2.Width = 190;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Couleur";
            this.Column4.Name = "Column4";
            this.Column4.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Taille";
            this.Column6.Name = "Column6";
            this.Column6.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix de vente HT";
            this.Column5.Name = "Column5";
            this.Column5.Width = 135;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Taux de la tva (%)";
            this.Column8.Name = "Column8";
            this.Column8.Width = 135;
            // 
            // st
            // 
            this.st.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.st.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st.Location = new System.Drawing.Point(158, 183);
            this.st.Margin = new System.Windows.Forms.Padding(4);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(328, 22);
            this.st.TabIndex = 60;
            // 
            // ndpr
            // 
            this.ndpr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ndpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndpr.Location = new System.Drawing.Point(158, 93);
            this.ndpr.Margin = new System.Windows.Forms.Padding(4);
            this.ndpr.Name = "ndpr";
            this.ndpr.ReadOnly = true;
            this.ndpr.Size = new System.Drawing.Size(200, 22);
            this.ndpr.TabIndex = 59;
            // 
            // nr
            // 
            this.nr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr.Location = new System.Drawing.Point(158, 63);
            this.nr.Margin = new System.Windows.Forms.Padding(4);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(328, 22);
            this.nr.TabIndex = 58;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(17, 189);
            this.s.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(47, 16);
            this.s.TabIndex = 56;
            this.s.Text = "Stock";
            // 
            // ndp
            // 
            this.ndp.AutoSize = true;
            this.ndp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndp.Location = new System.Drawing.Point(17, 99);
            this.ndp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ndp.Name = "ndp";
            this.ndp.Size = new System.Drawing.Size(114, 16);
            this.ndp.TabIndex = 55;
            this.ndp.Text = "Nom de produit";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(17, 69);
            this.r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(116, 16);
            this.r.TabIndex = 54;
            this.r.Text = "N° de référence";
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
            this.button36.Location = new System.Drawing.Point(-232, 13);
            this.button36.Margin = new System.Windows.Forms.Padding(4);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(33, 41);
            this.button36.TabIndex = 76;
            this.button36.Text = "-";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Visible = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
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
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button1.Location = new System.Drawing.Point(1088, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 41);
            this.button1.TabIndex = 75;
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
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.label8.Location = new System.Drawing.Point(949, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 74;
            this.label8.Text = "Nouveau produit";
            // 
            // btnNa
            // 
            this.btnNa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.btnNa.FlatAppearance.BorderSize = 0;
            this.btnNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNa.ForeColor = System.Drawing.Color.White;
            this.btnNa.Location = new System.Drawing.Point(366, 87);
            this.btnNa.Margin = new System.Windows.Forms.Padding(4);
            this.btnNa.Name = "btnNa";
            this.btnNa.Size = new System.Drawing.Size(120, 28);
            this.btnNa.TabIndex = 77;
            this.btnNa.Text = "Choisir";
            this.btnNa.UseVisualStyleBackColor = false;
            this.btnNa.Click += new System.EventHandler(this.btnNa_Click);
            // 
            // txtc
            // 
            this.txtc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.Location = new System.Drawing.Point(158, 123);
            this.txtc.Margin = new System.Windows.Forms.Padding(4);
            this.txtc.Name = "txtc";
            this.txtc.ReadOnly = true;
            this.txtc.Size = new System.Drawing.Size(328, 22);
            this.txtc.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Couleur";
            // 
            // txts
            // 
            this.txts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts.Location = new System.Drawing.Point(158, 153);
            this.txts.Margin = new System.Windows.Forms.Padding(4);
            this.txts.Name = "txts";
            this.txts.ReadOnly = true;
            this.txts.Size = new System.Drawing.Size(328, 22);
            this.txts.TabIndex = 81;
            // 
            // Taille
            // 
            this.Taille.AutoSize = true;
            this.Taille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taille.Location = new System.Drawing.Point(17, 159);
            this.Taille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Taille.Name = "Taille";
            this.Taille.Size = new System.Drawing.Size(48, 16);
            this.Taille.TabIndex = 80;
            this.Taille.Text = "Taille";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 2);
            this.panel2.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 720);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1131, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 718);
            this.panel3.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 718);
            this.panel4.TabIndex = 101;
            // 
            // np
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.Taille);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNa);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pvh);
            this.Controls.Add(this.pv);
            this.Controls.Add(this.ttva);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.st);
            this.Controls.Add(this.ndpr);
            this.Controls.Add(this.nr);
            this.Controls.Add(this.s);
            this.Controls.Add(this.ndp);
            this.Controls.Add(this.r);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "np";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveu produit";
            this.Load += new System.EventHandler(this.np_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pvh;
        private System.Windows.Forms.Label pv;
        private System.Windows.Forms.ComboBox ttva;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.TextBox rec;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.TextBox ndpr;
        private System.Windows.Forms.TextBox nr;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label ndp;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNa;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label Taille;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

