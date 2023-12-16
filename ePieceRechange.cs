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
    public partial class ePieceRechange : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public ePieceRechange()
        {
            InitializeComponent();
        }

        private void ePieceRechange_Load(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd1 = new SqlCommand("select n_ref from piece_rechange", bd);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                cmbref.Items.Add(rd1.GetValue(0).ToString().Trim());
            }
            bd.Close();
        }

        private void cmbref_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from piece_rechange where [n_ref]='" + cmbref.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            txtnp.Text = rd.GetValue(1).ToString();
            bd.Close();
            txtq.Select();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbref.Text != "")
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == cmbref.Text)
                    {
                        MessageBox.Show("PIECE RECHANGE DEJA AJOUTE" ,"HIBA SOCKS");
                        return;
                    }
                }
                tableau2.Rows.Add(
                    cmbref.Text,
                    txtnp.Text,
                    txtq.Text
                    );
                cmbref.Text = ""; txtnp.Clear(); txtq.Text = "0";
            }
            else
            {
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(tableau2.Rows.Count > 1)
            {
                bd.Open();
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into epiece_rechange values('" + tableau2.Rows[i].Cells[0].Value.ToString() + "','" + tableau2.Rows[i].Cells[1].Value.ToString() + "','" + tableau2.Rows[i].Cells[2].Value.ToString() + "')", bd);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("select * from piece_rechange where [n_ref]='" + tableau2.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    SqlDataReader rd1 = cmd2.ExecuteReader();
                    rd1.Read();
                    int qs = Convert.ToInt32(rd1.GetValue(2)) + Convert.ToInt32(tableau2.Rows[i].Cells[2].Value);
                    rd1.Close();
                    SqlCommand cmd4 = new SqlCommand("update piece_rechange set [stock]='" + qs.ToString() + "' where [n_ref]='" + tableau2.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    cmd4.ExecuteNonQuery();
                }
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES", "HIBA SOCKS");
                tableau2.Rows.Clear();
                bd.Close();
            }
            else
            {
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
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
