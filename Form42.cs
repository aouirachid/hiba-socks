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
    public partial class npg : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public npg()
        {
            InitializeComponent();
        }

        private void npg_Load(object sender, EventArgs e)
        {
            Remplir();
        }

        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }


            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from composant", bd);
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

        private void enregistrer_Click(object sender, EventArgs e)
        {
            try
            { 
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
             SqlCommand cmb = new SqlCommand("select*from composant where upper([nom article])='" + nda.Text.ToUpper() + "'", bd);
            SqlDataReader rd = cmb.ExecuteReader();
                if (rd.HasRows == true)
                {
                    MessageBox.Show("COMPOSANT DEJA EXISTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            else if (nr.Text != "" && ttva.Text != "")

            {
                 rd.Close();
                SqlCommand cmd = new SqlCommand("insert into composant values('" + ta.Text + "','" + color.Text + "','" + nr.Text + "','" + nda.Text + "','" + st.Text + "','" + pah.Text + "','" + ttva.Text + "')", bd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nouveau_Click(sender, e);
                Remplir();
            }

            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            rd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            ta.Text = "";
            nr.Clear();
            nda.Clear();
            st.Clear();
            pah.Clear();
            ttva.Text = "";
            color.Text = "";
            color.Visible = false;
            modifier.Enabled = false;
           //supprimer.Enabled = false;
            enregistrer.Enabled = true;
            ta.Select();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                if (nr.Text != "")
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("update composant set[type article]='" + ta.Text + "',[reference]='" + nr.Text + "',[nom article]='" + nda.Text + "', [stock]='" + st.Text + "', [prix achath]='" + pah.Text + "',[tva]='" + ttva.Text + "' where [n° article]='" + npr.ToString() + "'", bd);


                cmd.ExecuteNonQuery();
                MessageBox.Show("MODIFICATION EFFECTUER AVEC SUCCE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            nouveau_Click(sender, e);
            Remplir();
            bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
                bd.Close();
            try
            { 
            bd.Open();
            string input;
            input = (Microsoft.VisualBasic.Interaction.InputBox("RECHERCHER N° COMPOSANT", "HIBA SOCKS"));

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("VEUILLEZ SAISIR N° COMPOSANT", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(input, out npr))
            {
                MessageBox.Show("N° COMPOSANT NON VALIDE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand cmd = new SqlCommand("select * from composant where [n° article]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == false)
            {
                MessageBox.Show("N° COMPOSANT " + npr.ToString() + "  N'EXISTE PAS", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rd.Read();
                ta.Text = rd[1].ToString().Trim() ;
                color.Text = rd[2].ToString().Trim();
                nr.Text = rd[3].ToString().Trim();
                nda.Text = rd[4].ToString().Trim();
                st.Text = rd[5].ToString().Trim();
                pah.Text = rd[6].ToString().Trim();
                ttva.Text = rd[7].ToString().Trim();
                modifier.Enabled = true;
                //supprimer.Enabled = true;
                enregistrer.Enabled = false;


            }
            rd.Close();
            bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from composant where [nom article] like '" + rec.Text + "%' ", bd);
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

        private void ta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ta.SelectedIndex == 0)
            {
                color.Visible = true;
            }
            else
            {
                color.Visible = false;
            }
        }
    }
}
