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

namespace FD_STOCK.FOURNISSEUR
{
    public partial class paymentFournisseur : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public paymentFournisseur()
        {
            InitializeComponent();
        }
        int nc;
        private void btnListeEntree_Click(object sender, EventArgs e)
        {
            leg x = new leg();
            x.ShowDialog();
        }

        private void remplir()
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand remp = new SqlCommand("select * from cheque", bd);
            SqlDataReader reader = remp.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    tableau.Rows.Add(
                        reader[1],
                        reader[2],
                        reader[3],
                        reader[4],
                        reader[5],
                        reader[6]
                   );
                }
            }
            bd.Close();
        }

        private void clear()
        {
            txtNe.Text = "";
            mp.Text = "";
            tableau2.Rows.Clear();
            txtObservation.Clear();
            nuce.Clear();
            mce.Clear();
            noce.Clear();
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (nuce.Text != "" && float.TryParse(mce.Text, out float montant) && montant > 0)
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == nuce.Text)
                    {
                        MessageBox.Show("N° CHEQUE DEJA AJOUTER", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                tableau2.Rows.Add(
                    nuce.Text,
                    montant.ToString(),
                    txtObservation.Text,
                    dvc.Value.ToString()
                );

                nuce.Text = "";
                mce.Text = "0.00";
                txtObservation.Text = "";
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (txtNe.Text != "" && tableau2.Rows.Count > 0)
            {
                bd.Open();
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into cheque values(@nEntree,@nombreCheque,@nCheque,@montant,@observation,@dateVersement,@etat)", bd);
                    cmd.Parameters.AddWithValue("@nEntree", txtNe.Text);
                    cmd.Parameters.AddWithValue("@nombreCheque", noce.Text);
                    cmd.Parameters.AddWithValue("@nCheque", tableau2.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@montant", tableau2.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@observation", tableau2.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@dateVersement", tableau2.Rows[i].Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@etat", 0);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.Close();
                clear();
                remplir();
            }
            else
                MessageBox.Show("you have an error", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void tableau2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableau2.Columns["Supprimerc"].Index && e.RowIndex >= 0)
            {
                if (tableau2.Rows[e.RowIndex].Cells["Supprimerc"].Value != null)
                {
                    // Get the row to be deleted
                    DataGridViewRow row = tableau2.Rows[e.RowIndex];

                    // Perform your delete logic here
                    // For example, you can delete the row from a data source
                    // and then remove it from the DataGridView
                    // data source.Remove(row.DataBoundItem); // Adjust this line as per your data source
                    tableau2.Rows.Remove(row);
                }
            }
        }

        private void paymentFournisseur_Load(object sender, EventArgs e)
        {
            remplir();
        }

        private void tableau_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            nc = Int32.Parse(tableau.Rows[i].Cells[0].Value.ToString());
            txtNe.Text = tableau.Rows[i].Cells[0].Value.ToString().Trim();
            noce.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            nuce.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            mce.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
            txtObservation.Text = tableau.Rows[i].Cells[4].Value.ToString().Trim();
            Enregistrer.Enabled = false;
        }

        private void modier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNe.Text !="")
                {
                    bd.Open();
                    SqlCommand cmd = new SqlCommand("update cheque set [nombreCheque]=@nombreCheque,[n°cheque]=@numeroCheque,[montant]=@montant,[observation]=@observation,[date versement]=@date where[n° entrree]='" + nc.ToString() + "'", bd);
                    cmd.Parameters.AddWithValue("@nEntree", txtNe.Text);
                    cmd.Parameters.AddWithValue("@nombreCheque", noce.Text);
                    cmd.Parameters.AddWithValue("@numeroCheque", nuce.Text);
                    cmd.Parameters.AddWithValue("@montant", mce.Text);
                    cmd.Parameters.AddWithValue("@observation", txtObservation.Text);
                    cmd.Parameters.AddWithValue("@date", dvc.Value);
                    cmd.ExecuteNonQuery();
                    bd.Close();
                    MessageBox.Show("MODIFICATION EFFECTUEE AVEC SUCCES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    remplir();
                    clear();
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

        private void txtnCheque_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand remp = new SqlCommand("select * from cheque where [n°cheque] like @nCheque", bd);
            remp.Parameters.AddWithValue("@nCheque", txtnCheque.Text + "%");
            SqlDataReader reader = remp.ExecuteReader();
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    tableau.Rows.Add(
                        reader[1],
                        reader[2],
                        reader[3],
                        reader[4],
                        reader[5],
                        reader[6]
                   );
                }
            }
            bd.Close();
        }

        private void tableau_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            nc = Int32.Parse(tableau.Rows[i].Cells[0].Value.ToString());
            txtNe.Text = tableau.Rows[i].Cells[0].Value.ToString().Trim();
            noce.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            nuce.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            mce.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
            txtObservation.Text = tableau.Rows[i].Cells[4].Value.ToString().Trim();
            Enregistrer.Enabled = false;
        }
        /*
* 
private void btnch_Click(object sender, EventArgs e)
{
if (nuce.Text != "" && float.TryParse(mce.Text, out float montant) && montant > 0)
{
for (int i = 0; i < tableau2.Rows.Count - 1; i++)
{
if (tableau2.Rows[i].Cells[0].Value.ToString() == nuce.Text)
{
MessageBox.Show("N° CHEQUE DEJA AJOUTER", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
}

tableau2.Rows.Add(
nuce.Text,
montant.ToString(), // Utiliser la valeur convertie ici
dvc.Value.ToString()
);

nuce.Text = "";
mce.Text = "0.00";
}
else
{
MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
}

}


this delete from table
private void tableau2_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
if (e.ColumnIndex == tableau2.Columns["Supprimerc"].Index && e.RowIndex >= 0)
{
if (tableau2.Rows[e.RowIndex].Cells["Supprimerc"].Value != null)
{
// Get the row to be deleted
DataGridViewRow row = tableau2.Rows[e.RowIndex];

// Perform your delete logic here
// For example, you can delete the row from a data source
// and then remove it from the DataGridView
// data source.Remove(row.DataBoundItem); // Adjust this line as per your data source
tableau2.Rows.Remove(row);
}
}
}
*/
    }
}
