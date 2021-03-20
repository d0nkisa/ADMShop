using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class PostOffer : Form
    {
        Users currentuser;

        private static int ID;
        private OfferDAO offerDAO;
        private TownDAO townDAO;
        private CategoryDAO categoryDAO;
        private PictureBox picture;

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

        private void homeLabel_Click(object sender, EventArgs e)
        {
            PostOffer.ActiveForm.Close();
            HomeScreen home = new HomeScreen(currentuser);
            home.Activate();
            home.Show();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            PostOffer.ActiveForm.Close();
            ProfileForm prof = new ProfileForm(currentuser);
            prof.Activate();
            prof.Show();
        }

        private string getCtg(string name)
        {
            switch (name)
            {
                case "Cars & Parts":
                    return "Cars";
                case "Electronics":
                    return "Electronics";
                case "Sport items":
                    return "Sport";
                case "Furniture":
                    return "Furniture";

                default: return "Cars";

            }
        }

        private void picOfTheOffer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picOfTheOffer.SizeMode = PictureBoxSizeMode.Zoom;
                picOfTheOffer.Image = new Bitmap(open.FileName);
                picture = picOfTheOffer;

            }
        }

        private void postOfferButton_Click(object sender, EventArgs e)
        {
            Offers newoffer = new Offers();

            newoffer.OfferHeading = textBoxName.Text;
            newoffer.OfferDescription = richTextBox1.Text;

            if (radioButton1.Checked == true)
                newoffer.ItemState = true;

            else newoffer.ItemState = false;

            newoffer.Town = this.townDAO.GetTown(comboTown.SelectedItem.ToString());
            newoffer.Category = this.categoryDAO.GetCategory(getCtg(comboCategory.SelectedItem.ToString())).Id;
            newoffer.OfferPrice = decimal.Parse(textBoxPrice.Text);
            newoffer.UserId = currentuser.UserId;
            newoffer.OfferId = ID + 1;
            newoffer.Image = this.offerDAO.ImageToByte(picture);

            offerDAO.CreateOffer(newoffer);
        }
    }
}
