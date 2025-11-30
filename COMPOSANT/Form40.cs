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
        private void UpdateTCLabel()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (row.Cells[7].Value != null && row.Cells[11].Value != DBNull.Value)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells[7].Value.ToString(), out cellValue))
                    {
                        total += cellValue;
                    }
                }
            }

            TEC.Text = total.ToString();
        }
        private void leg_Load(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT entreeg.[n°entree], fournisseur.denomination, entreeg.[type piece], entreeg.[n° piece], composant.[type article], composant.[nom article],composant.[color], dentreeg.quantite, dentreeg.[prix achatht], composant.tva, entreeg.[entree par],  entreeg.[date entree] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] ", bd);
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
                   rd[10],
                   rd.GetDateTime(11).ToString("dd/MM/yyyy")
                   );
                }
            }
            bd.Close();
            UpdateTCLabel();
        }

        private void f_Click(object sender, EventArgs e)
        {
            this. Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT entreeg.[n°entree], fournisseur.denomination, entreeg.[type piece], entreeg.[n° piece], composant.[type article], composant.[nom article],composant.color, dentreeg.quantite, dentreeg.[prix achatht], composant.tva, entreeg.[entree par],  entreeg.[date entree] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] where composant.[type article] like @typeArticle and composant.[nom article] like @nomArticle ", bd);
            cmd.Parameters.AddWithValue("@typeArticle", comboBox1.Text + "%");
            cmd.Parameters.AddWithValue("@nomArticle", rec.Text + "%");
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
                   rd[10],
                   rd.GetDateTime(11).ToString("dd/MM/yyyy")
                   );
            }
            bd.Close();
            UpdateTCLabel();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT entreeg.[n°entree], fournisseur.denomination, entreeg.[type piece], entreeg.[n° piece], composant.[type article], composant.[nom article],composant.color, dentreeg.quantite, dentreeg.[prix achatht], composant.tva, entreeg.[entree par],  entreeg.[date entree] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] where composant.[nom article] like @nomArticle and composant.[type article] like @typeArticle ", bd);
            cmd.Parameters.AddWithValue("@typeArticle", comboBox1.Text + "%");
            cmd.Parameters.AddWithValue("@nomArticle", rec.Text + "%");
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
                   rd[10],
                   rd.GetDateTime(11).ToString("dd/MM/yyyy")
                   );
            }
            bd.Close();
            UpdateTCLabel();
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

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            string query = "SELECT entreeg.[n°entree], fournisseur.denomination, entreeg.[type piece], entreeg.[n° piece], composant.[type article], composant.[nom article],composant.color, dentreeg.quantite, dentreeg.[prix achatht], composant.tva, entreeg.[entree par],  entreeg.[date entree] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] INNER JOIN fournisseur ON dentreeg.nFourn = fournisseur.[n° fournisseur] WHERE entreeg.[date entree] >= @fromDate AND entreeg.[date entree] <= @toDate and composant.[nom article] like @nomArticle and composant.[type article] like @typeArticle";
            SqlCommand cmd = new SqlCommand(query, bd);
            cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
            cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));
            cmd.Parameters.AddWithValue("@typeArticle", comboBox1.Text + "%");
            cmd.Parameters.AddWithValue("@nomArticle", rec.Text + "%");
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
                   rd[10],
                   rd.GetDateTime(11).ToString("dd/MM/yyyy")
                   );
            }
            bd.Close();
            UpdateTCLabel();
        }
    }
}
