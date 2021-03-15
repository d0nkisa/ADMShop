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
        public HomeScreen()
        {
            InitializeComponent();
        }

        private OfferDAO offerDAO;

        Offers[] SuggestedOfers = new Offers[4];
        Offers[] CarOffers = new Offers[4];
        Offers[] SportOffers = new Offers[4];
        Offers[] ElectronicsOffers = new Offers[4];
        Offers[] FurnitureOffers = new Offers[4];

        private void SearchByCategoryBtn_Click(object sender, EventArgs e)
        {
            if (radioCars.Checked == true)
            {
                headerLabel.Text = "Cars";

                for (int i = 0; i < CarOffers.Length-1; i++)
                {

                }
            }
            if (radioSports.Checked == true)
            {
                headerLabel.Text = "Sports";

                for (int i = 0; i < SportOffers.Length - 1; i++)
                {

                }
            }
            if (radioElectronics.Checked == true)
            {
                headerLabel.Text = "Electronics";

                for (int i = 0; i < ElectronicsOffers.Length - 1; i++)
                {

                }
            }
            if (radioFurniture.Checked == true)
            {
                headerLabel.Text = "Furniture";

                for (int i = 0; i < FurnitureOffers.Length - 1; i++)
                {

                }
            }
        }
    }
}
