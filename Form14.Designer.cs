
namespace FD_STOCK
{
    partial class lem
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
            this.rec = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Button();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportBtn = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // rec
            // 
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(203, 122);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(914, 26);
            this.rec.TabIndex = 41;
            this.rec.TextChanged += new System.EventHandler(this.rec_TextChanged);
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(16, 125);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(181, 20);
            this.r.TabIndex = 40;
            this.r.Text = "Nom du matiére 1 ére";
            this.r.Click += new System.EventHandler(this.r_Click);
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.f.FlatAppearance.BorderSize = 0;
            this.f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.Color.White;
            this.f.Location = new System.Drawing.Point(931, 670);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(186, 38);
            this.f.TabIndex = 43;
            this.f.Text = "Fermer";
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.f_Click);
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column10,
            this.Column1,
            this.Column6,
            this.Column9,
            this.Column2,
            this.Column4,
            this.Column8,
            this.Column7});
            this.tableau.Location = new System.Drawing.Point(16, 164);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 500);
            this.tableau.TabIndex = 42;
            this.tableau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "N° d\'entrée";
            this.Column5.Name = "Column5";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "N° de référence";
            this.Column10.Name = "Column10";
            this.Column10.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type de piéce";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "N° de piéce";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Nom produit";
            this.Column9.Name = "Column9";
            this.Column9.Width = 172;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantité";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix achat  HT";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Taux de la tva (%)";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date de sortie";
            this.Column7.Name = "Column7";
            this.Column7.Width = 135;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Location = new System.Drawing.Point(739, 670);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(186, 38);
            this.exportBtn.TabIndex = 44;
            this.exportBtn.Text = "Exporter";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
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
            this.button36.TabIndex = 169;
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
            this.button1.TabIndex = 168;
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
            this.label8.Location = new System.Drawing.Point(847, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 20);
            this.label8.TabIndex = 167;
            this.label8.Text = "Liste entrée matiére 1ére";
            // 
            // lem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 725);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.r);
            this.Controls.Add(this.f);
            this.Controls.Add(this.tableau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste d\'entrée matiére1 ére";
            this.Load += new System.EventHandler(this.lem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rec;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Button f;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}