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
    public partial class np : Form
    {
        int npr;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public np()
        {
            InitializeComponent();
        }

        private void np_Load(object sender, EventArgs e)
        {
            
            Remplir();
            bd.Close();
        }

        private void Remplir()
        {
            if(bd.State==ConnectionState.Closed)
            {
                bd.Open();
            }
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from produits", bd);
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
            bd.Open();
            SqlCommand cmb = new SqlCommand("select*from produits where upper([n° reference])='" + nr.Text.ToUpper() + "'", bd);
            SqlDataReader rd = cmb.ExecuteReader();
            if (rd.HasRows == true)
            {
                MessageBox.Show("REFERENCE DEJA EXISTE", "HIBA SOCKS");
              
            }
           
            else if (nr.Text != "" && ttva.Text != "")

            {
                rd.Close();
                SqlCommand cmd = new SqlCommand("insert into produits values('" + nr.Text + "','" + ndpr.Text + "','" + txtc.Text + "','" + txts.Text + "','" + st.Text + "','" + pvh.Text + "','" + ttva.Text + "')", bd);
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
            bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void nouveau_Click(object sender, EventArgs e)
        {
            
            nr.Clear();
            ndpr.Clear();
            txtc.Clear();
            txts.Clear();
            st.Clear();
            pvh.Clear();
            ttva.Text = "";
            modifier.Enabled = false;
            supprimer.Enabled = false;
            enregistrer.Enabled = true;
            nr.Select();
            
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            { 
            if (nr.Text!="")
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("update produits set[n° reference]='" + nr.Text + "',[nom produit]='" + ndpr.Text + "',[stock]='" + st.Text + "', [prix venteht]='" + pvh.Text + "', [taux tva]='" + ttva.Text + "' where [n° produit]='" + npr.ToString() + "'", bd);


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

        private void re_Click(object sender, EventArgs e)
        {
            bd.Open();
            string input;
            input = (Microsoft.VisualBasic.Interaction.InputBox("RECHERCHER N° PRODUIT", "HIBA SOCKS"));

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("VEUILLEZ SAISIR N° PRODUIT.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(input, out npr))
            {
                MessageBox.Show("N° PRODUIT NON VALIDE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            SqlCommand cmd = new SqlCommand("select * from produits where [n° produit]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == false)
            {
                MessageBox.Show("N° PRODUIT " + npr.ToString() +  " N° N'EXISTE PAS", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rd.Read();
                nr.Text = rd[1].ToString().Trim();
                ndpr.Text = rd[2].ToString().Trim();
                txtc.Text = rd[3].ToString().Trim();
                txts.Text = rd[4].ToString().Trim();
                st.Text = rd[5].ToString().Trim();
                pvh.Text = rd[6].ToString().Trim();
                ttva.Text = rd[7].ToString().Trim();
                modifier.Enabled = true;
                supprimer.Enabled = true;
                enregistrer.Enabled = false;


            }
            rd.Close();
            bd.Close();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("SUPPRIMER LE PRODUIT", "HIBA SOCKS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("delete from produits where [n° produit]='" + npr.ToString() + "'", bd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SUPPRESSION EFFECTUE AVEC SUCCES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nouveau_Click(sender, e);
                    Remplir();
                }
            }
            catch (Exception ex)
            {
                
                bd.Close();
                MessageBox.Show(" IMPOSSIBLE D'EFFECTUER LA SUPPRESSION " , "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
   
        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from produits where [nom produit] like '" + rec.Text + "%' ", bd);
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

        private void inportBtn_Click(object sender, EventArgs e)
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

        private void btnNa_Click(object sender, EventArgs e)
        {
            la x = new la();
            x.ShowDialog();
            int i = x.tableau.CurrentRow.Index;
            ndpr.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtc.Text = x.tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txts.Text = x.tableau.Rows[i].Cells[3].Value.ToString().Trim();
        }
    }
}

