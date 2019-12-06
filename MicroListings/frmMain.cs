using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroListings
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtPasteSKUs_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEditSkus_Click(object sender, EventArgs e)
        {
            txtPasteSKUs.Enabled = true;
            btnSaveSkus.Enabled = true;
        }

        private void btnSaveSkus_Click(object sender, EventArgs e)
        {
            txtPasteSKUs.Enabled = false;
            listBoxSkus.Items.Clear();
            int numSkus = txtPasteSKUs.Lines.Count();
            Globals.SKUS = new string[numSkus];
            Globals.ITEM_NAMES = new string[numSkus];
            Globals.QUANTITIES = new string[numSkus]; 
            Globals.DESCRIPTIONS = new string[numSkus]; 
            Globals.BULLET1 = new string[numSkus]; 
            Globals.BULLET2 = new string[numSkus]; 
            Globals.BULLET3 = new string[numSkus]; 
            Globals.BULLET4 = new string[numSkus]; 
            Globals.BULLET5 = new string[numSkus]; 
            Globals.IMAGE1 = new string[numSkus]; 
            Globals.IMAGE2 = new string[numSkus]; 
            Globals.IMAGE3 = new string[numSkus]; 
            Globals.IMAGE4 = new string[numSkus]; 
            Globals.IMAGE5 = new string[numSkus]; 
            Globals.IMAGE6 = new string[numSkus]; 
            Globals.IMAGE7 = new string[numSkus]; 
            Globals.IMAGE8 = new string[numSkus];
            Globals.RELATIONSHIP_TYPE = new string[numSkus];
            Globals.PARENT_CHILD = new string[numSkus];
            Globals.PARENT_SKU = new string[numSkus];



            btnSaveSkus.Enabled = false;

              for (int i = 0; i < txtPasteSKUs.Lines.Count(); i++)
                {
                   listBoxSkus.Items.Add(txtPasteSKUs.Lines[i]);
                    Globals.SKUS[i] = txtPasteSKUs.Lines[i];
                }
           
        } 

        private void txtPastePrices_TextChanged(object sender, EventArgs e)
        {
            txtPrices.Text = txtPrices.Text.Replace("$", "");
        }

       
       private void SaveAll()
        {

            for (int i = 0; i < txtPasteSKUs.Lines.Count(); i++)
            {
                Globals.ITEM_NAMES[i] = txtItemNames.Lines[i];
                Globals.QUANTITIES[i] = txtQuantities.Lines[i];
                Globals.PRICES[i] = txtPrices.Lines[i];
                Globals.DESCRIPTIONS[i] = txtDescripton.Text;

            }            
           
            Globals.BULLET1[listBoxSkus.SelectedIndex] = txtBullets.Lines[0];
            Globals.BULLET2[listBoxSkus.SelectedIndex] = txtBullets.Lines[1];
            Globals.BULLET3[listBoxSkus.SelectedIndex] = txtBullets.Lines[2];
            Globals.BULLET4[listBoxSkus.SelectedIndex] = txtBullets.Lines[3];
            Globals.BULLET5[listBoxSkus.SelectedIndex] = txtBullets.Lines[4];

            Globals.IMAGE1[listBoxSkus.SelectedIndex] = txtImage1.Text;
            Globals.IMAGE2[listBoxSkus.SelectedIndex] = txtImage2.Text;
            Globals.IMAGE3[listBoxSkus.SelectedIndex] = txtImage3.Text;
            Globals.IMAGE4[listBoxSkus.SelectedIndex] = txtImage4.Text;
            Globals.IMAGE5[listBoxSkus.SelectedIndex] = txtImage5.Text;
            Globals.IMAGE6[listBoxSkus.SelectedIndex] = txtImage6.Text;
            Globals.IMAGE7[listBoxSkus.SelectedIndex] = txtImage7.Text;
            Globals.IMAGE8[listBoxSkus.SelectedIndex] = txtImage8.Text;
            Globals.RELATIONSHIP_TYPE[listBoxSkus.SelectedIndex] = txtRelationshipType.Text ;
            Globals.PARENT_CHILD[listBoxSkus.SelectedIndex]=txtParentChild.Text;
            Globals.PARENT_SKU[listBoxSkus.SelectedIndex] = txtParentSku.Text;


    }

        private void listBoxSkus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Micro Listings " + Convert.ToString(listBoxSkus.SelectedItem);
            SaveAll();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SaveAll();
        }
    }
}
