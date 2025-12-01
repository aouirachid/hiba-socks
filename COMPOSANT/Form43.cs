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
using ClosedXML.Excel;

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

        private void f_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
