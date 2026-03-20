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
using System.Drawing.Imaging;
using System.IO;
using ClosedXML.Excel;
using ZXing;
using ZXing.Common;
using ClosedXML.Excel.Drawings;

namespace FD_STOCK
{
    public partial class lpg : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        public lpg()
        {
            InitializeComponent();
        }

        private void lpg_Load(object sender, EventArgs e)
        {
            bd.Open();
            Remplir();
        }
        private void Remplir()
        {
            if (bd.State == ConnectionState.Closed)
            {
                bd.Open();
            }


            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from composant", bd);
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
                        rd[6]
                        );
                }
                rd.Close();
            }

            bd.Close();


        }

        private void rec_TextChanged(object sender, EventArgs e)
        {
            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from composant where [nom article] like '" + rec.Text + "%' and [type article] like '" + rec1.Text + "%' ", bd);
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
                        rd[6]
                    );
            }
            bd.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            bd.Open();
            tableau.Rows.Clear();
            SqlCommand cmd = new SqlCommand("select * from composant where [type article] like '" + rec1.Text + "%' and [nom article] like '" + rec.Text + "%' ", bd);
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
                        rd[6]
                    );
            }
            bd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable ExportDataGridViewToDataTable(DataGridView dgv)
        {
            var dt = new DataTable();

            // Add columns
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType ?? typeof(string));
            }

            // Add rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dataRow = dt.NewRow();
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        dataRow[column.HeaderText] = row.Cells[column.Index].Value ?? DBNull.Value;
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string fileName = "";
            string dateSuffix = DateTime.Now.ToString("yyyyMMdd_HHmm");
            string ComposantType = rec1.Text.Trim();
            if (string.IsNullOrEmpty(ComposantType))
            {
                fileName = $" LISTE_COMPOSANT_{dateSuffix}.xlsx";
            }
            else
            {
                fileName = $" LISTE_COMPOSANT_{ComposantType}_{dateSuffix}.xlsx";
            }          

            const string root = "DMRproduction";
            string myDocsRoot = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                root);
            string appRoot = Path.Combine(Environment.CurrentDirectory, root);

            string excelFolder = Path.Combine(myDocsRoot, "LISTE COMPOSANT");
            string excelFolderBak = Path.Combine(appRoot, "LISTE COMPOSANT");

            foreach (var dir in new[] { excelFolder, excelFolderBak })
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);


            string filePath = Path.Combine(excelFolder, fileName);
            string filePathBak = Path.Combine(excelFolderBak, fileName);



            using (var workbook = new XLWorkbook())
            {

                var ListComposant = ExportDataGridViewToDataTable(tableau);
                workbook.Worksheets.Add(ListComposant, "LISTE COMPOSANT");

                workbook.SaveAs(filePath);
                workbook.SaveAs(filePathBak);
                MessageBox.Show("EXPORTER AVEC SUCCE.", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private DataTable ExportSelectedCellsToDataTable(DataGridView dgv, int[] columnIndexesToExport)
        {
            var dt = new DataTable();

            // Add only the selected columns
            foreach (int colIndex in columnIndexesToExport)
            {
                var column = dgv.Columns[colIndex];
                dt.Columns.Add(column.HeaderText, column.ValueType ?? typeof(string));
            }

            // Add rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dataRow = dt.NewRow();
                    foreach (int colIndex in columnIndexesToExport)
                    {
                        dataRow[dgv.Columns[colIndex].HeaderText] = row.Cells[colIndex].Value ?? DBNull.Value;
                    }
                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }

        private void ExportDataTableToExcelWithBarcode(DataTable dt, int referenceColumnIndex)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("LISTE COMPOSANT");

                // Add headers
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    ws.Cell(1, c + 1).Value = dt.Columns[c].ColumnName;
                }

                int barcodeColIndex = dt.Columns.Count + 1; // Insert barcode in next column
                ws.Cell(1, barcodeColIndex).Value = "BARCODE";

                // ZXing barcode writer
                var writer = new BarcodeWriterPixelData
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new EncodingOptions
                    {
                        Height = 60,
                        Width = 180,
                        Margin = 1,
                        PureBarcode = true
                    }
                };

                // Add data + barcodes
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // Fill the row with selected cells
                    for (int c = 0; c < dt.Columns.Count; c++)
                    {
                        var cellValue = dt.Rows[i][c] == DBNull.Value ? "" : dt.Rows[i][c].ToString();
                        ws.Cell(i + 2, c + 1).Value = cellValue;
                    }

                    // Sanitize reference value for Code128
                    string referenceValue = dt.Rows[i][referenceColumnIndex]?.ToString().Trim();
                    referenceValue = SanitizeForCode128(referenceValue);

                    if (!string.IsNullOrEmpty(referenceValue))
                    {
                        var pixelData = writer.Write(referenceValue);

                        using (Bitmap barcodeBitmap = new Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb))
                        {
                            var bitmapData = barcodeBitmap.LockBits(
                                new Rectangle(0, 0, pixelData.Width, pixelData.Height),
                                ImageLockMode.WriteOnly,
                                PixelFormat.Format32bppRgb);

                            try
                            {
                                System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                            }
                            finally
                            {
                                barcodeBitmap.UnlockBits(bitmapData);
                            }

                            using (var ms = new MemoryStream())
                            {
                                barcodeBitmap.Save(ms, ImageFormat.Png);
                                ms.Position = 0;

                                ws.AddPicture(ms, XLPictureFormat.Png)
                                  .MoveTo(ws.Cell(i + 2, barcodeColIndex))
                                  .WithSize(180, 60);
                            }
                        }
                    }

                    ws.Row(i + 2).Height = 60; // Set row height to fit barcode
                }

                ws.Columns().AdjustToContents(); // Auto-fit columns
                ws.Column(barcodeColIndex).Width = 25; // Adjust barcode column width

                // Save file
                string fileName = "";
                string dateSuffix = DateTime.Now.ToString("yyyyMMdd_HHmm");
                string ComposantType = rec1.Text.Trim();
                if (string.IsNullOrEmpty(ComposantType))
                {
                    fileName = $" LISTE_COMPOSANT_AVEC_CODE_BAR_{dateSuffix}.xlsx";
                }
                else
                {
                    fileName = $" LISTE_COMPOSANT_AVEC_CODE_BAR_{ComposantType}_{dateSuffix}.xlsx";
                }

                const string root = "DMRproduction";
                string myDocsRoot = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    root);
                string appRoot = Path.Combine(Environment.CurrentDirectory, root);

                string excelFolder = Path.Combine(myDocsRoot, "LISTE COMPOSANT AVEC CODE BAR");
                string excelFolderBak = Path.Combine(appRoot, "LISTE COMPOSANT AVEC CODE BAR");

                foreach (var dir in new[] { excelFolder, excelFolderBak })
                    if (!Directory.Exists(dir))
                        Directory.CreateDirectory(dir);


                string filePath = Path.Combine(excelFolder, fileName);
                string filePathBak = Path.Combine(excelFolderBak, fileName);

                workbook.SaveAs(filePath);
                workbook.SaveAs(filePathBak);

                MessageBox.Show("EXPORTER AVEC SUCCÈS !", "HIBA SOCKS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string SanitizeForCode128(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";

            // Keep only valid ASCII characters (0–127)
            return new string(input.Where(c => c <= 127).ToArray());
        }

        private void exportBarCode_Click(object sender, EventArgs e)
        {
            int[] columnsToExport = { 0, 1, 3, 4 }; // Only these cells
            DataTable dt = ExportSelectedCellsToDataTable(tableau, columnsToExport);

            int referenceColumnIndexInDataTable = 2; // index of reference in your selected columns
            ExportDataTableToExcelWithBarcode(dt, referenceColumnIndexInDataTable);
        }
        
        
    }
}
