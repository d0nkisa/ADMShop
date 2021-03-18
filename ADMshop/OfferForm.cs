using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class OfferForm : Form
    {
        public OfferForm()
        {
            InitializeComponent();
        }

        private void OfferForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
