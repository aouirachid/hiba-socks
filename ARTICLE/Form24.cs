using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace FD_STOCK
{
    public partial class nart : Form
    {
        int npr;
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public nart()
        {
            InitializeComponent();
        }

        private void nart_Load(object sender, EventArgs e)
        {
            Remplir();
            bd.Open();
        }
        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = int.Parse(tableau.Rows[i].Cells[0].Value.ToString().Trim());
            txtna.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtc.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txts.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
        }

        private void tableau_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = int.Parse(tableau.Rows[i].Cells[0].Value.ToString().Trim());
            txtna.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtc.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txts.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
        }
        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }

            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from article", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(0).ToString().Trim(),
                   rd.GetValue(1).ToString().Trim(),
                   rd.GetValue(2).ToString().Trim(),
                   rd.GetValue(3).ToString().Trim()
                    );
            }
            bd.Close();


        }
        private void clear()
        {
            txtna.Text = "";
            txtc.Text = "";
            txts.Text = "";
            btnUpdate.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
            try
            { 
            //bd.Open();
            if (txtna.Text != "" && txtc.Text != "" && txts.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into article values('" + txtna.Text.ToUpper() + "' , '" + txtc.Text + "','" + txts.Text + "')", bd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Close();
                clear();
                Remplir();

            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            { 
            if (txtna.Text != "" && txtc.Text != "" && txts.Text != "")
            {
                bd.Open();
                SqlCommand cmd1 = new SqlCommand("update article set [nom_article]='" + txtna.Text.ToUpper() + "',[color]='" + txtc.Text + "',[size]='" + txts.Text + "' where[n_article]='" + npr.ToString() + "'", bd);
                cmd1.ExecuteNonQuery();
                bd.Close();
                MessageBox.Show("MODIFICATION EFFECTUER AVEC SUCCE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            clear();
            Remplir();
            bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
                bd.Close();
            try
            { 
            bd.Open();
            string input;
            input = (Microsoft.VisualBasic.Interaction.InputBox("RECHERCHER N° ARTICLE", "HIBA SOCKS"));

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("VEUILLEZ SAISIR N° ARTICLE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(input, out npr))
            {
                MessageBox.Show("N° ARTICLE NON VALIDE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmd = new SqlCommand("select * from article where [n_article]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == false)
            {
                MessageBox.Show("N° ARTICLE " + npr.ToString() + " N° N'EXISTE PAS", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rd.Read();
                txtna.Text = rd.GetValue(1).ToString().Trim();
                txtc.Text = rd.GetValue(2).ToString().Trim();
                txts.Text = rd.GetValue(3).ToString().Trim();
                btnUpdate.Enabled = true;
                saveBtn.Enabled = false;
            }
            rd.Close();
            bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void fermer_Click(object sender, EventArgs e)
        {
            
        }

        private void inportBtn_Click(object sender, EventArgs e)
        {
          
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
                bd.Close();
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from article where [nom_article] like '%" + txtnoa.Text + "%'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(0).ToString().Trim(),
                   rd.GetValue(1).ToString().Trim(),
                   rd.GetValue(2).ToString().Trim(),
                   rd.GetValue(3).ToString().Trim()
                    );
            }
            bd.Close();
        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = int.Parse(tableau.Rows[i].Cells[0].Value.ToString().Trim());
            txtna.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtc.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txts.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
        }

        private void tableau_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = int.Parse(tableau.Rows[i].Cells[0].Value.ToString().Trim());
            txtna.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtc.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txts.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
        }
    }
}
