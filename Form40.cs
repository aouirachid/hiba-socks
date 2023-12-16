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
    public partial class leg : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public leg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leg_Load(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT entreeg.[n°entree], entreeg.[type piece], entreeg.[n° piece], composant.[type article], composant.[nom article], dentreeg.quantite, dentreeg.[prix achatht], composant.tva, entreeg.[entree par], entreeg.[date entree] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] ", bd);
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
                   rd[9]
                   );
                }
            }
            bd.Close();
        }

        private void f_Click(object sender, EventArgs e)
        {
            this. Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT entreeg.[n°entree], entreeg.[type piece], entreeg.[n° piece], composant.[type article], composant.[nom article], dentreeg.quantite, dentreeg.[prix achatht], composant.tva, entreeg.[entree par], entreeg.[date entree] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] where composant.[type article] like '" + comboBox1.Text + "%' and composant.[nom article] like '" + rec.Text + "%' ", bd);
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
                   rd[9]
                   );
            }
            bd.Close();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT entreeg.[n°entree], entreeg.[type piece], entreeg.[n° piece], composant.[type article], composant.[nom article], dentreeg.quantite, dentreeg.[prix achatht], composant.tva, entreeg.[entree par], entreeg.[date entree] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] where composant.[nom article] like '" + rec.Text + "%' and composant.[type article] like '" + comboBox1.Text + "%' ", bd);
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
                   rd[9]
                   );
            }
            bd.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE ENTREE COMPOSANT " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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
                MessageBox.Show("EXPORTER AVEC SUCCE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
