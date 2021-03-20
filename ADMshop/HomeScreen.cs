using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ADMshop.Models;
using ADMshop.DAO;

namespace ADMshop
{
    public partial class HomeScreen : Form
    {
        Users currentuser;
        adm_dbContext context = default;
        public HomeScreen(Users Currentuser)
        {
            InitializeComponent();
            context = new adm_dbContext();
            offerDAO = new OfferDAO(context);
            currentuser = Currentuser;
        }
        private OfferDAO offerDAO;
        int page = 1;
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            picBoxOfferOne.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferTwo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferThree.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferFour.SizeMode = PictureBoxSizeMode.Zoom;
            LoadOffers();
        }
        private void SearchByCategoryBtn_Click(object sender, EventArgs e)
        {
            if (radioCars.Checked == true)
            {
                headerLabel.Text = "Cars";
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 200;
                pictureBox.Height = 200;

            }
            else if (radioSports.Checked == true)
            {
                headerLabel.Text = "Sports";
            }
            else if (radioElectronics.Checked == true)
            {
                headerLabel.Text = "Electronics";
            }
            else if (radioFurniture.Checked == true)
            {
                headerLabel.Text = "Furniture";
            }
        }

        private void sellLabel_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Close();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate(); postOffer.Show();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Close();
            ProfileForm profile = new ProfileForm(currentuser);
            profile.Activate(); profile.Show();
        }
        private void LoadOffers()
        {
            Offers offer1, offer2, offer3, offer4;
            try
            {
                offer1 = this.offerDAO.GetOfferById(page * 4 - 3);
                OfferOneTitle.Text = offer1.OfferHeading;
                picBoxOfferOne.Image = this.offerDAO.ByteToImage(offer1.Image);
                OfferOnePrice.Text = offer1.OfferPrice.ToString();

            }
            catch (Exception)
            {
                OfferOnePrice.Text = "";
                OfferOneTitle.Text = "";
            }
            try
            {
                offer2 = this.offerDAO.GetOfferById(page * 4 - 2);
                picBoxOfferTwo.Image = this.offerDAO.ByteToImage(offer2.Image);
                OfferTwoTitle.Text = offer2.OfferHeading;
                OfferTwoPrice.Text = offer2.OfferPrice.ToString();

            }
            catch (Exception)
            {
                OfferTwoPrice.Text = "";
                OfferTwoTitle.Text = "";
            }
            try
            {
                offer3 = this.offerDAO.GetOfferById(page * 4 - 1);
                picBoxOfferThree.Image = this.offerDAO.ByteToImage(offer3.Image);
                OfferThreeTitle.Text = offer3.OfferHeading;
                OfferThreePrice.Text = offer3.OfferPrice.ToString();

            }
            catch (Exception)
            {
                OfferThreePrice.Text = "";
                OfferThreeTitle.Text = "";
            }
            try
            {
                offer4 = this.offerDAO.GetOfferById(page * 4);
                picBoxOfferFour.Image = this.offerDAO.ByteToImage(offer4.Image);
                OfferFourTitle.Text = offer4.OfferHeading;
                OfferFourPrice.Text = offer4.OfferPrice.ToString();
            }
            catch (Exception)
            {
                OfferFourPrice.Text = "";
                OfferFourTitle.Text = "";
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (page != 1 && PreviousPage.Visible == false)
                PreviousPage.Show();

            if (page + 1 == this.offerDAO.OfferCount(context))
            {
                NextPage.Hide(); page++; LoadOffers();
            }
            else
            {
                page++;
                LoadOffers();
            }
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if (page != this.offerDAO.OfferCount(context) && NextPage.Visible == false)
                NextPage.Show();

            if (page - 1 == 1)
            {
                PreviousPage.Hide();
                page--;
                LoadOffers();
            }
            else
            {
                page--;
                LoadOffers();
            }
        }

        private void picBoxOfferOne_Click(object sender, EventArgs e)
        {

        }
    }
}
