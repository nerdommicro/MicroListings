﻿using System;
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
            treeView1.Nodes.Clear();
            txtPasteSKUs.Enabled = false;
            listBoxSkus.Items.Clear();
            int numSkus = txtPasteSKUs.Lines.Count();
            Globals.SKUS = new string[numSkus];
            Globals.ITEM_NAMES = new string[numSkus];
            Globals.QUANTITIES = new string[numSkus];
            Globals.PRICES = new string[numSkus];
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
            Globals.SIZENAMES = new string[numSkus];
            Globals.COLORNAMES = new string[numSkus];
            Globals.STYLENAMES = new string[numSkus];

            btnSaveSkus.Enabled = false;

              for (int i = 0; i < txtPasteSKUs.Lines.Count(); i++)
                {
                   listBoxSkus.Items.Add(txtPasteSKUs.Lines[i]);
                    Globals.SKUS[i] = txtPasteSKUs.Lines[i];                 

                }
            listBoxSkus.SelectedIndex = 0;
           
        } 

        private void txtPastePrices_TextChanged(object sender, EventArgs e)
        {
            txtPrices.Text = txtPrices.Text.Replace("$", "");
        }

       
        private void SaveAll()
        {
            for (int i = 0; i < txtPasteSKUs.Lines.Count(); i++)
            {
                try
                {
                    if (!(txtItemNames.Text == "")) Globals.ITEM_NAMES[i] = txtItemNames.Lines[i];
                }
                catch { }
            }
            if (listBoxSkus.SelectedIndex > -1)
            {
                for (int i = 0; i < txtPasteSKUs.Lines.Count() - 1; i++)
                {
                    if (!(txtPrices.Text == "")) Globals.PRICES[i] = txtPrices.Lines[i];
                    if (!(txtQuantities.Text == "")) Globals.QUANTITIES[i] = txtQuantities.Lines[i];
                    if (!(txtSizeNames.Text == "")) Globals.SIZENAMES[i] = txtSizeNames.Lines[i];
                    if (!(txtStyleNames.Text == "")) Globals.STYLENAMES[i] = txtStyleNames.Lines[i];
                    if (!(txtColorNames.Text == "")) Globals.COLORNAMES[i] = txtColorNames.Lines[i];
                    if (!(txtDescription.Text=="")) Globals.DESCRIPTIONS[i] = txtDescription.Text;
                }

                if (!(txtBullets.Text == ""))
                {
                    try
                    {
                        Globals.BULLET1[listBoxSkus.SelectedIndex] = txtBullets.Lines[0];
                        Globals.BULLET2[listBoxSkus.SelectedIndex] = txtBullets.Lines[1];
                        Globals.BULLET3[listBoxSkus.SelectedIndex] = txtBullets.Lines[2];
                        Globals.BULLET4[listBoxSkus.SelectedIndex] = txtBullets.Lines[3];
                        Globals.BULLET5[listBoxSkus.SelectedIndex] = txtBullets.Lines[4];
                    }
                    catch { }
                    try
                    {
                        
                    }
                    catch { }
                }
               
                Globals.IMAGE1[listBoxSkus.SelectedIndex] = txtImage1.Text;
                Globals.IMAGE2[listBoxSkus.SelectedIndex] = txtImage2.Text;
                Globals.IMAGE3[listBoxSkus.SelectedIndex] = txtImage3.Text;
                Globals.IMAGE4[listBoxSkus.SelectedIndex] = txtImage4.Text;
                Globals.IMAGE5[listBoxSkus.SelectedIndex] = txtImage5.Text;
                Globals.IMAGE6[listBoxSkus.SelectedIndex] = txtImage6.Text;
                Globals.IMAGE7[listBoxSkus.SelectedIndex] = txtImage7.Text;
                Globals.IMAGE8[listBoxSkus.SelectedIndex] = txtImage8.Text;
                Globals.RELATIONSHIP_TYPE[listBoxSkus.SelectedIndex] = txtRelationshipType.Text;
                Globals.PARENT_CHILD[listBoxSkus.SelectedIndex] = txtParentChild.Text;
                Globals.PARENT_SKU[listBoxSkus.SelectedIndex] = txtParentSku.Text;

               AddTreeNodes();
            }
    }

     
        private void listBoxSkus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = "Micro Listings " + Convert.ToString(listBoxSkus.SelectedItem);            

        }
             
        private void AddTreeNodes()    
        
        {
            treeView1.Nodes.Clear();
            for (int i = 0; i < txtPasteSKUs.Lines.Count(); i++)
            {
                treeView1.Nodes.Add(Globals.SKUS[i]);
            }

            for (int i = 0; i < txtPasteSKUs.Lines.Count(); i++)
            {
                if (!(txtItemNames.Text == "")) treeView1.Nodes[i].Nodes.Add(Globals.ITEM_NAMES[i]);
            }
            
            for (int i = 0; i < txtPasteSKUs.Lines.Count() - 1; i++)
            {
                if (!(txtPrices.Text == "")) treeView1.Nodes[i + 1].Nodes.Add(Globals.PRICES[i]);
                if (!(txtQuantities.Text == "")) treeView1.Nodes[i + 1].Nodes.Add(Globals.QUANTITIES[i]);
                if (!(txtBullets.Text == ""))
                    try
                    {
                        treeView1.Nodes[i + 1].Nodes.Add(Globals.BULLET1[i]);
                        treeView1.Nodes[i + 1].Nodes.Add(Globals.BULLET2[i]);
                        treeView1.Nodes[i + 1].Nodes.Add(Globals.BULLET3[i]);
                        treeView1.Nodes[i + 1].Nodes.Add(Globals.BULLET4[i]);
                        treeView1.Nodes[i + 1].Nodes.Add(Globals.BULLET5[i]);
                    }
                    catch
                    { }


            }


        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            SaveAll();
        }

        private void btnSaveItemDesc_Click(object sender, EventArgs e)
        {
            Globals.DESCRIPTIONS[listBoxSkus.SelectedIndex] = txtDescription.Text;        

                if (!(txtBullets.Text == ""))
                {
                    try
                    {
                        Globals.BULLET1[listBoxSkus.SelectedIndex] = txtBullets.Lines[0];
                        Globals.BULLET2[listBoxSkus.SelectedIndex] = txtBullets.Lines[1];
                        Globals.BULLET3[listBoxSkus.SelectedIndex] = txtBullets.Lines[2];
                        Globals.BULLET4[listBoxSkus.SelectedIndex] = txtBullets.Lines[3];
                        Globals.BULLET5[listBoxSkus.SelectedIndex] = txtBullets.Lines[4];
                    }
                    catch { }
                   
                }
            AddTreeNodes();
        }
    }
}
