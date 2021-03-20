using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class LogIn : Form
    {
        private HomeDAO homeDAO;

        public LogIn()
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            this.homeDAO = new HomeDAO(context);
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            LogIn.ActiveForm.Hide();
            SignUp reg = new SignUp();
            reg.Activate();
            reg.Show();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxEmail.Text, password = textBoxPassword.Text;
            LogIn.ActiveForm.Hide();
            HomeScreen home = new HomeScreen(this.homeDAO.LogIn(username, password));
            home.Activate();
            home.Show();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
