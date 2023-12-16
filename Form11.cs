using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace FD_STOCK
{
    public partial class nem : Form
    {
        int npr;

        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public nem()
        {
            InitializeComponent();
            
        }

        private void nem_Load(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from produitsm", bd);
           SqlDataReader rd = cmd.ExecuteReader();
           while (rd.Read())
            {
                npro.Items.Add(rd.GetValue(0));
           }
            rd.Close();
            bd.Close();
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            tdee.Text = "";
            npe.Text = "";
            qu.Text = "0";
            npro.Text = "";
            nc.Text = "";
            tableau.Rows.Clear();

            //Modifier.Enabled = false;
            //Supprimer.Enabled = false;
            Enregistrer.Enabled = true;
            tdee.Select();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (npe.Text != "" && tableau.Rows.Count > 1)
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("insert into entreem values('" + tdee.Text + "','" + npe.Text + "','" + ddee.Value.ToString() + "')", bd);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("select top(1) [n° entreem] from [entreem] order by [n° entreem] desc", bd);
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                int ndee = Convert.ToInt32(rd.GetValue(0));
                rd.Close();

                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into dentreem values(" + ndee.ToString() + ",'" + tableau.Rows[i].Cells[0].Value.ToString() + "','" + tableau.Rows[i].Cells[2].Value.ToString() + "','" + tableau.Rows[i].Cells[3].Value.ToString() + "')", bd);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("select * from produitsm where [n° produitm]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    SqlDataReader rd1 = cmd3.ExecuteReader();
                    rd1.Read();
                    int qs = Convert.ToInt32(rd1.GetValue(3)) + Convert.ToInt32(tableau.Rows[i].Cells[2].Value);
                    rd1.Close();

                    SqlCommand cmd4 = new SqlCommand("update produitsm set [stockm]='" + qs.ToString() + "'where [n° produitm]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    cmd4.ExecuteNonQuery();
                }

                MessageBox.Show("ENREGISTREMENT EFFECTUER AVEC SUCCES", "HIBA SOCKS");

                bd.Close();
                Nouveau_Click(sender, e);
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (npro.Text != "" && int.Parse(qu.Text) > 0)
            {
                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    if (tableau.Rows[i].Cells[0].Value.ToString() == npro.Text)
                    {
                        MessageBox.Show(" MATIERE 1 ére DEJA AJOUTER", "HIBA SOCKS");
                        return;
                    }
                }
                tableau.Rows.Add(
                npro.Text,
                nc.Text,
                qu.Text,
                pah.Text,
                ttva.Text
                );
                npro.Text = ""; nc.Clear(); qu.Text = "0"; pah.Clear(); ttva.Clear();
            }
            else
            {
                MessageBox.Show(" VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void npro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from produitsm where [n° produitm]='" + npro.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            nc.Text = rd.GetValue(2).ToString();
            pah.Text = rd.GetValue(4).ToString();
            ttva.Text = rd.GetValue(5).ToString();
            bd.Close();
            qu.Select();
        }

        private void Femer_Click(object sender, EventArgs e)
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
    }
}
