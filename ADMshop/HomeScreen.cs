using ADMshop.DAO;
using ADMshop.Models;
using ADMshop.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class HomeScreen : Form
    {
        Users currentuser;
        adm_dbContext context = default;

        private Offers offer;
        private OfferDAO offerDAO;

        int page = 1;
        int id;

        public HomeScreen(Users Currentuser)
        {
            InitializeComponent();
            context = new adm_dbContext();
            offerDAO = new OfferDAO(context);
            currentuser = Currentuser;
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
            picBoxOfferOne.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferTwo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferThree.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferFour.SizeMode = PictureBoxSizeMode.Zoom;
            LoadOffers();
        }

        private void sellLabel_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Close();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate();
            postOffer.Show();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Close();
            ProfileForm profile = new ProfileForm(currentuser);
            profile.Activate();
            profile.Show();
        }

        private void LoadOffers()
        {
            Offers offer1, offer2, offer3, offer4;
            try
            {
                offer1 = this.offerDAO.GetOfferById(page * 4 - 3);
                OfferOneTitle.Text = offer1.OfferHeading;
                picBoxOfferOne.Image = this.offerDAO.ByteToImage(offer1.Image);
                OfferOnePrice.Text = offer1.OfferPrice.ToString() + " lv.";

            }
            catch (Exception)
            {
                picBoxOfferOne.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferOnePrice.Text = "000 lv.";
                OfferOneTitle.Text = "no offer";
            }
            try
            {
                offer2 = this.offerDAO.GetOfferById(page * 4 - 2);
                picBoxOfferTwo.Image = this.offerDAO.ByteToImage(offer2.Image);
                OfferTwoTitle.Text = offer2.OfferHeading;
                OfferTwoPrice.Text = offer2.OfferPrice.ToString() + " lv.";

            }
            catch (Exception)
            {
                picBoxOfferTwo.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferTwoPrice.Text = "000 lv.";
                OfferTwoTitle.Text = "no offer";
            }
            try
            {
                offer3 = this.offerDAO.GetOfferById(page * 4 - 1);
                picBoxOfferThree.Image = this.offerDAO.ByteToImage(offer3.Image);
                OfferThreeTitle.Text = offer3.OfferHeading;
                OfferThreePrice.Text = offer3.OfferPrice.ToString() + " lv.";

            }
            catch (Exception)
            {
                picBoxOfferThree.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferThreePrice.Text = "000 lv.";
                OfferThreeTitle.Text = "no offer";
            }
            try
            {
                offer4 = this.offerDAO.GetOfferById(page * 4);
                picBoxOfferFour.Image = this.offerDAO.ByteToImage(offer4.Image);
                OfferFourTitle.Text = offer4.OfferHeading;
                OfferFourPrice.Text = offer4.OfferPrice.ToString() + " lv.";
            }
            catch (Exception)
            {
                picBoxOfferFour.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferFourPrice.Text = "000 lv.";
                OfferFourTitle.Text = "no offer";
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (page == this.offerDAO.OfferCount(context) / 4)
            {
                NextPage.Hide();
                page++; LoadOffers();
                PreviousPage.Show();
            }
            else
            {
                page++;
                LoadOffers();
                PreviousPage.Show();
            }
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if (page == this.offerDAO.OfferCount(context) / 4 + 1)
            {
                NextPage.Show();
            }

            if (page - 1 == 1)
            {
                PreviousPage.Hide();
                page--; LoadOffers();
            }
            else
            {
                page--;
                LoadOffers();
            }
        }

        private void picBoxOfferOne_Click(object sender, EventArgs e)
        {
            id = page * 4 - 3;
            this.offerDAO.CheckIfOfferIsNull(currentuser, id);
        }

        private void picBoxOfferTwo_Click(object sender, EventArgs e)
        {
            id = page * 4 - 2;
            this.offerDAO.CheckIfOfferIsNull(currentuser, id);
        }

        private void picBoxOfferThree_Click(object sender, EventArgs e)
        {
            id = page * 4 - 1;
            this.offerDAO.CheckIfOfferIsNull(currentuser, id);
        }

        private void picBoxOfferFour_Click(object sender, EventArgs e)
        {
            id = page * 4;
            this.offerDAO.CheckIfOfferIsNull(currentuser, id);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
