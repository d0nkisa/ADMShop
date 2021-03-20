using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class PostOffer : Form
    {
        /// <summary>
        /// Деклариране на променливи нужни за работа с методите и създаване на обект и DAO- та,
        /// които ни свързват с базата данни;
        /// </summary>
        Users currentuser;
        private static int ID;
        private OfferDAO offerDAO;
        private TownDAO townDAO;
        private CategoryDAO categoryDAO;
        private PictureBox picture;

        /// <summary>
        /// Конструктор, инициализира се формата, подава се контекст на DAO-тата 
        /// към базата данни;
        /// </summary>
        /// <param name="Currentuser">Съдържа данни за текущия потребител</param>
        public PostOffer(Users Currentuser)
        {
            InitializeComponent();
            currentuser = Currentuser;
            adm_dbContext context = new adm_dbContext();
            this.townDAO = new TownDAO(context);
            this.offerDAO = new OfferDAO(context);
            this.categoryDAO = new CategoryDAO(context);
            ID = this.offerDAO.OfferCount(context);
        }
        /// <summary>
        /// Затваря формата за качване на обява и отваря списъка с качени обяви;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeLabel_Click(object sender, EventArgs e)
        {
            PostOffer.ActiveForm.Close();
            HomeScreen home = new HomeScreen(currentuser);
            home.Activate();
            home.Show();
        }
        /// <summary>
        /// Затваря формата за качване на обява, отваря профила на текущия потребител;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profileLabel_Click(object sender, EventArgs e)
        {
            PostOffer.ActiveForm.Close();
            ProfileForm prof = new ProfileForm(currentuser);
            prof.Activate();
            prof.Show();
        }
        /// <summary>
        /// Взема името на категорията от комбо бокса и връща аналога му за базата данни
        /// </summary>
        /// <param name="name">съдържа избрания елемент в комбо бокса</param>
        /// <returns>връша се съответната стойност</returns>
        private string getCtg(string name)
        {
            switch (name)
            {
                case "Cars & Parts":
                    return "Cars";
                case "Electronics":
                    return "Electronics";
                case "Sport items":
                    return "Sport";
                case "Furniture":
                    return "Furniture";

                default: return "Cars";

            }
        }
        /// <summary>
        /// Отваря диалогов прозорец от който да се избере снимка за обявата;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picOfTheOffer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picOfTheOffer.SizeMode = PictureBoxSizeMode.Zoom;
                picOfTheOffer.Image = new Bitmap(open.FileName);
                picture = picOfTheOffer;
            }
        }
        /// <summary>
        /// Разпределя четири обяви на началния екран, проверява дали има достатъчно обяви, ако
        /// няма празното място се запълва с празни обяви;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void postOfferButton_Click(object sender, EventArgs e)
        {
                Offers newoffer = new Offers();

                newoffer.OfferHeading = textBoxTitle.Text;
                newoffer.OfferDescription = richTextBox1.Text;

                if (radioButton1.Checked == true)
                    newoffer.ItemState = true;

                else newoffer.ItemState = false;

                newoffer.Town = this.townDAO.GetTown(comboTown.SelectedItem.ToString());
                newoffer.Category = this.categoryDAO.GetCategory(getCtg(comboCategory.SelectedItem.ToString())).Id;
                newoffer.OfferPrice = decimal.Parse(textBoxPrice.Text);
                newoffer.Image = this.offerDAO.ImageToByte(picture);
                newoffer.UserId = currentuser.UserId;
                newoffer.OfferId = ID + 1;

                offerDAO.CreateOffer(newoffer);

                MessageBox.Show("Your offer is successfuly posted in our app!");
                PostOffer.ActiveForm.Close();
                HomeScreen home = new HomeScreen(currentuser);
                home.Activate();
                home.Show();
        }
        /// <summary>
        /// Указва задължителното местоположение на формата при нейното зареждане;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PostOffer_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}