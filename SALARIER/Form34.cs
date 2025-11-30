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
    public partial class ldpers : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public ldpers()
        {
            InitializeComponent();
        }
        private void UpdateTotalLabel()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells[3].Value.ToString(), out cellValue))
                    {
                        total += cellValue;
                    }
                }
            }

            TE.Text = total.ToString();
        }

        private void ldpers_Load(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from dpersonel where [nom_comp] like '%" + txtnco.Text + "%'ORDER BY dpersonel.dhp", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(0).ToString().Trim(),
                   rd.GetValue(1).ToString().Trim(),
                   rd.GetValue(2).ToString().Trim(),
                   rd.GetValue(3).ToString().Trim(),
                   rd.GetValue(4).ToString().Trim(),
                   rd.GetValue(5).ToString().Trim()
                    );
            }
            bd.Close();
            UpdateTotalLabel();
        }

        private void txtnc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";
            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE DETAILLE SALARIER" + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
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

        private void txtnco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from dpersonel where [nom_comp] like @nomComposant and [post] like @post ORDER BY dpersonel.dhp ", bd);
                cmd.Parameters.AddWithValue("@nomComposant", "%" + txtnco.Text + "%");
                cmd.Parameters.AddWithValue("@post", "%" + post.Text + "%");
                cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
                cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tableau.Rows.Add(
                        rd.GetValue(0).ToString().Trim(),
                        rd.GetValue(1).ToString().Trim(),
                        rd.GetValue(2).ToString().Trim(),
                        rd.GetValue(3).ToString().Trim(),
                        rd.GetValue(4).ToString().Trim(),
                        rd.GetDateTime(5).ToString("dd/MM/yyyy")
                         );
                }
                bd.Close();
                UpdateTotalLabel();
            }

            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void post_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dpersonel WHERE [post] LIKE @post AND [nom_comp] LIKE @nomComposant ORDER BY dpersonel.dhp", bd);
            cmd.Parameters.AddWithValue("@post", "%" + post.Text + "%");
            cmd.Parameters.AddWithValue("@nomComposant", "%" + txtnco.Text + "%");
            cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
            cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd.GetValue(0).ToString().Trim(),
                    rd.GetValue(1).ToString().Trim(),
                    rd.GetValue(2).ToString().Trim(),
                    rd.GetValue(3).ToString().Trim(),
                    rd.GetValue(4).ToString().Trim(),
                    rd.GetDateTime(5).ToString("dd/MM/yyyy")
                     );
            }
            bd.Close();
            UpdateTotalLabel();
            }

            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();

            string query = "select * from dpersonel WHERE dhp >= @fromDate AND dhp <= @toDate and [post] LIKE @post AND [nom_comp] LIKE @nomComposant";
            SqlCommand cmd = new SqlCommand(query, bd);
            cmd.Parameters.AddWithValue("@post", "%" + post.Text + "%");
            cmd.Parameters.AddWithValue("@nomComposant", "%" + txtnco.Text + "%");
            cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
            cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0].ToString().Trim(),
                    rd[1].ToString().Trim(),
                    rd[2].ToString().Trim(),
                    rd[3].ToString().Trim(),
                    rd[4].ToString().Trim(),
                    rd.GetDateTime(5).ToString("dd/MM/yyyy")
                );
            }

            bd.Close();
            UpdateTotalLabel();
        }
    }
}
