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

namespace FD_STOCK
{
    public partial class nemb : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public nemb()
        {
            InitializeComponent();
        }

        private void nemb_Load(object sender, EventArgs e)
        {
            Remplir();
            bd.Close();
        }
        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }


            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from produitsem", bd);
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
                        rd[5]



                        );
                }
                rd.Close();
            }

            bd.Close();


        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmb = new SqlCommand("select*from produitsem where upper([nom produitem])='" + ndpr.Text.ToUpper() + "'", bd);
            SqlDataReader rd = cmb.ExecuteReader();
            if (rd.HasRows == true)
            {
                MessageBox.Show("EMBALLAGE DEJA EXISTE", "HIBA SOCKS");

            }

            else if (nr.Text != "" && ttva.Text != "")

            {
                rd.Close();
                SqlCommand cmd = new SqlCommand("insert into produitsem values('" + nr.Text + "','" + ndpr.Text + "','" + st.Text + "','" + pah.Text + "','" + ttva.Text + "')", bd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES ", "HIBA SOCKS");
                nouveau_Click(sender, e);
                Remplir();
            }

            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS");
            }
            rd.Close();
            bd.Close();
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            nr.Clear();
            ndpr.Clear();
            st.Clear();
            pah.Clear();
            ttva.Text = "";
            modifier.Enabled = false;
            supprimer.Enabled = false;
            enregistrer.Enabled = true;
            nr.Select();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if(nr.Text!="")
            { 
            bd.Open();
            SqlCommand cmd = new SqlCommand("update produitsem set[n° referenceem]='" + nr.Text + "',[nom produitem]='" + ndpr.Text + "',[stockem]='" + st.Text + "', [prix achathtem]='" + pah.Text + "' , [taux tvaem]='" + ttva.Text + "' where [n° produitem]='" + npr.ToString() + "'", bd);


            cmd.ExecuteNonQuery();
            MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES", "HIBA SOCKS");
            }
            else
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS");
            nouveau_Click(sender, e);
            Remplir();
            bd.Close();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("SUPPRIMER EMBALLAGE", "HIBA SOCKS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("delete from produitsem where [n° produitem]='" + npr.ToString() + "'", bd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SUPPRESSION EFFECTUE AVEC SUCCEE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nouveau_Click(sender, e);
                    Remplir();
                }
            }
            catch (Exception ex)
            {

                bd.Close();
                MessageBox.Show(" IMPOSSIBLE D'EFFECTUER LA SUPPRESSION ", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            bd.Open();
            string input;
            input = (Microsoft.VisualBasic.Interaction.InputBox("RECHERCHER N° EMBALLAGE", "HIBA SOCKS"));

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("VEUILLEZ SAISIR N° EMBALLAGE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(input, out npr))
            {
                MessageBox.Show("N° EMBALLAGE NON VALIDE.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SqlCommand cmd = new SqlCommand("select * from produitsem where [n° produitem]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == false)
            {
                MessageBox.Show("N° EMBALLAGE " + npr.ToString() + " N° N'EXISTE PAS", "HIBA SOCKS");
            }
            else
            {
                rd.Read();
                nr.Text = rd[1].ToString();
                ndpr.Text = rd[2].ToString();
                st.Text = rd[3].ToString();
                pah.Text = rd[4].ToString();
                ttva.Text = rd[5].ToString();
                modifier.Enabled = true;
                supprimer.Enabled = true;
                enregistrer.Enabled = false;


            }
            rd.Close();
            bd.Close();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from produitsem where [nom produitem] like '" + rec.Text + "%' ", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2],
                    rd[3],
                    rd[4],
                    rd[5]
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
    }
}
