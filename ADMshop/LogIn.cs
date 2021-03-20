using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class LogInForm : Form
    {
        /// <summary>
        /// създаване на инстанция на обект от класа HomeDAO, с цел
        /// достъп на информация от базата данни
        /// </summary>
        private HomeDAO homeDAO;

        /// <summary>
        /// инициализация на формата, зануляване на текст боксовете,
        /// инстанция на базата данни и свързване на HomeDAO с базата
        /// </summary>
        public LogInForm()
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            this.homeDAO = new HomeDAO(context);
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }
        /// <summary>
        /// Използва се за проверка дали потребителя е нулев или съществуващ, 
        /// ако съществува такъв потребител се логваме и се отваря друга форма,
        /// в противен случай се показва съобщение за грешка.
        /// </summary>
        /// <param name="username">Потребителското име на потребителя;</param>
        /// <param name="password">Паролата на потребителя;</param>
        public void CheckIfUserIsNull(string username, string password)
        {
            var result = this.homeDAO.LogIn(username, password);
            if (result != null)
            {
                LogInForm.ActiveForm.Hide();
                HomeScreen home = new HomeScreen(this.homeDAO.LogIn(username, password));
                home.Activate();
                home.Show();
            }
            else
            {
                MessageBox.Show("Wrong creditentials! Try again!");
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
            }
        }
        /// <summary>
        /// Затваря LogInForm и отваря формата за регистрация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpLabel_Click(object sender, EventArgs e)
        {
            LogInForm.ActiveForm.Hide();
            SignUp reg = new SignUp();
            reg.Activate();
            reg.Show();
        }
        /// <summary>
        /// Взема стойностите от двата текст бокса и ги подава към метода за проверка и логване.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxEmail.Text, password = textBoxPassword.Text;
            CheckIfUserIsNull(username, password);
        }
        /// <summary>
        /// Затваря приложението
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
        /// <summary>
        /// Задава задължителна позиция на екрана за формата. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInForm_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}
