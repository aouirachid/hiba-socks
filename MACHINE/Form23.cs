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
                    SqlCommand cmd = new SqlCommand("INSERT INTO machine VALUES (@nDeMachine, @diametreCylindre, @nombreAiguille, @modelMachine)", bd);
                    cmd.Parameters.AddWithValue("@nDeMachine", txtmdn.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@diametreCylindre", txtrc.Text);
                    cmd.Parameters.AddWithValue("@nombreAiguille", txta.Text);
                    cmd.Parameters.AddWithValue("@modelMachine", mma.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("ENREGISTREMENT EFFECTUEE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    Remplir();
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
        private void clear()
        {
            txtmdn.Text = "";
            txtrc.Text = "";
            txta.Text = "0";
            mma.Text = "";
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
                SqlCommand updateCmd = new SqlCommand("UPDATE machine SET [reference_cylindre] = @reference_cylindre, [aiguille] = @aiguille,model_machine=@modelMachine WHERE [n_machine] = @n_machine", bd);
                updateCmd.Parameters.AddWithValue("@n_machine", npr.ToString());
                updateCmd.Parameters.AddWithValue("@reference_cylindre", txtrc.Text);
                updateCmd.Parameters.AddWithValue("@aiguille", txta.Text);
                updateCmd.Parameters.AddWithValue("@modelMachine", mma.Text);

                updateCmd.ExecuteNonQuery();

                
                

                MessageBox.Show("MODIFICATION EFFECTUEE AVEC SUCCES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                mma.Text = rd.GetValue(4).ToString().Trim();
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
                   rd.GetValue(3).ToString().Trim(),
                   rd.GetValue(4).ToString().Trim()
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
            mma.Text = tableau.Rows[i].Cells[4].Value.ToString().Trim();

        }
        private void tableau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableau.CurrentRow.Index;
            npr = (tableau.Rows[i].Cells[1].Value.ToString().Trim());
            txtmdn.Text = tableau.Rows[i].Cells[1].Value.ToString().Trim();
            txtrc.Text = tableau.Rows[i].Cells[2].Value.ToString().Trim();
            txta.Text = tableau.Rows[i].Cells[3].Value.ToString().Trim();
            mma.Text = tableau.Rows[i].Cells[4].Value.ToString().Trim();
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
            
        }
    }
}
