using ADMshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADMshop.DAO;

namespace ADMshop
{
    public partial class PostOffer : Form
    {

        public PostOffer()
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = new Bitmap(open.FileName);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Offers newoffer = new Offers();
            newoffer.OfferHeading = textBox1.Text;
            newoffer.OfferDescription = richTextBox1.Text;
            

        }
    }
}
