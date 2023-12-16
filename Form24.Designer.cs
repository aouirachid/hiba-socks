
namespace FD_STOCK
{
    partial class nart
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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.txtna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnoa = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.ComboBox();
            this.txts = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.tableau.Location = new System.Drawing.Point(19, 333);
            this.tableau.Name = "tableau";
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableau.Size = new System.Drawing.Size(1101, 380);
            this.tableau.TabIndex = 25;
            this.tableau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellClick_1);
            this.tableau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° d\'article";
            this.Column1.Name = "Column1";
            this.Column1.Width = 157;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nom d\'article";
            this.Column4.Name = "Column4";
            this.Column4.Width = 294;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Couleur";
            this.Column2.Name = "Column2";
            this.Column2.Width = 294;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Taille";
            this.Column3.Name = "Column3";
            this.Column3.Width = 294;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(17, 300);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 26);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(181, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 34);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(338, 189);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(152, 34);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Enregister";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // txtna
            // 
            this.txtna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtna.Location = new System.Drawing.Point(181, 78);
            this.txtna.Name = "txtna";
            this.txtna.Size = new System.Drawing.Size(309, 26);
            this.txtna.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Taille";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Couleur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom d\'article";
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
            this.button36.TabIndex = 66;
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
            this.button1.TabIndex = 65;
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
            this.label8.Location = new System.Drawing.Point(924, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Nouveau article";
            // 
            // txtnoa
            // 
            this.txtnoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoa.Location = new System.Drawing.Point(183, 300);
            this.txtnoa.Name = "txtnoa";
            this.txtnoa.Size = new System.Drawing.Size(937, 26);
            this.txtnoa.TabIndex = 68;
            this.txtnoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtc
            // 
            this.txtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.FormattingEnabled = true;
            this.txtc.Items.AddRange(new object[] {
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
            this.txtc.Location = new System.Drawing.Point(183, 110);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(307, 26);
            this.txtc.TabIndex = 69;
            // 
            // txts
            // 
            this.txts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts.FormattingEnabled = true;
            this.txts.Items.AddRange(new object[] {
            "19",
            "22",
            "23",
            "26",
            "27 - 30",
            "31 - 34",
            "35 - 38",
            "39 - 42",
            "41 - 45"});
            this.txts.Location = new System.Drawing.Point(183, 142);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(307, 26);
            this.txts.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 2);
            this.panel2.TabIndex = 98;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel3.Location = new System.Drawing.Point(1132, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 718);
            this.panel3.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 718);
            this.panel4.TabIndex = 101;
            // 
            // nart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtnoa);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txtna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau article";
            this.Load += new System.EventHandler(this.nart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox txtna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnoa;
        private System.Windows.Forms.ComboBox txtc;
        private System.Windows.Forms.ComboBox txts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}