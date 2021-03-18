using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            adm_dbContext context = new adm_dbContext();
            this.homeDAO = new HomeDAO(context);
            this.townDAO = new TownDAO(context);
            this.countryDAO = new CountryDAO(context);
            this.roleDAO = new RoleDAO(context);
            ID = this.homeDAO.GetID(context);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Users newuser = new Users(); 
            Login newlogin = new Login();

            newuser.Firstname = tboxName.Text; 
            newuser.Lastname = tboxLast.Text;
            newuser.Age = int.Parse(tboxYears.Text); 
            newuser.Phone = int.Parse(tboxPhone.Text);
            newuser.Country = this.countryDAO.GetCoutry(comboCountry.SelectedItem.ToString());
            newuser.Town = this.townDAO.GetTown(comboTown.SelectedItem.ToString());
            newuser.Role = this.roleDAO.GetRole("user");
            newlogin.Username = tboxUsername.Text; 
            newlogin.Pasword = this.homeDAO.HashPassword(tboxPassword.Text);
            
            newlogin.Users = newuser;

            newlogin.LoginId = ID + 1;
            newlogin.Users.UserId = ID + 1;

            homeDAO.RegisterUser(newlogin, newuser);

            MessageBox.Show("Successfuly created account! Go back to Log In!");

            SignUp.ActiveForm.Close();
            LogIn log = new LogIn();
            log.Activate();
            log.Show();
        }

        private static int ID;
        private HomeDAO homeDAO;
        private CountryDAO countryDAO;
        private TownDAO townDAO;
        private RoleDAO roleDAO;

        private void tboxName_Enter(object sender, EventArgs e)
        {
            if (tboxName.Text == "First Name...")
            {
                tboxName.Text = "";
                tboxName.ForeColor = Color.Black;
            }
        }

        private void tboxLast_Enter(object sender, EventArgs e)
        {
            if (tboxLast.Text == "Last Name...")
            {
                tboxLast.Text = "";
                tboxLast.ForeColor = Color.Black;
            }
        }

        private void tboxYears_Enter(object sender, EventArgs e)
        {
            if (tboxYears.Text == "Age...")
            {
                tboxYears.Text = "";
                tboxYears.ForeColor = Color.Black;
            }
        }

        private void tboxPhone_Enter(object sender, EventArgs e)
        {
            if (tboxPhone.Text == "Phone number...")
            {
                tboxPhone.Text = "";
                tboxPhone.ForeColor = Color.Black;
            }
        }

        private void tboxUsername_Enter(object sender, EventArgs e)
        {
            if (tboxUsername.Text == "Username...")
            {
                tboxUsername.Text = "";
                tboxUsername.ForeColor = Color.Black;
            }
        }

        private void tboxPassword_Enter(object sender, EventArgs e)
        {
            if (tboxPassword.Text == "Password...")
            {
                tboxPassword.Text = "";
                tboxPassword.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SignUp.ActiveForm.Close();
            LogIn log = new LogIn();
            log.Activate(); log.Show();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(1);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
