using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class OfferForm : Form
    {
        Users currentuser;

        private OfferDAO offerDAO;
        private Offers offer;

        int id;

        public OfferForm(Users Currentuser, int page)
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            currentuser = Currentuser;
            offerDAO = new OfferDAO(context);
            id = page;
            offer = offerDAO.GetOfferById(id);
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
            Location = new Point(600, 250);
            OfferImage.Image = this.offerDAO.ByteToImage(offer.Image);
            title.Text = offer.OfferHeading;
            price.Text = offer.OfferPrice + " " + "lv.";
            description.Size = new Size(271, 130);
            description.AutoSize = false;
            description.Text = "Description: \n" + offer.OfferDescription;
            fname.Text = offer.User.Firstname;
            phone.Text = offer.User.Phone.ToString();
        }
    }
}
