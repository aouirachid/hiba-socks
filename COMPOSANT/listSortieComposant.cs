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

namespace FD_STOCK.COMPOSANT
{
    public partial class listSortieComposant : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public listSortieComposant()
        {
            InitializeComponent();
        }
        private void UpdateTCLabel()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[6].Value != DBNull.Value)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells[4].Value.ToString(), out cellValue))
                    {
                        total += cellValue;
                    }
                }
            }

            TSC.Text = total.ToString();

        }
        private void listSortieComposant_Load(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT dsortieg.nSortie, composant.[type article], composant.[nom article], composant.color, dsortieg.quantite, sortieg.sortiePar, sortieg.dateSortie FROM dsortieg INNER JOIN sortieg ON dsortieg.nSortie = sortieg.nSortie INNER JOIN composant ON dsortieg.nComposant = composant.[n° article] ", bd);
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
                   rd[6]
                   );
                }
            }
            bd.Close();
            UpdateTCLabel();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT dsortieg.nSortie, composant.[type article], composant.[nom article], composant.color, dsortieg.quantite, sortieg.sortiePar, sortieg.dateSortie FROM dsortieg INNER JOIN sortieg ON dsortieg.nSortie = sortieg.nSortie INNER JOIN composant ON dsortieg.nComposant = composant.[n° article] where composant.[type article] like @typeArticle and composant.[nom article] like @nomArticle ", bd);
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
                   rd.GetDateTime(6).ToString("dd/MM/yyyy")
                   );
            }
            bd.Close();
            UpdateTCLabel();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT dsortieg.nSortie, composant.[type article], composant.[nom article], composant.color, dsortieg.quantite, sortieg.sortiePar, sortieg.dateSortie FROM dsortieg INNER JOIN sortieg ON dsortieg.nSortie = sortieg.nSortie INNER JOIN composant ON dsortieg.nComposant = composant.[n° article] where composant.[nom article] like @nomArticle and composant.[type article] like @typeArticle ", bd);
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
                   rd.GetDateTime(6).ToString("dd/MM/yyyy")
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
            saveFileDialog.FileName = "EXPORTAION LISTE SORTIE COMPOSANT " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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

        private void f_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            string query = "SELECT dsortieg.nSortie, composant.[type article], composant.[nom article], composant.color, dsortieg.quantite, sortieg.sortiePar, sortieg.dateSortie FROM dsortieg INNER JOIN sortieg ON dsortieg.nSortie = sortieg.nSortie INNER JOIN composant ON dsortieg.nComposant = composant.[n° article] WHERE sortieg.dateSortie >= @fromDate AND sortieg.dateSortie <= @toDate and composant.[nom article] like @nomArticle and composant.[type article] like @typeArticle";
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
                   rd.GetDateTime(6).ToString("dd/MM/yyyy")
                   );
            }
            bd.Close();
            UpdateTCLabel();
        }
    }
}
