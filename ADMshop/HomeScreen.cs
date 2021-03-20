using ADMshop.DAO;
using ADMshop.Models;
using ADMshop.Properties;
using System.Linq;

namespace ADMshop
{
    public partial class HomeScreen : Form
    {
        /// <summary>
        /// Деклариране на променливи нужни за работа с методите и създаване на обект и DAO,
        /// което ни свързва с базата данни
        /// </summary>
        Users currentuser;
        adm_dbContext context = default;
        
        private Offers offer;
        private OfferDAO offerDAO;
        
        int page = 1;
        int id;

        /// <summary>
        /// Конструктор, инициализира се формата, подава се контекст на DAO-тата 
        /// към базата данни;
        /// </summary>
        /// <param name="Currentuser">Съдържа данни за текущия потребител</param>
        public HomeScreen(Users Currentuser)
        {
            InitializeComponent();
            context = new adm_dbContext();
            offerDAO = new OfferDAO(context);
            currentuser = Currentuser;
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
            picBoxOfferOne.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferTwo.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferThree.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxOfferFour.SizeMode = PictureBoxSizeMode.Zoom;
            LoadOffers(this.offerDAO.AllOffers());
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

        private void sellLabel_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Close();
            PostOffer postOffer = new PostOffer(currentuser);
            postOffer.Activate();
            postOffer.Show();
        }

        private void profileLabel_Click(object sender, EventArgs e)
        {
            HomeScreen.ActiveForm.Close();
            ProfileForm profile = new ProfileForm(currentuser);
            profile.Activate();
            profile.Show();
        }
        
         
        private List<Offers> SearchCheckBox()
        {  List<CheckBox> checkBoxes = new List<CheckBox>();
        List<Offers> offerticat = new List<Offers>();
        List<int> cat = new List<int>();
            int br = 1;
            checkBoxes.Add(checkBoxCars);
            checkBoxes.Add(checkBoxElectronics);
            checkBoxes.Add(checkBoxSport);
            checkBoxes.Add(checkBoxFurniture);          
            foreach (var item in checkBoxes)
            {
                if (item.Checked == true) { cat.Add(br); }
                br++;
            }           offerticat= this.offerDAO.GetOfferByCat(cat);
            if(cat.Count()==0) { return this.offerDAO.AllOffers(); }
            return offerticat;
        }
        private List<Offers> SearchName()
    {       List<Offers> offertiime = new List<Offers>();
            string heading = "";
                try
            {
                heading = searchBar.Text;
                if (searchBar.Text == "" || searchBar.Text == "Search ...") {
                    return this.offerDAO.AllOffers();
                }
                offertiime = this.offerDAO.SearchByName(heading);
            }
            catch
            {
                return this.offerDAO.AllOffers();
            }
            return offertiime;
        }
        private List<Offers> MixSearch()
        {
           var commons1 = from a in SearchName()
                                    join b in SearchCheckBox()
             on a.OfferHeading equals b.OfferHeading
                                    select a;
            return commons1.ToList();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadOffers(MixSearch());
        }
        public  void LoadOffers(List<Offers> offers)
        {
            
            Offers offer1, offer2, offer3, offer4;
            try
            {    
                offer1 = offers.ElementAt(page * 4 - 4);
                OfferOneTitle.Text = offer1.OfferHeading;
                picBoxOfferOne.Image = this.offerDAO.ByteToImage(offer1.Image);
                OfferOnePrice.Text = offer1.OfferPrice.ToString() + " lv.";

            }
            catch (Exception)
            {
                picBoxOfferOne.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferOnePrice.Text = "000 lv.";
                OfferOneTitle.Text = "no offer";
            }
            try
            {
                offer2 = offers.ElementAt(page * 4 - 3);
                picBoxOfferTwo.Image = this.offerDAO.ByteToImage(offer2.Image);
                OfferTwoTitle.Text = offer2.OfferHeading;
                OfferTwoPrice.Text = offer2.OfferPrice.ToString() + " lv.";

            }
            catch (Exception)
            {
                picBoxOfferTwo.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferTwoPrice.Text = "000 lv.";
                OfferTwoTitle.Text = "no offer";
            }
            try
            {
                offer3 = offers.ElementAt(page * 4 - 2);
                picBoxOfferThree.Image = this.offerDAO.ByteToImage(offer3.Image);
                OfferThreeTitle.Text = offer3.OfferHeading;
                OfferThreePrice.Text = offer3.OfferPrice.ToString() + " lv.";

            }
            catch (Exception)
            {
                picBoxOfferThree.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferThreePrice.Text = "000 lv.";
                OfferThreeTitle.Text = "no offer";
            }
            try
            {
                offer4 = offers.ElementAt(page * 4-1);
                picBoxOfferFour.Image = this.offerDAO.ByteToImage(offer4.Image);
                OfferFourTitle.Text = offer4.OfferHeading;
                OfferFourPrice.Text = offer4.OfferPrice.ToString() + " lv.";
            }
            catch (Exception)
            {
                picBoxOfferFour.Image = offerDAO.ByteToImage(Resources.no_photo);
                OfferFourPrice.Text = "000 lv.";
                OfferFourTitle.Text = "no offer";
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (page == MixSearch().Count() / 4)
            {
                NextPage.Hide(); 
                page++; LoadOffers(); 
                PreviousPage.Show();
            }
            else 
            { 
                page++; 
                LoadOffers(); 
                PreviousPage.Show();
            }
        }

        private void PreviousPage_Click(object sender, EventArgs e)
        {
            if (page == this.offerDAO.OfferCount(context) / 4 + 1) 
            { 
                NextPage.Show(); 
            }

            if (page - 1 == 1) 
            { 
                PreviousPage.Hide(); 
                page--; LoadOffers(); 
            }
            else 
            { 
                page--; 
                LoadOffers(); 
            }
        }

        private void picBoxOfferOne_Click(object sender, EventArgs e)
        {
            int id = page * 4 - 3;
            this.offerDAO.CheckIfOfferIsNull(offer, currentuser, id);
        }

        private void picBoxOfferTwo_Click(object sender, EventArgs e)
        {
            int id = page * 4 - 2;
            this.offerDAO.CheckIfOfferIsNull(offer, currentuser, id);
        }

        private void picBoxOfferThree_Click(object sender, EventArgs e)
        {
            int id = page * 4 - 1;
            this.offerDAO.CheckIfOfferIsNull(offer, currentuser, id);
        }

        private void picBoxOfferFour_Click(object sender, EventArgs e)
        {
            int id = page * 4;
            this.offerDAO.CheckIfOfferIsNull(offer, currentuser, id);
        }

        
    }
}
