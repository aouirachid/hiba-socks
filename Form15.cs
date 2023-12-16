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
    public partial class lsm : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public lsm()
        {
            InitializeComponent();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT sortiem.[n° sortiem], produitsm.[n° referencem], sortiem.[type piecem], sortiem.[n° piecem], produitsm.[nom produitm], dsortiem.quantitem, produitsm.[prix achathtm], produitsm.[taux tvam], sortiem.[date sortiem] FROM dsortiem INNER JOIN sortiem ON dsortiem.[n° sortim] = sortiem.[n° sortiem] INNER JOIN produitsm ON dsortiem.[n° produitm] = produitsm.[n° produitm] where produitsm.[nom produitm] like '" + rec.Text + "%'", bd);
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
                        rd[8]




                        );
                }
                rd.Close();
            }

            bd.Close();
            
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            bd.Open();
            Remplir();
        }

        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }


            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT sortiem.[n° sortiem], produitsm.[n° referencem], sortiem.[type piecem], sortiem.[n° piecem], produitsm.[nom produitm], dsortiem.quantitem, produitsm.[prix achathtm], produitsm.[taux tvam], sortiem.[date sortiem] FROM dsortiem INNER JOIN sortiem ON dsortiem.[n° sortim] = sortiem.[n° sortiem] INNER JOIN produitsm ON dsortiem.[n° produitm] = produitsm.[n° produitm]", bd);
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
                        rd[8]




                        );
                }
                rd.Close();
            }

            bd.Close();


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
            saveFileDialog.FileName = "EXPORTAION LISTE SORTIE MATIERES 1ére " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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
                            sw.Write(",");
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
                                sw.Write(",");
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
    }
}
