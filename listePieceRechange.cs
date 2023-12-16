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
    public partial class listePieceRechange : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public listePieceRechange()
        {
            InitializeComponent();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listePieceRechange_Load(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from piece_rechange ", bd);
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
                   rd[4]
                        );
                }
            }
            bd.Close();
        }

        private void txtnref_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from piece_rechange where [n_ref] like '%" + txtnref.Text + "%'", bd);
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
                   rd[4]
                        );
                }
            }
            bd.Close();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";
            // Set the default file name
            saveFileDialog.FileName = " EXPORTATION LISTE PIECE RECHANGE " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";
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
