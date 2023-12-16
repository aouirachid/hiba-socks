
namespace FD_STOCK
{
    partial class dpers
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateHour = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbp = new System.Windows.Forms.ComboBox();
            this.btnNa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnc = new System.Windows.Forms.TextBox();
            this.txtnco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.hs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtp = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.post = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(249, 272);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(309, 34);
            this.saveBtn.TabIndex = 62;
            this.saveBtn.Text = "Enregister";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.tableau.Location = new System.Drawing.Point(17, 361);
            this.tableau.Name = "tableau";
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableau.Size = new System.Drawing.Size(1101, 350);
            this.tableau.TabIndex = 61;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom et prénom";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Poste";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Présence";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Objectif";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Heure d\'objectif";
            this.Column5.Name = "Column5";
            this.Column5.Width = 160;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date et heure";
            this.Column6.Name = "Column6";
            this.Column6.Width = 160;
            // 
            // dateHour
            // 
            this.dateHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHour.Location = new System.Drawing.Point(249, 231);
            this.dateHour.Name = "dateHour";
            this.dateHour.Size = new System.Drawing.Size(309, 26);
            this.dateHour.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Date et heure";
            // 
            // txto
            // 
            this.txto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txto.Location = new System.Drawing.Point(249, 199);
            this.txto.Name = "txto";
            this.txto.Size = new System.Drawing.Size(100, 26);
            this.txto.TabIndex = 58;
            this.txto.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Objectif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Présence";
            // 
            // cmbp
            // 
            this.cmbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbp.FormattingEnabled = true;
            this.cmbp.Items.AddRange(new object[] {
            "Présent ",
            "Absent "});
            this.cmbp.Location = new System.Drawing.Point(249, 167);
            this.cmbp.Name = "cmbp";
            this.cmbp.Size = new System.Drawing.Size(309, 26);
            this.cmbp.TabIndex = 56;
            // 
            // btnNa
            // 
            this.btnNa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.btnNa.FlatAppearance.BorderSize = 0;
            this.btnNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNa.ForeColor = System.Drawing.Color.White;
            this.btnNa.Location = new System.Drawing.Point(468, 103);
            this.btnNa.Name = "btnNa";
            this.btnNa.Size = new System.Drawing.Size(90, 25);
            this.btnNa.TabIndex = 54;
            this.btnNa.Text = "Choisir";
            this.btnNa.UseVisualStyleBackColor = false;
            this.btnNa.Click += new System.EventHandler(this.btnNa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Poste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nom et prénom";
            // 
            // txtnc
            // 
            this.txtnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnc.Location = new System.Drawing.Point(249, 103);
            this.txtnc.Name = "txtnc";
            this.txtnc.ReadOnly = true;
            this.txtnc.Size = new System.Drawing.Size(213, 26);
            this.txtnc.TabIndex = 52;
            // 
            // txtnco
            // 
            this.txtnco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnco.Location = new System.Drawing.Point(153, 325);
            this.txtnco.Name = "txtnco";
            this.txtnco.Size = new System.Drawing.Size(430, 26);
            this.txtnco.TabIndex = 65;
            this.txtnco.TextChanged += new System.EventHandler(this.txtnco_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Nom et prénom";
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
            this.button36.TabIndex = 85;
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
            this.button1.TabIndex = 84;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.label5.Location = new System.Drawing.Point(912, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Détaille salarier";
            // 
            // hs
            // 
            this.hs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hs.FormattingEnabled = true;
            this.hs.Items.AddRange(new object[] {
            "08 H 00 min - 09 H 00 min",
            "09 H 00 min - 10 H 00 min",
            "10 H 00 min - 11 H 00 min",
            "11 H 00 min - 12 H 00 min",
            "12 H 00 min - 13 H 00 min",
            "13 H 00 min - 14 H 00 min",
            "14 H 00 min - 15 H 00 min",
            "15 H 00 min - 16 H 00 min",
            "16 H 00 min - 17 H 00 min",
            "17 H 00 min - 18 H 00 min",
            "18 H 00 min - 19 H 00 min",
            "19 H 00 min - 20 H 00 min",
            "20 H 00 min - 21 H 00 min",
            "21 H 00 min - 22 H 00 min",
            "22 H 00 min - 23 H 00 min",
            "23 H 00 min - 00 H 00 min",
            "00 H 00 min - 01 H 00 min",
            "01 H 00 min - 02 H 00 min",
            "02 H 00 min - 03 H 00 min",
            "03 H 00 min - 04 H 00 min",
            "04 H 00 min - 05 H 00 min",
            "05 H 00 min - 06 H 00 min",
            "06 H 00 min - 07 H 00 min",
            "07 H 00 min - 08 H 00 min"});
            this.hs.Location = new System.Drawing.Point(358, 199);
            this.hs.Name = "hs";
            this.hs.Size = new System.Drawing.Size(200, 26);
            this.hs.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 89;
            this.label9.Text = "Nouveau Salarier";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(249, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(309, 36);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Ajouter Nouveau";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtp
            // 
            this.txtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp.FormattingEnabled = true;
            this.txtp.Items.AddRange(new object[] {
            "Couture",
            "Contrôle",
            "Repassage",
            "Ticket",
            "Emballage cellophane",
            "Pistol"});
            this.txtp.Location = new System.Drawing.Point(249, 135);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(309, 26);
            this.txtp.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 720);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 2);
            this.panel2.TabIndex = 97;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel3.Location = new System.Drawing.Point(1132, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 718);
            this.panel3.TabIndex = 98;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 718);
            this.panel4.TabIndex = 99;
            // 
            // post
            // 
            this.post.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post.FormattingEnabled = true;
            this.post.Items.AddRange(new object[] {
            "",
            "Couture",
            "Contrôle",
            "Repassage",
            "Ticket",
            "Emballage cellophane",
            "Pistol"});
            this.post.Location = new System.Drawing.Point(688, 325);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(430, 26);
            this.post.TabIndex = 101;
            this.post.SelectedIndexChanged += new System.EventHandler(this.post_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 100;
            this.label7.Text = "Poste";
            // 
            // dpers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.post);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hs);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.dateHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbp);
            this.Controls.Add(this.btnNa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dpers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détaille salarier";
            this.Load += new System.EventHandler(this.dpers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.DateTimePicker dateHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbp;
        private System.Windows.Forms.Button btnNa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnc;
        private System.Windows.Forms.TextBox txtnco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox hs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox txtp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox post;
        private System.Windows.Forms.Label label7;
    }
}