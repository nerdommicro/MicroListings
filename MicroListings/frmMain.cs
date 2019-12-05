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
        }

        private void btnSaveSkus_Click(object sender, EventArgs e)
        {
            txtPasteSKUs.Enabled = false;
           listBoxSkus.Items.Clear();

          for (int i = 0; i < txtPasteSKUs.Lines.Count(); i++)
            {
               listBoxSkus.Items.Add(txtPasteSKUs.Lines[i]);
           }
            Globals.PRODUCTS = new string[txtPasteSKUs.Lines.Count(), 155];
        }

        private void btnPasteSkus_Click(object sender, EventArgs e)
        {
            txtPasteSKUs.Paste();
        }

        private void btnPastePrices_Click(object sender, EventArgs e)
        {
            txtPastePrices.Paste();
        }

        private void txtPastePrices_TextChanged(object sender, EventArgs e)
        {
            txtPastePrices.Text = txtPastePrices.Text.Replace("$", "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAll();
        }
        private void SaveAll()
        {

        }

        private void listBoxSkus_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveAll();
        }
    }
}
