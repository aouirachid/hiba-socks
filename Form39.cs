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
    public partial class regl : Form
    {
        int npr;

        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public regl()
        {
            InitializeComponent();
        }

        private void regl_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Femer_Click(object sender, EventArgs e)
        {
          
        }

        private void fo_TextChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
                bd.Close();
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT cheque.[n° entrree], composant.[type article], composant.[nom article], dentreeg.quantite, entreeg.[date entree], entreeg.[nombre cheque], cheque.[n°cheque], cheque.montant, cheque.[date versement] FROM dentreeg INNER JOIN composant ON dentreeg.[n° article] = composant.[n° article] INNER JOIN entreeg ON dentreeg.[n° entre] = entreeg.[n°entree] INNER JOIN fournisseur INNER JOIN cheque ON fournisseur.[n° fournisseur] = cheque.[n° fournisseur] ON entreeg.[n°entree] = cheque.[n° entrree]  where [fournisseur].denomination='" + fo.Text + "' and [cheque].[etat paiement]='" + "1" + "' ORDER BY cheque.[n° entrree]", bd);
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
                    rd[7],
                    rd[8]
                    ) ;
            }
            bd.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            { 
            bd.Open();
            int k = 0;

            if (fo.Text != "")
            {
                // Initialize k to 0 before the loop starts
                for (int z = 0; z < tableau.Rows.Count - 1; z++)
                {
                    if (Convert.ToBoolean(tableau.Rows[z].Cells["select"].Value) == true)
                    {
                        k = 1;
                    }
                }

                // Check k after the loop
                if (k == 0)
                {
                    MessageBox.Show("SÉLECTIONNER UN N° DE CHEQUE");
                    bd.Close();
                    return;
                }

                // Now iterate through the rows and update them
                for (int i = 0; i < tableau.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(tableau.Rows[i].Cells["select"].Value) == true)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE cheque SET [etat paiement] = '0' WHERE [n°cheque] = '" + tableau.Rows[i].Cells[6].Value.ToString() + "'", bd);
                        cmd.ExecuteNonQuery();

                        SqlCommand cmb = new SqlCommand("INSERT INTO reglement VALUES ('" + nf.Text + "','" + tableau.Rows[i].Cells[6].Value.ToString() + "','" + dvc.Value.ToString() + "')", bd);
                        cmb.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tableau.Rows.Clear(); fo.Clear();nf.Clear(); ; tomo.Text ="0.00";
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bd.Close();
            }
            catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tableau_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["select"].Index)
           // {
                // Initialize the total to 0
             //   decimal totalAmount = 0;

                // Iterate through the DataGridView rows
              //  foreach (DataGridViewRow row in dataGridView1.Rows)
             //   {
              //      DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["select"];

                 //   // Check if the CheckBox in the "select" column is checked
                  //  if (Convert.ToBoolean(checkBoxCell.Value))
                    //{
                        // Ensure that the cell value in the "montant" column is a valid decimal
                      //  if (decimal.TryParse(row.Cells["montant"].Value.ToString(), out decimal rowAmount))
                       // {
                       //     totalAmount += rowAmount;
                       // }
                    //}
               // }

                // Update the label text with the total amount
               // tomoLabel.Text = "Total: " + totalAmount.ToString("C"); // Format as currency if needed
           // }
        }

        private void tot_Click(object sender, EventArgs e)
        {
            tomo.Text = "0";
            for (int z = 0; z < tableau.Rows.Count; z++)
            {

                if (Convert.ToBoolean(tableau.Rows[z].Cells["select"].Value) == true)
                {
                    tomo.Text = (float.Parse(tomo.Text) + Convert.ToDouble(tableau.Rows[z].Cells[7].Value)).ToString("0.00");
                }
            }
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION REGLEMENT " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write header row
                    for (int i = 0; i < tableau.Columns.Count; i++)
                    {
                        sw.Write(tableau.Columns[i].HeaderText);
                        if (i < tableau.Columns.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();

                    // Write data rows
                    foreach (DataGridViewRow row in tableau.Rows)
                    {
                        for (int i = 0; i < tableau.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value);
                            if (i < tableau.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine();
                    }
                }
            }
        }

    }
    
}
