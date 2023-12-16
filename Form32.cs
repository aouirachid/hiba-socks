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
    public partial class dpers : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public dpers()
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
            if (txtnc.Text != ""  && txtp.Text != "" && cmbp.Text != "" && txto.Text != "" && hs.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into dpersonel values('" + txtnc.Text.ToUpper() + "' , '" + txtp.Text + "','" + cmbp.Text + "','" + txto.Text + "','" + hs.Text + "','" + dateHour.Value + "')", bd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Close();
                clear();
                Remplir();

            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dpers_Load(object sender, EventArgs e)
        {
            Remplir();
        }
        private void clear()
        {
            txtnc.Text = "";
            txtp.Text = "";
            cmbp.Text = "";
            txto.Text = "";
            hs.Text = "";
        }

        private void Remplir()
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
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            lpers x = new lpers();
            x.ShowDialog();
            int i = x.tableau.CurrentRow.Index;
            txtnc.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            
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
            SqlCommand cmd = new SqlCommand("select * from dpersonel where [nom_comp] like '" + txtnco.Text + "%' and [post] like '" + post.Text + "%' ORDER BY dpersonel.dhp ", bd);
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
            }

            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pers x = new pers();
            x.Show();
        }

        private void post_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from dpersonel where  [post] like '" + post.Text + "%' and [nom_comp] like '" + txtnco.Text + "%'  ORDER BY dpersonel.dhp ", bd);
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
        }
    }
}
