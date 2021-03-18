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
        
        Users currentuser;
        public  byte[] ImageToByte(PictureBox img)
        {ImageConverter converter = new ImageConverter();
            Bitmap bmp=default;
            try
            {
                 bmp = (Bitmap)img.Image;

            }
            catch {
                MessageBox.Show("Please insert image");
            }
            return (byte[])converter.ConvertTo(bmp, typeof(byte[]));
        }

        public PostOffer(Users Currentuser)
        {
            InitializeComponent();
            currentuser = Currentuser;
            adm_dbContext context = new adm_dbContext();
            this.townDAO = new TownDAO(context);
            this.offerDAO = new OfferDAO(context);
            this.categoryDAO = new CategoryDAO(context);
            ID = this.offerDAO.OfferCount(context);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = new Bitmap(open.FileName);
                picture = pictureBox1;
                
            }
        }
        private static int ID;
        private OfferDAO offerDAO;
        private TownDAO townDAO;
        private CategoryDAO categoryDAO;
        private PictureBox picture;
        private void button1_Click(object sender, EventArgs e)
        {
            Offers newoffer = new Offers();
            newoffer.OfferHeading = textBoxName.Text;
            newoffer.OfferDescription = richTextBox1.Text;
            if (radioButton1.Checked == true) newoffer.ItemState = true;
            else newoffer.ItemState = false;
            newoffer.Town = this.townDAO.GetTown(comboTown.SelectedItem.ToString());
            newoffer.Category = this.categoryDAO.GetCategory(getCtg(comboCategory.SelectedItem.ToString())).Id;
            newoffer.OfferPrice = decimal.Parse(textBoxPrice.Text);
            newoffer.UserId = currentuser.UserId;
            newoffer.OfferId = ID+1;
            newoffer.Image = ImageToByte(picture);
            
            offerDAO.CreateOffer(newoffer);

        }
        private string getCtg(string name)
        {
            switch (name)
            {
                case "Cars & Parts":
                    return "Koli";
                case "Electronics":
                    return "Elektronika";
                case "Sport items":
                    return "Sport";
                case "Furniture":
                    return "Mebeli";

                default: return "Koli";

            }
        }

        private void PostOffer_Load(object sender, EventArgs e)
        {

        }
    }
}
