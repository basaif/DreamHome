namespace DreamHome
{
    partial class MenuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchPropertiesButton = new System.Windows.Forms.Button();
            this.StaffBranchesButton = new System.Windows.Forms.Button();
            this.PropertiesOwnersButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchPropertiesButton
            // 
            this.SearchPropertiesButton.FlatAppearance.BorderSize = 0;
            this.SearchPropertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchPropertiesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPropertiesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchPropertiesButton.Image = global::DreamHome.Properties.Resources.find_house_icon;
            this.SearchPropertiesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchPropertiesButton.Location = new System.Drawing.Point(0, 340);
            this.SearchPropertiesButton.Name = "SearchPropertiesButton";
            this.SearchPropertiesButton.Size = new System.Drawing.Size(375, 50);
            this.SearchPropertiesButton.TabIndex = 4;
            this.SearchPropertiesButton.Text = "Search Properties";
            this.SearchPropertiesButton.UseVisualStyleBackColor = true;
            this.SearchPropertiesButton.Click += new System.EventHandler(this.AvailablePropertiesButton_Click);
            // 
            // StaffBranchesButton
            // 
            this.StaffBranchesButton.FlatAppearance.BorderSize = 0;
            this.StaffBranchesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffBranchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffBranchesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StaffBranchesButton.Image = global::DreamHome.Properties.Resources.branches_staff_icon;
            this.StaffBranchesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffBranchesButton.Location = new System.Drawing.Point(0, 290);
            this.StaffBranchesButton.Name = "StaffBranchesButton";
            this.StaffBranchesButton.Size = new System.Drawing.Size(375, 50);
            this.StaffBranchesButton.TabIndex = 3;
            this.StaffBranchesButton.Text = "Staff and Branches";
            this.StaffBranchesButton.UseVisualStyleBackColor = true;
            this.StaffBranchesButton.Click += new System.EventHandler(this.StaffBranchesButton_Click);
            // 
            // PropertiesOwnersButton
            // 
            this.PropertiesOwnersButton.FlatAppearance.BorderSize = 0;
            this.PropertiesOwnersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropertiesOwnersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesOwnersButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PropertiesOwnersButton.Image = global::DreamHome.Properties.Resources.owner_icon;
            this.PropertiesOwnersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PropertiesOwnersButton.Location = new System.Drawing.Point(0, 240);
            this.PropertiesOwnersButton.Name = "PropertiesOwnersButton";
            this.PropertiesOwnersButton.Size = new System.Drawing.Size(375, 50);
            this.PropertiesOwnersButton.TabIndex = 2;
            this.PropertiesOwnersButton.Text = "Oweners and Properties";
            this.PropertiesOwnersButton.UseVisualStyleBackColor = true;
            this.PropertiesOwnersButton.Click += new System.EventHandler(this.PropertiesOwnersButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientsButton.Image = global::DreamHome.Properties.Resources.customer_icon;
            this.ClientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsButton.Location = new System.Drawing.Point(0, 190);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(375, 50);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = global::DreamHome.Properties.Resources.dreamhome_logo_small;
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoPictureBox.Location = new System.Drawing.Point(36, 25);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(294, 159);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.SearchPropertiesButton);
            this.Controls.Add(this.StaffBranchesButton);
            this.Controls.Add(this.PropertiesOwnersButton);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(375, 920);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button PropertiesOwnersButton;
        private System.Windows.Forms.Button StaffBranchesButton;
        private System.Windows.Forms.Button SearchPropertiesButton;
       
    }
}
