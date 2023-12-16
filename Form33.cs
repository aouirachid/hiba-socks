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
    public partial class lpers : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public lpers()
        {
            InitializeComponent();
        }

        private void lpers_Load(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from personel", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(0).ToString().Trim(),
                   rd.GetValue(1).ToString().Trim()
                   
                    );
            }
            bd.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE SALARIER" + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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

        private void inportBtn_Click(object sender, EventArgs e)
        {
           
         }
    

        private void fermer_Click(object sender, EventArgs e)
        {
            
        }

        private void txtnco_TextChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
                bd.Close();
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from personel where [nom_comp] like '%" + textBox1.Text + "%'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(0).ToString().Trim(),
                   rd.GetValue(1).ToString().Trim()
                    );
            }
            bd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
                bd.Close();
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from personel where [nom_comp] like '%" + textBox1.Text + "%'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(0).ToString().Trim(),
                   rd.GetValue(1).ToString().Trim()
                    );
            }
            bd.Close();
        }

        private void fermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableau_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
