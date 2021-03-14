using ADMshop.Models;
using ADMshop.DAO;
using System;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            this.homeDAO = new HomeDAO(context);
        }

        private HomeDAO homeDAO;

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxEmail.Text, password = textBoxPassword.Text;
            this.homeDAO.LogIn(username, password);
        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {
            LogIn.ActiveForm.Hide();
            SignUp reg = new SignUp();
            reg.Activate(); reg.Show();
        }
    }
}
