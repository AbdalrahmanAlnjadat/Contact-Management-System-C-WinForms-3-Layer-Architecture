namespace WinFormsApp1
{
    partial class Form1
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
            txtIDNum = new TextBox();
            label1 = new Label();
            SearchBtn = new Button();
            txtFirstName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            TxtPhone = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtCountryID = new TextBox();
            label8 = new Label();
            txtImagePath = new TextBox();
            DateField = new DateTimePicker();
            label9 = new Label();
            button1 = new Button();
            deleteBtn = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            LvFindContacts = new ListView();
            tabPage2 = new TabPage();
            lblID = new Label();
            btnClr = new Button();
            tabPage3 = new TabPage();
            UBtnSearch = new Button();
            UtxtID = new TextBox();
            label19 = new Label();
            BtnUpdate = new Button();
            UTXTEmail = new TextBox();
            UTXTDateTime = new DateTimePicker();
            label11 = new Label();
            UTXTImagePath = new TextBox();
            UTXTAddress = new TextBox();
            label12 = new Label();
            label13 = new Label();
            UTXTPhone = new TextBox();
            label14 = new Label();
            UTXTLastName = new TextBox();
            label15 = new Label();
            label16 = new Label();
            UTXTCountryID = new TextBox();
            UTXTFirstName = new TextBox();
            label17 = new Label();
            label18 = new Label();
            tabPage6 = new TabPage();
            RefreshBtn = new Button();
            LvListAllContacts = new ListView();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabControl3 = new TabControl();
            tabPage7 = new TabPage();
            btnDeleteCountry = new Button();
            BtnFindCountryByID = new Button();
            TxtCountryID1 = new TextBox();
            RefreshBtnCountries = new Button();
            LvListAllCountries = new ListView();
            tabPage8 = new TabPage();
            btnClear = new Button();
            BtnAddNewCountry = new Button();
            LblCountryID = new Label();
            label21 = new Label();
            TxtCode = new TextBox();
            label20 = new Label();
            txtPhoneCode = new TextBox();
            label10 = new Label();
            txtCountryName = new TextBox();
            tabPage9 = new TabPage();
            lblCountryIDU = new Label();
            btnSearchCountryID = new Button();
            UbtnClear = new Button();
            btnUpdateCountry = new Button();
            UtxtIdSearch = new TextBox();
            label22 = new Label();
            UtxtCode = new TextBox();
            label23 = new Label();
            UtxtPhoneCode = new TextBox();
            label24 = new Label();
            UtxtCountryName = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage9.SuspendLayout();
            SuspendLayout();
            // 
            // txtIDNum
            // 
            txtIDNum.Location = new Point(88, 17);
            txtIDNum.Name = "txtIDNum";
            txtIDNum.Size = new Size(100, 23);
            txtIDNum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "IDNumber:";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(88, 45);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(100, 23);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(126, 35);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 23);
            txtFirstName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "FIrstName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "LastName";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(126, 72);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 23);
            txtLastName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 106);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 23);
            txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 140);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "Phone";
            // 
            // TxtPhone
            // 
            TxtPhone.Location = new Point(126, 137);
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(171, 23);
            TxtPhone.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 172);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 12;
            label6.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(126, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(171, 23);
            txtAddress.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 209);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 14;
            label7.Text = "CountryID";
            // 
            // txtCountryID
            // 
            txtCountryID.Location = new Point(126, 206);
            txtCountryID.Name = "txtCountryID";
            txtCountryID.Size = new Size(171, 23);
            txtCountryID.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 244);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 16;
            label8.Text = "ImagePath";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(126, 241);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(171, 23);
            txtImagePath.TabIndex = 15;
            // 
            // DateField
            // 
            DateField.CustomFormat = "yyyy-MM-dd";
            DateField.Location = new Point(126, 272);
            DateField.Name = "DateField";
            DateField.Size = new Size(194, 23);
            DateField.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 278);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 18;
            label9.Text = "DateOfBirth";
            // 
            // button1
            // 
            button1.Location = new Point(51, 320);
            button1.Name = "button1";
            button1.Size = new Size(117, 59);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(88, 74);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(100, 23);
            deleteBtn.TabIndex = 20;
            deleteBtn.Text = "DeleteContact";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Left;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(20, 40);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(5, 5);
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 423);
            tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ActiveCaption;
            tabPage1.Controls.Add(LvFindContacts);
            tabPage1.Controls.Add(deleteBtn);
            tabPage1.Controls.Add(SearchBtn);
            tabPage1.Controls.Add(txtIDNum);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(44, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(738, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search For Contact";
            // 
            // LvFindContacts
            // 
            LvFindContacts.BackColor = Color.WhiteSmoke;
            LvFindContacts.Dock = DockStyle.Bottom;
            LvFindContacts.Location = new Point(3, 204);
            LvFindContacts.Name = "LvFindContacts";
            LvFindContacts.Size = new Size(732, 208);
            LvFindContacts.TabIndex = 21;
            LvFindContacts.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaption;
            tabPage2.Controls.Add(lblID);
            tabPage2.Controls.Add(btnClr);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(DateField);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txtImagePath);
            tabPage2.Controls.Add(txtAddress);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(TxtPhone);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtLastName);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtCountryID);
            tabPage2.Controls.Add(txtFirstName);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(44, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.RightToLeft = RightToLeft.No;
            tabPage2.Size = new Size(738, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "AddNewContact";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(384, 83);
            lblID.Name = "lblID";
            lblID.Size = new Size(256, 86);
            lblID.TabIndex = 21;
            lblID.Text = "label19";
            // 
            // btnClr
            // 
            btnClr.Location = new Point(203, 320);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(117, 59);
            btnClr.TabIndex = 20;
            btnClr.Text = "CLR";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ActiveCaption;
            tabPage3.Controls.Add(UBtnSearch);
            tabPage3.Controls.Add(UtxtID);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(BtnUpdate);
            tabPage3.Controls.Add(UTXTEmail);
            tabPage3.Controls.Add(UTXTDateTime);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(UTXTImagePath);
            tabPage3.Controls.Add(UTXTAddress);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(UTXTPhone);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(UTXTLastName);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(UTXTCountryID);
            tabPage3.Controls.Add(UTXTFirstName);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label18);
            tabPage3.Location = new Point(44, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(738, 415);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "UpdateContact";
            // 
            // UBtnSearch
            // 
            UBtnSearch.Location = new Point(504, 82);
            UBtnSearch.Name = "UBtnSearch";
            UBtnSearch.Size = new Size(119, 24);
            UBtnSearch.TabIndex = 38;
            UBtnSearch.Text = "Search";
            UBtnSearch.UseVisualStyleBackColor = true;
            UBtnSearch.Click += UBtnSearch_Click;
            // 
            // UtxtID
            // 
            UtxtID.Location = new Point(504, 48);
            UtxtID.Name = "UtxtID";
            UtxtID.Size = new Size(119, 23);
            UtxtID.TabIndex = 36;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(381, 53);
            label19.Name = "label19";
            label19.Size = new Size(118, 15);
            label19.TabIndex = 37;
            label19.Text = "IDNumberToUpdate :";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(397, 246);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(96, 67);
            BtnUpdate.TabIndex = 35;
            BtnUpdate.Text = "UpdateInfo";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // UTXTEmail
            // 
            UTXTEmail.Location = new Point(100, 121);
            UTXTEmail.Name = "UTXTEmail";
            UTXTEmail.Size = new Size(171, 23);
            UTXTEmail.TabIndex = 23;
            // 
            // UTXTDateTime
            // 
            UTXTDateTime.CustomFormat = "yyyy-MM-dd";
            UTXTDateTime.Location = new Point(100, 290);
            UTXTDateTime.Name = "UTXTDateTime";
            UTXTDateTime.Size = new Size(194, 23);
            UTXTDateTime.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 296);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 34;
            label11.Text = "DateOfBirth";
            // 
            // UTXTImagePath
            // 
            UTXTImagePath.Location = new Point(100, 259);
            UTXTImagePath.Name = "UTXTImagePath";
            UTXTImagePath.Size = new Size(171, 23);
            UTXTImagePath.TabIndex = 31;
            // 
            // UTXTAddress
            // 
            UTXTAddress.Location = new Point(100, 187);
            UTXTAddress.Name = "UTXTAddress";
            UTXTAddress.Size = new Size(171, 23);
            UTXTAddress.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 262);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 32;
            label12.Text = "ImagePath";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 227);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 30;
            label13.Text = "CountryID";
            // 
            // UTXTPhone
            // 
            UTXTPhone.Location = new Point(100, 155);
            UTXTPhone.Name = "UTXTPhone";
            UTXTPhone.Size = new Size(171, 23);
            UTXTPhone.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(24, 124);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 24;
            label14.Text = "Email";
            // 
            // UTXTLastName
            // 
            UTXTLastName.Location = new Point(100, 90);
            UTXTLastName.Name = "UTXTLastName";
            UTXTLastName.Size = new Size(171, 23);
            UTXTLastName.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 190);
            label15.Name = "label15";
            label15.Size = new Size(49, 15);
            label15.TabIndex = 28;
            label15.Text = "Address";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(24, 93);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 22;
            label16.Text = "LastName";
            // 
            // UTXTCountryID
            // 
            UTXTCountryID.Location = new Point(100, 224);
            UTXTCountryID.Name = "UTXTCountryID";
            UTXTCountryID.Size = new Size(171, 23);
            UTXTCountryID.TabIndex = 29;
            // 
            // UTXTFirstName
            // 
            UTXTFirstName.Location = new Point(100, 53);
            UTXTFirstName.Name = "UTXTFirstName";
            UTXTFirstName.Size = new Size(171, 23);
            UTXTFirstName.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(24, 56);
            label17.Name = "label17";
            label17.Size = new Size(61, 15);
            label17.TabIndex = 20;
            label17.Text = "FIrstName";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(24, 158);
            label18.Name = "label18";
            label18.Size = new Size(41, 15);
            label18.TabIndex = 26;
            label18.Text = "Phone";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(RefreshBtn);
            tabPage6.Controls.Add(LvListAllContacts);
            tabPage6.Location = new Point(44, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(738, 415);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "ListAllContacts";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RefreshBtn.Location = new Point(209, 350);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(303, 47);
            RefreshBtn.TabIndex = 1;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // LvListAllContacts
            // 
            LvListAllContacts.BackColor = SystemColors.ActiveCaption;
            LvListAllContacts.Dock = DockStyle.Top;
            LvListAllContacts.Location = new Point(3, 3);
            LvListAllContacts.Name = "LvListAllContacts";
            LvListAllContacts.Size = new Size(732, 332);
            LvListAllContacts.TabIndex = 0;
            LvListAllContacts.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(800, 450);
            tabControl2.TabIndex = 22;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tabControl1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Contacts tab";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(tabControl3);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(792, 422);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Countries tab";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage7);
            tabControl3.Controls.Add(tabPage8);
            tabControl3.Controls.Add(tabPage9);
            tabControl3.Dock = DockStyle.Fill;
            tabControl3.Location = new Point(3, 3);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(786, 416);
            tabControl3.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.BackColor = SystemColors.ActiveCaption;
            tabPage7.Controls.Add(btnDeleteCountry);
            tabPage7.Controls.Add(BtnFindCountryByID);
            tabPage7.Controls.Add(TxtCountryID1);
            tabPage7.Controls.Add(RefreshBtnCountries);
            tabPage7.Controls.Add(LvListAllCountries);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(778, 388);
            tabPage7.TabIndex = 0;
            tabPage7.Text = "ListAllCountries";
            // 
            // btnDeleteCountry
            // 
            btnDeleteCountry.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteCountry.Location = new Point(33, 314);
            btnDeleteCountry.Name = "btnDeleteCountry";
            btnDeleteCountry.Size = new Size(116, 34);
            btnDeleteCountry.TabIndex = 5;
            btnDeleteCountry.Text = "Delete";
            btnDeleteCountry.UseVisualStyleBackColor = true;
            btnDeleteCountry.Click += btnDeleteCountry_Click;
            // 
            // BtnFindCountryByID
            // 
            BtnFindCountryByID.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFindCountryByID.Location = new Point(33, 274);
            BtnFindCountryByID.Name = "BtnFindCountryByID";
            BtnFindCountryByID.Size = new Size(116, 34);
            BtnFindCountryByID.TabIndex = 4;
            BtnFindCountryByID.Text = "Search";
            BtnFindCountryByID.UseVisualStyleBackColor = true;
            BtnFindCountryByID.Click += BtnFindCountryByID_Click;
            // 
            // TxtCountryID1
            // 
            TxtCountryID1.Location = new Point(33, 235);
            TxtCountryID1.Name = "TxtCountryID1";
            TxtCountryID1.Size = new Size(116, 23);
            TxtCountryID1.TabIndex = 3;
            // 
            // RefreshBtnCountries
            // 
            RefreshBtnCountries.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RefreshBtnCountries.Location = new Point(233, 235);
            RefreshBtnCountries.Name = "RefreshBtnCountries";
            RefreshBtnCountries.Size = new Size(303, 47);
            RefreshBtnCountries.TabIndex = 2;
            RefreshBtnCountries.Text = "Refresh";
            RefreshBtnCountries.UseVisualStyleBackColor = true;
            RefreshBtnCountries.Click += RefreshBtnCountries_Click;
            // 
            // LvListAllCountries
            // 
            LvListAllCountries.Dock = DockStyle.Top;
            LvListAllCountries.Location = new Point(3, 3);
            LvListAllCountries.Name = "LvListAllCountries";
            LvListAllCountries.Size = new Size(772, 196);
            LvListAllCountries.TabIndex = 0;
            LvListAllCountries.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage8
            // 
            tabPage8.BackColor = SystemColors.ActiveCaption;
            tabPage8.Controls.Add(btnClear);
            tabPage8.Controls.Add(BtnAddNewCountry);
            tabPage8.Controls.Add(LblCountryID);
            tabPage8.Controls.Add(label21);
            tabPage8.Controls.Add(TxtCode);
            tabPage8.Controls.Add(label20);
            tabPage8.Controls.Add(txtPhoneCode);
            tabPage8.Controls.Add(label10);
            tabPage8.Controls.Add(txtCountryName);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(778, 388);
            tabPage8.TabIndex = 1;
            tabPage8.Text = "AddNewCountry";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(220, 270);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 35);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // BtnAddNewCountry
            // 
            BtnAddNewCountry.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddNewCountry.Location = new Point(62, 270);
            BtnAddNewCountry.Name = "BtnAddNewCountry";
            BtnAddNewCountry.Size = new Size(116, 35);
            BtnAddNewCountry.TabIndex = 23;
            BtnAddNewCountry.Text = "Add";
            BtnAddNewCountry.UseVisualStyleBackColor = true;
            BtnAddNewCountry.Click += BtnAddNewCountry_Click;
            // 
            // LblCountryID
            // 
            LblCountryID.AutoSize = true;
            LblCountryID.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCountryID.Location = new Point(439, 55);
            LblCountryID.Name = "LblCountryID";
            LblCountryID.Size = new Size(256, 86);
            LblCountryID.TabIndex = 22;
            LblCountryID.Text = "label19";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(37, 94);
            label21.Name = "label21";
            label21.Size = new Size(35, 15);
            label21.TabIndex = 5;
            label21.Text = "Code";
            // 
            // TxtCode
            // 
            TxtCode.Location = new Point(135, 91);
            TxtCode.Name = "TxtCode";
            TxtCode.Size = new Size(117, 23);
            TxtCode.TabIndex = 4;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(37, 138);
            label20.Name = "label20";
            label20.Size = new Size(69, 15);
            label20.TabIndex = 3;
            label20.Text = "PhoneCode";
            // 
            // txtPhoneCode
            // 
            txtPhoneCode.Location = new Point(135, 135);
            txtPhoneCode.Name = "txtPhoneCode";
            txtPhoneCode.Size = new Size(117, 23);
            txtPhoneCode.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 55);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 1;
            label10.Text = "CountryName";
            // 
            // txtCountryName
            // 
            txtCountryName.Location = new Point(135, 52);
            txtCountryName.Name = "txtCountryName";
            txtCountryName.Size = new Size(117, 23);
            txtCountryName.TabIndex = 0;
            // 
            // tabPage9
            // 
            tabPage9.BackColor = SystemColors.ActiveCaption;
            tabPage9.Controls.Add(lblCountryIDU);
            tabPage9.Controls.Add(btnSearchCountryID);
            tabPage9.Controls.Add(UbtnClear);
            tabPage9.Controls.Add(btnUpdateCountry);
            tabPage9.Controls.Add(UtxtIdSearch);
            tabPage9.Controls.Add(label22);
            tabPage9.Controls.Add(UtxtCode);
            tabPage9.Controls.Add(label23);
            tabPage9.Controls.Add(UtxtPhoneCode);
            tabPage9.Controls.Add(label24);
            tabPage9.Controls.Add(UtxtCountryName);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(778, 388);
            tabPage9.TabIndex = 2;
            tabPage9.Text = "UpdateCountry";
            // 
            // lblCountryIDU
            // 
            lblCountryIDU.AutoSize = true;
            lblCountryIDU.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountryIDU.Location = new Point(416, 82);
            lblCountryIDU.Name = "lblCountryIDU";
            lblCountryIDU.Size = new Size(128, 45);
            lblCountryIDU.TabIndex = 28;
            lblCountryIDU.Text = "label19";
            //lblCountryIDU.Click += lblCountryIDU_Click;
            // 
            // btnSearchCountryID
            // 
            btnSearchCountryID.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchCountryID.Location = new Point(625, 285);
            btnSearchCountryID.Name = "btnSearchCountryID";
            btnSearchCountryID.Size = new Size(116, 35);
            btnSearchCountryID.TabIndex = 26;
            btnSearchCountryID.Text = "Search";
            btnSearchCountryID.UseVisualStyleBackColor = true;
            btnSearchCountryID.Click += btnSearchCountryID_Click;
            // 
            // UbtnClear
            // 
            UbtnClear.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UbtnClear.Location = new Point(476, 285);
            UbtnClear.Name = "UbtnClear";
            UbtnClear.Size = new Size(116, 35);
            UbtnClear.TabIndex = 25;
            UbtnClear.Text = "Clear";
            UbtnClear.UseVisualStyleBackColor = true;
            UbtnClear.Click += UbtnClear_Click;
            // 
            // btnUpdateCountry
            // 
            btnUpdateCountry.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateCountry.Location = new Point(329, 285);
            btnUpdateCountry.Name = "btnUpdateCountry";
            btnUpdateCountry.Size = new Size(116, 35);
            btnUpdateCountry.TabIndex = 24;
            btnUpdateCountry.Text = "Update";
            btnUpdateCountry.UseVisualStyleBackColor = true;
            btnUpdateCountry.Click += btnUpdateCountry_Click;
            // 
            // UtxtIdSearch
            // 
            UtxtIdSearch.Location = new Point(476, 234);
            UtxtIdSearch.Name = "UtxtIdSearch";
            UtxtIdSearch.Size = new Size(117, 23);
            UtxtIdSearch.TabIndex = 12;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(55, 85);
            label22.Name = "label22";
            label22.Size = new Size(35, 15);
            label22.TabIndex = 11;
            label22.Text = "Code";
            // 
            // UtxtCode
            // 
            UtxtCode.Location = new Point(153, 82);
            UtxtCode.Name = "UtxtCode";
            UtxtCode.Size = new Size(117, 23);
            UtxtCode.TabIndex = 10;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(55, 129);
            label23.Name = "label23";
            label23.Size = new Size(69, 15);
            label23.TabIndex = 9;
            label23.Text = "PhoneCode";
            // 
            // UtxtPhoneCode
            // 
            UtxtPhoneCode.Location = new Point(153, 126);
            UtxtPhoneCode.Name = "UtxtPhoneCode";
            UtxtPhoneCode.Size = new Size(117, 23);
            UtxtPhoneCode.TabIndex = 8;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(55, 46);
            label24.Name = "label24";
            label24.Size = new Size(82, 15);
            label24.TabIndex = 7;
            label24.Text = "CountryName";
            // 
            // UtxtCountryName
            // 
            UtxtCountryName.Location = new Point(153, 43);
            UtxtCountryName.Name = "UtxtCountryName";
            UtxtCountryName.Size = new Size(117, 23);
            UtxtCountryName.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtIDNum;
        private Label label1;
        private Button SearchBtn;
        private TextBox txtFirstName;
        private Label label2;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox TxtPhone;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtCountryID;
        private Label label8;
        private TextBox txtImagePath;
        private DateTimePicker DateField;
        private Label label9;
        private Button button1;
        private Button deleteBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnClr;
        private ListView LvFindContacts;
        private TabPage tabPage3;
        private TextBox UTXTEmail;
        private DateTimePicker UTXTDateTime;
        private Label label11;
        private TextBox UTXTImagePath;
        private TextBox UTXTAddress;
        private Label label12;
        private Label label13;
        private TextBox UTXTPhone;
        private Label label14;
        private TextBox UTXTLastName;
        private Label label15;
        private Label label16;
        private TextBox UTXTCountryID;
        private TextBox UTXTFirstName;
        private Label label17;
        private Label label18;
        private Label lblID;
        private Button UBtnSearch;
        private TextBox UtxtID;
        private Label label19;
        private Button BtnUpdate;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private ListView LvListAllContacts;
        private Button RefreshBtn;
        private TabControl tabControl3;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private ListView LvListAllCountries;
        private Button RefreshBtnCountries;
        private Button BtnFindCountryByID;
        private TextBox TxtCountryID1;
        private Button btnDeleteCountry;
        private TextBox txtCountryName;
        private Label LblCountryID;
        private Label label21;
        private TextBox TxtCode;
        private Label label20;
        private TextBox txtPhoneCode;
        private Label label10;
        private Button btnClear;
        private Button BtnAddNewCountry;
        private Label label22;
        private TextBox UtxtCode;
        private Label label23;
        private TextBox UtxtPhoneCode;
        private Label label24;
        private TextBox UtxtCountryName;
        private Button UbtnClear;
        private Button btnUpdateCountry;
        private TextBox UtxtIdSearch;
        private Label lblCountryIDU;
        private Button btnSearchCountryID;
    }
}
