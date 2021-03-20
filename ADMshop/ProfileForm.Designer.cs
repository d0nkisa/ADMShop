
namespace ADMshop
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.editLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.postedCountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.soldCountLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deletedCountLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sellBtn = new System.Windows.Forms.Button();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.sellLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameLabel.Location = new System.Drawing.Point(135, 241);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(142, 37);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "username";
            // 
            // profilePicBox
            // 
            this.profilePicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePicBox.BackgroundImage")));
            this.profilePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("profilePicBox.ErrorImage")));
            this.profilePicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("profilePicBox.InitialImage")));
            this.profilePicBox.Location = new System.Drawing.Point(120, 68);
            this.profilePicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(155, 169);
            this.profilePicBox.TabIndex = 1;
            this.profilePicBox.TabStop = false;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editLabel.Location = new System.Drawing.Point(14, 12);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(46, 25);
            this.editLabel.TabIndex = 2;
            this.editLabel.Text = "Edit";
            this.editLabel.Click += new System.EventHandler(this.editLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(14, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posted items:";
            // 
            // postedCountLabel
            // 
            this.postedCountLabel.AutoSize = true;
            this.postedCountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postedCountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.postedCountLabel.Location = new System.Drawing.Point(343, 393);
            this.postedCountLabel.Name = "postedCountLabel";
            this.postedCountLabel.Size = new System.Drawing.Size(49, 37);
            this.postedCountLabel.TabIndex = 4;
            this.postedCountLabel.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(-6, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "----------------------------------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(-6, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "----------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(-6, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(476, 28);
            this.label7.TabIndex = 26;
            this.label7.Text = "----------------------------------------------------------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(14, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 37);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sold items:";
            // 
            // soldCountLabel
            // 
            this.soldCountLabel.AutoSize = true;
            this.soldCountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.soldCountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.soldCountLabel.Location = new System.Drawing.Point(357, 463);
            this.soldCountLabel.Name = "soldCountLabel";
            this.soldCountLabel.Size = new System.Drawing.Size(33, 37);
            this.soldCountLabel.TabIndex = 4;
            this.soldCountLabel.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(14, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 37);
            this.label10.TabIndex = 3;
            this.label10.Text = "Deleted posts:";
            // 
            // deletedCountLabel
            // 
            this.deletedCountLabel.AutoSize = true;
            this.deletedCountLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletedCountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deletedCountLabel.Location = new System.Drawing.Point(357, 531);
            this.deletedCountLabel.Name = "deletedCountLabel";
            this.deletedCountLabel.Size = new System.Drawing.Size(33, 37);
            this.deletedCountLabel.TabIndex = 4;
            this.deletedCountLabel.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(-6, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(476, 28);
            this.label12.TabIndex = 26;
            this.label12.Text = "----------------------------------------------------------";
            // 
            // sellBtn
            // 
            this.sellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.sellBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sellBtn.Location = new System.Drawing.Point(120, 312);
            this.sellBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(155, 48);
            this.sellBtn.TabIndex = 27;
            this.sellBtn.Text = "Sell new item";
            this.sellBtn.UseVisualStyleBackColor = false;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logOutLabel.Location = new System.Drawing.Point(313, 12);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(82, 25);
            this.logOutLabel.TabIndex = 28;
            this.logOutLabel.Text = "Log out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(-6, 779);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "----------------------------------------------------------";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.profileLabel.Location = new System.Drawing.Point(289, 805);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(104, 32);
            this.profileLabel.TabIndex = 31;
            this.profileLabel.Text = "PROFILE";
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sellLabel.Location = new System.Drawing.Point(161, 805);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(87, 32);
            this.sellLabel.TabIndex = 30;
            this.sellLabel.Text = "SELL +";
            this.sellLabel.Click += new System.EventHandler(this.sellLabel_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.homeLabel.Location = new System.Drawing.Point(14, 805);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(84, 32);
            this.homeLabel.TabIndex = 29;
            this.homeLabel.Text = "HOME";
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(184)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(399, 851);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.sellLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletedCountLabel);
            this.Controls.Add(this.soldCountLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.postedCountLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editLabel);
            this.Controls.Add(this.profilePicBox);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label postedCountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label soldCountLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label deletedCountLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.Label homeLabel;
    }
}