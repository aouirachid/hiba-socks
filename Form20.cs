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
    public partial class nsemb : Form
    {
        int npr;

        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public nsemb()
        {
            InitializeComponent();
        }

        private void nsemb_Load(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd2 = new SqlCommand("select*from composant where [type article] = 'Emballage'", bd);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                npro.Items.Add(rd2.GetValue(0).ToString().Trim());
            }
            rd2.Close();
            bd.Close();
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            
            qu.Text = "0";
            npro.Text = "";
            nc.Text = "";
            tableau.Rows.Clear();

            //Modifier.Enabled = false;
            //Supprimer.Enabled = false;
            Enregistrer.Enabled = true;
            
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tableau.Rows.Count > 1)
                {
                    if (bd.State != ConnectionState.Open)
                    {
                        bd.Open();
                    }

                    // Check stock validity before starting the transaction
                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                    {
                        DataGridViewRow row = tableau.Rows[i];
                        // Check if the cell value is not null
                        if (row.Cells[0].Value != null)
                        {
                            string productCode = row.Cells[0].Value.ToString();
                            int quantitySold = Convert.ToInt32(row.Cells[2].Value);

                            using (SqlCommand cmdCheckStock = new SqlCommand("SELECT [stock] FROM composant WHERE [n° article] = @productCode", bd))
                            {
                                cmdCheckStock.Parameters.AddWithValue("@productCode", productCode);

                                using (SqlDataReader rdCheckStock = cmdCheckStock.ExecuteReader())
                                {
                                    if (rdCheckStock.Read())
                                    {
                                        int currentStock = Convert.ToInt32(rdCheckStock["stock"]);

                                        if (currentStock < quantitySold)
                                        {
                                            throw new Exception("STOCK INSUFFISANT: " + row.Cells[1].Value);
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Produit introuvable: " + productCode);
                                    }
                                }
                            }
                        }
                    }

                    // If stock checks pass, start the transaction
                    using (SqlTransaction transaction = bd.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO sortieemb VALUES (@date, @epe)", bd, transaction);
                            cmd.Parameters.AddWithValue("@date", ddee.Value.ToString());
                            cmd.Parameters.AddWithValue("@epe", epe.Text);
                            cmd.ExecuteNonQuery();

                            SqlCommand cmd1 = new SqlCommand("SELECT TOP(1) [n° sortieemb] FROM [sortieemb] ORDER BY [n° sortieemb] DESC", bd, transaction);

                            using (SqlDataReader rd = cmd1.ExecuteReader())
                            {
                                if (rd.Read())
                                {
                                    int ndee = Convert.ToInt32(rd["n° sortieemb"]);
                                    rd.Close();

                                    for (int i = 0; i < tableau.Rows.Count - 1; i++)
                                    {
                                        DataGridViewRow row = tableau.Rows[i];
                                        if (row.Cells[0].Value != null)
                                        {
                                            string productCode = row.Cells[0].Value.ToString();
                                            int quantitySold = Convert.ToInt32(row.Cells[2].Value);

                                            SqlCommand cmd2 = new SqlCommand("INSERT INTO dsortieemb VALUES (@ndee, @productCode, @quantitySold)", bd, transaction);
                                            cmd2.Parameters.AddWithValue("@ndee", ndee);
                                            cmd2.Parameters.AddWithValue("@productCode", productCode);
                                            cmd2.Parameters.AddWithValue("@quantitySold", quantitySold);
                                            cmd2.ExecuteNonQuery();

                                            // Update stock
                                            SqlCommand cmd4 = new SqlCommand("UPDATE composant SET [stock] = [stock] - @quantitySold WHERE [n° article] = @productCode", bd, transaction);
                                            cmd4.Parameters.AddWithValue("@quantitySold", quantitySold);
                                            cmd4.Parameters.AddWithValue("@productCode", productCode);
                                            cmd4.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            // Handle the case where the cell value is null
                                            MessageBox.Show("Cell value is null for row: " + row.Index, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            // You might want to skip or handle this row differently based on your requirements
                                        }
                                    }

                                    transaction.Commit();

                                    MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Nouveau_Click(sender, e);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("SAISIE INCORRECTE: " + ex.Message, "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(  ex.Message, "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bd.Close();
            }


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
                            MessageBox.Show(" EMBALLAGE DEJA AJOUTER", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(" SAISIE INCORRECTE ", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void npro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + npro.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            nc.Text = rd.GetValue(4).ToString();
            pah.Text = rd.GetValue(6).ToString();
            ttva.Text = rd.GetValue(7).ToString();
            bd.Close();
            qu.Select();
           
            
        }

        private void Femer_Click(object sender, EventArgs e)
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
    }
}
