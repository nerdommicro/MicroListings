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
            cmbSKU.Items.Clear();
            for (int i=-0; i < txtPasteSKUs.Lines.Count(); i++)
            {
                cmbSKU.Items.Add(txtPasteSKUs.Lines[i]);
                Globals.PRODUCTS = new string[]
            }
        }
    }
}
