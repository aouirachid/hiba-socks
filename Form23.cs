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

namespace FD_STOCK
{
    public partial class nmach : Form
    {
        static string constring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(constring);
        string npr;
        public nmach()
        {
            InitializeComponent();
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

            SqlCommand cmb = new SqlCommand("select * from machine where upper([n_machine])='" + txtmdn.Text.ToUpper() + "'", bd);
                SqlDataReader rd = cmb.ExecuteReader();

                if (rd.HasRows)
                {
                    MessageBox.Show("N° MACHINE DEJA EXISTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!string.IsNullOrEmpty(txtmdn.Text) && !string.IsNullOrEmpty(txtrc.Text) && !string.IsNullOrEmpty(txta.Text))
                {
                    rd.Close(); // Close the previous SqlDataReader

                    SqlCommand cmd = new SqlCommand("insert into machine values('" + txtmdn.Text.ToUpper() + "' , '" + txtrc.Text + "','" + txta.Text + "')", bd);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("select top(1) [nm] from [machine] order by [nm] desc", bd);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    rd1.Read();
                    string ne = rd1.GetValue(0).ToString();
                    rd1.Close();

                    // Check if the user has provided ref values in the DataGridView
                    int numberOfRefValues = tableau2.Rows.Count - 1;
                    if (numberOfRefValues >= 1 && numberOfRefValues <= 30)
                    {
                        
                        for (int f = 0; f < numberOfRefValues; f++)
                        {
                            // Determine the column name based on the current index
                            string refColumnName = "reference";

                            SqlCommand cmd2 = new SqlCommand("INSERT INTO ref_aiguille (n_machine, " + refColumnName + ") VALUES ('" + ne + "', '" + tableau2.Rows[f].Cells[0].Value.ToString() + "')", bd);
                            cmd2.ExecuteNonQuery();
                        }

                        MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        Remplir();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Le nombre de ref doit être compris entre 1 et 30", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


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
        private void clear()
        {
            txtmdn.Text = "";
            txtrc.Text = "";
            txta.Text = "0";
            ra.Text = "";
            tableau2.Rows.Clear();
            tableau2.Visible = false;
            btnUpdate.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (bd.State == ConnectionState.Open)
                {
                    bd.Close();
                }
                bd.Open();

                // Step 1: Retrieve nm for the specified n_machine
                SqlCommand selectCmd = new SqlCommand("SELECT [nm] FROM [machine] WHERE [n_machine] = @n_machine", bd);
                selectCmd.Parameters.AddWithValue("@n_machine", npr.ToString());
                SqlDataReader selectReader = selectCmd.ExecuteReader();

                int nmValue = 0;

                if (selectReader.Read())
                {
                    nmValue = Convert.ToInt32(selectReader["nm"]);
                }

                selectReader.Close();

                // Step 2: Update machine table
                SqlCommand updateCmd = new SqlCommand("UPDATE machine SET [reference_cylindre] = @reference_cylindre, [aiguille] = @aiguille WHERE [n_machine] = @n_machine", bd);
                updateCmd.Parameters.AddWithValue("@n_machine", npr.ToString());
                updateCmd.Parameters.AddWithValue("@reference_cylindre", txtrc.Text);
                updateCmd.Parameters.AddWithValue("@aiguille", txta.Text);

                updateCmd.ExecuteNonQuery();

                // Step 3: Retrieve existing references for the specified n_machine
                SqlCommand existingRefsCmd = new SqlCommand("SELECT [reference] FROM [ref_aiguille] WHERE [n_machine] = @n_machine", bd);
                existingRefsCmd.Parameters.AddWithValue("@n_machine", nmValue);
                SqlDataReader existingRefsReader = existingRefsCmd.ExecuteReader();

                List<string> existingReferences = new List<string>();

                while (existingRefsReader.Read())
                {
                    existingReferences.Add(existingRefsReader["reference"].ToString());
                }

                existingRefsReader.Close();

                // Step 4: Compare and insert new references
                int numberOfRefValues = tableau2.Rows.Count - 1;

                for (int f = 0; f < numberOfRefValues; f++)
                {
                    string newReference = tableau2.Rows[f].Cells[0].Value.ToString();

                    // Step 5: Insert new reference if it doesn't exist
                    if (!existingReferences.Contains(newReference))
                    {
                        SqlCommand insertCmd = new SqlCommand("INSERT INTO ref_aiguille (n_machine, reference) VALUES (@n_machine, @reference)", bd);
                        insertCmd.Parameters.AddWithValue("@n_machine", nmValue);
                        insertCmd.Parameters.AddWithValue("@reference", newReference);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("MODIFICATION EFFECTUE AVEC SUCCES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                Remplir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SAISIE INCORRECTE: " + ex.Message, "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bd.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            npr = Microsoft.VisualBasic.Interaction.InputBox("RECHERCHER N° MACHINE", "HIBA SOCKS");
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from machine where[n_machine]='" + npr.ToString() + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                rd.Read();
                txtmdn.Text = rd.GetValue(1).ToString().Trim();
                txtrc.Text = rd.GetValue(2).ToString().Trim();
                txta.Text = rd.GetValue(3).ToString().Trim();
                btnUpdate.Enabled = true;
                saveBtn.Enabled = false;

            }

            else
            {
                MessageBox.Show("N° MACHINE" + npr.ToString() + " N'EXIXTE PAS", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bd.Close();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            Remplir();
        }
        private void Remplir()
        {
            conState();
            tableau.Rows.Clear();

            SqlCommand cmd = new SqlCommand("select * from machine order by [nm] ", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(1).ToString().Trim(),
                   rd.GetValue(2).ToString().Trim(),
                   rd.GetValue(3).ToString().Trim()
                    );
            }
            bd.Close();


        }
        private void conState()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
        }
        private void tableau_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = (tableau.Rows[i].Cells[1].Value.ToString().Trim());
            txtmdn.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtrc.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txta.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();

        }
        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = (tableau.Rows[i].Cells[1].Value.ToString().Trim());
            txtmdn.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtrc.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txta.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
        }

        private void fermer_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            tableau.Rows.Clear();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from machine where [n_machine] like '%" + textBox1.Text + "%' order by [nm] ", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tableau.Rows.Add(
                   rd.GetValue(1).ToString().Trim(),
                   rd.GetValue(2).ToString().Trim(),
                   rd.GetValue(3).ToString().Trim()
                    );
            }
            bd.Close();
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            if (ra.Text != "")
            {
                for (int i = 0; i < tableau2.Rows.Count - 1; i++)
                {
                    if (tableau2.Rows[i].Cells[0].Value.ToString() == ra.Text)
                    {
                        MessageBox.Show("REFERENCE D'AIGUILLE DEJA AJOUTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                tableau2.Rows.Add(
                    ra.Text
                    );
                ra.Text = "";ra.Select(); tableau2.Visible = true;
            }
            else
            {
                MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
