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
using System.IO;

namespace FD_STOCK
{
    public partial class ls : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public ls()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            bd.Open();
            
        }

        private void remplirBon()
        {
            try
            {
                if (bd.State == ConnectionState.Closed)
                {
                    bd.Open();
                }


                tableau.Rows.Clear();
                SqlCommand cmd = new SqlCommand(" SELECT sortie_bon.[n° sortieb], produits.[n° reference], produits.[nom produit], produits.colour, produits.taille, dsortie_bon.quantiteb, dsortie_bon.qte_collisb, dsortie_bon.prixvb, produits.[taux tva], sortie_bon.[date sortie], sortie_bon.sp FROM sortie_bon INNER JOIN dsortie_bon ON sortie_bon.[n° sortieb] = dsortie_bon.[n° sortieb] INNER JOIN produits ON dsortie_bon.[n° produit] = produits.[n° reference] order BY sortie_bon.[n° sortieb] ", bd);
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
                            rd[4],
                            rd[5],
                            rd[6],
                            rd[7],
                            rd[8],
                            rd[9],
                            rd[10]
                            );
                    }
                    rd.Close();
                }
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void remplirFacture()
        {
            try
            {
                if (bd.State == ConnectionState.Closed)
                {
                    bd.Open();
                }


                tableau.Rows.Clear();
                SqlCommand cmd = new SqlCommand(" SELECT sortie_facture.[n° sortief], produits.[n° reference], produits.[nom produit], produits.colour, produits.taille, dsortie_facture.quantitef, dsortie_facture.qte_collisf, dsortie_facture.prixvf, produits.[taux tva], sortie_facture.[date sortief], sortie_facture.sp FROM sortie_facture INNER JOIN dsortie_facture ON sortie_facture.[n° sortief] = dsortie_facture.[n° sortief] INNER JOIN produits ON dsortie_facture.[n° produit] = produits.[n° reference] order BY sortie_facture.[n° sortief] ", bd);
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
                            rd[4],
                            rd[5],
                            rd[6],
                            rd[7],
                            rd[8],
                            rd[9],
                            rd[10]
                            );
                    }
                    rd.Close();
                }

                bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void rec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tdee.SelectedIndex == 1)
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                    }
                    bd.Open();
                    tableau.Rows.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT sortie_facture.[n° sortief], produits.[n° reference], produits.[nom produit], produits.colour, produits.taille, dsortie_facture.quantitef, dsortie_facture.qte_collisf, dsortie_facture.prixvf, produits.[taux tva], sortie_facture.[date sortief], sortie_facture.sp FROM sortie_facture INNER JOIN dsortie_facture ON sortie_facture.[n° sortief] = dsortie_facture.[n° sortief] INNER JOIN produits ON dsortie_facture.[n° produit] = produits.[n° reference] where produits.[nom produit] like '" + rec.Text + "%' order BY sortie_facture.[n° sortief]", bd);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        tableau.Rows.Add(
                            rd[0],
                                rd[1],
                                rd[2],
                                rd[3],
                                rd[4],
                                rd[5],
                                rd[6],
                                rd[7],
                                rd[8],
                                rd[9],
                                rd[10]
                            );
                    }
                    bd.Close();
                }
                else if (tdee.SelectedIndex == 2)
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                    }
                    bd.Open();
                    tableau.Rows.Clear();
                    SqlCommand cmd = new SqlCommand("SELECT sortie_bon.[n° sortieb], produits.[n° reference], produits.[nom produit], produits.colour, produits.taille, dsortie_bon.quantiteb, dsortie_bon.qte_collisb, dsortie_bon.prixvb, produits.[taux tva], sortie_bon.[date sortie], sortie_bon.sp FROM sortie_bon INNER JOIN dsortie_bon ON sortie_bon.[n° sortieb] = dsortie_bon.[n° sortieb] INNER JOIN produits ON dsortie_bon.[n° produit] = produits.[n° reference]  where produits.[nom produit] like '" + rec.Text + "%' order BY sortie_bon.[n° sortieb]", bd);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        tableau.Rows.Add(
                            rd[0],
                                rd[1],
                                rd[2],
                                rd[3],
                                rd[4],
                                rd[5],
                                rd[6],
                                rd[7],
                                rd[8],
                                rd[9],
                                rd[10]
                            );
                    }
                    bd.Close();
                }
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void f_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE SORTIE PRODUITS " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write header row
                    for (int i = 0; i < tableau.Columns.Count; i++)
                    {
                        sw.Write(tableau.Columns[i].HeaderText);
                        if (i < tableau.Columns.Count - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.WriteLine();

                    // Write data rows
                    foreach (DataGridViewRow row in tableau.Rows)
                    {
                        for (int i = 0; i < tableau.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value);
                            if (i < tableau.Columns.Count - 1)
                            {
                                sw.Write(";");
                            }
                        }
                        sw.WriteLine();
                    }
                }
                MessageBox.Show("EXPORTER AVEC SUCCES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tdee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tdee.SelectedIndex==1)
            {
                remplirFacture();
            }
            else if (tdee.SelectedIndex == 2)
            {
                remplirBon();
            }
            else
            {
                tableau.Rows.Clear();
            }
        }
    }
}
