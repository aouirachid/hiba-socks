
namespace FD_STOCK
{
    partial class npg
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
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pah = new System.Windows.Forms.TextBox();
            this.nda = new System.Windows.Forms.TextBox();
            this.nr = new System.Windows.Forms.TextBox();
            this.pa = new System.Windows.Forms.Label();
            this.ndp = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.TextBox();
            this.rechercher = new System.Windows.Forms.Button();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.ta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.color = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(928, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 18);
            this.label8.TabIndex = 182;
            this.label8.Text = "Nouveau composant";
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
            this.button1.TabIndex = 183;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pah
            // 
            this.pah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pah.Location = new System.Drawing.Point(163, 173);
            this.pah.Name = "pah";
            this.pah.Size = new System.Drawing.Size(326, 22);
            this.pah.TabIndex = 171;
            this.pah.Text = "0.00";
            this.pah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nda
            // 
            this.nda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nda.Location = new System.Drawing.Point(163, 145);
            this.nda.Name = "nda";
            this.nda.Size = new System.Drawing.Size(326, 22);
            this.nda.TabIndex = 169;
            // 
            // nr
            // 
            this.nr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr.Location = new System.Drawing.Point(163, 117);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(326, 22);
            this.nr.TabIndex = 168;
            // 
            // pa
            // 
            this.pa.AutoSize = true;
            this.pa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa.Location = new System.Drawing.Point(15, 179);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(114, 16);
            this.pa.TabIndex = 167;
            this.pa.Text = "Prix d\'achat HT";
            // 
            // ndp
            // 
            this.ndp.AutoSize = true;
            this.ndp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndp.Location = new System.Drawing.Point(15, 151);
            this.ndp.Name = "ndp";
            this.ndp.Size = new System.Drawing.Size(142, 16);
            this.ndp.TabIndex = 165;
            this.ndp.Text = "Nom de composant";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(15, 123);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(116, 16);
            this.r.TabIndex = 164;
            this.r.Text = "N° de référence";
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.modifier.FlatAppearance.BorderSize = 0;
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(163, 210);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(160, 28);
            this.modifier.TabIndex = 176;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.enregistrer.FlatAppearance.BorderSize = 0;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(329, 210);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(160, 28);
            this.enregistrer.TabIndex = 175;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // rec
            // 
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(172, 315);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(948, 22);
            this.rec.TabIndex = 174;
            this.rec.TextChanged += new System.EventHandler(this.rec_TextChanged);
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.rechercher.FlatAppearance.BorderSize = 0;
            this.rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.Location = new System.Drawing.Point(18, 315);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(148, 22);
            this.rechercher.TabIndex = 173;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column2,
            this.Column4});
            this.tableau.Location = new System.Drawing.Point(18, 353);
            this.tableau.Name = "tableau";
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableau.Size = new System.Drawing.Size(1102, 357);
            this.tableau.TabIndex = 172;
            // 
            // ta
            // 
            this.ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta.FormattingEnabled = true;
            this.ta.Items.AddRange(new object[] {
            "Matiére 1 ére",
            "Emballage",
            "Piéce de rechange"});
            this.ta.Location = new System.Drawing.Point(163, 87);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(160, 24);
            this.ta.TabIndex = 186;
            this.ta.SelectedIndexChanged += new System.EventHandler(this.ta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 185;
            this.label1.Text = "Type composant";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 247;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 720);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 2);
            this.panel2.TabIndex = 248;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1132, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 718);
            this.panel3.TabIndex = 250;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 718);
            this.panel5.TabIndex = 251;
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "Noir ",
            "Blanc ",
            "Gris",
            "Bleu ",
            "Bleu ciel",
            "Bleu marine",
            "Marron",
            "Rouge",
            "Orange",
            "Jaune",
            "Vert ",
            "Violet",
            "Rose"});
            this.color.Location = new System.Drawing.Point(329, 87);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(160, 24);
            this.color.TabIndex = 252;
            this.color.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de composant";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type de composant";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Couleur";
            this.Column6.Name = "Column6";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "N° de référence";
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom de composant";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix d\'achat HT";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // npg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.color);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pah);
            this.Controls.Add(this.nda);
            this.Controls.Add(this.nr);
            this.Controls.Add(this.pa);
            this.Controls.Add(this.ndp);
            this.Controls.Add(this.r);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.tableau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "npg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau produit général";
            this.Load += new System.EventHandler(this.npg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pah;
        private System.Windows.Forms.TextBox nda;
        private System.Windows.Forms.TextBox nr;
        private System.Windows.Forms.Label pa;
        private System.Windows.Forms.Label ndp;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.TextBox rec;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.ComboBox ta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}