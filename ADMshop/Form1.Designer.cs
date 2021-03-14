
namespace ADMshop
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.signUpLabel = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signUpLabel
            // 
            this.signUpLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.signUpLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.signUpLabel.ForeColor = System.Drawing.Color.White;
            this.signUpLabel.Location = new System.Drawing.Point(71, 549);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(219, 17);
            this.signUpLabel.TabIndex = 9;
            this.signUpLabel.Text = "Do not have an account? Sign up ...";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.LogInBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInBtn.ForeColor = System.Drawing.Color.White;
            this.LogInBtn.Location = new System.Drawing.Point(113, 486);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(128, 47);
            this.LogInBtn.TabIndex = 8;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.LogInBtn.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(87, 426);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(209, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.Location = new System.Drawing.Point(86, 353);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(209, 23);
            this.textBoxEmail.TabIndex = 6;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 591);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxEmail);
            this.DoubleBuffered = true;
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}

