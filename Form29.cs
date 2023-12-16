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
    public partial class ca : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public ca()
        {
            InitializeComponent();
        }

        private void ca_Load(object sender, EventArgs e)
        {
            remplir();
            UpdateSALabel();
            totalEntree();
        }
        private void remplir()
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from ecaisse", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd[0].ToString().Trim(),
                   rd[1].ToString().Trim(),
                   rd[2].ToString().Trim(),
                   rd.GetDateTime(3).ToString("dd/MM/yyyy")
                    );
            }
            bd.Close();

        }
        private void clear()
        {
            txtl.Text = "";
            txtp.Text = "0.00";
        }

        private void UpdateTotalLabel()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out cellValue))
                    {
                        total += cellValue;
                    }
                }
            }

            TE.Text = total.ToString();
        }


        private void totalEntree()
        {

            // Calculate the sum of numbers in the third column (index 2)
            decimal total = 0;

            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out cellValue))
                    {
                        total += cellValue;
                    }
                }
            }

            // Update the TE label with the calculated total
            TE.Text = total.ToString();

        }
        private void UpdateSALabel()
        {
            try
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("SELECT montant FROM caisse", bd);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    decimal montant = Convert.ToDecimal(result);
                    SA.Text = montant.ToString();
                }
                else
                {
                    // Handle the case where there is no data in the caisse table or another error occurred.
                    SA.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while updating the label.
                MessageBox.Show("Error updating SA label: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bd.Close();
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtl.Text != "" && float.Parse(txtp.Text) > 0)
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("insert into ecaisse values('" + txtl.Text + "' , '" + txtp.Text + "','" + dateHour.Value + "')", bd);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("select montant from caisse", bd);
                    SqlDataReader rd1 = cmd2.ExecuteReader();
                    rd1.Read();
                    decimal prix = decimal.Parse(txtp.Text);
                    decimal qs = Convert.ToDecimal(rd1.GetValue(0)) + prix;
                    rd1.Close();
                    SqlCommand cmd4 = new SqlCommand("update caisse set [montant]='" + qs.ToString() + "'", bd);
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Close();
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                remplir();
                clear();
                UpdateSALabel();
                totalEntree();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION ENTREE CAISSE " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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
                MessageBox.Show("EXPORTER AVEC SUCCES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from ecaisse where libelle like '" + textBox1.Text + "%'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd[0].ToString().Trim(),
                   rd[1].ToString().Trim(),
                   rd[2].ToString().Trim(),
                  rd.GetDateTime(3).ToString("dd/MM/yyyy")
                    );
            }
            bd.Close();
            UpdateTotalLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the DataGridView before adding filtered data
            tableau.Rows.Clear();
            bd.Open();

            string query = "SELECT * FROM ecaisse WHERE dh >= @fromDate AND dh <= @toDate";
            SqlCommand cmd = new SqlCommand(query, bd);
            cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
            cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0].ToString().Trim(),
                    rd[1].ToString().Trim(),
                    rd[2].ToString().Trim(),
                    rd[3].ToString().Trim()
                );
            }

            bd.Close();

            UpdateTotalLabel();
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
