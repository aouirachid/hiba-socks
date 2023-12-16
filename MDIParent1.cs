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

namespace FD_STOCK
{
    public partial class MDIParent1 : Form
    {
        static string cons = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        SqlConnection bd = new SqlConnection(cons);
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
           

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            


            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void nclient_Click(object sender, EventArgs e)
        {
            nc a= new nc();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void lclient_Click(object sender, EventArgs e)
        {
            lc a = new lc();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nf a = new nf();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lf a = new lf();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouveauProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            np a = new np();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lp a = new lp();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouvelleEntréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ne a = new ne();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeEntréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            le a = new le();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouvelleSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ns a = new ns();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeSortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ls a = new ls();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void matiére1éreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouvelleMatiére1ÉreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nm a = new nm();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeMatiére1éreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lm a = new lm();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouvelleEntréeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nem a = new nem();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeEntréeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lem a = new lem();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouvelleSortieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nsm a = new nsm();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeSortieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lsm a = new lsm();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouveauEmballageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nemb a = new nemb();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeEmballageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lemb a = new lemb();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouvelleEntréeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            neemb a = new neemb();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeEntréeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            leemb a = new leemb();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void nouvelleSortieToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            nsemb a = new nsemb();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void listeSortieToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lsem a = new lsem();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void cli_Click(object sender, EventArgs e)
        {
            nc a = new nc();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
        }

        private void client_Click(object sender, EventArgs e)
        {
           




            //client.ForeColor = Color.FromArgb(42, 142, 193);

        }

        private void Q_Click(object sender, EventArgs e)
        {
            nc a = new nc();
            a.TopLevel = false;
            panelContent.Controls.Add(a);
            a.BringToFront();
            a.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entréeCaisseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
