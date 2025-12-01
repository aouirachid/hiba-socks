using FD_STOCK.COMPOSANT;
using FD_STOCK.FOURNISSEUR;
using FD_STOCK.MACHINE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FD_STOCK
{
    public partial class menur : Form
    {
        public string uti = "admin";
        

        
        public menur()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {

            clientpanel.Visible = false;
            fournisseurpanel.Visible = false;
            produitpanel.Visible = false;
            machinepanel.Visible = false;
            articlepanel.Visible = false;
            salarierpanel.Visible = false;
            caissepanel.Visible = false;
            panelentreegeneral.Visible = false;
           
        }
        private void hideSubMenu()
        {

            if (clientpanel.Visible == true)
                clientpanel.Visible = false;
            if (fournisseurpanel.Visible == true)
                fournisseurpanel.Visible = false;
            if (produitpanel.Visible == true)
                produitpanel.Visible = false;
            if (machinepanel.Visible == true)
                machinepanel.Visible = false;
            if (articlepanel.Visible == true)
                articlepanel.Visible = false;
            if (salarierpanel.Visible == true)
                salarierpanel.Visible = false;
            if (caissepanel.Visible == true)
                caissepanel.Visible = false;
            if (panelentreegeneral.Visible == true)
                panelentreegeneral.Visible = false;
       
            
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void menur_Load(object sender, EventArgs e)
        {
            user.Text = uti;
        }
        
   

        private void btnPersonnel_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {
         
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            showSubMenu(salarierpanel);
        }

        private void btnPersonnel_Click_1(object sender, EventArgs e)
        {
            showSubMenu(clientpanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(fournisseurpanel);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            showSubMenu(machinepanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(articlepanel);
        }

        private void button21_Click(object sender, EventArgs e)
        {
          
        }

        private void button32_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNewPersonnel_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // nc a = new nc();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is nc)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            nc a = new nc();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
            
        }

        private void btnDetailPersonnel_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           // lc a = new lc();
           // a.TopLevel = false;
           // panelContent.Controls.Add(a);
           // a.BringToFront();
           // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is lc)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            lc a = new lc();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           // nf a = new nf();
           // a.TopLevel = false;
           // panelContent.Controls.Add(a);
           // a.BringToFront();
           // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is nf)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            nf a = new nf();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // lf a = new lf();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is lf)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            lf a = new lf();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
           
        }

        private void button26_Click(object sender, EventArgs e)
        {
           
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
           
        }

        private void button31_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           // nmach a = new nmach();
           // a.TopLevel = false;
           // panelContent.Controls.Add(a);
           // a.BringToFront();
           // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is nmach)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            nmach a = new nmach();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
        }

        private void button30_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // dmach a = new dmach();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is dmach)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            dmach a = new dmach();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           //  nart a = new nart();
           // a.TopLevel = false;
           // panelContent.Controls.Add(a);
           // a.BringToFront();
           // a.Show();

           // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is nart)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            nart a = new nart();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // la a = new la();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is la)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            la a = new la();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
           

        }

        private void button48_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
           
        }

        private void button42_Click(object sender, EventArgs e)
        {
           
        }

        private void button41_Click(object sender, EventArgs e)
        {
            

        }

        private void button40_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // dpers a = new dpers();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();


            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is dpers)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            dpers a = new dpers();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            hideSubMenu();
          //  ldpers a = new ldpers();
          //  a.TopLevel = false;
          //  panelContent.Controls.Add(a);
          // a.BringToFront();
          //  a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ldpers)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ldpers a = new ldpers();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
           
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
          

        }

        private void button45_Click(object sender, EventArgs e)
        {
            showSubMenu(produitpanel);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // np a = new np();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is np)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            np a = new np();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // lp a = new lp();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is lp)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            lp a = new lp();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // ne a = new ne();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ne)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ne a = new ne();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();
            a.epe.Text = uti;
            // Show the form.
            a.Show();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // le a = new le();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is le)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            le a = new le();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // ns a = new ns();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ns)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ns a = new ns();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();
            a.sp.Text = uti;
            // Show the form.
            a.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // ls a = new ls();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ls)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ls a = new ls();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            showSubMenu(caissepanel);
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // ca a = new ca();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ca)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ca a = new ca();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // cas a = new cas();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is cas)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            cas a = new cas();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            showSubMenu(panelentreegeneral);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // np a = new np();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is npg)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            npg a = new npg();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            // np a = new np();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is lpg)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            lpg a = new lpg();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
             regl a = new regl();
             a.TopLevel = false;
             panelContent.Controls.Add(a);
             a.BringToFront();
             a.Show();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // nf a = new nf();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is eg)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            eg a = new eg();
            
            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();
            a.epe.Text = uti;
            // Show the form.
            a.Show();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // nf a = new nf();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is leg)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            leg a = new leg();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
           
        }

        private void piecepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // nsemb a = new nsemb();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is sortieComposant)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            sortieComposant a = new sortieComposant();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();
            a.sp.Text = uti;

            // Show the form.
            a.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // lsem a = new lsem();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is listSortieComposant)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            listSortieComposant a = new listSortieComposant();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is regl)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            regl a = new regl();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // nf a = new nf();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ldf)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ldf a = new ldf();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // lmach a = new lmach();
            // a.TopLevel = false;
            //  panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is om)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            om a = new om();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // cas a = new cas();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ecc)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ecc a = new ecc();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // cas a = new cas();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is scc)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            scc a = new scc();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // cas a = new cas();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is dmrprog)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            dmrprog a = new dmrprog();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // cas a = new cas();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is utilisateur)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            utilisateur a = new utilisateur();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            // cas a = new cas();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is utilisateur)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            utilisateur a = new utilisateur();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(uti + " VOULEZ-VOUS QUITTER L'APPLICATION", "HIBA SOCKS", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
                conx x = new conx();
                x.StartPosition = FormStartPosition.CenterScreen;
                x.Show();
            }
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is consomationMachie)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            consomationMachie a = new consomationMachie();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();
            a.epe.Text = uti;

            // Show the form.
            a.Show();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is paymentFournisseur)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            paymentFournisseur a = new paymentFournisseur();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            hideSubMenu();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is regl)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            regl a = new regl();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            hideSubMenu();
            // nf a = new nf();
            // a.TopLevel = false;
            // panelContent.Controls.Add(a);
            // a.BringToFront();
            // a.Show();

            // Get the current form in the panelContent panel.
            Form currentForm = panelContent.Controls.OfType<Form>().FirstOrDefault();

            // If the current form is the form that the user wants to open, ignore the action.
            if (currentForm is ldf)
            {
                return;
            }

            // Close the current form if it is not null.
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Create a new instance of the form that the user wants to open.
            ldf a = new ldf();

            // Set the TopLevel property to false so that the form will be displayed in the panelContent panel.
            a.TopLevel = false;

            // Add the form to the panelContent panel.
            panelContent.Controls.Add(a);

            // Bring the form to the front of the panelContent panel.
            a.BringToFront();

            // Show the form.
            a.Show();
        }

        private void reglementpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
