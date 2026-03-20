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
using System.Drawing.Printing;
using ZXing;
using ZXing.Common;

namespace FD_STOCK
{
    public partial class eg : Form
    {
        private Debouncer searchDebouncer = new Debouncer(500);
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        string printerName = ConfigurationManager.AppSettings["printerName"];
        public eg()
        {
            InitializeComponent();
        }

        // 1. Define a class to hold the ticket data temporarily
        public class TicketData
        {
            public string CompanyName { get; set; } = "Hiba socks";
            public string ComposantName { get; set; }
            public string Reference { get; set; }
            public string Quantity { get; set; }
            public string Date { get; set; }
            public string User { get; set; }
            public string Supplier { get; set; }
            public string BoxNumber { get; set; } // For Barcode
        }

        // Variable to hold data for the current print job
        private TicketData _currentTicket;

        private void PrintTicket(TicketData data)
        {
            _currentTicket = data;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ConstructTicketLayout);
            //pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 315, 315);
            // UNCOMMENT TO TEST 58mm width
            //pd.DefaultPageSettings.PaperSize = new PaperSize("SmallRoll", 228, 315);
            //pd.DefaultPageSettings.PaperSize = new PaperSize("SmallRoll", 236, 236);
            pd.DefaultPageSettings.PaperSize = new PaperSize("SmallRoll", 236, 260);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.Width = 600;
            preview.Height = 800;
            preview.ShowDialog();


            try
            {
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing Failed: " + ex.Message);
            }
        }

        private void DrawAlignedLineItem(Graphics g, string label, string value, Font labelFont, Font valueFont, float labelX, float valueX, ref float y)
        {
            // 1. Draw the Label (Left side)
            g.DrawString(label, labelFont, Brushes.Black, labelX, y);

            // 2. Draw the Value (Fixed position on the Right)
            g.DrawString(value, valueFont, Brushes.Black, valueX, y);

            // 3. Move down for the next line
            y += 20;
        }

        private void ConstructTicketLayout(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float pageWidth = e.PageBounds.Width;
            float yPos = 10;
            float leftMargin = 10;

            // This is the "Tab" position where all values will start aligned
            float valueXPosition = pageWidth * 0.40f;

            // Fonts
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 9, FontStyle.Regular);
            Font valueFont = new Font("Arial", 9, FontStyle.Bold); // Optional: Make values bold?

            StringFormat centerFormat = new StringFormat { Alignment = StringAlignment.Center };

            // --- 1. HEADERS (Centered) ---
            g.DrawString(_currentTicket.CompanyName, titleFont, Brushes.Black,
                new RectangleF(0, yPos, pageWidth, 30), centerFormat);
            yPos += 30;

            //g.DrawString(_currentTicket.ComposantName, headerFont, Brushes.Black,
            //    new RectangleF(0, yPos, pageWidth, 25), centerFormat);
            //yPos += 25;

            g.DrawLine(Pens.Black, leftMargin, yPos, pageWidth - leftMargin, yPos);
            yPos += 10;

            // --- 2. DETAILS (Aligned Columns) ---
            // We use the new helper method here
            DrawAlignedLineItem(g, "Référence:", _currentTicket.Reference, bodyFont, valueFont, leftMargin, valueXPosition, ref yPos);
            DrawAlignedLineItem(g, " Composant:", _currentTicket.ComposantName, bodyFont, valueFont, leftMargin, valueXPosition, ref yPos);
            DrawAlignedLineItem(g, "Quantité:", _currentTicket.Quantity, bodyFont, valueFont, leftMargin, valueXPosition, ref yPos);
            DrawAlignedLineItem(g, "Date:", _currentTicket.Date, bodyFont, valueFont, leftMargin, valueXPosition, ref yPos);
            DrawAlignedLineItem(g, "Entrée par:", _currentTicket.User, bodyFont, valueFont, leftMargin, valueXPosition, ref yPos);
            DrawAlignedLineItem(g, "Fournisseur:", _currentTicket.Supplier, bodyFont, valueFont, leftMargin, valueXPosition, ref yPos);

            yPos += 5;

            // --- 3. BARCODE (Centered) ---
            if (!string.IsNullOrEmpty(_currentTicket.BoxNumber))
            {
                Bitmap barcodeImg = GenerateBarcodeBitmap(_currentTicket.BoxNumber);
                if (barcodeImg != null)
                {
                    float barcodeWidth = pageWidth * 0.80f;
                    float barcodeHeight = 30;
                    float centerImageX = (pageWidth - barcodeWidth) / 2;

                    g.DrawImage(barcodeImg, centerImageX, yPos, barcodeWidth, barcodeHeight);

                    yPos += barcodeHeight + 5;
                    g.DrawString(_currentTicket.BoxNumber, bodyFont, Brushes.Black,
                        new RectangleF(0, yPos, pageWidth, 20), centerFormat);
                }
            }
        }

        // Helper to draw text lines clearly
        private void DrawLineItem(Graphics g, string label, string value, Font font, float x, ref float y)
        {
            g.DrawString($"{label} {value}", font, Brushes.Black, x, y);
            y += 20; // Move down for next line
        }

        // Adapted from your code to return a Bitmap directly
        private Bitmap GenerateBarcodeBitmap(string content)
        {
            try
            {
                var writer = new BarcodeWriterPixelData
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new EncodingOptions
                    {
                        Height = 30,
                        Width = 180,
                        Margin = 1,
                        PureBarcode = true
                    }
                };

                var pixelData = writer.Write(content);

                // Create bitmap from pixel data
                Bitmap bitmap = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height),
                    System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

                System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                bitmap.UnlockBits(bitmapData);

                return bitmap;
            }
            catch
            {
                return null; // Handle error or return empty
            }
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
                TicketData ticketToPrint = new TicketData
                {
                    ComposantName = nc.Text,      // Nom de composant
                    Reference = nRef.Text,        // Reference Number
                    Quantity = qu.Text,           // Quantity
                    Date = ddee.Value.ToString("dd/MM/yyyy"), // Date Entree
                    User = epe.Text,              // Entree par
                    Supplier = fo.Text,           // Fournisseur Name
                    BoxNumber = nBox.Text         // Barcode content
                };

                checkStatus();
                Enregistrer.Enabled = false;
                Ajouter_Click(sender, e);
                if (teg.Text != "" && tableau.Rows.Count > 1)
                {
                    bd.Open();
                    var targetBox = tableau.Rows[0].Cells[3].Value?.ToString();
                    string query = "SELECT COUNT(1) FROM dentreeg WHERE boxNumber = @boxNumber";
                    SqlCommand command = new SqlCommand(query, bd);
                    command.Parameters.AddWithValue("@boxNumber", targetBox);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        Nouveau_Click(sender, e);
                        MessageBox.Show("Box deja existe", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Stop execution because it exists
                    }

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
                    PrintTicket(ticketToPrint);
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
                if (bd.State == ConnectionState.Open) bd.Close();
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
            nf.Clear();
            fo.Clear();
            tableau.Rows.Clear();
            nRef.Select();
            Enregistrer.Enabled = true;
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
                nBox.Text = "EM-";
            }
            else if (teg.Text == "Matiére 1 ére")
            {
                nBox.Text = "MAT-";
            }
            else
            {
                nBox.Text = "PDR-";
            }
        }
    }
}
