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

namespace FD_STOCK
{
    public partial class dmach : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        public dmach()
        {
            InitializeComponent();
        }
        
        private void dmach_Load(object sender, EventArgs e)
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
                cmbprm.Items.Add(rd2.GetValue(0).ToString().Trim());
            }
            rd2.Close();
            bd.Close();
            Remplir();
        }
        private void Remplir()
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT dmachine.nsm, dmachine.n_machine, dmachine.nom_article, dmachine.color, dmachine.size,  dmachine.date_hour, composant.[type article], composant.[nom article],  dcomposant.qte AS QTECom FROM  composant INNER JOIN dcomposant ON composant.[n° article] = dcomposant.n_article INNER JOIN dmachine ON dcomposant.nsm = dmachine.nsm  GROUP BY dmachine.nsm, dmachine.n_machine, dmachine.nom_article, dmachine.color, dmachine.size, composant.[type article], composant.[nom article], dcomposant.qte, dmachine.date_hour, dmachine.nsm ", bd);
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
                   rd[7],
                   rd[8]
                   );
                }
            }
            bd.Close();
        }

        private void clear()
        {
            cmbndm.Text = "";
            txtna.Text = "";
            txtc.Text = "";
            txts.Text = "";
            rc.Text = "";
            na.Text = "";
            ob.Text = "";
            txtconv.Text = "";
            tableau2.Rows.Clear();
            tableau3.Rows.Clear();

        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            la x = new la();
            x.ShowDialog();
            int i = x.tableau.CurrentRow.Index;
            txtna.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtc.Text = x.tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txts.Text = x.tableau.Rows[i].Cells[3].Value.ToString().Trim();
            
        }

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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            bool stockAvailableTableau2 = true;  // Assume there is enough stock by default for tableau2

            for (int f = 0; f < tableau2.Rows.Count - 1; f++)
            {
                SqlCommand cmb = new SqlCommand("select [stock] from composant where [n° article]='" + tableau2.Rows[f].Cells[0].Value.ToString() + "'", bd);
                SqlDataReader rb = cmb.ExecuteReader();

                if (rb.Read()) // Check if the record exists
                {
                    float currentStock1 = Convert.ToSingle(rb["stock"]);
                    float requestedQuantity1 = Convert.ToSingle(tableau2.Rows[f].Cells[2].Value);

                    if (currentStock1 < requestedQuantity1)
                    {
                        // Insufficient stock for tableau2, set the flag to false and exit the operation.
                        stockAvailableTableau2 = false;
                        rb.Close();
                        break; // Exit the loop
                    }
                    else
                    {
                        // Sufficient stock is available; update the stock.
                        float qs1 = currentStock1 - requestedQuantity1;
                        rb.Close();

                        SqlCommand cmb1 = new SqlCommand("update composant set [stock]='" + qs1.ToString() + "' where [n° article]='" + tableau2.Rows[f].Cells[0].Value.ToString() + "'", bd);
                        cmb1.ExecuteNonQuery();
                    }
                }
            }

            if (!stockAvailableTableau2)
            {
                MessageBox.Show("STOCK COMPOSANT INSUFFISANT.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Continue the entire operation as you originally had, including steps 1 to 6.
                // This section should only be reached if stockAvailableTableau2 is true.
                SqlCommand cmd = new SqlCommand("insert into dmachine values('" + cmbndm.Text + "','" + txtna.Text.ToUpper() + "' , '" + txtc.Text + "','" + txts.Text + "', '" + dateHour.Value + "')", bd);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("select top(1) [nsm] from [dmachine] order by [nsm] desc", bd);
                SqlDataReader rd = cmd1.ExecuteReader();
                rd.Read();
                string ne = rd.GetValue(0).ToString();
                rd.Close();
                for (int f = 0; f < tableau2.Rows.Count - 1; f++)
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO dcomposant  VALUES ('" + ne + "','" + tableau2.Rows[f].Cells[0].Value.ToString() + "','" + tableau2.Rows[f].Cells[2].Value.ToString() + "')", bd);
                    cmd2.ExecuteNonQuery();
                }
                MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bd.Close();
            Remplir();
            clear();
        }

        private void cmbndm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from machine where n_machine='" + cmbndm.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            tableau3.Rows.Clear();
            rc.Text = rd.GetValue(2).ToString().Trim();
            na.Text = rd.GetValue(3).ToString().Trim();
            rd.Close();
            SqlCommand cmd1 = new SqlCommand("SELECT  ref_aiguille.reference FROM ref_aiguille INNER JOIN machine ON ref_aiguille.n_machine = machine.nm where machine.n_machine='" + cmbndm.Text + "'", bd);
            SqlDataReader rd1 = cmd1.ExecuteReader();
            
            while (rd1.Read())
            {
                
                tableau3.Rows.Add(
                   rd1.GetValue(0).ToString().Trim()
                    );
                tableau3.Visible = true;
            }
                bd.Close();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
      
        }

        private void txtnpr_TextChanged(object sender, EventArgs e)
        {

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtprq_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateHour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtq_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtna_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void txtndm_TextChanged(object sender, EventArgs e)
        {
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from dmachine where [n_machine] like '%" + txtndm.Text + "%'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                while (rd.Read())
                {
                    tableau.Rows.Add(
                    rd[1],
                   rd[2],
                   rd[3],
                   rd[4],
                   rd[5]
                        ) ;
                }
            }
            bd.Close();
        }

        private void cmbprm_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from composant where [n° article]='" + cmbprm.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            txtnprm.Text = rd.GetValue(4).ToString();
            bd.Close();
            txtprqm.Select();
        }

        private void txtnprm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnm_Click(object sender, EventArgs e)
        {
            if (cmbprm.Text != "")
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == cmbprm.Text)
                    {
                        MessageBox.Show("MATIERE 1 ére DEJA AJOUTE", "HIBA SOCKS");
                        return;
                    }
                }
                tableau2.Rows.Add(
                    cmbprm.Text,
                    txtnprm.Text,
                    txtconv.Text
                    );
                cmbprm.Text = ""; txtnprm.Clear(); txtprqm.Text = "0"; ob.Clear(); txtconv.Clear(); tableau2.Visible = true;
            }
            else
            {
                MessageBox.Show("VERIFIER LA SAISIE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtconv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtprqm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtndm_TextChanged_1(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("SELECT dmachine.nsm, dmachine.n_machine, dmachine.nom_article, dmachine.color, dmachine.size, dmachine.date_hour, composant.[type article], composant.[nom article],  dcomposant.qte AS QTECom FROM  composant INNER JOIN dcomposant ON composant.[n° article] = dcomposant.n_article INNER JOIN dmachine ON dcomposant.nsm = dmachine.nsm where dmachine.n_machine like '%" + txtndm.Text + "%'  GROUP BY dmachine.nsm,dmachine.n_machine, dmachine.nom_article, dmachine.color, dmachine.size, composant.[type article], composant.[nom article], dcomposant.qte, dmachine.date_hour, dmachine.nsm ", bd);
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
                   rd[7],
                   rd[8]
                   );
                }
            }
            bd.Close();
        }

        private void exporter_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";

            // Set the default file name
            saveFileDialog.FileName = "EXPORTAION LISTE OETAILLE MACHINE " + DateTime.Now.ToString("yyyy_MM_dd") + ".csv";

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

        private void button2_Click(object sender, EventArgs e)
        {
            lpg x = new lpg();
            x.ShowDialog();
        }

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
    }
}
