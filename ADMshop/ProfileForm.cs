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
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            currentuser = null;
            ProfileForm.ActiveForm.Close();
            LogInForm log = new LogInForm();
            log.Activate(); 
            log.Show();
        }

        private void editLabel_Click(object sender, EventArgs e)
        {

        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Close();
            HomeScreen home = new HomeScreen(currentuser);
            home.Activate(); 
            home.Show();
        }

        private void sellLabel_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate(); 
            postOffer.Show();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate(); 
            postOffer.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = currentuser.Firstname + " " + currentuser.Lastname;
            postedCountLabel.Text = currentuser.Offers.Count.ToString();
        }
    }
}
