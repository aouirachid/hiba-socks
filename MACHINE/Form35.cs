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
    public partial class om : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public om()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear()
        {
            cmbnm.Text = "";
            txtrc.Text = "";
            txta.Text = "";
            ofc.Text = "";
            osc.Text = "";
            cmbh.Text = "";
            mma.Text = "";
        }
        private void Remplir()
        {


            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from objectif_machine", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(1).ToString().Trim(),
                   rd.GetValue(2).ToString().Trim(),
                   rd.GetValue(3).ToString().Trim(),
                   rd.GetValue(4).ToString().Trim(),
                   rd.GetValue(5).ToString().Trim()
                    );
            }
            bd.Close();
        }



        private void cmbnm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
       
            SqlCommand cmd = new SqlCommand("select*from machine where n_machine='" + cmbnm.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            txtrc.Text = rd.GetValue(2).ToString().Trim();
            txta.Text = rd.GetValue(3).ToString().Trim();
            mma.Text = rd.GetValue(4).ToString().Trim();
            rd.Close();
            bd.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbnm.Text != "" && ofc.Text != "" && osc.Text != "" && cmbh.Text != "")
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("insert into objectif_machine values('" + cmbnm.Text.ToUpper() + "' , '" + ofc.Text + "','" + osc.Text + "','" + cmbh.Text + "','" + dateo.Value + "')", bd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ENREGISTREMENT EFFECTUEE AVEC SUCCES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Close();
                    Remplir();
                    clear();

                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }

               

                catch 
            {
                MessageBox.Show("SAISIE INCORRECTE"  , "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           



        }

        private void om_Load(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd1 = new SqlCommand("select n_machine from machine", bd);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                cmbnm.Items.Add(rd1.GetValue(0).ToString().Trim());
            }
            bd.Close();
            Remplir();
        }

        private void txtndm_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from  objectif_machine where [n_machine] like '%" + txtndm.Text + "%'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                while (rd.Read())
                {
                    tableau.Rows.Add(
                    rd[1],
                   rd[2],
                   rd[3],
                   rd[4],
                   rd[5]
                        );
                }
            }
            bd.Close();
        }

        private void exporter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE OBJECTIF MACHINE " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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
