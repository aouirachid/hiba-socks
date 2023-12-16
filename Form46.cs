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
    public partial class utilisateur : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        string npr;
        public utilisateur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                bd.Open();
                if (logi.Text != "" && mpas.Text != "" && type.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into connexion values('" + logi.Text + "','" + mpas.Text + "','" + type.Text + "')", bd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    remplir();
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
            bd.Close();
        }

        private void utilisateur_Load(object sender, EventArgs e)
        {
            remplir();
        }
        private void remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from connexion", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                while (rd.Read())
                {
                    tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2]


                  );
                }
                rd.Close();
            }
            bd.Close();
        }
        private void clear()
        {
            logi.Clear();
            mpas.Clear();
            type.SelectedIndex = 0;
        }
        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(logi.Text) && !string.IsNullOrEmpty(mpas.Text) && !string.IsNullOrEmpty(type.Text))
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                    }
                    bd.Open();
                    SqlCommand cmd1 = new SqlCommand("update connexion set [login]='" + logi.Text + "',[motpasse]='" + mpas.Text + "',[type]='" + type.Text + "' where[login]='" + npr.ToString() + "'", bd);
                    cmd1.ExecuteNonQuery();
                    bd.Close();
                    MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                modifier.Enabled = false;
                enregistrer.Enabled = true;
                clear();
                remplir();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                npr = Microsoft.VisualBasic.Interaction.InputBox("ENTRE LE LOGIN", "HIBA SOCKS");
                bd.Open();
                SqlCommand cmd = new SqlCommand("select*from connexion where[login]='" + npr.ToString() + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == true)
                {
                    rd.Read();
                    logi.Text = rd.GetValue(0).ToString().Trim();
                    mpas.Text = rd.GetValue(1).ToString().Trim();
                    type.Text = rd.GetValue(2).ToString().Trim();
                }
                
                else
                {
                    MessageBox.Show("LOGIN  " + npr.ToString() + " N'EXISTE PAS", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bd.Close();
                modifier.Enabled = true;
                enregistrer.Enabled = false;
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                tableau.Rows.Clear();
                bd.Open();
                SqlCommand cmd = new SqlCommand("select * from connexion where [login] like '%" + rec.Text + "%'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        tableau.Rows.Add(
                        rd[0],
                        rd[1],
                       rd[2]
                            );
                    }
                }
                bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
