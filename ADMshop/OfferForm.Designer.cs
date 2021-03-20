
namespace ADMshop
{
    partial class OfferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfferForm));
            this.OfferImage = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.phone = new System.Windows.Forms.Label();
            this.goBackToHome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OfferImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OfferImage
            // 
            this.OfferImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OfferImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OfferImage.Location = new System.Drawing.Point(10, 34);
            this.OfferImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OfferImage.Name = "OfferImage";
            this.OfferImage.Size = new System.Drawing.Size(328, 278);
            this.OfferImage.TabIndex = 0;
            this.OfferImage.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(10, 328);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(175, 30);
            this.title.TabIndex = 1;
            this.title.Text = "Title of the offer";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fname.Location = new System.Drawing.Point(94, 521);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(71, 17);
            this.fname.TabIndex = 2;
            this.fname.Text = "FirstName";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(269, 332);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(55, 25);
            this.price.TabIndex = 1;
            this.price.Text = "12 lv.";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(10, 369);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(271, 119);
            this.description.TabIndex = 3;
            this.description.Text = resources.GetString("description.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(10, 502);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 70);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(94, 545);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(67, 15);
            this.phone.TabIndex = 5;
            this.phone.Text = "0812345678";
            // 
            // goBackToHome
            // 
            this.goBackToHome.AutoSize = true;
            this.goBackToHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goBackToHome.Location = new System.Drawing.Point(10, 9);
            this.goBackToHome.Name = "goBackToHome";
            this.goBackToHome.Size = new System.Drawing.Size(54, 17);
            this.goBackToHome.TabIndex = 5;
            this.goBackToHome.Text = "<- Back";
            this.goBackToHome.Click += new System.EventHandler(this.goBackToHome_Click);
            // 
            // OfferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(184)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(349, 591);
            this.ControlBox = false;
            this.Controls.Add(this.goBackToHome);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.price);
            this.Controls.Add(this.title);
            this.Controls.Add(this.OfferImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OfferForm";
            this.Text = "Offer";
            this.Load += new System.EventHandler(this.OfferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OfferImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox OfferImage;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label goBackToHome;
    }
}