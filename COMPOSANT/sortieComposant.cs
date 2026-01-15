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
        private Debouncer searchDebouncer = new Debouncer(500);
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public sortieComposant()
        {
            InitializeComponent();
        }
        private void clear()
        {
            qu.Text = "0.00";
            nc.Clear();
            nComposant.Clear(); 
            tsg.Clear();
            nBox.Clear();
            nBox.BackColor = Color.White;
        }
        private void checkStatus()
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
        }

        
        private void sortieComposant_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProcessBoxAndAutoSave(string boxNumber)
        {
            // 1. Reset UI to avoid mixing old data with new
            ClearFieldsButKeepBox();

            // 2. Validate Box
            if (string.IsNullOrEmpty(boxNumber)) return;

            try
            {
                bd.Open();

                // --- STEP A: FETCH DATA ---
                // We fetch data to memory first. We do NOT rely on Textboxes for storage.
                string query = @"select c.[nom article], deg.[quantite], deg.[n° article], c.[type article] 
                         from dentreeg deg 
                         join composant c on deg.[n° article] = c.[n° article] 
                         where deg.boxNumber = @boxNumber";

                SqlCommand fetchCmd = new SqlCommand(query, bd);
                fetchCmd.Parameters.AddWithValue("@boxNumber", boxNumber);

                SqlDataReader rd = fetchCmd.ExecuteReader();

                // Variables to hold data for the subsequent Save
                string val_Nom = "", val_Type = "", val_Ref = "";
                float val_Qte = 0;
                bool found = false;

                if (rd.Read())
                {
                    val_Nom = rd[0].ToString().Trim();
                    val_Qte = Convert.ToSingle(rd[1]); // Store as number
                    val_Ref = rd[2].ToString().Trim();
                    val_Type = rd[3].ToString().Trim();
                    found = true;
                }
                rd.Close(); // Close reader immediately so we can start a Transaction

                if (!found)
                {
                    // Visual feedback for "Not Found"
                    nBox.BackColor = Color.Red;
                    bd.Close();
                    return;
                }

                // --- STEP B: POPULATE UI (For User Visibility) ---
                nc.Text = val_Nom;
                qu.Text = val_Qte.ToString();
                nComposant.Text = val_Ref;
                tsg.Text = val_Type;
                nBox.BackColor = Color.LightGreen; // Visual Feedback: Found!

                // --- STEP C: AUTO SAVE (Immediate Transaction) ---
                // We pass the variables directly, not reading from UI (safer)
                PerformSafeTransaction(val_Type, val_Ref, val_Qte, boxNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing scan: " + ex.Message);
            }
            finally
            {
                checkStatus();
            }
        }

        private void PerformSafeTransaction(string typeArt, string refArt, float qte, string boxNum)
        {
            SqlTransaction transaction = bd.BeginTransaction();

            try
            {
                // 1. Insert Sortie & Get ID safely
                string q1 = @"insert into sortieg values (@type, @date, @user); 
                      SELECT CAST(SCOPE_IDENTITY() as int);";

                SqlCommand cmd1 = new SqlCommand(q1, bd, transaction);
                cmd1.Parameters.AddWithValue("@type", typeArt);
                cmd1.Parameters.AddWithValue("@date", dds.Value);
                cmd1.Parameters.AddWithValue("@user", sp.Text); // Assuming 'admin' is here

                int newSortieID = (int)cmd1.ExecuteScalar();

                // 2. Insert Detail
                string q2 = "insert into dsortieg values (@nSortie, @ref, @qte, @box)";
                SqlCommand cmd2 = new SqlCommand(q2, bd, transaction);
                cmd2.Parameters.AddWithValue("@nSortie", newSortieID);
                cmd2.Parameters.AddWithValue("@ref", refArt);
                cmd2.Parameters.AddWithValue("@qte", qte);
                cmd2.Parameters.AddWithValue("@box", boxNum);
                cmd2.ExecuteNonQuery();

                // 3. Update Stock (Atomic Update)
                string q3 = "update composant set stock = stock - @qte where [n° article] = @ref";
                SqlCommand cmd3 = new SqlCommand(q3, bd, transaction);
                cmd3.Parameters.AddWithValue("@qte", qte);
                cmd3.Parameters.AddWithValue("@ref", refArt);
                cmd3.ExecuteNonQuery();

                transaction.Commit();

                // Visual Success Indicator (Optional: Play a sound)
                 System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("ENREGISTREMENT EFFECTUEE AVEC SUCCEES", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Wait a split second so user sees the data, then clear?
                // Or keep it there until next scan.
                 clear(); 
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Transaction Failed: " + ex.Message);
                nBox.BackColor = Color.Orange; // Visual error
            }
        }

        // Helper to keep the UI clean
        private void ClearFieldsButKeepBox()
        {
            nc.Clear(); qu.Clear(); nComposant.Clear(); tsg.Clear();
            nBox.BackColor = Color.White;
        }

        private void nBox_TextChanged(object sender, EventArgs e)
        {
            if (nBox.Text != "")
            {
                // Debounce to wait for the scanner to finish typing the digits
                searchDebouncer.Debounce(() =>
                {
                    // IMPORTANT: Move back to the UI thread to touch UI controls safely
                    this.Invoke((MethodInvoker)delegate
                    {
                        ProcessBoxAndAutoSave(nBox.Text);
                    });
                });
            }
        }

        
    }
}
