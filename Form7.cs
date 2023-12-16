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
    public partial class ne : Form
    {
        int npr;
        
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);

        public int i { get; private set; }

        public ne()
        {
            InitializeComponent();
        }

        private void ne_Load(object sender, EventArgs e)
        {
          
            //Nouveau_Click(sender, e);
            bd.Open();
        SqlCommand cmd = new SqlCommand("select*from produits", bd);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
        npro.Items.Add(rd.GetValue(0));      
        }
        rd.Close();
        //Remplir();
        bd.Close();
        }

        private void Remplir()
        {
        if (bd.State == ConnectionState.Closed)
        {
        bd.Open();
        }
        tableau.Rows.Clear();
        SqlCommand cmd = new SqlCommand("select * from entree", bd);
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

        private void Nouveau_Click(object sender, EventArgs e)
        {
        ndee.Text = "";
        tdee.Text = "";
        npe.Text = "";
        qu.Text = "0";
        npro.Text = "";
        nc.Text = "";
        tableau.Rows.Clear();

        //Modifier.Enabled = false;
        //Supprimer.Enabled = false;
        Enregistrer.Enabled = true;
        tdee.Select();
        }

        private void Femer_Click(object sender, EventArgs e)
        {
       
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (npro.Text != "" && int.Parse(qu.Text) > 0)
                {
                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        if (tableau.Rows[i].Cells[0].Value.ToString() == npro.Text)
                        {
                            MessageBox.Show(" PRODUIT DEJA AJOUTER", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    tableau.Rows.Add(
                    npro.Text,
                    nc.Text,
                    qu.Text,
                    pah.Text,
                    ttva.Text
                    );
                    npro.Text = ""; nc.Clear(); qu.Text = "0"; pah.Clear(); ttva.Clear();
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

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableau.Columns["Supprimer"].Index && e.RowIndex >= 0)
            {
                if (tableau.Rows[e.RowIndex].Cells["Supprimer"].Value != null)
                { 
                    // Get the row to be deleted
                    DataGridViewRow row = tableau.Rows[e.RowIndex];

                // Perform your delete logic here
                // For example, you can delete the row from a data source
                // and then remove it from the DataGridView
                // data source.Remove(row.DataBoundItem); // Adjust this line as per your data source
                tableau.Rows.Remove(row);
                }
            }
           
        }

        private void npro_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from produits where [n° produit]='" + npro.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            nc.Text = rd.GetValue(2).ToString().Trim();
            pah.Text = rd.GetValue(6).ToString().Trim();
            ttva.Text = rd.GetValue(7).ToString().Trim();
            bd.Close();
            qu.Select();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            { 
            
            if (tableau.Rows.Count > 1)
            {
                bd.Open();
                SqlCommand cmd = new SqlCommand("insert into entree values('" + ddee.Value.ToString() + "','" + epe.Text.ToString() + "')", bd);
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("select top(1) [n° entree] from [entree] order by [n° entree] desc", bd);
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                int ndee = Convert.ToInt32(rd.GetValue(0));
                rd.Close();

                for (int i = 0; i < tableau.Rows.Count - 1; i++) 
                {
                    SqlCommand cmd2 = new SqlCommand("insert into dentree values(" + ndee.ToString() + ",'" + tableau.Rows[i].Cells[0].Value.ToString() + "','" + tableau.Rows[i].Cells[2].Value.ToString() + "')", bd);
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = new SqlCommand("select * from produits where [n° produit]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    SqlDataReader rd1 = cmd3.ExecuteReader();
                    rd1.Read();
                    int qs = Convert.ToInt32(rd1.GetValue(5)) + Convert.ToInt32(tableau.Rows[i].Cells[2].Value);
                    rd1.Close();

                    SqlCommand cmd4 = new SqlCommand("update produits set [stock]='" + qs.ToString() + "'where [n° produit]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                    cmd4.ExecuteNonQuery();
                }
              
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Close();
                Nouveau_Click(sender, e);
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
            lp x = new lp();
            x.ShowDialog();
        }
    }
}
