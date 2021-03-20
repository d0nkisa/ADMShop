using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class OfferForm : Form
    {
        /// <summary>
        /// Деклариране на променливи нужни за работа с методите и създаване на обект и DAO,
        /// което ни свързва с базата данни
        /// </summary>
        Users currentuser;
        private OfferDAO offerDAO;
        private Offers offer;
        int id;

        /// <summary>
        /// Конструктор, инициализира се формата, подава се контекст на DAO-тата 
        /// към базата данни;
        /// </summary>
        /// <param name="Currentuser">Съдържа данни за текущия потребител</param>
        /// <param name="page">показва номера на текущата страница с обяви</param>
        public OfferForm(Users Currentuser, int page)
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            currentuser = Currentuser;
            offerDAO = new OfferDAO(context);
            id = page;
            offer = offerDAO.GetOfferById(id);
        }
        /// <summary>
        /// затваря обявата и се връща към списъка от обяви
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackToHome_Click(object sender, EventArgs e)
        {
            OfferForm.ActiveForm.Close();
            HomeScreen home = new HomeScreen(currentuser);
            home.Activate();
            home.Show();
        }
        /// <summary>
        /// при зареждане на формата, задава стойности на променливите, според
        /// това коя обява е избрана;
        /// Също така карантира точно определено местоположение на формата върху екрана;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
