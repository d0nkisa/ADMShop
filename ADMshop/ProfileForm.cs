using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class ProfileForm : Form
    {
        /// <summary>
        /// Деклариране на променливи нужни за работа с методите;
        /// </summary>
        Users currentuser;
        private PictureBox ptofilePicture;
        private OfferDAO offerDAO;
        /// <summary>
        /// Конструктор;
        /// </summary>
        /// <param name="Currentuser"></param>
        public ProfileForm(Users Currentuser)
        {
            InitializeComponent();
            currentuser = Currentuser;
        }
        /// <summary>
        /// Изкарва потребителя от акаунта му и нулира променливата. която съдържа текущия
        /// потребител;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutLabel_Click(object sender, EventArgs e)
        {
            currentuser = null;
            ProfileForm.ActiveForm.Close();
            LogInForm log = new LogInForm();
            log.Activate();
            log.Show();
        }
        /// <summary>
        /// Отваря дилогов прозорец, чрез който потребителя може да си избере профилна снимка;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editLabel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    profilePicBox.SizeMode = PictureBoxSizeMode.Zoom;
                    profilePicBox.Image = new Bitmap(open.FileName);
                    ptofilePicture = profilePicBox;
                }
            }
            catch (Exception)
            {
                Exception ex = new Exception();
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// Връща потребителя в началната страница;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeLabel_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Close();
            HomeScreen home = new HomeScreen(currentuser);
            home.Activate();
            home.Show();
        }
        /// <summary>
        /// Отвежда потребителя към страницата за качване на обяви;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellLabel_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate();
            postOffer.Show();
        }
        /// <summary>
        /// Отвежда потребителя към страницата за качване на обяви;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sellBtn_Click(object sender, EventArgs e)
        {
            ProfileForm.ActiveForm.Hide();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate();
            postOffer.Show();
        }
        /// <summary>
        /// Задава задължително местоположение на формата, 
        /// подава стойности за името и профилната снимка;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
            usernameLabel.Text = currentuser.Firstname + " " + currentuser.Lastname;
            profilePicBox.Image = this.offerDAO.ByteToImage(currentuser.UserImage);
            postedCountLabel.Text = currentuser.Offers.Count.ToString();
        }
    }
}
