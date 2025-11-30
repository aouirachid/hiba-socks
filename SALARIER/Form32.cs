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
                UpdateTotalLabel();

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
            UpdateTotalLabel();
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
            UpdateTotalLabel();
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            lpers x = new lpers();
            x.ShowDialog();
            int i = x.tableau.CurrentRow.Index;
            txtnc.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
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
            SqlCommand cmd = new SqlCommand("select * from dpersonel where [nom_comp] like @nomComposant and [post] like @post  ORDER BY dpersonel.dhp ", bd);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM dpersonel WHERE [post] LIKE @post AND [nom_comp] LIKE @nomComposant  ORDER BY dpersonel.dhp", bd);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear the DataGridView before adding filtered data
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
