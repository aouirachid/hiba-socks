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

namespace FD_STOCK.COMPOSANT
{
    public partial class sortieComposant : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public sortieComposant()
        {
            InitializeComponent();
        }
        private void clear()
        {
            tsg.Text="";
            npro.Text = "";
            nc.Text = "";
            qu.Text = "0.00";
            tableau.Rows.Clear();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
           // try
           // {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                if (tsg.Text != "" && tableau.Rows.Count > 1)
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("insert into sortieg values( @typeComposant,@dateSortie,@sortiePar)", bd);
                    cmd.Parameters.AddWithValue("@typeComposant", tsg.Text);
                    cmd.Parameters.AddWithValue("@dateSortie", dds.Value.ToString());
                    cmd.Parameters.AddWithValue("@sortiePar", sp.Text);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("select top(1) nSortie from sortieg order by nSortie desc", bd);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    rd.Read();
                    int ndee = Convert.ToInt32(rd.GetValue(0));
                    rd.Close();
                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd2 = new SqlCommand("insert into dsortieg values(@nSortie,@nComposatnt,@qte)", bd);
                        cmd2.Parameters.AddWithValue("@nSortie", ndee.ToString());
                        cmd2.Parameters.AddWithValue("@nComposatnt", tableau.Rows[i].Cells[0].Value.ToString());
                        cmd2.Parameters.AddWithValue("@qte", tableau.Rows[i].Cells[2].Value.ToString());
                        cmd2.ExecuteNonQuery();
                        SqlCommand cd = new SqlCommand("select*from composant where [n° article]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        SqlDataReader rb = cd.ExecuteReader();
                        rb.Read();
                        float qs = Convert.ToSingle(rb.GetValue(5)) - Convert.ToSingle(tableau.Rows[i].Cells[2].Value);
                        rb.Close();
                        SqlCommand cm = new SqlCommand("update composant set [stock]='" + qs.ToString() + "' where [n° article]='" + tableau.Rows[i].Cells[0].Value.ToString() + "'", bd);
                        cm.ExecuteNonQuery();

                    }

                    MessageBox.Show("ENREGISTREMENT EFFECTUEE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bd.Close();
                    clear();
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           // }
           // catch
           // {
           //     MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        }

        private void sortieComposant_Load(object sender, EventArgs e)
        {

        }

        private void tsg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                bd.Open();
                if (tsg.SelectedIndex == 0)
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
                else if (tsg.SelectedIndex == 1)
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
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void npro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                bd.Open();
                if (tsg.SelectedIndex == 0)
                {
                    SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + npro.Text + "'", bd);
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    nc.Text = rd.GetValue(4).ToString();
                    rd.Close();
                }

                else if (tsg.SelectedIndex == 1)
                {
                    SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + npro.Text + "'", bd);
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    nc.Text = rd.GetValue(4).ToString();
                    rd.Close();

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + npro.Text + "'", bd);
                    SqlDataReader rd = cmd.ExecuteReader();
                    rd.Read();
                    nc.Text = rd.GetValue(4).ToString();
                    rd.Close();
                }
                bd.Close();
                qu.Select();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            lpg x = new lpg();
            x.WindowState = FormWindowState.Normal;
            x.ShowDialog();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
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
                    qu.Text
                    );
                    npro.Text = ""; nc.Clear(); qu.Text = "0.00";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
