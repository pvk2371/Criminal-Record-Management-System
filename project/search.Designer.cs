namespace Project
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.criminalNameComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.criminalNameTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.penaltyTextBox = new System.Windows.Forms.TextBox();
            this.dateOfCrimeTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dobTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.aadharTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.regdateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(102, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Name To Search Record:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.RosyBrown;
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkColor = System.Drawing.Color.Tomato;
            this.linkLabel1.Location = new System.Drawing.Point(341, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(212, 31);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "  Record Search";
            // 
            // criminalNameComboBox
            // 
            this.criminalNameComboBox.FormattingEnabled = true;
            this.criminalNameComboBox.Location = new System.Drawing.Point(441, 93);
            this.criminalNameComboBox.Name = "criminalNameComboBox";
            this.criminalNameComboBox.Size = new System.Drawing.Size(278, 24);
            this.criminalNameComboBox.TabIndex = 2;
            this.criminalNameComboBox.SelectedIndexChanged += new System.EventHandler(this.criminalNameComboBox_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 206);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label16.Size = new System.Drawing.Size(81, 24);
            this.label16.TabIndex = 29;
            this.label16.Text = "Gender:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 260);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label15.Size = new System.Drawing.Size(150, 24);
            this.label15.TabIndex = 28;
            this.label15.Text = "Aadhar Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 485);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label14.Size = new System.Drawing.Size(115, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "Crime Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 315);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label13.Size = new System.Drawing.Size(88, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 368);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label12.Size = new System.Drawing.Size(128, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Date Of Birth:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 633);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "Date Of Crime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 427);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label9.Size = new System.Drawing.Size(157, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "Contact Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 557);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Penalty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 695);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Crime Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 777);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Police Station:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Criminal Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 557);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 1, 0, 1);
            this.label7.Size = new System.Drawing.Size(88, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(562, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Photo:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoPictureBox.Location = new System.Drawing.Point(676, 368);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(122, 129);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoPictureBox.TabIndex = 32;
            this.photoPictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Registration Date:";
            // 
            // criminalNameTextBox
            // 
            this.criminalNameTextBox.Location = new System.Drawing.Point(192, 147);
            this.criminalNameTextBox.Multiline = true;
            this.criminalNameTextBox.Name = "criminalNameTextBox";
            this.criminalNameTextBox.ReadOnly = true;
            this.criminalNameTextBox.Size = new System.Drawing.Size(294, 30);
            this.criminalNameTextBox.TabIndex = 34;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(192, 200);
            this.genderTextBox.Multiline = true;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(294, 30);
            this.genderTextBox.TabIndex = 35;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(192, 485);
            this.typeTextBox.Multiline = true;
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(294, 30);
            this.typeTextBox.TabIndex = 36;
            // 
            // penaltyTextBox
            // 
            this.penaltyTextBox.Location = new System.Drawing.Point(192, 557);
            this.penaltyTextBox.Multiline = true;
            this.penaltyTextBox.Name = "penaltyTextBox";
            this.penaltyTextBox.ReadOnly = true;
            this.penaltyTextBox.Size = new System.Drawing.Size(294, 30);
            this.penaltyTextBox.TabIndex = 37;
            // 
            // dateOfCrimeTextBox
            // 
            this.dateOfCrimeTextBox.Location = new System.Drawing.Point(192, 627);
            this.dateOfCrimeTextBox.Multiline = true;
            this.dateOfCrimeTextBox.Name = "dateOfCrimeTextBox";
            this.dateOfCrimeTextBox.ReadOnly = true;
            this.dateOfCrimeTextBox.Size = new System.Drawing.Size(294, 30);
            this.dateOfCrimeTextBox.TabIndex = 38;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(192, 689);
            this.locationTextBox.Multiline = true;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(294, 30);
            this.locationTextBox.TabIndex = 39;
            // 
            // stationTextBox
            // 
            this.stationTextBox.Location = new System.Drawing.Point(192, 777);
            this.stationTextBox.Multiline = true;
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.ReadOnly = true;
            this.stationTextBox.Size = new System.Drawing.Size(294, 30);
            this.stationTextBox.TabIndex = 40;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(689, 551);
            this.amountTextBox.Multiline = true;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(294, 30);
            this.amountTextBox.TabIndex = 41;
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(192, 362);
            this.dobTextBox.Multiline = true;
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.ReadOnly = true;
            this.dobTextBox.Size = new System.Drawing.Size(294, 30);
            this.dobTextBox.TabIndex = 42;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(192, 309);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(294, 30);
            this.addressTextBox.TabIndex = 43;
            // 
            // aadharTextBox
            // 
            this.aadharTextBox.Location = new System.Drawing.Point(192, 254);
            this.aadharTextBox.Multiline = true;
            this.aadharTextBox.Name = "aadharTextBox";
            this.aadharTextBox.ReadOnly = true;
            this.aadharTextBox.Size = new System.Drawing.Size(294, 30);
            this.aadharTextBox.TabIndex = 44;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(192, 427);
            this.contactTextBox.Multiline = true;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.ReadOnly = true;
            this.contactTextBox.Size = new System.Drawing.Size(294, 30);
            this.contactTextBox.TabIndex = 45;
            // 
            // regdateTextBox
            // 
            this.regdateTextBox.Location = new System.Drawing.Point(737, 153);
            this.regdateTextBox.Multiline = true;
            this.regdateTextBox.Name = "regdateTextBox";
            this.regdateTextBox.ReadOnly = true;
            this.regdateTextBox.Size = new System.Drawing.Size(294, 30);
            this.regdateTextBox.TabIndex = 46;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 853);
            this.Controls.Add(this.regdateTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.aadharTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.dobTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.stationTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.dateOfCrimeTextBox);
            this.Controls.Add(this.penaltyTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.criminalNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.criminalNameComboBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criminal Record management : Search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox criminalNameComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox criminalNameTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox penaltyTextBox;
        private System.Windows.Forms.TextBox dateOfCrimeTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox stationTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox dobTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox aadharTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox regdateTextBox;
    }
}