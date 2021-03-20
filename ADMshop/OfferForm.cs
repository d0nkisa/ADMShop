using ADMshop.DAO;
using ADMshop.Models;
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
        Users currentuser;
        private OfferDAO offerDAO;
        private Offers offer;
        public OfferForm(Users Currentuser, int page,Offers offers)
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            currentuser = Currentuser;
            offerDAO = new OfferDAO(context);
            offer = offers;
        }

        private void goBackToHome_Click(object sender, EventArgs e)
        {
            OfferForm.ActiveForm.Close();
            HomeScreen home = new HomeScreen(currentuser);
            home.Activate();
            home.Show();
        }

        private void OfferForm_Load(object sender, EventArgs e)
        {
                OfferImage.Image = this.offerDAO.ByteToImage(offer.Image);
                title.Text = offer.OfferHeading;
                price.Text = offer.OfferPrice + " " + "lv.";
                description.Size = new Size(271, 130);
                description.AutoSize = false;
                description.Text = "Description: \n" + offer.OfferDescription;
                fname.Text = currentuser.Firstname;
                phone.Text = currentuser.Phone.ToString();
                location.Text = currentuser.Town + ", " + currentuser.Country;
        }
    }
}
