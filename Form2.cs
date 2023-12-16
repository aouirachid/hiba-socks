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
    public partial class lp : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public lp()
        {
            InitializeComponent();
        }

        private void lp_Load(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand("select * from produits", bd);
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
                        rd[7]
                        );
                }
                rd.Close();
            }

            bd.Close();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from produits where [nom produit] like '" + rec.Text + "%' ", bd);
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
                    rd[6]
                    );
            }
            bd.Close();
        }

        private void Q_Click(object sender, EventArgs e)
        {

        }

        private void v_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void r_Click(object sender, EventArgs e)
        {

        }

        private void im_Click(object sender, EventArgs e)
        {

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
            saveFileDialog.FileName = "EXPORTAION LISTE PRODUITS " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rec_TextChanged_1(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from produits where [nom produit] like '" + rec.Text + "%' ", bd);
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
                    rd[7]
                    );
            }
            bd.Close();
        }

        private void tableau_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
