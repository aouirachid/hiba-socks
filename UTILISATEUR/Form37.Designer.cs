
namespace FD_STOCK
{
    partial class conx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conx));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.qui = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.va = new System.Windows.Forms.Button();
            this.mpa = new System.Windows.Forms.CheckBox();
            this.mpas = new System.Windows.Forms.TextBox();
            this.logi = new System.Windows.Forms.TextBox();
            this.mp = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.fid = new System.Windows.Forms.Timer(this.components);
            this.button36 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.qui);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.va);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 451);
            this.panel2.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 127);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "HIBA SOCKS";
            // 
            // qui
            // 
            this.qui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.qui.FlatAppearance.BorderSize = 0;
            this.qui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qui.ForeColor = System.Drawing.Color.White;
            this.qui.Location = new System.Drawing.Point(15, 317);
            this.qui.Name = "qui";
            this.qui.Size = new System.Drawing.Size(200, 34);
            this.qui.TabIndex = 5;
            this.qui.Text = "QUITTER";
            this.qui.UseVisualStyleBackColor = false;
            this.qui.Click += new System.EventHandler(this.qui_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(50)))), ((int)(((byte)(103)))));
            this.panel3.BackgroundImage = global::FD_STOCK.Properties.Resources.LOGO_FINAL_HS_HIBA_SOCKS_2;
            this.panel3.Location = new System.Drawing.Point(55, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 106);
            this.panel3.TabIndex = 4;
            // 
            // va
            // 
            this.va.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.va.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.va.FlatAppearance.BorderSize = 0;
            this.va.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.va.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.va.ForeColor = System.Drawing.Color.White;
            this.va.Location = new System.Drawing.Point(15, 277);
            this.va.Name = "va";
            this.va.Size = new System.Drawing.Size(200, 34);
            this.va.TabIndex = 0;
            this.va.Text = "VALIDER";
            this.va.UseVisualStyleBackColor = false;
            this.va.Click += new System.EventHandler(this.va_Click);
            // 
            // mpa
            // 
            this.mpa.AutoSize = true;
            this.mpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpa.Location = new System.Drawing.Point(427, 253);
            this.mpa.Name = "mpa";
            this.mpa.Size = new System.Drawing.Size(216, 22);
            this.mpa.TabIndex = 74;
            this.mpa.Text = "AFFICHER MOT DE PASSE";
            this.mpa.UseVisualStyleBackColor = true;
            this.mpa.CheckedChanged += new System.EventHandler(this.mpa_CheckedChanged);
            // 
            // mpas
            // 
            this.mpas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpas.Location = new System.Drawing.Point(398, 199);
            this.mpas.Name = "mpas";
            this.mpas.Size = new System.Drawing.Size(265, 26);
            this.mpas.TabIndex = 73;
            this.mpas.UseSystemPasswordChar = true;
            // 
            // logi
            // 
            this.logi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logi.Location = new System.Drawing.Point(398, 156);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(265, 26);
            this.logi.TabIndex = 72;
            // 
            // mp
            // 
            this.mp.AutoSize = true;
            this.mp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mp.ForeColor = System.Drawing.Color.Black;
            this.mp.Location = new System.Drawing.Point(248, 201);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(119, 18);
            this.mp.TabIndex = 71;
            this.mp.Text = "MOT DE PASSE";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.Black;
            this.log.Location = new System.Drawing.Point(248, 158);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(59, 18);
            this.log.TabIndex = 70;
            this.log.Text = "LOGIN";
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatAppearance.BorderSize = 0;
            this.button36.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button36.Location = new System.Drawing.Point(636, 12);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(25, 33);
            this.button36.TabIndex = 79;
            this.button36.Text = "-";
            this.button36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button36.UseVisualStyleBackColor = false;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.button1.Location = new System.Drawing.Point(667, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 33);
            this.button1.TabIndex = 78;
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
            this.label8.Location = new System.Drawing.Point(541, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 77;
            this.label8.Text = "Connexion";
            // 
            // conx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mpa);
            this.Controls.Add(this.mpas);
            this.Controls.Add(this.logi);
            this.Controls.Add(this.mp);
            this.Controls.Add(this.log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form37";
            this.Load += new System.EventHandler(this.conx_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button qui;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button va;
        private System.Windows.Forms.CheckBox mpa;
        private System.Windows.Forms.TextBox mpas;
        private System.Windows.Forms.Label mp;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Timer fid;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox logi;
    }
}