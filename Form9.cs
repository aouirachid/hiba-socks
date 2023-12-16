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
using Ex = Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;

namespace FD_STOCK
{
    public partial class ns : Form
    {
        int npr;
        string nfap;
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        string dp = System.Configuration.ConfigurationManager.AppSettings["documentsPaths"];
        static string[] ones = { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };
        static string[] tens = { "", "", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix" };
        public ns()
        {
            InitializeComponent();
        }

        static string ConvertToWords(int number)
        {
            if (number < 0)
                return "moins " + ConvertToWords(Math.Abs(number));
            if (number < 20)
                return ones[number];
            if (number < 100)
            {
                int remainder = number % 10;
                string word = tens[number / 10];
                if (remainder == 1 || remainder == 11)
                    word += " et un";
                else if (remainder > 0)
                    word += "-" + ones[remainder];
                return word;
            }
            if (number < 1000)
            {
                int remainder1 = (number - (number % 100)) / 100;
                if (remainder1 == 1)
                    return "cent" + ((number % 100 != 0) ? " " + ConvertToWords(number % 100) : "");
                else
                    return ones[number / 100] + " cent" + ((number % 100 != 0) ? " " + ConvertToWords(number % 100) : "");
            }
            if (number < 1000000)
            {
                int remainder1 = (number - (number % 1000)) / 1000;
                if (remainder1 == 1)
                    return "mille" + ((number % 1000 != 0) ? " " + ConvertToWords(number % 1000) : "");
                else
                    return ConvertToWords(number / 1000) + " mille" + ((number % 1000 != 0) ? " " + ConvertToWords(number % 1000) : "");
            }
            if (number < 1000000000)
                return ConvertToWords(number / 1000000) + " million" + ((number % 1000000 != 0) ? " " + ConvertToWords(number % 1000000) : "");
            return "nombre trop grand pour être converti en mots";
        }
        static string ConvertToWords(double number)
        {
            int integerPart = (int)number;
            int fractionalPart = (int)Math.Round((number - integerPart) * 100);
            string integerPartWords = ConvertToWords(integerPart);
            string fractionalPartWords = ConvertToWords(fractionalPart);
            if (fractionalPart == 0)
                return integerPartWords + " dirhams ";
            else if (integerPart == 0)
                return fractionalPartWords + " centimes";
            else
                return integerPartWords + " dirhams " + fractionalPartWords + " centimes";
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            ndee.Text = "";
            tdee.Text = "";
            npe.Text = "";
            qu.Text = "0";
            npro.Text = "";
            nc.Text = "";
            txtnc.Text = "";
            qtec.Text = "";
            re.Text = "0.00";
            txtht.Text = "0.00";
            txttva.Text = "0.00";
            txtttc.Text = "0.00";
            txtttcc.Text = "";
            textBox1.Text = "0";
            tableau.Rows.Clear();
            lblnc.Text = "Dénomination";
            lblice.Text = "Ice";
            lblt.Text = "Téléphone";
            lble.Text = "E-mail";
            lblv.Text = "Siége social";
            lbla.Text = "Adresse";
            tdee.SelectedIndex = 1;
            //Modifier.Enabled = false;
            //Supprimer.Enabled = false;
            Enregistrer.Enabled = true;
            tdee.Select();
        }

        private void ns_Load(object sender, EventArgs e)
        {
            tdee.SelectedIndex = 1;
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from produits", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                npro.Items.Add(rd.GetValue(1));
            }
            rd.Close();
            // Remplir();
            bd.Close();
        }
        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from entree", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows == true)
            {
                while (rd.Read())
                {
                    tableau.Rows.Add(
                    rd[0],
                    rd[1],
                    rd[2]


                  );
                }
                rd.Close();
            }
            bd.Close();
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (tdee.SelectedIndex == 0)
            {
                //start insert if type piece is facture
                if (npe.Text != "" && tableau.Rows.Count > 1)
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                    }
                    bd.Open();
                    SqlTransaction transaction = bd.BeginTransaction();

                    try
                    {
                        bool stockAvailableTableau = true;

                        for (int i = 0; i < tableau.Rows.Count - 1; i++)
                        {
                            string productCode = tableau.Rows[i].Cells[0].Value.ToString();
                            int quantitySold = Convert.ToInt32(tableau.Rows[i].Cells[4].Value);

                            // Check if there is enough stock for the product
                            SqlCommand cmd3 = new SqlCommand("select [stock] from produits where [n° reference]='" + productCode + "'", bd, transaction);
                            SqlDataReader rd2 = cmd3.ExecuteReader();
                            rd2.Read();
                            int currentStock = Convert.ToInt32(rd2.GetValue(0));
                            rd2.Close();
                            if (currentStock < quantitySold)
                            {
                                // Insufficient stock for tableau2, set the flag to false and exit the operation.
                                stockAvailableTableau = false;
                                break; // Exit the loop
                            }
                            else
                            {
                                // Sufficient stock is available; update the stock.
                                int newStock = currentStock - quantitySold;
                                SqlCommand cmd5 = new SqlCommand("update produits set [stock]='" + newStock.ToString() + "'where [n° reference]='" + productCode + "'", bd, transaction);
                                cmd5.ExecuteNonQuery();
                            }
                        }
                        if (!stockAvailableTableau)
                        {
                            MessageBox.Show("STOCK PRODUIT INSUFFISANT.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("insert into sortie_facture values('" + tdee.Text + "','" + txtnc.Text + "','" + ddee.Value.ToString() + "','" + cmbmdp.Text + "','" + textBox1.Text + "','" + sp.Text + "','" + " " + "','" + 0 + "')", bd, transaction);
                            cmd.ExecuteNonQuery();
                            SqlCommand cmd1 = new SqlCommand("select max([n° sortief]) from sortie_facture", bd, transaction);
                            SqlDataReader rd = cmd1.ExecuteReader();
                            rd.Read();
                            string nf = rd[0].ToString();
                            string nfb;
                            int tt = nf.Trim().Length;
                            if (tt == 1)
                            {
                                nfb = "00" + nf.Trim();
                            }
                            else if (tt == 2)
                            {
                                nfb = "0" + nf.Trim();
                            }
                            else
                            {
                                nfb = nf.Trim();
                            }
                            nfb = "HS - " + nfb.Trim() + "/" + ddee.Value.Year;
                            rd.Close();
                            SqlCommand cmb = new SqlCommand("update sortie_facture set nf='" + nfb + "' where [n° sortief]='" + nf + "'", bd, transaction);
                            cmb.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand("select top(1) [n° sortief] from [sortie_facture] order by [n° sortief] desc", bd, transaction);
                            SqlDataReader rd1 = cmd2.ExecuteReader();
                            rd1.Read();
                            int ndee = Convert.ToInt32(rd1.GetValue(0));
                            rd1.Close();
                            // Insert into dsortie
                            for (int f = 0; f < tableau.Rows.Count - 1; f++)
                            {
                                SqlCommand cmd4 = new SqlCommand("insert into dsortie_facture values(" + ndee.ToString() + ",'" + tableau.Rows[f].Cells[0].Value + "','" + tableau.Rows[f].Cells[4].Value + "','" + tableau.Rows[f].Cells[5].Value + "','" + tableau.Rows[f].Cells[6].Value + "')", bd, transaction);
                                cmd4.ExecuteNonQuery();
                            }
                            int nl = 18;
                            Ex.Application app1 = new Ex.Application();
                            Ex.Workbooks books;
                            books = app1.Workbooks;
                            Ex.Workbook book;
                            book = books.Open(Environment.CurrentDirectory + "\\Factur.xlsx");
                            Ex._Worksheet ws = book.ActiveSheet;

                            ws.Cells[10, 3] = ddee.Value.Date;
                            ws.Cells[11, 3] = nfb;
                            ws.Cells[12, 3] = cmbmdp.Text;
                            ws.Cells[13, 3] = textBox1.Text;
                            ws.Cells[10, 8] = lblnc.Text;
                            ws.Cells[11, 8] = lblv.Text;
                            ws.Cells[12, 8] = lbla.Text;
                            ws.Cells[13, 8] = lblice.Text;
                            ws.Cells[38, 9] = re.Text;
                            ws.Cells[39, 9] = txtht.Text;
                            ws.Cells[40, 9] = txttva.Text;
                            ws.Cells[41, 9] = txtttc.Text;
                            ws.Cells[44, 5] = txtttcc.Text;
                            for (int i = 0; i < tableau.Rows.Count - 1; i++)
                            {
                                ws.Cells[nl, 1] = tableau.Rows[i].Cells[1].Value.ToString() + "  " + tableau.Rows[i].Cells[2].Value.ToString().Trim() + "  " + tableau.Rows[i].Cells[3].Value.ToString().Trim();
                                ws.Cells[nl, 6] = tableau.Rows[i].Cells[5].Value.ToString();
                                ws.Cells[nl, 7] = tableau.Rows[i].Cells[4].Value.ToString();
                                ws.Cells[nl, 9] = tableau.Rows[i].Cells[6].Value.ToString();
                                nl++;
                            }

                            string pdffile = Environment.CurrentDirectory + "\\factures\\" + nf + ".pdf";
                            string pdffile1 = dp + "\\factures\\" + nf + ".pdf";
                            book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdffile);
                            book.Close(false);
                            app1.Quit();
                            // book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdffile1);
                            System.Diagnostics.Process.Start(pdffile);

                            transaction.Commit();
                            bd.Close();
                            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Nouveau_Click(sender, e);
                            re.ReadOnly = false;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        bd.Close();
                        MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //end inserting if type piece is facture and insert if type bon
            else
            {
                if (npe.Text != "" && tableau.Rows.Count > 1)
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                    }
                    bd.Open();
                    SqlTransaction transaction = bd.BeginTransaction();

                    try
                    {
                        //start check if there is enough stock
                        bool stockAvailableTableau = true;

                        for (int i = 0; i < tableau.Rows.Count - 1; i++)
                        {
                            string productCode = tableau.Rows[i].Cells[0].Value.ToString();
                            int quantitySold = Convert.ToInt32(tableau.Rows[i].Cells[4].Value);

                            // Check if there is enough stock for the product
                            SqlCommand cmd3 = new SqlCommand("select [stock] from produits where [n° reference]='" + productCode + "'", bd, transaction);
                            SqlDataReader rd2 = cmd3.ExecuteReader();
                            rd2.Read();
                            int currentStock = Convert.ToInt32(rd2.GetValue(0));
                            rd2.Close();
                            if (currentStock < quantitySold)
                            {
                                // Insufficient stock for tableau2, set the flag to false and exit the operation.
                                stockAvailableTableau = false;
                                break; // Exit the loop
                            }
                            else
                            {
                                // Sufficient stock is available; update the stock.
                                int newStock = currentStock - quantitySold;
                                SqlCommand cmd5 = new SqlCommand("update produits set [stock]='" + newStock.ToString() + "'where [n° reference]='" + productCode + "'", bd, transaction);
                                cmd5.ExecuteNonQuery();
                            }
                        }
                        if (!stockAvailableTableau)
                        {
                            MessageBox.Show("STOCK COMPOSANT INSUFFISANT.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //start inserting if stock available
                        else
                        {
                            SqlCommand cmd = new SqlCommand("insert into sortie_bon values('" + tdee.Text + "','" + txtnc.Text + "','" + ddee.Value.ToString() + "','" + cmbmdp.Text + "','" + " " + "','" + sp.Text + "','" + " " + "','" + 0 + "')", bd, transaction);
                            cmd.ExecuteNonQuery();
                            SqlCommand cmd1 = new SqlCommand("select max([n° sortieb]) from sortie_bon", bd, transaction);
                            SqlDataReader rd = cmd1.ExecuteReader();
                            rd.Read();
                            string nf = rd[0].ToString();
                            string nfb;
                            int tt = nf.Trim().Length;
                            if (tt == 1)
                            {
                                nfb = "00" + nf.Trim();
                            }
                            else if (tt == 2)
                            {
                                nfb = "0" + nf.Trim();
                            }
                            else
                            {
                                nfb = nf.Trim();
                            }
                            nfb = "HS - " + nfb.Trim() + "/" + ddee.Value.Year;
                            rd.Close();
                            SqlCommand cmb = new SqlCommand("update sortie_bon set nb='" + nfb + "' where [n° sortieb]='" + nf + "'", bd, transaction);
                            cmb.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand("select top(1) [n° sortieb] from [sortie_bon] order by [n° sortieb] desc", bd, transaction);
                            SqlDataReader rd1 = cmd2.ExecuteReader();
                            rd1.Read();
                            int ndee = Convert.ToInt32(rd1.GetValue(0));
                            rd1.Close();
                            for (int f = 0; f < tableau.Rows.Count - 1; f++)
                            {
                                // Insert into dsortie
                                SqlCommand cmd4 = new SqlCommand("insert into dsortie_bon values(" + ndee.ToString() + ",'" + tableau.Rows[f].Cells[0].Value + "','" + tableau.Rows[f].Cells[4].Value + "','" + tableau.Rows[f].Cells[5].Value + "','" + tableau.Rows[f].Cells[6].Value + "')", bd, transaction);
                                cmd4.ExecuteNonQuery();
                            }

                            int nl = 18;
                            Ex.Application app1 = new Ex.Application();
                            Ex.Workbooks books;
                            books = app1.Workbooks;
                            Ex.Workbook book;
                            book = books.Open(Environment.CurrentDirectory + "\\BON DE LIVRAISON.xlsx");
                            Ex._Worksheet ws = book.ActiveSheet;

                            ws.Cells[10, 3] = ddee.Value.Date;
                            ws.Cells[11, 3] = nfb;
                            ws.Cells[12, 3] = cmbmdp.Text;
                            ws.Cells[13, 3] = textBox1.Text;
                            ws.Cells[10, 8] = lblnc.Text;
                            ws.Cells[11, 8] = lblv.Text;
                            ws.Cells[12, 8] = lbla.Text;
                            ws.Cells[13, 8] = lblice.Text;
                            ws.Cells[38, 9] = re.Text;
                            ws.Cells[39, 9] = txtht.Text;
                            ws.Cells[43, 5] = txtttcc.Text;
                            for (int i = 0; i < tableau.Rows.Count - 1; i++)
                            {
                                ws.Cells[nl, 1] = tableau.Rows[i].Cells[1].Value.ToString() + "  " + tableau.Rows[i].Cells[2].Value.ToString().Trim() + "  " + tableau.Rows[i].Cells[3].Value.ToString().Trim();
                                ws.Cells[nl, 6] = tableau.Rows[i].Cells[5].Value.ToString();
                                ws.Cells[nl, 7] = tableau.Rows[i].Cells[4].Value.ToString();
                                ws.Cells[nl, 9] = tableau.Rows[i].Cells[6].Value.ToString();
                                nl++;
                            }

                            string pdffile = Environment.CurrentDirectory + "\\BON DE LIVRAISON\\" + nf + ".pdf";
                            string pdffile1 = dp + "\\BON DE LIVRAISON\\" + nf + ".pdf";
                            book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdffile);
                            book.Close(false);
                            app1.Quit();
                            // book.ExportAsFixedFormat(Ex.XlFixedFormatType.xlTypePDF, pdffile1);
                            System.Diagnostics.Process.Start(pdffile);

                            transaction.Commit();
                            bd.Close();
                            MessageBox.Show("ENREGISTREMENT EFFECTUE AVEC SUCCEES.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Nouveau_Click(sender, e);
                            re.ReadOnly = false;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        bd.Close();
                        MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void npro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bd.State == ConnectionState.Open)
            {
                bd.Close();
            }
            bd.Open();
            SqlCommand cmd = new SqlCommand("select*from produits where [n° reference]='" + npro.Text + "'", bd);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            nc.Text = rd.GetValue(2).ToString();
            color.Text = rd.GetValue(3).ToString();
            taille.Text = rd.GetValue(4).ToString();
            pah.Text = rd.GetValue(6).ToString();
            ttva.Text = rd.GetValue(7).ToString();
            bd.Close();
            qu.Select();
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
                            MessageBox.Show(" PRODUIT DEJA AJOUTER", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    tableau.Rows.Add(
                    npro.Text,
                    nc.Text,
                    color.Text,
                    taille.Text,
                    qu.Text,
                    qtec.Text,
                    pah.Text,
                    ttva.Text
                    ) ;
                    float m = float.Parse(pah.Text) * float.Parse(qu.Text);
                    txtht.Text = (float.Parse(txtht.Text) + m - float.Parse(re.Text)).ToString("0.00");
                    // txtht.Text = (float.Parse(txtht.Text) + m).ToString("0.00");                    
                    //txttva.Text = (float.Parse(txttva.Text) + float.Parse(txtht.Text)) .ToString("0.00");
                    if (tdee.SelectedIndex == 0)
                    {
                        txttva.Text = (float.Parse(txtht.Text) * float.Parse(ttva.Text) / 100).ToString("0.00");

                        txtttc.Text = (float.Parse(txtht.Text) + float.Parse(txttva.Text)).ToString("0.00");
                        //  txttva.Text = ((float.Parse(txtttc.Text) - (float.Parse(txtht.Text) )).ToString("0.00"));
                    }
                    npro.Text = ""; nc.Clear(); qu.Text = "0"; qtec.Text = "0"; pah.Clear(); ttva.Clear();color.Clear();taille.Clear();
                }
                else
                {
                    MessageBox.Show("SAISIE INCOMPLETE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch
            {
                MessageBox.Show("SAISIE INCORRECTE", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                    // Perform your delete logic here, for example:
                    // data source.Remove(row.DataBoundItem); // Adjust this line as per your data source
                    tableau.Rows.Remove(row);

                    float totalHt = 0.0f;

                    for (int i = 0; i < tableau.Rows.Count; i++)
                    {
                        if (tableau.Rows[i].Cells[2].Value != null && tableau.Rows[i].Cells[4].Value != null)
                        {
                            if (float.TryParse(tableau.Rows[i].Cells[2].Value.ToString(), out float value1) &&
                                float.TryParse(tableau.Rows[i].Cells[4].Value.ToString(), out float value2))
                            {
                                totalHt += value1 * value2;
                            }
                        }
                    }

                    txtht.Text = totalHt.ToString("0.00");

                    if (tdee.SelectedIndex == 0)
                    {
                        txttva.Text = (totalHt * 0.2).ToString("0.00");
                        txtttc.Text = (totalHt + float.Parse(txttva.Text)).ToString("0.00");
                    }
                }
            }

        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            lp x = new lp();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lc x = new lc();
            x.ShowDialog();
            x.WindowState = FormWindowState.Normal;
            int i = x.tableau.CurrentRow.Index;
            txtnc.Text = x.tableau.Rows[i].Cells[0].Value.ToString().Trim();
            npe.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
            lblnc.Text = x.tableau.Rows[i].Cells[1].Value.ToString().Trim();
            lblice.Text = x.tableau.Rows[i].Cells[3].Value.ToString().Trim();
            lblt.Text = x.tableau.Rows[i].Cells[4].Value.ToString().Trim();
            lblv.Text = x.tableau.Rows[i].Cells[6].Value.ToString().Trim();
            lble.Text = x.tableau.Rows[i].Cells[5].Value.ToString().Trim();
            lbla.Text = x.tableau.Rows[i].Cells[7].Value.ToString().Trim();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void re_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtht.Text = (float.Parse(txtht.Text) - float.Parse(re.Text)).ToString("0.00");
                if (tdee.SelectedIndex == 0)
                {
                    
                    txttva.Text = (float.Parse(txtht.Text) * 0.2).ToString("0.00");
                    txtttc.Text = (float.Parse(txtht.Text) + float.Parse(txttva.Text)).ToString("0.00");
                    //  txttva.Text = ((float.Parse(txtttc.Text) - (float.Parse(txtht.Text) )).ToString("0.00"));
                }
                re.Text = float.Parse(re.Text).ToString("0.00");
                re.ReadOnly = true;
                
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtttc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //re.Text = "0";
            if (re.Visible == false)
            {
                re.Visible = true;
            }
            else
                re.Visible = false;
        }

        private void txtttcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void re_TextChanged(object sender, EventArgs e)
        {

        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (tdee.SelectedIndex == 0)
            {
                float txtnum = float.Parse(txtttc.Text);
                double number = txtnum;
                string text = ConvertToWords(number); // "mille deux cent trente-quatre et cinquante-six centimes"
                txtttcc.Text = text;
            }
            else
            {
                float txtnum = float.Parse(txtht.Text);
                double number = txtnum;
                string text = ConvertToWords(number); // "mille deux cent trente-quatre et cinquante-six centimes"
                txtttcc.Text = text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bd.Open();
            if (tdee.SelectedIndex == 0)
            {
                nfap = (Microsoft.VisualBasic.Interaction.InputBox("N°Facture Rechercher", "HIBA SOCKS"));
                SqlCommand cmd = new SqlCommand("select * from sortie_facture where [n° sortief]='" + nfap.ToString() + "'", bd);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == false)
                {
                    MessageBox.Show("N° Facture  " + nfap.ToString() + "  n'existe pas");
                }
                else
                {
                    string pdffile = Environment.CurrentDirectory + "\\factures\\" + nfap + ".pdf";
                    System.Diagnostics.Process.Start(pdffile);
                }
                rd.Close();
            }
            else
            {
                nfap = (Microsoft.VisualBasic.Interaction.InputBox("N° BON Rechercher", "HIBA SOCKS"));
                SqlCommand cmd1 = new SqlCommand("select * from sortie_bon where [n° sortieb]='" + nfap.ToString() + "'", bd);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.HasRows == false)
                {
                    MessageBox.Show("N° BON  " + nfap.ToString() + "  n'existe pas");
                }
                else
                {
                    string pdffile = Environment.CurrentDirectory + "\\BON DE LIVRAISON\\" + nfap + ".pdf";
                    System.Diagnostics.Process.Start(pdffile);
                }
                rd1.Close();
            }
            bd.Close();
        }
    }
}  

