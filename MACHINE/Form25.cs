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
    public partial class dmach : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public dmach()
        {
            InitializeComponent();
        }
        
        private void dmach_Load(object sender, EventArgs e)
        {

            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
            SqlCommand cmd = new SqlCommand("select n_machine from machine", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmbndm.Items.Add(rd.GetValue(0).ToString().Trim());
            }
            rd.Close();
          

            
            bd.Close();
            Remplir();
        }
        private void Remplir()
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT dmachine.nsm, dmachine.n_machine, machine.model_machine, dmachine.nom_article, dmachine.color, dmachine.size, dmachine.date_hour FROM dmachine INNER JOIN machine ON dmachine.n_machine = machine.n_machine", bd);
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
        }

        private void clear()
        {
            cmbndm.Text = "";
            txtna.Text = "";
            txtc.Text = "";
            txts.Text = "";
            rc.Text = "";
            na.Text = "";
            mma.Text = "";

        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            la x = new la();
            x.ShowDialog();
            int i = x.tableau.CurrentRow.Index;
            txtna.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtc.Text = x.tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txts.Text = x.tableau.Rows[i].Cells[3].Value.ToString().Trim();
            
        }
        

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            
                SqlCommand cmd = new SqlCommand("insert into dmachine values('" + cmbndm.Text + "','" + txtna.Text.ToUpper() + "' , '" + txtc.Text + "','" + txts.Text + "', '" + dateHour.Value + "')", bd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUEE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            bd.Close();
            Remplir();
            clear();
        }

        private void cmbndm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from machine where n_machine='" + cmbndm.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            rc.Text = rd.GetValue(2).ToString().Trim();
            na.Text = rd.GetValue(3).ToString().Trim();
            mma.Text = rd.GetValue(4).ToString().Trim();
            rd.Close();
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

        private void txtndm_TextChanged_1(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT dmachine.nsm, dmachine.n_machine, machine.model_machine, dmachine.nom_article, dmachine.color, dmachine.size, dmachine.date_hour FROM dmachine INNER JOIN machine ON dmachine.n_machine = machine.n_machine where dmachine.n_machine like '%" + txtndm.Text + "%' ", bd);
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
        }

        private void exporter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE DETAILLE MACHINE " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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
                MessageBox.Show("EXPORTER AVEC SUCCES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lpg x = new lpg();
            x.ShowDialog();
        }

        
    }
}
