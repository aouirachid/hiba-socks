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
    public partial class eg : Form
    {
        int npr;

        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public eg()
        {
            InitializeComponent();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                if (teg.Text != "" && tableau.Rows.Count > 1)
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("insert into entreeg values('" + teg.Text + "','" + tdee.Text + "','" + npe.Text + "','" + ddee.Value.ToString() + "','" + epe.Text + "')", bd);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("select top(1) [n°entree] from [entreeg] order by [n°entree] desc", bd);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    rd.Read();
                    int ndee = Convert.ToInt32(rd.GetValue(0));
                    rd.Close();
                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd2 = new SqlCommand("insert into dentreeg values(" + ndee.ToString() + ",'" + tableau.Rows[i].Cells[0].Value.ToString() + "','" + nf.Text + "','" + tableau.Rows[i].Cells[2].Value.ToString() + "','" + tableau.Rows[i].Cells[3].Value.ToString() + "')", bd);
                        cmd2.ExecuteNonQuery();
                        SqlCommand cd = new SqlCommand("select*from composant where [n° article]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        SqlDataReader rb = cd.ExecuteReader();
                        rb.Read();
                        float qs = Convert.ToSingle(rb.GetValue(5)) + Convert.ToSingle(tableau.Rows[i].Cells[2].Value);
                        rb.Close();
                        SqlCommand cm = new SqlCommand("update composant set [stock]='" + qs.ToString() + "' where [n° article]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        cm.ExecuteNonQuery();

                    }

                    MessageBox.Show("ENREGISTREMENT EFFECTUEE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try { 
           // if (npro.Text != "" && int.Parse(qu.Text) > 0)
            if (npro.Text != "" && float.TryParse(qu.Text, out float quantite) && quantite > 0)
                    {
                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    if (tableau.Rows[i].Cells[0].Value.ToString() == npro.Text)
                    {
                        MessageBox.Show(" COMPOSANT DEJA AJOUTER", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                npro.Text = ""; nc.Clear(); qu.Text = "0.00"; pah.Clear(); ttva.Clear();
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

        private void npro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            if (teg.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + npro.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                nc.Text = rd.GetValue(4).ToString();
                pah.Text = rd.GetValue(6).ToString();
                ttva.Text = rd.GetValue(7).ToString();
                rd.Close();
            }
            
            else if (teg.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + npro.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                nc.Text = rd.GetValue(4).ToString();
                pah.Text = rd.GetValue(6).ToString();
                ttva.Text = rd.GetValue(7).ToString();
                rd.Close();
                
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + npro.Text + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                nc.Text = rd.GetValue(4).ToString();
                pah.Text = rd.GetValue(6).ToString();
                ttva.Text = rd.GetValue(7).ToString();
                rd.Close();
            }
            bd.Close();
            qu.Select();
        }

        private void eg_Load(object sender, EventArgs e)
        {
            
        }

       

        private void teg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            if (teg.SelectedIndex == 0)
            {
                SqlCommand cmd = new SqlCommand("select*from composant where [type article] = 'Matiére 1 ére'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                npro.Items.Clear();
                while (rd.Read())
                {
                    npro.Items.Add(rd.GetValue(0));
                }
                rd.Close();

                
            }
            else if (teg.SelectedIndex == 1)
            {
                SqlCommand cmd = new SqlCommand("select*from composant where [type article] = 'Emballage'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                npro.Items.Clear();
                while (rd.Read())
                {
                    npro.Items.Add(rd.GetValue(0));
                }
                rd.Close();
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("select*from composant where [type article] = 'Piéce de rechange'", bd);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                npro.Items.Clear();
                while (rd1.Read())
                {
                    npro.Items.Add(rd1.GetValue(0).ToString().Trim());
                }
            }
            bd.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            lf x = new lf();
            x.ShowDialog();
            int i = x.tableau.CurrentRow.Index;
            nf.Text = x.tableau.Rows[i].Cells[0].Value.ToString().Trim();
            fo.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
          
           // lf.Select();
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            teg.Text = "";
            tdee.Text = "";
            npe.Clear();
            epe.Clear();
            nf.Clear();
            fo.Clear();
            tableau.Rows.Clear();
            // modifier.Enabled = false;
            // supprimer.Enabled = false;
            // enregistrer.Enabled = true;
            teg.Select();
        }

        private void Femer_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnNa_Click(object sender, EventArgs e)
        {
            lpg x = new lpg();
            x.ShowDialog();
        }

        private void qu_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
