
using System;

namespace ADMshop
{
    partial class PostOffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostOffer));
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.picOfTheOffer = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTown = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.postOfferButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.sellLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOfTheOffer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Cars & Parts",
            "Electronics",
            "Sport items",
            "Furniture"});
            this.comboCategory.Location = new System.Drawing.Point(26, 301);
            this.comboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(162, 23);
            this.comboCategory.TabIndex = 0;
            // 
            // picOfTheOffer
            // 
            this.picOfTheOffer.Image = ((System.Drawing.Image)(resources.GetObject("picOfTheOffer.Image")));
            this.picOfTheOffer.Location = new System.Drawing.Point(26, 45);
            this.picOfTheOffer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOfTheOffer.Name = "picOfTheOffer";
            this.picOfTheOffer.Size = new System.Drawing.Size(297, 172);
            this.picOfTheOffer.TabIndex = 1;
            this.picOfTheOffer.TabStop = false;
            this.picOfTheOffer.Click += new System.EventHandler(this.picOfTheOffer_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton1.Location = new System.Drawing.Point(208, 302);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "New";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton2.Location = new System.Drawing.Point(270, 302);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Used";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(26, 241);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(162, 27);
            this.textBoxName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(26, 351);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(297, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 20);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(287, 189);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(208, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item state";
            // 
            // comboTown
            // 
            this.comboTown.FormattingEnabled = true;
            this.comboTown.Items.AddRange(new object[] {
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse",
            "Madrid",
            "Barcelona",
            "Valencia",
            "Seville",
            "Berlin",
            "Hamburg",
            "Munchen",
            "Paris",
            "Lion",
            "Nice",
            "London",
            "Manchester",
            "Shcefield"});
            this.comboTown.Location = new System.Drawing.Point(208, 244);
            this.comboTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTown.Name = "comboTown";
            this.comboTown.Size = new System.Drawing.Size(115, 23);
            this.comboTown.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(26, 592);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(65, 23);
            this.textBoxPrice.TabIndex = 7;
            // 
            // postOfferButton
            // 
            this.postOfferButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(91)))), ((int)(((byte)(0)))));
            this.postOfferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postOfferButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postOfferButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.postOfferButton.Location = new System.Drawing.Point(233, 573);
            this.postOfferButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postOfferButton.Name = "postOfferButton";
            this.postOfferButton.Size = new System.Drawing.Size(90, 42);
            this.postOfferButton.TabIndex = 8;
            this.postOfferButton.Text = "Post!";
            this.postOfferButton.UseVisualStyleBackColor = false;
            this.postOfferButton.Click += new System.EventHandler(this.postOfferButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(26, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(108, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Post your offer";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.profileLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.profileLabel.Location = new System.Drawing.Point(239, 635);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(84, 25);
            this.profileLabel.TabIndex = 20;
            this.profileLabel.Text = "PROFILE";
            this.profileLabel.Click += new System.EventHandler(this.profileLabel_Click);
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.sellLabel.Location = new System.Drawing.Point(132, 635);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(68, 25);
            this.sellLabel.TabIndex = 19;
            this.sellLabel.Text = "SELL +";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.homeLabel.Location = new System.Drawing.Point(26, 635);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(68, 25);
            this.homeLabel.TabIndex = 18;
            this.homeLabel.Text = "HOME";
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(26, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Category";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Title.Location = new System.Drawing.Point(26, 219);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(40, 20);
            this.Title.TabIndex = 22;
            this.Title.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(-4, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "----------------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(208, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Town";
            // 
            // PostOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(184)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(349, 669);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.sellLabel);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postOfferButton);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.picOfTheOffer);
            this.Controls.Add(this.comboTown);
            this.Controls.Add(this.comboCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PostOffer";
            this.Text = "PostOffer";
            ((System.ComponentModel.ISupportInitialize)(this.picOfTheOffer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.PictureBox picOfTheOffer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTown;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button postOfferButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}