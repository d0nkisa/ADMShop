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
        public HomeScreen(Users Currentuser)
        {
            InitializeComponent();
            currentuser = Currentuser;
        }

        private OfferDAO offerDAO;

        Offers offer = new Offers();
        List<Offers> SuggestedOfers = new List<Offers>();
        List<Offers> CarOffers = new List<Offers>();
        List<Offers> SportOffers = new List<Offers>();
        List<Offers> ElectronicsOffers = new List<Offers>();
        List<Offers> FurnitureOffers = new List<Offers>();

        private void SearchByCategoryBtn_Click(object sender, EventArgs e)
        {
            if (radioCars.Checked == true)
            {
                headerLabel.Text = "Cars";

                for (int i = 0; i < CarOffers.Count-1; i++)
                {

                }
            }
            else if (radioSports.Checked == true)
            {
                headerLabel.Text = "Sports";

                for (int i = 0; i < SportOffers.Count - 1; i++)
                {

                }
            }
            else if (radioElectronics.Checked == true)
            {
                headerLabel.Text = "Electronics";

                for (int i = 0; i < ElectronicsOffers.Count - 1; i++)
                {

                }
            }
            else if (radioFurniture.Checked == true)
            {
                headerLabel.Text = "Furniture";

                for (int i = 0; i < FurnitureOffers.Count - 1; i++)
                {

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate();postOffer.Show();
        }
    }
}
