
namespace ADMshop
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.comboTown = new System.Windows.Forms.ComboBox();
            this.tboxYears = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPhone = new System.Windows.Forms.TextBox();
            this.tboxLast = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCountry
            // 
            this.comboCountry.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboCountry.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Items.AddRange(new object[] {
            "Bulgaria",
            "Spain",
            "Germany",
            "Serbia",
            "France",
            "England",
            "Greece"});
            this.comboCountry.Location = new System.Drawing.Point(54, 342);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(100, 28);
            this.comboCountry.TabIndex = 16;
            this.comboCountry.Text = "Country";
            // 
            // comboTown
            // 
            this.comboTown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboTown.ForeColor = System.Drawing.SystemColors.GrayText;
            this.comboTown.FormattingEnabled = true;
            this.comboTown.Items.AddRange(new object[] {
            "Sofia",
            "Ruse",
            "Berlin",
            "Volos",
            "Serres",
            "Plovdiv",
            "Kragujevac",
            "Birmingham"});
            this.comboTown.Location = new System.Drawing.Point(197, 341);
            this.comboTown.Name = "comboTown";
            this.comboTown.Size = new System.Drawing.Size(100, 28);
            this.comboTown.TabIndex = 15;
            this.comboTown.Text = "Town";
            // 
            // tboxYears
            // 
            this.tboxYears.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxYears.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tboxYears.Location = new System.Drawing.Point(51, 285);
            this.tboxYears.Name = "tboxYears";
            this.tboxYears.Size = new System.Drawing.Size(66, 26);
            this.tboxYears.TabIndex = 14;
            this.tboxYears.Text = "Age...";
            this.tboxYears.Enter += new System.EventHandler(this.tboxYears_Enter);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tboxPassword.Location = new System.Drawing.Point(54, 459);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(243, 26);
            this.tboxPassword.TabIndex = 13;
            this.tboxPassword.Text = "Password...";
            this.tboxPassword.Enter += new System.EventHandler(this.tboxPassword_Enter);
            // 
            // tboxUsername
            // 
            this.tboxUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tboxUsername.Location = new System.Drawing.Point(54, 401);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(243, 26);
            this.tboxUsername.TabIndex = 11;
            this.tboxUsername.Text = "Username...";
            this.tboxUsername.Enter += new System.EventHandler(this.tboxUsername_Enter);
            // 
            // tboxPhone
            // 
            this.tboxPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxPhone.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tboxPhone.Location = new System.Drawing.Point(158, 285);
            this.tboxPhone.Name = "tboxPhone";
            this.tboxPhone.Size = new System.Drawing.Size(139, 26);
            this.tboxPhone.TabIndex = 12;
            this.tboxPhone.Text = "Phone number...";
            this.tboxPhone.Enter += new System.EventHandler(this.tboxPhone_Enter);
            // 
            // tboxLast
            // 
            this.tboxLast.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxLast.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tboxLast.Location = new System.Drawing.Point(197, 228);
            this.tboxLast.Name = "tboxLast";
            this.tboxLast.Size = new System.Drawing.Size(100, 26);
            this.tboxLast.TabIndex = 10;
            this.tboxLast.Text = "Last Name...";
            this.tboxLast.Enter += new System.EventHandler(this.tboxLast_Enter);
            // 
            // tboxName
            // 
            this.tboxName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tboxName.Location = new System.Drawing.Point(54, 228);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(100, 26);
            this.tboxName.TabIndex = 9;
            this.tboxName.Text = "First Name...";
            this.tboxName.Enter += new System.EventHandler(this.tboxName_Enter);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.registerBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(108, 522);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(129, 42);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 591);
            this.Controls.Add(this.comboCountry);
            this.Controls.Add(this.comboTown);
            this.Controls.Add(this.tboxYears);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.tboxPhone);
            this.Controls.Add(this.tboxLast);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.registerBtn);
            this.DoubleBuffered = true;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.ComboBox comboTown;
        private System.Windows.Forms.TextBox tboxYears;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPhone;
        private System.Windows.Forms.TextBox tboxLast;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Button registerBtn;
    }
}