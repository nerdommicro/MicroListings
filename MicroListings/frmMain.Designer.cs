namespace MicroListings
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPasteSKUs = new System.Windows.Forms.TextBox();
            this.cmbSKU = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPasteSKUs
            // 
            this.txtPasteSKUs.Location = new System.Drawing.Point(8, 20);
            this.txtPasteSKUs.Multiline = true;
            this.txtPasteSKUs.Name = "txtPasteSKUs";
            this.txtPasteSKUs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasteSKUs.Size = new System.Drawing.Size(120, 114);
            this.txtPasteSKUs.TabIndex = 0;
            this.txtPasteSKUs.Text = "A-TMSC35-1\r\nA-TMSC35-2\r\nA-TMSC35-4\r\nA-TMSC35-6\r\nA-TMSC35-8\r\nA-TMSC35-10\r\nA-TMSC35" +
    "-20\r\n";
            this.txtPasteSKUs.TextChanged += new System.EventHandler(this.txtPasteSKUs_TextChanged);
            // 
            // cmbSKU
            // 
            this.cmbSKU.FormattingEnabled = true;
            this.cmbSKU.Location = new System.Drawing.Point(134, 20);
            this.cmbSKU.Name = "cmbSKU";
            this.cmbSKU.Size = new System.Drawing.Size(122, 21);
            this.cmbSKU.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Paste SKUs Here";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(722, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select SKU to Edit";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSKU);
            this.Controls.Add(this.txtPasteSKUs);
            this.Name = "frmMain";
            this.Text = "Micro Listings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasteSKUs;
        private System.Windows.Forms.ComboBox cmbSKU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
    }
}

