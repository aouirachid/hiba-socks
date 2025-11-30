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

namespace FD_STOCK
{
    public partial class conx : Form
    {
        
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);

        int i =0;
        public conx()
        {
            InitializeComponent();
            fid.Enabled = true;
            bd.Open();
        }

        private void conx_Load(object sender, EventArgs e)
        {

        }

        private void qui_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void va_Click(object sender, EventArgs e)
        {
            try
            { 
            SqlCommand cmd = new SqlCommand("select login,motpasse,type from connexion where [login]='" + logi.Text + "' and [motpasse]='" + mpas.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows == true)
            {
                rd.Read();
                menur x = new menur();
                x.uti = logi.Text;
                this.Hide();
                    if (rd.GetValue(2).ToString().Trim() == "Super administrateur")
                    {
                        x.button18.Visible = true;
                    }
                    else
                        x.button18.Visible = false;
                    MessageBox.Show("MOT DE PASSE VALIDE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                x.Show();
            }
            else
            {
                MessageBox.Show("MOT DE PASSE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mpas.Clear();
                logi.Clear(); logi.Select();
            }

            if (i == 3)
            {

                MessageBox.Show("DESOLE VOUS AVEZ DEPASSE LE NOMBRE D'ACTIVATION AUTORISEES ", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            i++;
            rd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void mpa_CheckedChanged(object sender, EventArgs e)
        {
            if (mpa.Checked == true)
            {
                mpas.UseSystemPasswordChar = false;
            }


            else
            {
                mpas.UseSystemPasswordChar = true;
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
