using ADMshop.DAO;
using ADMshop.Models;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ADMshop
{
    public partial class SignUp : Form
    {
        /// <summary>
        /// Деклариране на DAO-та, за връзка с базата данни;
        /// </summary>
        private static int ID;
        private HomeDAO homeDAO;
        private CountryDAO countryDAO;
        private TownDAO townDAO;
        private RoleDAO roleDAO;
        private Regex regexPass;
        private Regex regexNames;

        /// <summary>
        /// Конструктор;
        /// </summary>
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

        /// <summary>
        /// Проверява за стойностите на всичко въведено, ако има нещо неподходящо, 
        /// връща съобщение за грешка, а ако всичко е наред, връща съобщение, че потрнителя е 
        /// регистриран успешно и го връша във формата за логване;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerBtn_Click(object sender, EventArgs e)
        {
            regexPass = new Regex("^([a-zA-Z0-9])*$");
            regexNames = new Regex("^([a-zA-Z])*$");

            if (regexPass.IsMatch(tboxPassword.Text))
            {
                if (regexNames.IsMatch(tboxName.Text) && regexNames.IsMatch(tboxLast.Text))
                {
                    try
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
                        LogInForm log = new LogInForm();
                        log.Activate();
                        log.Show();
                    }
                    catch (Exception)
                    {
                        Exception ex = new Exception();
                        MessageBox.Show(ex.ToString());
                        tboxName.Text = "First Name";
                        tboxName.ForeColor = Color.Gray;
                        tboxLast.Text = "Last Name";
                        tboxLast.ForeColor = Color.Gray;
                        tboxPhone.Text = "Phone Number";
                        tboxPhone.ForeColor = Color.Gray;
                        tboxYears.Text = "Age";
                        tboxYears.ForeColor = Color.Gray;
                        tboxUsername.Text = "Username";
                        tboxUsername.ForeColor = Color.Gray;
                        tboxPassword.Text = "Password";
                        tboxPassword.ForeColor = Color.Gray;
                        comboCountry.Text = "Country";
                        comboCountry.ForeColor = Color.Gray;
                        comboTown.Text = "Town";
                        comboTown.ForeColor = Color.Gray;
                    }
                }
                else MessageBox.Show("Names only contain symbols from A to Z!");
            }
            else MessageBox.Show("Password cannot contains special symbols!");
        }
        /// <summary>
        /// При клик изпразва текст бокса за да може да се въвежда и 
        /// променя цвета на текста на черен;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            LogInForm log = new LogInForm();
            log.Activate(); 
            log.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Location = new Point(600, 250);
        }
    }
}