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
    public partial class nsm : Form
    {
        int npr;

        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public nsm()
        {
            InitializeComponent();
        }

        private void nsm_Load(object sender, EventArgs e)
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
            ndee.Text = "";
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
                SqlTransaction transaction = bd.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("insert into sortiem values('" + tdee.Text + "','" + npe.Text + "','" + ddee.Value.ToString() + "')", bd, transaction);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("select top(1) [n° sortiem] from [sortiem] order by [n° sortiem] desc", bd, transaction);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    rd.Read();
                    int ndee = Convert.ToInt32(rd.GetValue(0));
                    rd.Close();

                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        string productCode = tableau.Rows[i].Cells[0].Value.ToString();
                        int quantitySold = Convert.ToInt32(tableau.Rows[i].Cells[2].Value);

                        // Check if there is enough stock for the product
                        SqlCommand cmd3 = new SqlCommand("select [stockm] from produitsm where [n° produitm]='" + productCode + "'", bd, transaction);
                        SqlDataReader rd1 = cmd3.ExecuteReader();
                        rd1.Read();
                        int currentStock = Convert.ToInt32(rd1.GetValue(0));
                        rd1.Close();

                        if (currentStock < quantitySold)
                        {
                            throw new Exception("Not enough stock for product: " + productCode);
                        }

                        // Insert into dsortiem
                        SqlCommand cmd2 = new SqlCommand("insert into dsortiem values(" + ndee.ToString() + ",'" + productCode + "','" + quantitySold + "')", bd, transaction);
                        cmd2.ExecuteNonQuery();

                        // Update stock
                        int newStock = currentStock - quantitySold;
                        SqlCommand cmd4 = new SqlCommand("update produitsm set [stockm]='" + newStock.ToString() + "'where [n° produitm]='" + productCode + "'", bd, transaction);
                        cmd4.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    bd.Close();
                    MessageBox.Show("ENREGISTRER EFFECTUE AVEC SUCCES", "HIBA SOCKS");
                    Nouveau_Click(sender, e);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    bd.Close();
                    MessageBox.Show("Error: " + ex.Message, "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Femer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
