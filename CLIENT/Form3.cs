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
    public partial class nc : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public nc()
        {
            InitializeComponent();
        }

        private void nc_Load(object sender, EventArgs e)
        {
            bd.Open();
            Remplir();
        }
        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }


            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from client", bd);
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

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                bd.Open();

                // Use parameterized query for SELECT
                SqlCommand selectCmd = new SqlCommand("SELECT * FROM client WHERE UPPER([denomination]) = @denomination", bd);
                selectCmd.Parameters.AddWithValue("@denomination", de.Text.ToUpper());

                SqlDataReader rd = selectCmd.ExecuteReader();

                if (rd.HasRows)
                {
                    MessageBox.Show("CLIENT DEJA EXISTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!string.IsNullOrEmpty(de.Text) && !string.IsNullOrEmpty(vil.Text))
                {
                    rd.Close();

                    // Use parameterized query for INSERT
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO client VALUES (@denomination, @responsable, @ice, @telephone, @email, @siege_social, @ville)", bd);
                    insertCmd.Parameters.AddWithValue("@denomination", de.Text);
                    insertCmd.Parameters.AddWithValue("@responsable", resp.Text);
                    insertCmd.Parameters.AddWithValue("@ice", ice.Text);
                    insertCmd.Parameters.AddWithValue("@telephone", te.Text);
                    insertCmd.Parameters.AddWithValue("@email", ema.Text);
                    insertCmd.Parameters.AddWithValue("@siege_social", sie.Text);
                    insertCmd.Parameters.AddWithValue("@ville", vil.Text);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Nouveau_Click(sender, e);
                    Remplir();
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                rd.Close();
                bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            de.Clear();
            resp.Clear();
            ice.Clear();
            te.Clear();
            ema.Clear();
            sie.Clear();
            vil.Text = "";
            Modifier.Enabled = false;
            Supprimer.Enabled = false;
            Enregistrer.Enabled = true;
            de.Select();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            { 
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();

            // Use parameterized query
            SqlCommand cmd = new SqlCommand("UPDATE client SET [denomination]=@denomination, [responsable]=@responsable, [n° ice]=@n_ice, [n° telephone]=@n_telephone, [email]=@email, [siege social]=@siege_social, [ville]=@ville WHERE [n° client]=@n_client", bd);

            // Set parameter values
            cmd.Parameters.AddWithValue("@denomination", de.Text);
            cmd.Parameters.AddWithValue("@responsable", resp.Text);
            cmd.Parameters.AddWithValue("@n_ice", ice.Text);
            cmd.Parameters.AddWithValue("@n_telephone", te.Text);
            cmd.Parameters.AddWithValue("@email", ema.Text);
            cmd.Parameters.AddWithValue("@siege_social", sie.Text);
            cmd.Parameters.AddWithValue("@ville", vil.Text);
            cmd.Parameters.AddWithValue("@n_client", npr);

            // Execute the query
            cmd.ExecuteNonQuery();

            MessageBox.Show("MODIFICATION EFFECTUEE AVEC SUCCES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Nouveau_Click(sender, e);
            Remplir();
            bd.Close();

            }
            catch
            {
              MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            
            string input;
            input = Microsoft.VisualBasic.Interaction.InputBox("RECHERCHER N° CLIENT", "HIBA SOCKS");

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("VEUILLEZ SAISIR N° CLIENT.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(input, out npr))
            {
                MessageBox.Show("N° CLIENT NON VALIDE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bd.Open();

            SqlCommand cmd = new SqlCommand("select * from client where [n° client]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == false)
            {
                MessageBox.Show("N° CLIENT  " + npr.ToString() + "  N'EXISTE PAS", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rd.Read();
                de.Text = rd[1].ToString();
                resp.Text = rd[2].ToString();
                ice.Text = rd[3].ToString();
                te.Text = rd[4].ToString();
                ema.Text = rd[5].ToString();
                sie.Text = rd[6].ToString();
                vil.Text = rd[7].ToString();
                Modifier.Enabled = true;
                Supprimer.Enabled = true;
                Enregistrer.Enabled = false;


            }
            rd.Close();
            bd.Close();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("SUPPRIMER LE CLIENT", "HIBA SOCKS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("delete from client where [n° client]='" + npr.ToString() + "'", bd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SUPPRESSION EFFECTUE AVEC SUCCE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Nouveau_Click(sender, e);
                    Remplir();
                }
            }
            catch (Exception ex)
            {

                bd.Close();
                MessageBox.Show(" IMPOSSIBLE D'EFFECTUER LA SUPPRESSION ", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from client where [denomination] like '" + rec.Text + "%' ", bd);
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
                    rd[6]
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

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
