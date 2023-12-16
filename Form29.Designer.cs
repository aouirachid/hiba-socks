
namespace FD_STOCK
{
    partial class ca
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
            this.label6 = new System.Windows.Forms.Label();
            this.SA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TE = new System.Windows.Forms.Label();
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dateHour = new System.Windows.Forms.DateTimePicker();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 656);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Tolat Entree :";
            // 
            // SA
            // 
            this.SA.AutoSize = true;
            this.SA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SA.ForeColor = System.Drawing.Color.Red;
            this.SA.Location = new System.Drawing.Point(129, 688);
            this.SA.Name = "SA";
            this.SA.Size = new System.Drawing.Size(0, 24);
            this.SA.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 692);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Solde Actuel :";
            // 
            // TE
            // 
            this.TE.AutoSize = true;
            this.TE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TE.ForeColor = System.Drawing.Color.Red;
            this.TE.Location = new System.Drawing.Point(128, 652);
            this.TE.Name = "TE";
            this.TE.Size = new System.Drawing.Size(0, 24);
            this.TE.TabIndex = 41;
            // 
            // tableau
            // 
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tableau.Location = new System.Drawing.Point(15, 287);
            this.tableau.Name = "tableau";
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableau.Size = new System.Drawing.Size(1101, 350);
            this.tableau.TabIndex = 37;
            this.tableau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableau_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N° entrée";
            this.Column1.Name = "Column1";
            this.Column1.Width = 244;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Libélle";
            this.Column2.Name = "Column2";
            this.Column2.Width = 275;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Montant";
            this.Column3.Name = "Column3";
            this.Column3.Width = 260;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date et heure";
            this.Column4.Name = "Column4";
            this.Column4.Width = 260;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(248, 186);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 34);
            this.btnExport.TabIndex = 36;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(406, 186);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(152, 34);
            this.saveBtn.TabIndex = 35;
            this.saveBtn.Text = "Enregister";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dateHour
            // 
            this.dateHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHour.Location = new System.Drawing.Point(249, 142);
            this.dateHour.Name = "dateHour";
            this.dateHour.Size = new System.Drawing.Size(309, 26);
            this.dateHour.TabIndex = 34;
            // 
            // txtp
            // 
            this.txtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp.Location = new System.Drawing.Point(249, 110);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(309, 26);
            this.txtp.TabIndex = 30;
            this.txtp.Text = "0.00";
            this.txtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtl
            // 
            this.txtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtl.Location = new System.Drawing.Point(249, 78);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(309, 26);
            this.txtl.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Date et heure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Montant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Libélle";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(77, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 26);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Libélle";
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
            this.button36.Location = new System.Drawing.Point(1066, 12);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 72;
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
            this.button1.Location = new System.Drawing.Point(1097, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 71;
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
            this.label8.Location = new System.Drawing.Point(934, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 70;
            this.label8.Text = "Entrée caisse";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 2);
            this.panel1.TabIndex = 245;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 720);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 2);
            this.panel2.TabIndex = 246;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel3.Location = new System.Drawing.Point(1132, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 718);
            this.panel3.TabIndex = 248;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 718);
            this.panel5.TabIndex = 249;
            // 
            // fromDate
            // 
            this.fromDate.CustomFormat = "dd/MM/yyyy";
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDate.Location = new System.Drawing.Point(713, 256);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(132, 26);
            this.fromDate.TabIndex = 250;
            this.fromDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1018, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 26);
            this.button2.TabIndex = 251;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toDate
            // 
            this.toDate.CustomFormat = "dd/MM/yyyy";
            this.toDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDate.Location = new System.Drawing.Point(880, 256);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(132, 26);
            this.toDate.TabIndex = 252;
            this.toDate.ValueChanged += new System.EventHandler(this.toDate_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(851, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 286;
            this.label9.Text = "Au";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(682, 264);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 15);
            this.label19.TabIndex = 287;
            this.label19.Text = "Du";
            // 
            // ca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 722);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TE);
            this.Controls.Add(this.tableau);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dateHour);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caisse";
            this.Load += new System.EventHandler(this.ca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TE;
        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker dateHour;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
    }
}