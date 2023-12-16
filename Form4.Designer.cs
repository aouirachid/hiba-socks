
namespace FD_STOCK
{
    partial class lc
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
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rec = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
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
            this.Column7,
            this.Column8,
            this.Column5});
            this.tableau.Location = new System.Drawing.Point(20, 168);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 500);
            this.tableau.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° de client";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Dénomination";
            this.Column10.Name = "Column10";
            this.Column10.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Responsable";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "N° ice";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Téléphone";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "E-mail";
            this.Column7.Name = "Column7";
            this.Column7.Width = 170;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Siége social";
            this.Column8.Name = "Column8";
            this.Column8.Width = 220;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ville";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // rec
            // 
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(146, 126);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(975, 26);
            this.rec.TabIndex = 29;
            this.rec.TextChanged += new System.EventHandler(this.rec_TextChanged);
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(20, 129);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(120, 20);
            this.r.TabIndex = 28;
            this.r.Text = "Dénomination";
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.f.FlatAppearance.BorderSize = 0;
            this.f.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.ForeColor = System.Drawing.Color.White;
            this.f.Location = new System.Drawing.Point(935, 674);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(186, 38);
            this.f.TabIndex = 31;
            this.f.Text = "Fermer";
            this.f.UseVisualStyleBackColor = false;
            this.f.Click += new System.EventHandler(this.f_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Location = new System.Drawing.Point(743, 674);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(186, 38);
            this.exportBtn.TabIndex = 32;
            this.exportBtn.Text = "Exporter";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
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
            this.button36.Location = new System.Drawing.Point(1070, 12);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 69;
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
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.button1.Location = new System.Drawing.Point(1101, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 68;
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
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(965, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Liste client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 242;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 720);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 2);
            this.panel2.TabIndex = 243;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel3.Location = new System.Drawing.Point(1132, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 718);
            this.panel3.TabIndex = 245;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 718);
            this.panel5.TabIndex = 246;
            // 
            // lc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.r);
            this.Controls.Add(this.f);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste clients";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rec;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Button f;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        public System.Windows.Forms.DataGridView tableau;
    }
}