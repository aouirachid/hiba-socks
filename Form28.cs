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

namespace FD_STOCK
{
    public partial class prech : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        string npr;
        public prech()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bd.Open();

                SqlCommand cmb = new SqlCommand("select * from piece_rechange where upper([n_ref])='" + txtnr.Text.ToUpper() + "'", bd);
                SqlDataReader rd = cmb.ExecuteReader();

                if (rd.HasRows)
                {
                    MessageBox.Show("N° PIECE DE RECHANGE DEJA EXISTE", "HIBA SOCKS");
                    rd.Close();
                }
                else if (!string.IsNullOrEmpty(txtnr.Text) && !string.IsNullOrEmpty(txtnp.Text) && int.Parse(txtst.Text) > 0 && float.Parse(txtpa.Text) > 0)
                {
                    rd.Close(); // Close the previous SqlDataReader

                    SqlCommand cmd = new SqlCommand("insert into piece_rechange values('" + txtnr.Text + "' , '" + txtnp.Text + "','" + txtst.Text + "', '" + txtpa.Text + "', '" + txttatva.Text + "')", bd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "HIBA SOCKS");

                    // Close the connection after use
                    bd.Close();

                    clear();
                    Remplir();
                }
                else
                {
                    MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            finally
            {
                // Ensure that the connection is closed even if an exception occurs
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
            }
    }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtnr.Text) && !string.IsNullOrEmpty(txtnp.Text) && int.Parse(txtst.Text) > 0 && float.Parse(txtpa.Text) > 0)
            { 
                bd.Open();
            SqlCommand cmd1 = new SqlCommand("update piece_rechange set n_ref='" + txtnr.Text + "',nom_piece='" + txtnp.Text + "',stock='" + txtst.Text + "',prix_achat='" + txtpa.Text + "',tatva='" + txttatva.Text + "' where[n_ref]='" + npr.ToString() + "'", bd);
            cmd1.ExecuteNonQuery();
            bd.Close();
            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES", "HIBA SOCKS");
            }
            else
                MessageBox.Show("VERIFIER LA SAISIE","HIBA SOCKS");
            clear();
            Remplir();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            npr = Microsoft.VisualBasic.Interaction.InputBox("N° REFERENCE PIECE DE RECHANGE", "HIBA SOCKS");
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from piece_rechange where[n_ref]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                rd.Read();
                txtnr.Text = rd.GetValue(0).ToString().Trim();
                txtnp.Text = rd.GetValue(1).ToString().Trim();
                txtst.Text = rd.GetValue(2).ToString().Trim();
                txtpa.Text = rd.GetValue(3).ToString().Trim();
                txttatva.Text = rd.GetValue(4).ToString().Trim();
            }

            else
            {
                MessageBox.Show("N° PIECE DE RECHANGE  " + npr.ToString() + " N'EXISTE PAS", "HIBA SOCKS");
            }
            bd.Close();
        }
        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = (tableau.Rows[i].Cells[0].Value.ToString().Trim());
            txtnr.Text = tableau.Rows[i].Cells[0].Value.ToString().Trim();
            txtnp.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtst.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txtpa.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
            txttatva.Text = tableau.Rows[i].Cells[4].Value.ToString().Trim();
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = (tableau.Rows[i].Cells[0].Value.ToString().Trim());
            txtnr.Text = tableau.Rows[i].Cells[0].Value.ToString().Trim();
            txtnp.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtst.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txtpa.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
            txttatva.Text = tableau.Rows[i].Cells[4].Value.ToString().Trim();
        }

        private void prech_Load(object sender, EventArgs e)
        {
            Remplir();
        }
        private void Remplir()
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from piece_rechange", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(0).ToString().Trim(),
                   rd.GetValue(1).ToString().Trim(),
                   rd.GetValue(2).ToString().Trim(),
                   rd.GetValue(3).ToString().Trim(),
                   rd.GetValue(4).ToString().Trim()
                    );
            }
            bd.Close();
        }

        private void clear()
        {
            txtnr.Text = "";
            txtnp.Text = "";
            txtst.Text = "0";
            txtpa.Text = "";
            txttatva.Text = "0";
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnref_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from piece_rechange where [n_ref] like '%" + txtnref.Text + "%'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                while (rd.Read())
                {
                    tableau.Rows.Add(
                    rd[0],
                    rd[1],
                   rd[2],
                   rd[3],
                   rd[4]
                        );
                }
            }
            bd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
