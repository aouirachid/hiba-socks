﻿
namespace FD_STOCK
{
    partial class nm
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
            this.pah = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.TextBox();
            this.ndpr = new System.Windows.Forms.TextBox();
            this.nr = new System.Windows.Forms.TextBox();
            this.pa = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.ndp = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.ttva = new System.Windows.Forms.ComboBox();
            this.tt = new System.Windows.Forms.Label();
            this.fermer = new System.Windows.Forms.Button();
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // pah
            // 
            this.pah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pah.Location = new System.Drawing.Point(164, 220);
            this.pah.Name = "pah";
            this.pah.Size = new System.Drawing.Size(200, 26);
            this.pah.TabIndex = 82;
            // 
            // st
            // 
            this.st.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st.Location = new System.Drawing.Point(164, 188);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(200, 26);
            this.st.TabIndex = 81;
            // 
            // ndpr
            // 
            this.ndpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndpr.Location = new System.Drawing.Point(164, 156);
            this.ndpr.Name = "ndpr";
            this.ndpr.Size = new System.Drawing.Size(200, 26);
            this.ndpr.TabIndex = 80;
            // 
            // nr
            // 
            this.nr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nr.Location = new System.Drawing.Point(164, 124);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(200, 26);
            this.nr.TabIndex = 79;
            // 
            // pa
            // 
            this.pa.AutoSize = true;
            this.pa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa.Location = new System.Drawing.Point(12, 228);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(123, 18);
            this.pa.TabIndex = 78;
            this.pa.Text = "Prix d\'achat HT";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(12, 196);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(52, 18);
            this.s.TabIndex = 77;
            this.s.Text = "Stock";
            // 
            // ndp
            // 
            this.ndp.AutoSize = true;
            this.ndp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndp.Location = new System.Drawing.Point(12, 164);
            this.ndp.Name = "ndp";
            this.ndp.Size = new System.Drawing.Size(124, 18);
            this.ndp.TabIndex = 76;
            this.ndp.Text = "Nom de produit";
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(12, 132);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(126, 18);
            this.r.TabIndex = 75;
            this.r.Text = "N° de référence";
            // 
            // ttva
            // 
            this.ttva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttva.FormattingEnabled = true;
            this.ttva.Items.AddRange(new object[] {
            "20",
            "14",
            "10",
            "  7",
            "  0"});
            this.ttva.Location = new System.Drawing.Point(164, 253);
            this.ttva.Name = "ttva";
            this.ttva.Size = new System.Drawing.Size(200, 26);
            this.ttva.TabIndex = 92;
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.Location = new System.Drawing.Point(12, 261);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(143, 18);
            this.tt.TabIndex = 91;
            this.tt.Text = "Taux de la tva (%)";
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.ForeColor = System.Drawing.Color.White;
            this.fermer.Location = new System.Drawing.Point(610, 220);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(326, 34);
            this.fermer.TabIndex = 90;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.supprimer.FlatAppearance.BorderSize = 0;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(776, 180);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(160, 34);
            this.supprimer.TabIndex = 89;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // nouveau
            // 
            this.nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.nouveau.FlatAppearance.BorderSize = 0;
            this.nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.Color.White;
            this.nouveau.Location = new System.Drawing.Point(776, 140);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(160, 34);
            this.nouveau.TabIndex = 88;
            this.nouveau.Text = "Nouveau";
            this.nouveau.UseVisualStyleBackColor = false;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.modifier.FlatAppearance.BorderSize = 0;
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(610, 180);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(160, 34);
            this.modifier.TabIndex = 87;
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
            this.enregistrer.Location = new System.Drawing.Point(610, 140);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(160, 34);
            this.enregistrer.TabIndex = 86;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // rec
            // 
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(164, 328);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(954, 26);
            this.rec.TabIndex = 85;
            this.rec.TextChanged += new System.EventHandler(this.rec_TextChanged);
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.rechercher.FlatAppearance.BorderSize = 0;
            this.rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.Location = new System.Drawing.Point(17, 328);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(140, 28);
            this.rechercher.TabIndex = 84;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8});
            this.tableau.Location = new System.Drawing.Point(17, 360);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 350);
            this.tableau.TabIndex = 83;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de produit";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "N° de référence";
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom de produit";
            this.Column2.Name = "Column2";
            this.Column2.Width = 158;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix d\'achat HT";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Taux de la tva (%)";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
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
            this.button36.TabIndex = 163;
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
            this.button1.TabIndex = 162;
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
            this.label8.Location = new System.Drawing.Point(875, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 20);
            this.label8.TabIndex = 161;
            this.label8.Text = "Nouvelle matiére 1ére";
            // 
            // nm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 725);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pah);
            this.Controls.Add(this.st);
            this.Controls.Add(this.ndpr);
            this.Controls.Add(this.nr);
            this.Controls.Add(this.pa);
            this.Controls.Add(this.s);
            this.Controls.Add(this.ndp);
            this.Controls.Add(this.r);
            this.Controls.Add(this.ttva);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.tableau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle matiére 1ére";
            this.Load += new System.EventHandler(this.nm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pah;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.TextBox ndpr;
        private System.Windows.Forms.TextBox nr;
        private System.Windows.Forms.Label pa;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label ndp;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.ComboBox ttva;
        private System.Windows.Forms.Label tt;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.TextBox rec;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}