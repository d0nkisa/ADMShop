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

        private void label3_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate();postOffer.Show();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
