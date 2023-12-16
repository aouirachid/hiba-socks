
namespace FD_STOCK
{
    partial class utilisateur
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
            this.components = new System.ComponentModel.Container();
            this.enregistrer = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.mpas = new System.Windows.Forms.TextBox();
            this.logi = new System.Windows.Forms.TextBox();
            this.mp = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.fid = new System.Windows.Forms.Timer(this.components);
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.enregistrer.FlatAppearance.BorderSize = 0;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(526, 153);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(160, 34);
            this.enregistrer.TabIndex = 7;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.modifier.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.modifier.FlatAppearance.BorderSize = 0;
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(526, 193);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(160, 34);
            this.modifier.TabIndex = 0;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // mpas
            // 
            this.mpas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpas.Location = new System.Drawing.Point(180, 177);
            this.mpas.Name = "mpas";
            this.mpas.Size = new System.Drawing.Size(283, 26);
            this.mpas.TabIndex = 84;
            // 
            // logi
            // 
            this.logi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logi.Location = new System.Drawing.Point(180, 145);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(283, 26);
            this.logi.TabIndex = 83;
            // 
            // mp
            // 
            this.mp.AutoSize = true;
            this.mp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp.ForeColor = System.Drawing.Color.Black;
            this.mp.Location = new System.Drawing.Point(12, 185);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(105, 18);
            this.mp.TabIndex = 82;
            this.mp.Text = "Mot de passe";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.Black;
            this.log.Location = new System.Drawing.Point(12, 153);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(49, 18);
            this.log.TabIndex = 81;
            this.log.Text = "Login";
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.button36.Location = new System.Drawing.Point(1066, 12);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 88;
            this.button36.Text = "-";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.button1.Location = new System.Drawing.Point(1097, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 87;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(898, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 86;
            this.label8.Text = "Nouveau utilisateur";
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.tableau.Location = new System.Drawing.Point(15, 360);
            this.tableau.Name = "tableau";
            this.tableau.Size = new System.Drawing.Size(1101, 350);
            this.tableau.TabIndex = 91;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Login";
            this.Column2.Name = "Column2";
            this.Column2.Width = 347;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mot de passe";
            this.Column3.Name = "Column3";
            this.Column3.Width = 347;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            this.Column4.Width = 347;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 92;
            this.label3.Text = "Type";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Super administrateur",
            "Administrateur"});
            this.type.Location = new System.Drawing.Point(180, 209);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(283, 28);
            this.type.TabIndex = 151;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 248;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1132, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 720);
            this.panel3.TabIndex = 251;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 720);
            this.panel5.TabIndex = 252;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(2, 720);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 2);
            this.panel2.TabIndex = 253;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(15, 326);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 28);
            this.btnSearch.TabIndex = 254;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rec
            // 
            this.rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec.Location = new System.Drawing.Point(161, 326);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(955, 26);
            this.rec.TabIndex = 256;
            this.rec.TextChanged += new System.EventHandler(this.rec_TextChanged);
            // 
            // utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.mpas);
            this.Controls.Add(this.logi);
            this.Controls.Add(this.mp);
            this.Controls.Add(this.log);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "utilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSCRIPTION";
            this.Load += new System.EventHandler(this.utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.TextBox mpas;
        public System.Windows.Forms.TextBox logi;
        private System.Windows.Forms.Label mp;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Timer fid;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}