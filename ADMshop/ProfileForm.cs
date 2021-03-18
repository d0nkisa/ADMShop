using ADMshop.Models;
using System;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class ProfileForm : Form
    {
        Users currentuser;
        public ProfileForm(Users Currentuser)
        {
            InitializeComponent();
            currentuser = Currentuser;
            usernameLabel.Text = Currentuser.Firstname + " " + Currentuser.Lastname;
            postedCountLabel.Text = Currentuser.Offers.Count.ToString();
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            currentuser = null;
            ProfileForm.ActiveForm.Close();
            LogIn log = new LogIn();
            log.Activate(); log.Show();
        }

        private void editLabel_Click(object sender, EventArgs e)
        {

        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Close();
            HomeScreen home = new HomeScreen(currentuser);
            home.Activate(); home.Show();
        }

        private void sellLabel_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate(); postOffer.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate(); postOffer.Show();
        }
    }
}
