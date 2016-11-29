namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wholeTabs = new System.Windows.Forms.TabControl();
            this.addContactsTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxAddVerifyEmail = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAddSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddCancel = new System.Windows.Forms.Button();
            this.textBoxAddSecondLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddFirstLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.searchContactTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchEditEliminate = new System.Windows.Forms.Button();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.checkBoxSearchnEditVerifyEmail = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonSearchEditModificate = new System.Windows.Forms.Button();
            this.buttonSearchEditLookFor = new System.Windows.Forms.Button();
            this.textBoxSearchEditSecondLastName = new System.Windows.Forms.TextBox();
            this.textBoxSearchEditFirstLastName = new System.Windows.Forms.TextBox();
            this.textBoxSearchEditEmail = new System.Windows.Forms.TextBox();
            this.textBoxSearchEditName = new System.Windows.Forms.TextBox();
            this.settingTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSettingTabSave = new System.Windows.Forms.Button();
            this.listBoxSettingTabMode = new System.Windows.Forms.ListBox();
            this.textBoxSettingTabLastConfigDate = new System.Windows.Forms.TextBox();
            this.textBoxSettingTabPeriodicity = new System.Windows.Forms.TextBox();
            this.monthCalendarSettingTab = new System.Windows.Forms.MonthCalendar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.autoEmailTab = new System.Windows.Forms.TabPage();
            this.dataGridViewAutoMailTab = new System.Windows.Forms.DataGridView();
            this.checkBoxAutoSendEmail = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.wholeTabs.SuspendLayout();
            this.addContactsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.searchContactTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.settingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.autoEmailTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoMailTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.wholeTabs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 591);
            this.panel1.TabIndex = 0;
            // 
            // wholeTabs
            // 
            this.wholeTabs.AccessibleDescription = "";
            this.wholeTabs.AccessibleName = "";
            this.wholeTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.wholeTabs.Controls.Add(this.addContactsTab);
            this.wholeTabs.Controls.Add(this.searchContactTab);
            this.wholeTabs.Controls.Add(this.settingTab);
            this.wholeTabs.Controls.Add(this.autoEmailTab);
            this.wholeTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeTabs.ImageList = this.imageList1;
            this.wholeTabs.Location = new System.Drawing.Point(3, 137);
            this.wholeTabs.Name = "wholeTabs";
            this.wholeTabs.Padding = new System.Drawing.Point(33, 3);
            this.wholeTabs.SelectedIndex = 0;
            this.wholeTabs.ShowToolTips = true;
            this.wholeTabs.Size = new System.Drawing.Size(923, 451);
            this.wholeTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.wholeTabs.TabIndex = 4;
            this.wholeTabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // addContactsTab
            // 
            this.addContactsTab.AccessibleDescription = "";
            this.addContactsTab.AccessibleName = "";
            this.addContactsTab.BackColor = System.Drawing.SystemColors.Control;
            this.addContactsTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addContactsTab.Controls.Add(this.label10);
            this.addContactsTab.Controls.Add(this.label9);
            this.addContactsTab.Controls.Add(this.checkBoxAddVerifyEmail);
            this.addContactsTab.Controls.Add(this.label6);
            this.addContactsTab.Controls.Add(this.label5);
            this.addContactsTab.Controls.Add(this.label4);
            this.addContactsTab.Controls.Add(this.label3);
            this.addContactsTab.Controls.Add(this.pictureBox2);
            this.addContactsTab.Controls.Add(this.buttonAddSave);
            this.addContactsTab.Controls.Add(this.buttonAddCancel);
            this.addContactsTab.Controls.Add(this.textBoxAddSecondLastName);
            this.addContactsTab.Controls.Add(this.textBoxAddFirstLastName);
            this.addContactsTab.Controls.Add(this.textBoxAddEmail);
            this.addContactsTab.Controls.Add(this.textBoxAddName);
            this.addContactsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContactsTab.ImageIndex = 1;
            this.addContactsTab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addContactsTab.Location = new System.Drawing.Point(4, 42);
            this.addContactsTab.Name = "addContactsTab";
            this.addContactsTab.Padding = new System.Windows.Forms.Padding(3);
            this.addContactsTab.Size = new System.Drawing.Size(915, 405);
            this.addContactsTab.TabIndex = 0;
            this.addContactsTab.Text = "Add ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(535, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "C a n c e l";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(754, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "S a v e";
            // 
            // checkBoxAddVerifyEmail
            // 
            this.checkBoxAddVerifyEmail.AutoSize = true;
            this.checkBoxAddVerifyEmail.Checked = true;
            this.checkBoxAddVerifyEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAddVerifyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAddVerifyEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxAddVerifyEmail.Location = new System.Drawing.Point(82, 134);
            this.checkBoxAddVerifyEmail.Name = "checkBoxAddVerifyEmail";
            this.checkBoxAddVerifyEmail.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAddVerifyEmail.TabIndex = 11;
            this.checkBoxAddVerifyEmail.Text = "Verify E-mail by SMTP";
            this.checkBoxAddVerifyEmail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Second Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "First Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(139, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // buttonAddSave
            // 
            this.buttonAddSave.ImageKey = "yes-3-512.png";
            this.buttonAddSave.ImageList = this.imageList1;
            this.buttonAddSave.Location = new System.Drawing.Point(675, 330);
            this.buttonAddSave.Name = "buttonAddSave";
            this.buttonAddSave.Size = new System.Drawing.Size(200, 48);
            this.buttonAddSave.TabIndex = 5;
            this.buttonAddSave.UseVisualStyleBackColor = true;
            this.buttonAddSave.Click += new System.EventHandler(this.buttonAddSave_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit_user-.png");
            this.imageList1.Images.SetKeyName(1, "users-add-user-icon.png");
            this.imageList1.Images.SetKeyName(2, "calendar_settings-512.png");
            this.imageList1.Images.SetKeyName(3, "email_send-512.png");
            this.imageList1.Images.SetKeyName(4, "mail_send_4-512.png");
            this.imageList1.Images.SetKeyName(5, "YPS__email_mail_send_letter_mail_envelope_stamp_postal-512.png");
            this.imageList1.Images.SetKeyName(6, "sent_mail_2-512.png");
            this.imageList1.Images.SetKeyName(7, "Email-Sending-512.png");
            this.imageList1.Images.SetKeyName(8, "email_mail_envelope_letter_send_inbox_newsletter-512.png");
            this.imageList1.Images.SetKeyName(9, "1454.png");
            this.imageList1.Images.SetKeyName(10, "Email_envelope_fast_internet_letter_mail_message_network_news_send_sending_addres" +
                    "s_communication_contactdocument_flight_air_delivery-512.png");
            this.imageList1.Images.SetKeyName(11, "next_mail-512.png");
            this.imageList1.Images.SetKeyName(12, "peoplesearch.jpg");
            this.imageList1.Images.SetKeyName(13, "user-search-icon-92803.png");
            this.imageList1.Images.SetKeyName(14, "search.png");
            this.imageList1.Images.SetKeyName(15, "plainicon.com-46286-256px-c92.png");
            this.imageList1.Images.SetKeyName(16, "pencil-striped-symbol-for-interface-edit-buttons_318-50260.jpg");
            this.imageList1.Images.SetKeyName(17, "Editing-Edit-icon.png");
            this.imageList1.Images.SetKeyName(18, "cancel-icon-27894.png");
            this.imageList1.Images.SetKeyName(19, "yes-3-512.png");
            this.imageList1.Images.SetKeyName(20, "AutoSWimage.png");
            this.imageList1.Images.SetKeyName(21, "AutoSWimage2.bmp");
            this.imageList1.Images.SetKeyName(22, "edit_userANDsearch.png");
            // 
            // buttonAddCancel
            // 
            this.buttonAddCancel.ImageKey = "cancel-icon-27894.png";
            this.buttonAddCancel.ImageList = this.imageList1;
            this.buttonAddCancel.Location = new System.Drawing.Point(463, 330);
            this.buttonAddCancel.Name = "buttonAddCancel";
            this.buttonAddCancel.Size = new System.Drawing.Size(200, 48);
            this.buttonAddCancel.TabIndex = 4;
            this.buttonAddCancel.UseVisualStyleBackColor = true;
            this.buttonAddCancel.Click += new System.EventHandler(this.buttonAddCancel_Click);
            // 
            // textBoxAddSecondLastName
            // 
            this.textBoxAddSecondLastName.Location = new System.Drawing.Point(463, 157);
            this.textBoxAddSecondLastName.Name = "textBoxAddSecondLastName";
            this.textBoxAddSecondLastName.Size = new System.Drawing.Size(412, 29);
            this.textBoxAddSecondLastName.TabIndex = 3;
            // 
            // textBoxAddFirstLastName
            // 
            this.textBoxAddFirstLastName.Location = new System.Drawing.Point(463, 67);
            this.textBoxAddFirstLastName.Name = "textBoxAddFirstLastName";
            this.textBoxAddFirstLastName.Size = new System.Drawing.Size(412, 29);
            this.textBoxAddFirstLastName.TabIndex = 2;
            // 
            // textBoxAddEmail
            // 
            this.textBoxAddEmail.Location = new System.Drawing.Point(25, 157);
            this.textBoxAddEmail.Name = "textBoxAddEmail";
            this.textBoxAddEmail.Size = new System.Drawing.Size(412, 29);
            this.textBoxAddEmail.TabIndex = 1;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(25, 67);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(412, 29);
            this.textBoxAddName.TabIndex = 0;
            // 
            // searchContactTab
            // 
            this.searchContactTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchContactTab.Controls.Add(this.label8);
            this.searchContactTab.Controls.Add(this.label7);
            this.searchContactTab.Controls.Add(this.label1);
            this.searchContactTab.Controls.Add(this.buttonSearchEditEliminate);
            this.searchContactTab.Controls.Add(this.dataGridViewContacts);
            this.searchContactTab.Controls.Add(this.checkBoxSearchnEditVerifyEmail);
            this.searchContactTab.Controls.Add(this.pictureBox5);
            this.searchContactTab.Controls.Add(this.buttonSearchEditModificate);
            this.searchContactTab.Controls.Add(this.buttonSearchEditLookFor);
            this.searchContactTab.Controls.Add(this.textBoxSearchEditSecondLastName);
            this.searchContactTab.Controls.Add(this.textBoxSearchEditFirstLastName);
            this.searchContactTab.Controls.Add(this.textBoxSearchEditEmail);
            this.searchContactTab.Controls.Add(this.textBoxSearchEditName);
            this.searchContactTab.ImageIndex = 22;
            this.searchContactTab.Location = new System.Drawing.Point(4, 42);
            this.searchContactTab.Name = "searchContactTab";
            this.searchContactTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchContactTab.Size = new System.Drawing.Size(915, 405);
            this.searchContactTab.TabIndex = 1;
            this.searchContactTab.Text = "Search / Edit";
            this.searchContactTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(639, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "D e l e t e";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "E d i t ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "S e a r c h ";
            // 
            // buttonSearchEditEliminate
            // 
            this.buttonSearchEditEliminate.ImageKey = "cancel-icon-27894.png";
            this.buttonSearchEditEliminate.ImageList = this.imageList1;
            this.buttonSearchEditEliminate.Location = new System.Drawing.Point(568, 335);
            this.buttonSearchEditEliminate.Name = "buttonSearchEditEliminate";
            this.buttonSearchEditEliminate.Size = new System.Drawing.Size(200, 48);
            this.buttonSearchEditEliminate.TabIndex = 14;
            this.buttonSearchEditEliminate.UseVisualStyleBackColor = true;
            this.buttonSearchEditEliminate.Click += new System.EventHandler(this.buttonSearchEditEliminate_Click);
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.AllowUserToAddRows = false;
            this.dataGridViewContacts.AllowUserToDeleteRows = false;
            this.dataGridViewContacts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewContacts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Location = new System.Drawing.Point(12, 199);
            this.dataGridViewContacts.MultiSelect = false;
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.ReadOnly = true;
            this.dataGridViewContacts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewContacts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContacts.Size = new System.Drawing.Size(540, 203);
            this.dataGridViewContacts.TabIndex = 13;
            this.dataGridViewContacts.Visible = false;
            this.dataGridViewContacts.SelectionChanged += new System.EventHandler(this.dataGridViewContacts_SelectionChanged);
            // 
            // checkBoxSearchnEditVerifyEmail
            // 
            this.checkBoxSearchnEditVerifyEmail.AutoSize = true;
            this.checkBoxSearchnEditVerifyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSearchnEditVerifyEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxSearchnEditVerifyEmail.Location = new System.Drawing.Point(81, 134);
            this.checkBoxSearchnEditVerifyEmail.Name = "checkBoxSearchnEditVerifyEmail";
            this.checkBoxSearchnEditVerifyEmail.Size = new System.Drawing.Size(130, 17);
            this.checkBoxSearchnEditVerifyEmail.TabIndex = 12;
            this.checkBoxSearchnEditVerifyEmail.Text = "Verify E-mail by SMTP";
            this.checkBoxSearchnEditVerifyEmail.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(777, 267);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 128);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // buttonSearchEditModificate
            // 
            this.buttonSearchEditModificate.ImageKey = "Editing-Edit-icon.png";
            this.buttonSearchEditModificate.ImageList = this.imageList1;
            this.buttonSearchEditModificate.Location = new System.Drawing.Point(568, 267);
            this.buttonSearchEditModificate.Name = "buttonSearchEditModificate";
            this.buttonSearchEditModificate.Size = new System.Drawing.Size(200, 48);
            this.buttonSearchEditModificate.TabIndex = 9;
            this.buttonSearchEditModificate.UseVisualStyleBackColor = true;
            this.buttonSearchEditModificate.Click += new System.EventHandler(this.buttonSearchEditModificate_Click);
            // 
            // buttonSearchEditLookFor
            // 
            this.buttonSearchEditLookFor.ImageKey = "search.png";
            this.buttonSearchEditLookFor.ImageList = this.imageList1;
            this.buttonSearchEditLookFor.Location = new System.Drawing.Point(568, 199);
            this.buttonSearchEditLookFor.Name = "buttonSearchEditLookFor";
            this.buttonSearchEditLookFor.Size = new System.Drawing.Size(200, 48);
            this.buttonSearchEditLookFor.TabIndex = 8;
            this.buttonSearchEditLookFor.UseVisualStyleBackColor = true;
            this.buttonSearchEditLookFor.Click += new System.EventHandler(this.buttonSearchEditLookFor_Click);
            // 
            // textBoxSearchEditSecondLastName
            // 
            this.textBoxSearchEditSecondLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchEditSecondLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearchEditSecondLastName.Location = new System.Drawing.Point(463, 157);
            this.textBoxSearchEditSecondLastName.Name = "textBoxSearchEditSecondLastName";
            this.textBoxSearchEditSecondLastName.Size = new System.Drawing.Size(412, 29);
            this.textBoxSearchEditSecondLastName.TabIndex = 7;
            this.textBoxSearchEditSecondLastName.Text = "*Second Lastname";
            this.textBoxSearchEditSecondLastName.Click += new System.EventHandler(this.textBoxSearchEditSecondLastName_Click);
            // 
            // textBoxSearchEditFirstLastName
            // 
            this.textBoxSearchEditFirstLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearchEditFirstLastName.Location = new System.Drawing.Point(463, 67);
            this.textBoxSearchEditFirstLastName.Name = "textBoxSearchEditFirstLastName";
            this.textBoxSearchEditFirstLastName.Size = new System.Drawing.Size(412, 29);
            this.textBoxSearchEditFirstLastName.TabIndex = 6;
            this.textBoxSearchEditFirstLastName.Text = "*First Lastname";
            this.textBoxSearchEditFirstLastName.Click += new System.EventHandler(this.textBoxSearchEditFirstLastName_Click);
            // 
            // textBoxSearchEditEmail
            // 
            this.textBoxSearchEditEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearchEditEmail.Location = new System.Drawing.Point(25, 157);
            this.textBoxSearchEditEmail.Name = "textBoxSearchEditEmail";
            this.textBoxSearchEditEmail.Size = new System.Drawing.Size(412, 29);
            this.textBoxSearchEditEmail.TabIndex = 5;
            this.textBoxSearchEditEmail.Text = "*E-mail";
            this.textBoxSearchEditEmail.Click += new System.EventHandler(this.textBoxSearchEditEmail_Click);
            // 
            // textBoxSearchEditName
            // 
            this.textBoxSearchEditName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearchEditName.Location = new System.Drawing.Point(25, 67);
            this.textBoxSearchEditName.Name = "textBoxSearchEditName";
            this.textBoxSearchEditName.Size = new System.Drawing.Size(412, 29);
            this.textBoxSearchEditName.TabIndex = 4;
            this.textBoxSearchEditName.Text = "*Name";
            this.textBoxSearchEditName.Click += new System.EventHandler(this.textBoxSearchEditName_Click);
            // 
            // settingTab
            // 
            this.settingTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingTab.Controls.Add(this.label14);
            this.settingTab.Controls.Add(this.label13);
            this.settingTab.Controls.Add(this.label12);
            this.settingTab.Controls.Add(this.label11);
            this.settingTab.Controls.Add(this.buttonSettingTabSave);
            this.settingTab.Controls.Add(this.listBoxSettingTabMode);
            this.settingTab.Controls.Add(this.textBoxSettingTabLastConfigDate);
            this.settingTab.Controls.Add(this.textBoxSettingTabPeriodicity);
            this.settingTab.Controls.Add(this.monthCalendarSettingTab);
            this.settingTab.Controls.Add(this.pictureBox3);
            this.settingTab.ImageIndex = 2;
            this.settingTab.Location = new System.Drawing.Point(4, 42);
            this.settingTab.Name = "settingTab";
            this.settingTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingTab.Size = new System.Drawing.Size(915, 405);
            this.settingTab.TabIndex = 2;
            this.settingTab.Text = "Setting";
            this.settingTab.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(523, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "M o d e";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(502, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "P e r i o d i c i t y ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(483, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "L a s t   D a t e   C o n f i g";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(525, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "S a v e";
            // 
            // buttonSettingTabSave
            // 
            this.buttonSettingTabSave.ImageKey = "yes-3-512.png";
            this.buttonSettingTabSave.ImageList = this.imageList1;
            this.buttonSettingTabSave.Location = new System.Drawing.Point(447, 272);
            this.buttonSettingTabSave.Name = "buttonSettingTabSave";
            this.buttonSettingTabSave.Size = new System.Drawing.Size(200, 48);
            this.buttonSettingTabSave.TabIndex = 13;
            this.buttonSettingTabSave.UseVisualStyleBackColor = true;
            this.buttonSettingTabSave.Click += new System.EventHandler(this.buttonSettingTabSave_Click);
            // 
            // listBoxSettingTabMode
            // 
            this.listBoxSettingTabMode.AllowDrop = true;
            this.listBoxSettingTabMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSettingTabMode.FormattingEnabled = true;
            this.listBoxSettingTabMode.HorizontalScrollbar = true;
            this.listBoxSettingTabMode.ItemHeight = 18;
            this.listBoxSettingTabMode.Items.AddRange(new object[] {
            "MANUAL SENDING",
            "AUTOMATIC SENDING"});
            this.listBoxSettingTabMode.Location = new System.Drawing.Point(447, 77);
            this.listBoxSettingTabMode.Name = "listBoxSettingTabMode";
            this.listBoxSettingTabMode.Size = new System.Drawing.Size(200, 22);
            this.listBoxSettingTabMode.TabIndex = 12;
            // 
            // textBoxSettingTabLastConfigDate
            // 
            this.textBoxSettingTabLastConfigDate.Location = new System.Drawing.Point(447, 210);
            this.textBoxSettingTabLastConfigDate.Name = "textBoxSettingTabLastConfigDate";
            this.textBoxSettingTabLastConfigDate.ReadOnly = true;
            this.textBoxSettingTabLastConfigDate.Size = new System.Drawing.Size(200, 29);
            this.textBoxSettingTabLastConfigDate.TabIndex = 11;
            // 
            // textBoxSettingTabPeriodicity
            // 
            this.textBoxSettingTabPeriodicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSettingTabPeriodicity.Location = new System.Drawing.Point(447, 143);
            this.textBoxSettingTabPeriodicity.Name = "textBoxSettingTabPeriodicity";
            this.textBoxSettingTabPeriodicity.Size = new System.Drawing.Size(200, 29);
            this.textBoxSettingTabPeriodicity.TabIndex = 10;
            // 
            // monthCalendarSettingTab
            // 
            this.monthCalendarSettingTab.Location = new System.Drawing.Point(72, 68);
            this.monthCalendarSettingTab.MaxSelectionCount = 31;
            this.monthCalendarSettingTab.Name = "monthCalendarSettingTab";
            this.monthCalendarSettingTab.TabIndex = 8;
            this.monthCalendarSettingTab.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(705, 195);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // autoEmailTab
            // 
            this.autoEmailTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.autoEmailTab.Controls.Add(this.dataGridViewAutoMailTab);
            this.autoEmailTab.Controls.Add(this.checkBoxAutoSendEmail);
            this.autoEmailTab.Controls.Add(this.pictureBox4);
            this.autoEmailTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.autoEmailTab.ImageIndex = 6;
            this.autoEmailTab.Location = new System.Drawing.Point(4, 42);
            this.autoEmailTab.Name = "autoEmailTab";
            this.autoEmailTab.Padding = new System.Windows.Forms.Padding(3);
            this.autoEmailTab.Size = new System.Drawing.Size(915, 405);
            this.autoEmailTab.TabIndex = 3;
            this.autoEmailTab.Text = "Auto Email";
            this.autoEmailTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAutoMailTab
            // 
            this.dataGridViewAutoMailTab.AllowUserToAddRows = false;
            this.dataGridViewAutoMailTab.AllowUserToDeleteRows = false;
            this.dataGridViewAutoMailTab.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewAutoMailTab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAutoMailTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAutoMailTab.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoMailTab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAutoMailTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAutoMailTab.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAutoMailTab.Location = new System.Drawing.Point(6, 65);
            this.dataGridViewAutoMailTab.Name = "dataGridViewAutoMailTab";
            this.dataGridViewAutoMailTab.ReadOnly = true;
            this.dataGridViewAutoMailTab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAutoMailTab.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAutoMailTab.Size = new System.Drawing.Size(665, 330);
            this.dataGridViewAutoMailTab.TabIndex = 9;
            // 
            // checkBoxAutoSendEmail
            // 
            this.checkBoxAutoSendEmail.AccessibleDescription = "ON and OFF email sending script";
            this.checkBoxAutoSendEmail.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxAutoSendEmail.AutoSize = true;
            this.checkBoxAutoSendEmail.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAutoSendEmail.Checked = true;
            this.checkBoxAutoSendEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoSendEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxAutoSendEmail.Location = new System.Drawing.Point(6, 6);
            this.checkBoxAutoSendEmail.Name = "checkBoxAutoSendEmail";
            this.checkBoxAutoSendEmail.Size = new System.Drawing.Size(216, 34);
            this.checkBoxAutoSendEmail.TabIndex = 8;
            this.checkBoxAutoSendEmail.Text = "Email Script Check Box";
            this.checkBoxAutoSendEmail.UseMnemonic = false;
            this.checkBoxAutoSendEmail.UseVisualStyleBackColor = true;
            this.checkBoxAutoSendEmail.CheckedChanged += new System.EventHandler(this.checkBoxAutoSendEmail_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(705, 195);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "A d m i n   N a m e ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(953, 615);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Software Scripting";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.wholeTabs.ResumeLayout(false);
            this.addContactsTab.ResumeLayout(false);
            this.addContactsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.searchContactTab.ResumeLayout(false);
            this.searchContactTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.settingTab.ResumeLayout(false);
            this.settingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.autoEmailTab.ResumeLayout(false);
            this.autoEmailTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoMailTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl wholeTabs;
        private System.Windows.Forms.TabPage addContactsTab;
        private System.Windows.Forms.TabPage searchContactTab;
        private System.Windows.Forms.TabPage settingTab;
        private System.Windows.Forms.TabPage autoEmailTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonAddSave;
        private System.Windows.Forms.Button buttonAddCancel;
        private System.Windows.Forms.TextBox textBoxAddSecondLastName;
        private System.Windows.Forms.TextBox textBoxAddFirstLastName;
        private System.Windows.Forms.TextBox textBoxAddEmail;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Button buttonSearchEditModificate;
        private System.Windows.Forms.Button buttonSearchEditLookFor;
        private System.Windows.Forms.TextBox textBoxSearchEditSecondLastName;
        private System.Windows.Forms.TextBox textBoxSearchEditFirstLastName;
        private System.Windows.Forms.TextBox textBoxSearchEditEmail;
        private System.Windows.Forms.TextBox textBoxSearchEditName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkBoxAddVerifyEmail;
        private System.Windows.Forms.CheckBox checkBoxSearchnEditVerifyEmail;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.MonthCalendar monthCalendarSettingTab;
        private System.Windows.Forms.CheckBox checkBoxAutoSendEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchEditEliminate;
        private System.Windows.Forms.ListBox listBoxSettingTabMode;
        private System.Windows.Forms.TextBox textBoxSettingTabLastConfigDate;
        private System.Windows.Forms.TextBox textBoxSettingTabPeriodicity;
        private System.Windows.Forms.Button buttonSettingTabSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewAutoMailTab;
    }
}

