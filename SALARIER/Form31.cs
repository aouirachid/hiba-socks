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

namespace FD_STOCK
{
    public partial class pers : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        int npr;
        public pers()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            { 
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
            if (txtnc.Text != "" )
            {
                    SqlCommand cmd = new SqlCommand("insert into personel values('" + txtnc.Text.ToUpper() + "')", bd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bd.Close();
                
            clear();
            this.Hide();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        

        private void pers_Load(object sender, EventArgs e)
        {
            
        }
       

        private void clear()
        {
            txtnc.Text = "";
            
        }
        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


           




        }

        private void btnSearch_Click(object sender, EventArgs e)
        {








        }

        private void fermer_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tableau_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tableau_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
