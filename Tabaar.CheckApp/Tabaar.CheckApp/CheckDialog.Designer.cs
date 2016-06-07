namespace Tabaar.CheckApp
{
    partial class CheckDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Bank = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.SchoolCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.ReturnDate = new Tabaar.CheckApp.Controls.PersianDate();
            this.CheckDate = new Tabaar.CheckApp.Controls.PersianDate();
            this.FollowUp = new System.Windows.Forms.Button();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Status = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SchoolName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AccountNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام دانش آموز:";
            // 
            // Student
            // 
            this.Student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Student.Location = new System.Drawing.Point(203, 57);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(188, 22);
            this.Student.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "شماره چک:";
            // 
            // CheckNumber
            // 
            this.CheckNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckNumber.Location = new System.Drawing.Point(203, 87);
            this.CheckNumber.MaxLength = 30;
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(188, 22);
            this.CheckNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "تاریخ چک:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "مبلغ:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "بانک:";
            // 
            // Bank
            // 
            this.Bank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bank.Location = new System.Drawing.Point(203, 202);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(188, 22);
            this.Bank.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "تلفن:";
            // 
            // Phone
            // 
            this.Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone.Location = new System.Drawing.Point(144, 230);
            this.Phone.MaxLength = 50;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(247, 22);
            this.Phone.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "توضیحات:";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(16, 288);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(375, 58);
            this.Description.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "کد مدرسه:";
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.Location = new System.Drawing.Point(203, 174);
            this.Amount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(188, 22);
            this.Amount.TabIndex = 12;
            this.Amount.ThousandsSeparator = true;
            // 
            // SchoolCode
            // 
            this.SchoolCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolCode.AutoCompleteCustomSource.AddRange(new string[] {
            "36",
            "44",
            "51",
            "69",
            "77",
            "85",
            "93",
            "002",
            "101",
            "119",
            "127",
            "135",
            "143",
            "150",
            "168",
            "176",
            "184",
            "192",
            "200",
            "218",
            "226"});
            this.SchoolCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SchoolCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SchoolCode.Location = new System.Drawing.Point(336, 30);
            this.SchoolCode.Name = "SchoolCode";
            this.SchoolCode.Size = new System.Drawing.Size(55, 22);
            this.SchoolCode.TabIndex = 1;
            this.SchoolCode.Validating += new System.ComponentModel.CancelEventHandler(this.SchoolCode_Validating);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "تاریخ برگشت چک:";
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.Controls.Add(this.ReturnDate);
            this.GroupBox.Controls.Add(this.CheckDate);
            this.GroupBox.Controls.Add(this.FollowUp);
            this.GroupBox.Controls.Add(this.Status);
            this.GroupBox.Controls.Add(this.pictureBox1);
            this.GroupBox.Controls.Add(this.Phone);
            this.GroupBox.Controls.Add(this.SchoolCode);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.Amount);
            this.GroupBox.Controls.Add(this.SchoolName);
            this.GroupBox.Controls.Add(this.Student);
            this.GroupBox.Controls.Add(this.label8);
            this.GroupBox.Controls.Add(this.label11);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.Description);
            this.GroupBox.Controls.Add(this.AccountNumber);
            this.GroupBox.Controls.Add(this.CheckNumber);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.label10);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.label9);
            this.GroupBox.Controls.Add(this.Bank);
            this.GroupBox.Controls.Add(this.label5);
            this.GroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(504, 403);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "مشخصات چک";
            // 
            // ReturnDate
            // 
            this.ReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnDate.Location = new System.Drawing.Point(213, 258);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.SelectedDateTime = new System.DateTime(2016, 3, 20, 0, 0, 0, 0);
            this.ReturnDate.Size = new System.Drawing.Size(178, 27);
            this.ReturnDate.TabIndex = 18;
            // 
            // CheckDate
            // 
            this.CheckDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckDate.Location = new System.Drawing.Point(213, 143);
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.SelectedDateTime = new System.DateTime(2016, 3, 20, 0, 0, 0, 0);
            this.CheckDate.Size = new System.Drawing.Size(175, 25);
            this.CheckDate.TabIndex = 10;
            // 
            // FollowUp
            // 
            this.FollowUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FollowUp.ImageIndex = 1;
            this.FollowUp.ImageList = this.ImageList2;
            this.FollowUp.Location = new System.Drawing.Point(16, 352);
            this.FollowUp.Name = "FollowUp";
            this.FollowUp.Size = new System.Drawing.Size(181, 41);
            this.FollowUp.TabIndex = 23;
            this.FollowUp.Text = "پیگیری";
            this.FollowUp.UseVisualStyleBackColor = true;
            this.FollowUp.Visible = false;
            this.FollowUp.Click += new System.EventHandler(this.FollowUp_Click);
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "FollowUp.png");
            this.ImageList2.Images.SetKeyName(1, "Question.png");
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(203, 352);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(190, 22);
            this.Status.TabIndex = 22;
            this.Status.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tabaar.CheckApp.Properties.Resources.WritingCheck;
            this.pictureBox1.Location = new System.Drawing.Point(16, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SchoolName
            // 
            this.SchoolName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolName.Location = new System.Drawing.Point(122, 29);
            this.SchoolName.Name = "SchoolName";
            this.SchoolName.ReadOnly = true;
            this.SchoolName.Size = new System.Drawing.Size(208, 22);
            this.SchoolName.TabIndex = 2;
            this.SchoolName.Text = "نام مدرسه";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "شماره حساب:";
            // 
            // AccountNumber
            // 
            this.AccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNumber.Location = new System.Drawing.Point(203, 115);
            this.AccountNumber.MaxLength = 30;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(188, 22);
            this.AccountNumber.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "وضعیت:";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "New.png");
            this.ImageList.Images.SetKeyName(1, "OK.png");
            this.ImageList.Images.SetKeyName(2, "Cancel.png");
            this.ImageList.Images.SetKeyName(3, "Delete.png");
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.ImageKey = "Delete.png";
            this.Delete.ImageList = this.ImageList;
            this.Delete.Location = new System.Drawing.Point(427, 421);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 37);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "حذف";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // New
            // 
            this.New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New.ImageKey = "New.png";
            this.New.ImageList = this.ImageList;
            this.New.Location = new System.Drawing.Point(209, 421);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(89, 37);
            this.New.TabIndex = 1;
            this.New.Text = "جدید";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.ImageKey = "OK.png";
            this.Save.ImageList = this.ImageList;
            this.Save.Location = new System.Drawing.Point(114, 421);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(89, 37);
            this.Save.TabIndex = 2;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.ImageKey = "Cancel.png";
            this.Cancel.ImageList = this.ImageList;
            this.Cancel.Location = new System.Drawing.Point(19, 421);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(89, 37);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "بستن";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CheckDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 470);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.GroupBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "چک";
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Bank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.TextBox SchoolCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox SchoolName;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button FollowUp;
        private System.Windows.Forms.ImageList ImageList2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AccountNumber;
        private Controls.PersianDate CheckDate;
        private Controls.PersianDate ReturnDate;
    }
}