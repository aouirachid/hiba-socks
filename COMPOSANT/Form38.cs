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
        private Debouncer searchDebouncer = new Debouncer(500);
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public eg()
        {
            InitializeComponent();
        }

        private void checkStatus()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                checkStatus();
                Enregistrer.Enabled = false;
                Ajouter_Click(sender, e);
                if (teg.Text != "" && tableau.Rows.Count > 1)
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("insert into entreeg ([type dentree],[type piece],[n° piece],[date entree],[entree par]) values('" + teg.Text + "','" + tdee.Text + "','" + npe.Text + "','" + ddee.Value.ToString() + "','" + epe.Text + "')", bd);
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd1 = new SqlCommand("select top(1) [n°entree] from [entreeg] order by [n°entree] desc", bd);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    rd.Read();
                    int ndee = Convert.ToInt32(rd.GetValue(0));
                    rd.Close();
                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd2 = new SqlCommand("insert into dentreeg ([n° entre],[n° article],[nFourn],[quantite],[prix achatht],[boxNumber]) values(@nEntree,@nComposant,@nFournisseur,@quantity,@prixAchatHt,@boxNumber)", bd);
                        cmd2.Parameters.AddWithValue("@nEntree", ndee.ToString());
                        cmd2.Parameters.AddWithValue("@nComposant", tableau.Rows[i].Cells[0].Value.ToString());
                        cmd2.Parameters.AddWithValue("@nFournisseur", nf.Text);
                        cmd2.Parameters.AddWithValue("@quantity", double.Parse(tableau.Rows[i].Cells[2].Value.ToString()));
                        cmd2.Parameters.AddWithValue("@prixAchatHt", Convert.ToDouble(tableau.Rows[i].Cells[4].Value.ToString()));
                        cmd2.Parameters.AddWithValue("@boxNumber", tableau.Rows[i].Cells[3].Value.ToString());
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
                    Enregistrer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Enregistrer.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Enregistrer.Enabled = true;
            }

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try {

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
                    nBox.Text,
                    pah.Text,
                    ttva.Text
                    );
                    npro.Text = ""; nc.Clear(); qu.Text = "0.00"; pah.Clear(); ttva.Clear(); nBox.Clear(); nRef.Clear(); nRef.Select();
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
            nBox.Text = "";
            npe.Clear();
            epe.Clear();
            nf.Clear();
            fo.Clear();
            tableau.Rows.Clear();
            nRef.Select();
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

        private void nRef_TextChanged(object sender, EventArgs e)
        {
            if (nRef.Text != "")
            {
                searchDebouncer.Debounce(() =>
                {
                    checkStatus();
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("select*from composant where [reference]=@nReference", bd);
                    cmd.Parameters.AddWithValue("@nReference", nRef.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read()) // Check if a record was actually found
                {
                        npro.Text = rd[0].ToString().Trim();
                        teg.Text = rd[1].ToString().Trim();
                        nc.Text = rd[4].ToString().Trim();
                        pah.Text = rd[6].ToString().Trim();
                        ttva.Text = rd[7].ToString().Trim();
                    }
                    else
                    {
                        // Clear the fields if no match is found
                        teg.Text = "";
                        nc.Text = "";
                        pah.Text = "";
                        ttva.Text = "";
                    }
                    rd.Close();
                    bd.Close();
                    qu.Select();
                });
            }
            
        }

        private void teg_TextChanged(object sender, EventArgs e)
        {
            if (teg.Text == "Emballage")
            {
                nBox.Text = "MAT-";
            }
            else if (teg.Text == "Matiére 1 ére")
            {
                nBox.Text = "EM-";
            }
            else
            {
                nBox.Text = "PDR-";
            }
        }
    }
}
