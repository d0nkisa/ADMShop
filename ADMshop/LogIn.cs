using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class LogInForm : Form
    {
        private HomeDAO homeDAO;

        public LogInForm()
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            this.homeDAO = new HomeDAO(context);
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
        }
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
                MessageBox.Show("metoda raboti");
                textBoxEmail.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            LogInForm.ActiveForm.Hide();
            SignUp reg = new SignUp();
            reg.Activate();
            reg.Show();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxEmail.Text, password = textBoxPassword.Text;
            CheckIfUserIsNull(username, password);
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}
