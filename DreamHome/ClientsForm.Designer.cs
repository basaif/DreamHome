namespace DreamHome
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.ClientDeleteButton = new System.Windows.Forms.Button();
            this.ClientNoTextBox = new System.Windows.Forms.TextBox();
            this.ClientNoLabel = new System.Windows.Forms.Label();
            this.ClientFNameLabel = new System.Windows.Forms.Label();
            this.ClientFNameTextBox = new System.Windows.Forms.TextBox();
            this.ClientLNameLabel = new System.Windows.Forms.Label();
            this.ClientLNameTextBox = new System.Windows.Forms.TextBox();
            this.StaffClientPhoneNoLabel = new System.Windows.Forms.Label();
            this.StaffSexLabel = new System.Windows.Forms.Label();
            this.ClientMaxRentLabel = new System.Windows.Forms.Label();
            this.ClientEmailLabel = new System.Windows.Forms.Label();
            this.ClientEmailTextBox = new System.Windows.Forms.TextBox();
            this.ClientFlatRadioButton = new System.Windows.Forms.RadioButton();
            this.ClientHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.ClientAddButton = new System.Windows.Forms.Button();
            this.ClientPrevButton = new System.Windows.Forms.Button();
            this.ClientNextButton = new System.Windows.Forms.Button();
            this.ClientNoneRadioButton = new System.Windows.Forms.RadioButton();
            this.ClientGroupBox = new System.Windows.Forms.GroupBox();
            this.ClientMaxRentmaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.ClientSaveButton = new System.Windows.Forms.Button();
            this.ClientPhoneNomaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.ClientModifyButton = new System.Windows.Forms.Button();
            this.RegistrationGroupBox = new System.Windows.Forms.GroupBox();
            this.RegistrationSaveButton = new System.Windows.Forms.Button();
            this.RegistrationBranchComboBox = new System.Windows.Forms.ComboBox();
            this.RegistrationStaffComboBox = new System.Windows.Forms.ComboBox();
            this.RegistrationClientComboBox = new System.Windows.Forms.ComboBox();
            this.RegistrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegistrationStaffNoLabel = new System.Windows.Forms.Label();
            this.RegistrationBranchNoLabel = new System.Windows.Forms.Label();
            this.RegistrationNextButton = new System.Windows.Forms.Button();
            this.RegistrationPrevButton = new System.Windows.Forms.Button();
            this.RegistrationDeleteButton = new System.Windows.Forms.Button();
            this.RegistrationModifyButton = new System.Windows.Forms.Button();
            this.RegistrationAddButton = new System.Windows.Forms.Button();
            this.RegistrationDateLabel = new System.Windows.Forms.Label();
            this.RegistrationClientNoLabel = new System.Windows.Forms.Label();
            this.headerUserControl1 = new DreamHome.HeaderUserControl();
            this.ClientsMenuUserControl = new DreamHome.MenuUserControl();
            this.ClientGroupBox.SuspendLayout();
            this.RegistrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientDeleteButton
            // 
            this.ClientDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientDeleteButton.Image")));
            this.ClientDeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientDeleteButton.Location = new System.Drawing.Point(548, 191);
            this.ClientDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientDeleteButton.Name = "ClientDeleteButton";
            this.ClientDeleteButton.Size = new System.Drawing.Size(105, 32);
            this.ClientDeleteButton.TabIndex = 26;
            this.ClientDeleteButton.Text = "Delete";
            this.ClientDeleteButton.UseVisualStyleBackColor = true;
            this.ClientDeleteButton.Click += new System.EventHandler(this.ClientDeleteButton_Click);
            // 
            // ClientNoTextBox
            // 
            this.ClientNoTextBox.Location = new System.Drawing.Point(110, 43);
            this.ClientNoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNoTextBox.Name = "ClientNoTextBox";
            this.ClientNoTextBox.ReadOnly = true;
            this.ClientNoTextBox.Size = new System.Drawing.Size(76, 23);
            this.ClientNoTextBox.TabIndex = 0;
            this.ClientNoTextBox.TextChanged += new System.EventHandler(this.ClientNoTextBox_TextChanged);
            // 
            // ClientNoLabel
            // 
            this.ClientNoLabel.AutoSize = true;
            this.ClientNoLabel.Location = new System.Drawing.Point(46, 46);
            this.ClientNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientNoLabel.Name = "ClientNoLabel";
            this.ClientNoLabel.Size = new System.Drawing.Size(61, 17);
            this.ClientNoLabel.TabIndex = 1;
            this.ClientNoLabel.Text = "ClientNo";
            this.ClientNoLabel.Click += new System.EventHandler(this.StaffNoLabel_Click);
            // 
            // ClientFNameLabel
            // 
            this.ClientFNameLabel.AutoSize = true;
            this.ClientFNameLabel.Location = new System.Drawing.Point(32, 80);
            this.ClientFNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientFNameLabel.Name = "ClientFNameLabel";
            this.ClientFNameLabel.Size = new System.Drawing.Size(76, 17);
            this.ClientFNameLabel.TabIndex = 2;
            this.ClientFNameLabel.Text = "First Name";
            // 
            // ClientFNameTextBox
            // 
            this.ClientFNameTextBox.Location = new System.Drawing.Point(110, 77);
            this.ClientFNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClientFNameTextBox.Name = "ClientFNameTextBox";
            this.ClientFNameTextBox.Size = new System.Drawing.Size(161, 23);
            this.ClientFNameTextBox.TabIndex = 3;
            // 
            // ClientLNameLabel
            // 
            this.ClientLNameLabel.AutoSize = true;
            this.ClientLNameLabel.Location = new System.Drawing.Point(352, 75);
            this.ClientLNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientLNameLabel.Name = "ClientLNameLabel";
            this.ClientLNameLabel.Size = new System.Drawing.Size(76, 17);
            this.ClientLNameLabel.TabIndex = 4;
            this.ClientLNameLabel.Text = "Last Name";
            // 
            // ClientLNameTextBox
            // 
            this.ClientLNameTextBox.Location = new System.Drawing.Point(436, 75);
            this.ClientLNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClientLNameTextBox.Name = "ClientLNameTextBox";
            this.ClientLNameTextBox.Size = new System.Drawing.Size(161, 23);
            this.ClientLNameTextBox.TabIndex = 5;
            // 
            // StaffClientPhoneNoLabel
            // 
            this.StaffClientPhoneNoLabel.AutoSize = true;
            this.StaffClientPhoneNoLabel.Location = new System.Drawing.Point(36, 114);
            this.StaffClientPhoneNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StaffClientPhoneNoLabel.Name = "StaffClientPhoneNoLabel";
            this.StaffClientPhoneNoLabel.Size = new System.Drawing.Size(76, 17);
            this.StaffClientPhoneNoLabel.TabIndex = 6;
            this.StaffClientPhoneNoLabel.Text = "Telephone";
            this.StaffClientPhoneNoLabel.Click += new System.EventHandler(this.StaffPositionLabel_Click);
            // 
            // StaffSexLabel
            // 
            this.StaffSexLabel.AutoSize = true;
            this.StaffSexLabel.Location = new System.Drawing.Point(330, 149);
            this.StaffSexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StaffSexLabel.Name = "StaffSexLabel";
            this.StaffSexLabel.Size = new System.Drawing.Size(104, 17);
            this.StaffSexLabel.TabIndex = 7;
            this.StaffSexLabel.Text = "Preferred Type";
            // 
            // ClientMaxRentLabel
            // 
            this.ClientMaxRentLabel.AutoSize = true;
            this.ClientMaxRentLabel.Location = new System.Drawing.Point(40, 148);
            this.ClientMaxRentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientMaxRentLabel.Name = "ClientMaxRentLabel";
            this.ClientMaxRentLabel.Size = new System.Drawing.Size(67, 17);
            this.ClientMaxRentLabel.TabIndex = 9;
            this.ClientMaxRentLabel.Text = "Max Rent";
            // 
            // ClientEmailLabel
            // 
            this.ClientEmailLabel.AutoSize = true;
            this.ClientEmailLabel.Location = new System.Drawing.Point(382, 111);
            this.ClientEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientEmailLabel.Name = "ClientEmailLabel";
            this.ClientEmailLabel.Size = new System.Drawing.Size(42, 17);
            this.ClientEmailLabel.TabIndex = 11;
            this.ClientEmailLabel.Text = "Email";
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.Location = new System.Drawing.Point(436, 111);
            this.ClientEmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.Size = new System.Drawing.Size(161, 23);
            this.ClientEmailTextBox.TabIndex = 14;
            // 
            // ClientFlatRadioButton
            // 
            this.ClientFlatRadioButton.AutoSize = true;
            this.ClientFlatRadioButton.Location = new System.Drawing.Point(436, 147);
            this.ClientFlatRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientFlatRadioButton.Name = "ClientFlatRadioButton";
            this.ClientFlatRadioButton.Size = new System.Drawing.Size(49, 21);
            this.ClientFlatRadioButton.TabIndex = 16;
            this.ClientFlatRadioButton.TabStop = true;
            this.ClientFlatRadioButton.Text = "Flat";
            this.ClientFlatRadioButton.UseVisualStyleBackColor = true;
            this.ClientFlatRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // ClientHouseRadioButton
            // 
            this.ClientHouseRadioButton.AutoSize = true;
            this.ClientHouseRadioButton.Location = new System.Drawing.Point(484, 147);
            this.ClientHouseRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientHouseRadioButton.Name = "ClientHouseRadioButton";
            this.ClientHouseRadioButton.Size = new System.Drawing.Size(67, 21);
            this.ClientHouseRadioButton.TabIndex = 17;
            this.ClientHouseRadioButton.TabStop = true;
            this.ClientHouseRadioButton.Text = "House";
            this.ClientHouseRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClientAddButton
            // 
            this.ClientAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.ClientAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientAddButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientAddButton.Image")));
            this.ClientAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientAddButton.Location = new System.Drawing.Point(328, 191);
            this.ClientAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientAddButton.Name = "ClientAddButton";
            this.ClientAddButton.Size = new System.Drawing.Size(105, 32);
            this.ClientAddButton.TabIndex = 19;
            this.ClientAddButton.Text = "Add";
            this.ClientAddButton.UseVisualStyleBackColor = true;
            this.ClientAddButton.Click += new System.EventHandler(this.ClientAddButton_Click);
            // 
            // ClientPrevButton
            // 
            this.ClientPrevButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.ClientPrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientPrevButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientPrevButton.Image")));
            this.ClientPrevButton.Location = new System.Drawing.Point(12, 191);
            this.ClientPrevButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientPrevButton.Name = "ClientPrevButton";
            this.ClientPrevButton.Size = new System.Drawing.Size(45, 32);
            this.ClientPrevButton.TabIndex = 22;
            this.ClientPrevButton.UseVisualStyleBackColor = true;
            this.ClientPrevButton.Click += new System.EventHandler(this.ClientPrevButton_Click);
            // 
            // ClientNextButton
            // 
            this.ClientNextButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.ClientNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientNextButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientNextButton.Image")));
            this.ClientNextButton.Location = new System.Drawing.Point(62, 191);
            this.ClientNextButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNextButton.Name = "ClientNextButton";
            this.ClientNextButton.Size = new System.Drawing.Size(45, 32);
            this.ClientNextButton.TabIndex = 23;
            this.ClientNextButton.UseVisualStyleBackColor = true;
            this.ClientNextButton.Click += new System.EventHandler(this.ClientNextButton_Click);
            // 
            // ClientNoneRadioButton
            // 
            this.ClientNoneRadioButton.AutoSize = true;
            this.ClientNoneRadioButton.Location = new System.Drawing.Point(548, 147);
            this.ClientNoneRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNoneRadioButton.Name = "ClientNoneRadioButton";
            this.ClientNoneRadioButton.Size = new System.Drawing.Size(60, 21);
            this.ClientNoneRadioButton.TabIndex = 24;
            this.ClientNoneRadioButton.TabStop = true;
            this.ClientNoneRadioButton.Text = "None";
            this.ClientNoneRadioButton.UseVisualStyleBackColor = true;
            this.ClientNoneRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ClientGroupBox
            // 
            this.ClientGroupBox.Controls.Add(this.ClientMaxRentmaskedTextBox2);
            this.ClientGroupBox.Controls.Add(this.ClientSaveButton);
            this.ClientGroupBox.Controls.Add(this.ClientPhoneNomaskedTextBox1);
            this.ClientGroupBox.Controls.Add(this.ClientModifyButton);
            this.ClientGroupBox.Controls.Add(this.ClientDeleteButton);
            this.ClientGroupBox.Controls.Add(this.ClientNoneRadioButton);
            this.ClientGroupBox.Controls.Add(this.ClientNextButton);
            this.ClientGroupBox.Controls.Add(this.ClientPrevButton);
            this.ClientGroupBox.Controls.Add(this.ClientAddButton);
            this.ClientGroupBox.Controls.Add(this.ClientHouseRadioButton);
            this.ClientGroupBox.Controls.Add(this.ClientFlatRadioButton);
            this.ClientGroupBox.Controls.Add(this.ClientEmailTextBox);
            this.ClientGroupBox.Controls.Add(this.ClientEmailLabel);
            this.ClientGroupBox.Controls.Add(this.ClientMaxRentLabel);
            this.ClientGroupBox.Controls.Add(this.StaffSexLabel);
            this.ClientGroupBox.Controls.Add(this.StaffClientPhoneNoLabel);
            this.ClientGroupBox.Controls.Add(this.ClientLNameTextBox);
            this.ClientGroupBox.Controls.Add(this.ClientLNameLabel);
            this.ClientGroupBox.Controls.Add(this.ClientFNameTextBox);
            this.ClientGroupBox.Controls.Add(this.ClientFNameLabel);
            this.ClientGroupBox.Controls.Add(this.ClientNoLabel);
            this.ClientGroupBox.Controls.Add(this.ClientNoTextBox);
            this.ClientGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientGroupBox.Location = new System.Drawing.Point(308, 76);
            this.ClientGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClientGroupBox.Name = "ClientGroupBox";
            this.ClientGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ClientGroupBox.Size = new System.Drawing.Size(664, 237);
            this.ClientGroupBox.TabIndex = 2;
            this.ClientGroupBox.TabStop = false;
            this.ClientGroupBox.Text = "Clients";
            this.ClientGroupBox.Enter += new System.EventHandler(this.StaffGroupBox_Enter);
            // 
            // ClientMaxRentmaskedTextBox2
            // 
            this.ClientMaxRentmaskedTextBox2.Location = new System.Drawing.Point(110, 143);
            this.ClientMaxRentmaskedTextBox2.Mask = "999999";
            this.ClientMaxRentmaskedTextBox2.Name = "ClientMaxRentmaskedTextBox2";
            this.ClientMaxRentmaskedTextBox2.Size = new System.Drawing.Size(161, 23);
            this.ClientMaxRentmaskedTextBox2.TabIndex = 30;
            // 
            // ClientSaveButton
            // 
            this.ClientSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.ClientSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientSaveButton.Image")));
            this.ClientSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientSaveButton.Location = new System.Drawing.Point(219, 191);
            this.ClientSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientSaveButton.Name = "ClientSaveButton";
            this.ClientSaveButton.Size = new System.Drawing.Size(105, 32);
            this.ClientSaveButton.TabIndex = 27;
            this.ClientSaveButton.Text = "Save";
            this.ClientSaveButton.UseVisualStyleBackColor = true;
            this.ClientSaveButton.Click += new System.EventHandler(this.ClientSaveButton_Click);
            // 
            // ClientPhoneNomaskedTextBox1
            // 
            this.ClientPhoneNomaskedTextBox1.Location = new System.Drawing.Point(111, 114);
            this.ClientPhoneNomaskedTextBox1.Mask = "799999999";
            this.ClientPhoneNomaskedTextBox1.Name = "ClientPhoneNomaskedTextBox1";
            this.ClientPhoneNomaskedTextBox1.Size = new System.Drawing.Size(160, 23);
            this.ClientPhoneNomaskedTextBox1.TabIndex = 29;
            // 
            // ClientModifyButton
            // 
            this.ClientModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.ClientModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientModifyButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientModifyButton.Image")));
            this.ClientModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientModifyButton.Location = new System.Drawing.Point(438, 191);
            this.ClientModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClientModifyButton.Name = "ClientModifyButton";
            this.ClientModifyButton.Size = new System.Drawing.Size(105, 32);
            this.ClientModifyButton.TabIndex = 26;
            this.ClientModifyButton.Text = "Modify";
            this.ClientModifyButton.UseVisualStyleBackColor = true;
            this.ClientModifyButton.Click += new System.EventHandler(this.ClientModifyButton_Click);
            // 
            // RegistrationGroupBox
            // 
            this.RegistrationGroupBox.Controls.Add(this.RegistrationSaveButton);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationBranchComboBox);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationStaffComboBox);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationClientComboBox);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationDateTimePicker);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationStaffNoLabel);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationBranchNoLabel);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationNextButton);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationPrevButton);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationDeleteButton);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationModifyButton);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationAddButton);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationDateLabel);
            this.RegistrationGroupBox.Controls.Add(this.RegistrationClientNoLabel);
            this.RegistrationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationGroupBox.Location = new System.Drawing.Point(308, 392);
            this.RegistrationGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationGroupBox.Name = "RegistrationGroupBox";
            this.RegistrationGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RegistrationGroupBox.Size = new System.Drawing.Size(664, 192);
            this.RegistrationGroupBox.TabIndex = 26;
            this.RegistrationGroupBox.TabStop = false;
            this.RegistrationGroupBox.Text = "Registration";
            this.RegistrationGroupBox.Enter += new System.EventHandler(this.RegistrationGroupBox_Enter);
            // 
            // RegistrationSaveButton
            // 
            this.RegistrationSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.RegistrationSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrationSaveButton.Image")));
            this.RegistrationSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationSaveButton.Location = new System.Drawing.Point(219, 146);
            this.RegistrationSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationSaveButton.Name = "RegistrationSaveButton";
            this.RegistrationSaveButton.Size = new System.Drawing.Size(105, 32);
            this.RegistrationSaveButton.TabIndex = 32;
            this.RegistrationSaveButton.Text = "Save";
            this.RegistrationSaveButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationBranchComboBox
            // 
            this.RegistrationBranchComboBox.FormattingEnabled = true;
            this.RegistrationBranchComboBox.Location = new System.Drawing.Point(330, 49);
            this.RegistrationBranchComboBox.Name = "RegistrationBranchComboBox";
            this.RegistrationBranchComboBox.Size = new System.Drawing.Size(121, 25);
            this.RegistrationBranchComboBox.TabIndex = 31;
            // 
            // RegistrationStaffComboBox
            // 
            this.RegistrationStaffComboBox.FormattingEnabled = true;
            this.RegistrationStaffComboBox.Location = new System.Drawing.Point(523, 49);
            this.RegistrationStaffComboBox.Name = "RegistrationStaffComboBox";
            this.RegistrationStaffComboBox.Size = new System.Drawing.Size(121, 25);
            this.RegistrationStaffComboBox.TabIndex = 30;
            // 
            // RegistrationClientComboBox
            // 
            this.RegistrationClientComboBox.FormattingEnabled = true;
            this.RegistrationClientComboBox.Location = new System.Drawing.Point(111, 49);
            this.RegistrationClientComboBox.Name = "RegistrationClientComboBox";
            this.RegistrationClientComboBox.Size = new System.Drawing.Size(121, 25);
            this.RegistrationClientComboBox.TabIndex = 29;
            // 
            // RegistrationDateTimePicker
            // 
            this.RegistrationDateTimePicker.CustomFormat = "dd/mm/yyyy";
            this.RegistrationDateTimePicker.Location = new System.Drawing.Point(111, 91);
            this.RegistrationDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationDateTimePicker.Name = "RegistrationDateTimePicker";
            this.RegistrationDateTimePicker.Size = new System.Drawing.Size(234, 23);
            this.RegistrationDateTimePicker.TabIndex = 28;
            // 
            // RegistrationStaffNoLabel
            // 
            this.RegistrationStaffNoLabel.AutoSize = true;
            this.RegistrationStaffNoLabel.Location = new System.Drawing.Point(472, 51);
            this.RegistrationStaffNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationStaffNoLabel.Name = "RegistrationStaffNoLabel";
            this.RegistrationStaffNoLabel.Size = new System.Drawing.Size(37, 17);
            this.RegistrationStaffNoLabel.TabIndex = 27;
            this.RegistrationStaffNoLabel.Text = "Staff";
            // 
            // RegistrationBranchNoLabel
            // 
            this.RegistrationBranchNoLabel.AutoSize = true;
            this.RegistrationBranchNoLabel.Location = new System.Drawing.Point(267, 51);
            this.RegistrationBranchNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationBranchNoLabel.Name = "RegistrationBranchNoLabel";
            this.RegistrationBranchNoLabel.Size = new System.Drawing.Size(53, 17);
            this.RegistrationBranchNoLabel.TabIndex = 25;
            this.RegistrationBranchNoLabel.Text = "Branch";
            // 
            // RegistrationNextButton
            // 
            this.RegistrationNextButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.RegistrationNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationNextButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrationNextButton.Image")));
            this.RegistrationNextButton.Location = new System.Drawing.Point(62, 146);
            this.RegistrationNextButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationNextButton.Name = "RegistrationNextButton";
            this.RegistrationNextButton.Size = new System.Drawing.Size(45, 32);
            this.RegistrationNextButton.TabIndex = 23;
            this.RegistrationNextButton.UseVisualStyleBackColor = true;
            this.RegistrationNextButton.Click += new System.EventHandler(this.RegistrationNextButton_Click);
            // 
            // RegistrationPrevButton
            // 
            this.RegistrationPrevButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.RegistrationPrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationPrevButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrationPrevButton.Image")));
            this.RegistrationPrevButton.Location = new System.Drawing.Point(12, 146);
            this.RegistrationPrevButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationPrevButton.Name = "RegistrationPrevButton";
            this.RegistrationPrevButton.Size = new System.Drawing.Size(45, 32);
            this.RegistrationPrevButton.TabIndex = 22;
            this.RegistrationPrevButton.UseVisualStyleBackColor = true;
            this.RegistrationPrevButton.Click += new System.EventHandler(this.RegistrationPrevButton_Click);
            // 
            // RegistrationDeleteButton
            // 
            this.RegistrationDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegistrationDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrationDeleteButton.Image")));
            this.RegistrationDeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationDeleteButton.Location = new System.Drawing.Point(548, 146);
            this.RegistrationDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationDeleteButton.Name = "RegistrationDeleteButton";
            this.RegistrationDeleteButton.Size = new System.Drawing.Size(105, 32);
            this.RegistrationDeleteButton.TabIndex = 21;
            this.RegistrationDeleteButton.Text = "Delete";
            this.RegistrationDeleteButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationModifyButton
            // 
            this.RegistrationModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.RegistrationModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationModifyButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrationModifyButton.Image")));
            this.RegistrationModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationModifyButton.Location = new System.Drawing.Point(438, 146);
            this.RegistrationModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationModifyButton.Name = "RegistrationModifyButton";
            this.RegistrationModifyButton.Size = new System.Drawing.Size(105, 32);
            this.RegistrationModifyButton.TabIndex = 20;
            this.RegistrationModifyButton.Text = "Modify";
            this.RegistrationModifyButton.UseVisualStyleBackColor = true;
            this.RegistrationModifyButton.Click += new System.EventHandler(this.button11_Click);
            // 
            // RegistrationAddButton
            // 
            this.RegistrationAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.RegistrationAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationAddButton.Image = ((System.Drawing.Image)(resources.GetObject("RegistrationAddButton.Image")));
            this.RegistrationAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrationAddButton.Location = new System.Drawing.Point(328, 146);
            this.RegistrationAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegistrationAddButton.Name = "RegistrationAddButton";
            this.RegistrationAddButton.Size = new System.Drawing.Size(105, 32);
            this.RegistrationAddButton.TabIndex = 19;
            this.RegistrationAddButton.Text = "Add";
            this.RegistrationAddButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationDateLabel
            // 
            this.RegistrationDateLabel.AutoSize = true;
            this.RegistrationDateLabel.Location = new System.Drawing.Point(22, 97);
            this.RegistrationDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationDateLabel.Name = "RegistrationDateLabel";
            this.RegistrationDateLabel.Size = new System.Drawing.Size(84, 17);
            this.RegistrationDateLabel.TabIndex = 2;
            this.RegistrationDateLabel.Text = "Date Joined";
            // 
            // RegistrationClientNoLabel
            // 
            this.RegistrationClientNoLabel.AutoSize = true;
            this.RegistrationClientNoLabel.Location = new System.Drawing.Point(62, 49);
            this.RegistrationClientNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RegistrationClientNoLabel.Name = "RegistrationClientNoLabel";
            this.RegistrationClientNoLabel.Size = new System.Drawing.Size(43, 17);
            this.RegistrationClientNoLabel.TabIndex = 1;
            this.RegistrationClientNoLabel.Text = "Client";
            // 
            // headerUserControl1
            // 
            this.headerUserControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerUserControl1.Location = new System.Drawing.Point(281, 0);
            this.headerUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headerUserControl1.Name = "headerUserControl1";
            this.headerUserControl1.Size = new System.Drawing.Size(712, 41);
            this.headerUserControl1.TabIndex = 28;
            // 
            // ClientsMenuUserControl
            // 
            this.ClientsMenuUserControl.BackColor = System.Drawing.Color.Navy;
            this.ClientsMenuUserControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClientsMenuUserControl.Location = new System.Drawing.Point(0, 0);
            this.ClientsMenuUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientsMenuUserControl.Name = "ClientsMenuUserControl";
            this.ClientsMenuUserControl.Size = new System.Drawing.Size(281, 640);
            this.ClientsMenuUserControl.TabIndex = 27;
            this.ClientsMenuUserControl.Load += new System.EventHandler(this.ClientsMenuUserControl_Load);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 640);
            this.Controls.Add(this.headerUserControl1);
            this.Controls.Add(this.ClientsMenuUserControl);
            this.Controls.Add(this.RegistrationGroupBox);
            this.Controls.Add(this.ClientGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.formclients_Load);
            this.ClientGroupBox.ResumeLayout(false);
            this.ClientGroupBox.PerformLayout();
            this.RegistrationGroupBox.ResumeLayout(false);
            this.RegistrationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientDeleteButton;
        private System.Windows.Forms.TextBox ClientNoTextBox;
        private System.Windows.Forms.Label ClientNoLabel;
        private System.Windows.Forms.Label ClientFNameLabel;
        private System.Windows.Forms.TextBox ClientFNameTextBox;
        private System.Windows.Forms.Label ClientLNameLabel;
        private System.Windows.Forms.TextBox ClientLNameTextBox;
        private System.Windows.Forms.Label StaffClientPhoneNoLabel;
        private System.Windows.Forms.Label StaffSexLabel;
        private System.Windows.Forms.Label ClientMaxRentLabel;
        private System.Windows.Forms.Label ClientEmailLabel;
        private System.Windows.Forms.TextBox ClientEmailTextBox;
        private System.Windows.Forms.RadioButton ClientFlatRadioButton;
        private System.Windows.Forms.RadioButton ClientHouseRadioButton;
        private System.Windows.Forms.Button ClientAddButton;
        private System.Windows.Forms.Button ClientPrevButton;
        private System.Windows.Forms.Button ClientNextButton;
        private System.Windows.Forms.RadioButton ClientNoneRadioButton;
        private System.Windows.Forms.GroupBox ClientGroupBox;
        private System.Windows.Forms.Button ClientModifyButton;
        private System.Windows.Forms.GroupBox RegistrationGroupBox;
        private System.Windows.Forms.Label RegistrationStaffNoLabel;
        private System.Windows.Forms.Label RegistrationBranchNoLabel;
        private System.Windows.Forms.Button RegistrationNextButton;
        private System.Windows.Forms.Button RegistrationPrevButton;
        private System.Windows.Forms.Button RegistrationDeleteButton;
        private System.Windows.Forms.Button RegistrationModifyButton;
        private System.Windows.Forms.Button RegistrationAddButton;
        private System.Windows.Forms.Label RegistrationDateLabel;
        private System.Windows.Forms.Label RegistrationClientNoLabel;
        private System.Windows.Forms.DateTimePicker RegistrationDateTimePicker;
        private System.Windows.Forms.ComboBox RegistrationBranchComboBox;
        private System.Windows.Forms.ComboBox RegistrationStaffComboBox;
        private System.Windows.Forms.ComboBox RegistrationClientComboBox;
        private MenuUserControl ClientsMenuUserControl;
        private HeaderUserControl headerUserControl1;
        private System.Windows.Forms.Button ClientSaveButton;
        private System.Windows.Forms.Button RegistrationSaveButton;
        private System.Windows.Forms.MaskedTextBox ClientPhoneNomaskedTextBox1;
        private System.Windows.Forms.MaskedTextBox ClientMaxRentmaskedTextBox2;
    }
}