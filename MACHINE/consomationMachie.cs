using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace FD_STOCK.MACHINE
{
    public partial class consomationMachie : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public consomationMachie()
        {
            InitializeComponent();
        }
        private void clear()
        {
            cmbndm.Text = "";
            rc.Text = "";
            na.Text = "";
            mma.Text = "";
            tableau2.Rows.Clear();            
        }
        private void UpdateTCLabel()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in tableau.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells[2].Value.ToString(), out cellValue))
                    {
                        total += cellValue;
                    }
                }
            }

            TC.Text = total.ToString();

        }

        private void remplir()
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from consomationMachine", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd[1].ToString().Trim(),
                   rd[2].ToString().Trim(),
                   rd[3].ToString().Trim(),
                   rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                   rd[5].ToString().Trim()
                    );
            }
            bd.Close();

        }

        private void consomationMachie_Load(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
            SqlCommand cmd = new SqlCommand("select n_machine from machine", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                cmbndm.Items.Add(rd.GetValue(0).ToString().Trim());
            }
            rd.Close();
            bd.Close();
            
            UpdateTCLabel();
        }

        private void cmbndm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from machine where n_machine='" + cmbndm.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            rc.Text = rd.GetValue(2).ToString().Trim();
            na.Text = rd.GetValue(3).ToString().Trim();
            mma.Text = rd.GetValue(4).ToString().Trim();
            rd.Close();
            bd.Close();
            UpdateTCLabel();
        }

        private void btnPr_Click(object sender, EventArgs e)
        {
            if (cmbPieceRechange.Text != "")
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == cmbPieceRechange.Text)
                    {
                        MessageBox.Show("PIECE DE RECHANGE DEJA AJOUTE", "HIBA SOCKS");
                        return;
                    }
                }
                tableau2.Rows.Add(
                    cmbPieceRechange.Text,
                    txtprq.Text
                    );
                cmbPieceRechange.Text = "";  txtprq.Text = "0"; tableau2.Visible = true;
            }
            else
            {
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnm_Click(object sender, EventArgs e)
        {
            if (cmbMatier.Text != "")
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == cmbMatier.Text)
                    {
                        MessageBox.Show("MATIERE 1 ére DEJA AJOUTE", "HIBA SOCKS");
                        return;
                    }
                }
                tableau2.Rows.Add(
                    cmbMatier.Text,
                    txtconv.Text
                    );
                cmbMatier.Text = "";  txtprqm.Text = "0"; ob.Clear(); txtconv.Clear(); txtTaux.Clear(); tableau2.Visible = true;
            }
            else
            {
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableau2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableau2.Columns["supprimer"].Index && e.RowIndex >= 0)
            {
                if (tableau2.Rows[e.RowIndex].Cells["supprimer"].Value != null)
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

        private void ob_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtprqm.Text, out float inputValue) && float.TryParse(ob.Text, out float inputob) && float.TryParse(txtTaux.Text, out float inputTaux))
            {
                // Divide the parsed value by 1000
                float result = ((inputob * inputTaux * inputValue ) / 100)/1000;

                // Display the result in txtconv
                txtconv.Text = (result.ToString());
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                bd.Open();
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into consomationMachine values(@nMachine,@nomComposant,@qte,@date,@entreePar)", bd);
                    cmd.Parameters.AddWithValue("@nMachine", cmbndm.Text);
                    cmd.Parameters.AddWithValue("@date", dateHour.Value.ToString());
                    cmd.Parameters.AddWithValue("@entreePar", epe.Text);
                    cmd.Parameters.AddWithValue("@nomComposant", tableau2.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@qte", tableau2.Rows[i].Cells[1].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("ENREGISTREMENT EFFECTUEE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.Close();
                clear();
                remplir();
                UpdateTCLabel();
            }
            catch
            {
                MessageBox.Show("SAISIE INCCORECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMachine_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from consomationMachine where nMachine like @machine and nomComposant like @composant", bd);
            cmd.Parameters.AddWithValue("@machine", txtMachine.Text + "%");
            cmd.Parameters.AddWithValue("@composant", txtComposant.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd[1].ToString().Trim(),
                   rd[2].ToString().Trim(),
                   rd[3].ToString().Trim(),
                   rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                   rd[5].ToString().Trim()
                    );
            }
            bd.Close();
            UpdateTCLabel();
        }

        private void txtComposant_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from consomationMachine where  nomComposant like @composant AND nMachine like @machine", bd);
            cmd.Parameters.AddWithValue("@machine", txtMachine.Text + "%");
            cmd.Parameters.AddWithValue("@composant", txtComposant.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd[1].ToString().Trim(),
                   rd[2].ToString().Trim(),
                   rd[3].ToString().Trim(),
                   rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                   rd[5].ToString().Trim()
                    );
            }
            bd.Close();
            UpdateTCLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear the DataGridView before adding filtered data
            tableau.Rows.Clear();
            bd.Open();

            string query = "SELECT * FROM consomationMachine WHERE date >= @fromDate AND date <= @toDate and  nomComposant like @composant AND nMachine like @machine";
            SqlCommand cmd = new SqlCommand(query, bd);
            cmd.Parameters.AddWithValue("@fromDate", fromDate.Value.Date);
            cmd.Parameters.AddWithValue("@toDate", toDate.Value.Date.AddDays(1));
            cmd.Parameters.AddWithValue("@machine", txtMachine.Text + "%");
            cmd.Parameters.AddWithValue("@composant", txtComposant.Text + "%");
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                tableau.Rows.Add(
                    rd[1].ToString().Trim(),
                   rd[2].ToString().Trim(),
                   rd[3].ToString().Trim(),
                   rd.GetDateTime(4).ToString("dd/MM/yyyy"),
                   rd[5].ToString().Trim()
                );
            }

            bd.Close();

            UpdateTCLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * this code in form load
         * 
         * //bring data from composant table
            SqlCommand cmd1 = new SqlCommand("select*from composant where [type article] = 'Piéce de rechange'", bd);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            while (rd1.Read())
            {
                cmbpr.Items.Add(rd1.GetValue(0).ToString().Trim());
            }
            rd1.Close();
            SqlCommand cmd2 = new SqlCommand("select*from composant where [type article] = 'Matiére 1 ére'", bd);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                cmbMatier.Items.Add(rd2.GetValue(0).ToString().Trim());
            }
            rd2.Close();

        //remplier dorpdown de piece de rechange
        private void cmbpr_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + cmbpr.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            txtnpr.Text = rd.GetValue(4).ToString();
            bd.Close();
            txtprq.Select();
        }
        //ajouter piece de rechange au tableau
        private void btnPr_Click(object sender, EventArgs e)
        {
            if (cmbpr.Text != "")
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == cmbpr.Text)
                    {
                        MessageBox.Show("PIECE DE RECHANGE DEJA AJOUTE", "HIBA SOCKS");
                        return;
                    }
                }
                tableau2.Rows.Add(
                    cmbpr.Text,
                    txtnpr.Text,
                    txtprq.Text
                    );
                cmbpr.Text = ""; txtnpr.Clear(); txtprq.Text = "0"; tableau2.Visible = true;
            }
            else
            {
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //row delete from table
        private void tableau2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableau2.Columns["supprimer"].Index && e.RowIndex >= 0)
            {
                if (tableau2.Rows[e.RowIndex].Cells["supprimer"].Value != null)
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

        //remplier le dropDown de matier premier
        private void cmbMatier_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + cmbMatier.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            txtnprm.Text = rd.GetValue(4).ToString();
            bd.Close();
            txtprqm.Select();
        }
        //ajouter matier premier au tableau
        private void btnm_Click(object sender, EventArgs e)
        {
            if (cmbMatier.Text != "")
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == cmbMatier.Text)
                    {
                        MessageBox.Show("MATIERE 1 ére DEJA AJOUTE", "HIBA SOCKS");
                        return;
                    }
                }
                tableau2.Rows.Add(
                    cmbMatier.Text,
                    txtnprm.Text,
                    txtconv.Text
                    );
                cmbMatier.Text = ""; txtnprm.Clear(); txtprqm.Text = "0"; ob.Clear(); txtconv.Clear(); tableau2.Visible = true;
            }
            else
            {
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //calcule d'objectif
        private void ob_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txtprqm.Text, out float inputValue) && float.TryParse(ob.Text, out float inputob))
            {
                // Divide the parsed value by 1000
                float result = (inputob * inputValue) / 1000;

                // Display the result in txtconv
                txtconv.Text = (result.ToString());
            }

        }
         */
    }
}
