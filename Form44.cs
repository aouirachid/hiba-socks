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
    public partial class sg : Form
    {
        int npr;

        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public sg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sg_Load(object sender, EventArgs e)
        {

        }






        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (teg.Text != "" && tableau.Rows.Count > 1)
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("insert into entreeg values('" + teg.Text + "','" + tdee.Text + "','" + npe.Text + "','" + ddee.Value.ToString() + "','" + epe.Text + "')", bd);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("select top(1) [n°entree] from [entreeg] order by [n°entree] desc", bd);
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                int ndee = Convert.ToInt32(rd.GetValue(0));
                rd.Close();
             
               
                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into dentreeg values(" + ndee.ToString() + ",'" + tableau.Rows[i].Cells[0].Value.ToString() + "','" + tableau.Rows[i].Cells[2].Value.ToString() + "','" + tableau.Rows[i].Cells[3].Value.ToString() + "')", bd);
                    cmd2.ExecuteNonQuery();
                    if (teg.SelectedIndex == 0)
                    {
                        SqlCommand cmd3 = new SqlCommand("select * from produitsm where [n° produitm]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        SqlDataReader rd1 = cmd3.ExecuteReader();
                        rd1.Read();
                        int qs = Convert.ToInt32(rd1.GetValue(3)) + Convert.ToInt32(tableau.Rows[i].Cells[2].Value);
                        rd1.Close();

                        SqlCommand cmd4 = new SqlCommand("update produitsm set [stockm]='" + qs.ToString() + "'where [n° produitm]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        cmd4.ExecuteNonQuery();
                    }
                    else if (teg.SelectedIndex == 1)
                    {
                        SqlCommand cs = new SqlCommand("select * from produitsem where [n° produitem]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        SqlDataReader rs = cs.ExecuteReader();
                        rs.Read();
                        int qs = Convert.ToInt32(rs.GetValue(3)) + Convert.ToInt32(tableau.Rows[i].Cells[2].Value);
                        rs.Close();

                        SqlCommand cmd4 = new SqlCommand("update produitsem set [stockem]='" + qs.ToString() + "'where [n° produitem]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        cmd4.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cd = new SqlCommand("select * from piece_rechange where [n_ref]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        SqlDataReader rb = cd.ExecuteReader();
                        rb.Read();
                        int qs = Convert.ToInt32(rb.GetValue(2)) + Convert.ToInt32(tableau.Rows[i].Cells[2].Value);
                        rb.Close();
                        SqlCommand cm = new SqlCommand("update piece_rechange set [stock]='" + qs.ToString() + "' where [n_ref]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        cm.ExecuteNonQuery();
                    }
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

        private void Nouveau_Click(object sender, EventArgs e)
        {
            teg.Text = "";
            tdee.Text = "";
            npe.Clear();
            epe.Clear();
           
            tableau.Rows.Clear();
          

            // modifier.Enabled = false;
            // supprimer.Enabled = false;
            // enregistrer.Enabled = true;
            teg.Select();
        }

        private void npro_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            if (teg.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("select*from produitsm where [n° produitm]='" + npro.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                nc.Text = rd.GetValue(2).ToString();
                pah.Text = rd.GetValue(4).ToString();
                ttva.Text = rd.GetValue(5).ToString();
                rd.Close();
            }

            else if (teg.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("select*from produitsem where [n° produitem]='" + npro.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                nc.Text = rd.GetValue(2).ToString();
                pah.Text = rd.GetValue(4).ToString();
                ttva.Text = rd.GetValue(5).ToString();
                rd.Close();

            }
            else
            {
                SqlCommand cmd = new SqlCommand("select*from piece_rechange where [n_ref]='" + npro.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                nc.Text = rd.GetValue(1).ToString();
                pah.Text = rd.GetValue(3).ToString();
                ttva.Text = rd.GetValue(4).ToString();
                rd.Close();
            }
            bd.Close();
            qu.Select();
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

        private void teg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                bd.Open();
                if (teg.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("select*from produitsm", bd);
                    SqlDataReader rd = cmd.ExecuteReader();
                    npro.Items.Clear();
                    while (rd.Read())
                    {
                        npro.Items.Add(rd.GetValue(0));
                    }
                    rd.Close();


                }
                else if (teg.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select*from produitsem", bd);
                    SqlDataReader rd = cmd.ExecuteReader();
                    npro.Items.Clear();
                    while (rd.Read())
                    {
                        npro.Items.Add(rd.GetValue(0));
                    }
                    rd.Close();
                }
                else
                {
                    SqlCommand cmd1 = new SqlCommand("select n_ref from piece_rechange", bd);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    npro.Items.Clear();
                    while (rd1.Read())
                    {
                        npro.Items.Add(rd1.GetValue(0).ToString().Trim());
                    }
                }
                bd.Close();
            }
        
    }
}
