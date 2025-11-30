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
    public partial class ldf : Form
    {

        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        string etat;
        public ldf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ldf_Load(object sender, EventArgs e)
        {
            Remplir();
        }
        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }


            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT  cheque.[n° entrree], composant.[type article], composant.[nom article], dentreeg.quantite, entreeg.[date entree], cheque.nombreCheque, cheque.[n°cheque], cheque.montant, cheque.[date versement], cheque.[etat paiement],fournisseur.denomination FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN cheque ON dentreeg.[n° entre] = cheque.[n° entrree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] ORDER BY cheque.[n° entrree] ", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                while (rd.Read())
                {
                    if (rd[9].ToString() == "1")
                    {
                        etat = "Paye";
                    }
                    else
                    {
                        etat = "Non Paye";
                    }
                    tableau.Rows.Add(
                        rd[0],
                        rd[10],
                        rd[1],
                        rd[2],
                        rd[3],
                        rd[4],
                        rd[5],
                        rd[6],
                        rd[7],
                        rd[8],
                        etat



                        ) ;
                }
                rd.Close();
            }

            bd.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT cheque.[n° entrree], composant.[type article], composant.[nom article], dentreeg.quantite, entreeg.[date entree], cheque.nombreCheque, cheque.[n°cheque], cheque.montant, cheque.[date versement], cheque.[etat paiement],fournisseur.denomination FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN cheque ON dentreeg.[n° entre] = cheque.[n° entrree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree]  where fournisseur.denomination like '" + textBox1.Text + "%' and composant.[type article] like '" + comboBox1.Text + "%' and composant.[nom article] like '" + rec.Text + "%' ORDER BY cheque.[n° entrree] ", bd);
            cmd.Parameters.AddWithValue("@denomination", textBox1.Text + "%");
            cmd.Parameters.AddWithValue("@typeArticle", comboBox1.Text + "%");
            cmd.Parameters.AddWithValue("@nomArticle", rec.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[9].ToString() == "1")
                {
                    etat = "Paye";
                }
                else
                {
                    etat = "Non Paye";
                }
                tableau.Rows.Add(
                    rd[0],
                    rd[10],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5],
                    rd[6],
                    rd[7],
                    rd[8],
                    etat
                    );
            }
            bd.Close();
        }

        private void f_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT cheque.[n° entrree], composant.[type article], composant.[nom article], dentreeg.quantite, entreeg.[date entree], cheque.nombreCheque, cheque.[n°cheque], cheque.montant, cheque.[date versement], cheque.[etat paiement],fournisseur.denomination FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN cheque ON dentreeg.[n° entre] = cheque.[n° entrree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree]  where  composant.[type article] like @typeArticle and composant.[nom article] like @nomArticle and fournisseur.denomination like @denomination ORDER BY cheque.[n° entrree]", bd);
            cmd.Parameters.AddWithValue("@denomination", textBox1.Text + "%");
            cmd.Parameters.AddWithValue("@typeArticle", comboBox1.Text + "%");
            cmd.Parameters.AddWithValue("@nomArticle", rec.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[9].ToString() == "1")
                {
                    etat = "Paye";
                }
                else
                {
                    etat = "Non Paye";
                }
                tableau.Rows.Add(
                    rd[0],
                    rd[10],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5],
                    rd[6],
                    rd[7],
                    rd[8],
                    etat
                    );
            }
            bd.Close();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT cheque.[n° entrree], composant.[type article], composant.[nom article], dentreeg.quantite, entreeg.[date entree], cheque.nombreCheque, cheque.[n°cheque], cheque.montant, cheque.[date versement], cheque.[etat paiement],fournisseur.denomination FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN cheque ON dentreeg.[n° entre] = cheque.[n° entrree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] where fournisseur.denomination like @denomination and composant.[type article] like @typeArticle and composant.[nom article] like @nomArticle ORDER BY cheque.[n° entrree]", bd);
            cmd.Parameters.AddWithValue("@denomination", textBox1.Text + "%");
            cmd.Parameters.AddWithValue("@typeArticle", comboBox1.Text + "%");
            cmd.Parameters.AddWithValue("@nomArticle", rec.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[9].ToString() == "1")
                {
                    etat = "Paye";
                }
                else
                {
                    etat = "Non Paye";
                }
                tableau.Rows.Add(
                    rd[0],
                    rd[10],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5],
                    rd[6],
                    rd[7],
                    rd[8],
                    etat
                    );
            }
            bd.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE DETAILLE REGLEMENT " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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
                MessageBox.Show("EXPORTER AVEC SUCCE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
