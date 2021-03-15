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
            newoffer.OfferHeading = textBoxName.Text;
            newoffer.OfferDescription = richTextBox1.Text;
            newoffer.Town = this.townDAO.GetTown(comboCategory.SelectedItem.ToString());
            if (radioButton1.Checked == true) newoffer.ItemState = true;
            else newoffer.ItemState = false;

            newoffer.Category = this.categoryDAO.GetCategory(comboCategory.SelectedItem.ToString()).Id;
            newoffer.OfferPrice = decimal.Parse(textBoxPrice.Text);
            this.offerDAO.CreateOffer(newoffer);

        }
        private OfferDAO offerDAO;
        private HomeDAO homeDAO;
        private TownDAO townDAO;
        private CategoryDAO categoryDAO;
    }
}
