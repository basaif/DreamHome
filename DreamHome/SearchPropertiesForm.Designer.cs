namespace DreamHome
{
    partial class SearchPropertiesForm
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
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.flatRadioButton = new System.Windows.Forms.RadioButton();
            this.houseRadioButton = new System.Windows.Forms.RadioButton();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.rentLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.PropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.PropertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.headerUserControl1 = new DreamHome.HeaderUserControl();
            this.menuUserControl1 = new DreamHome.MenuUserControl();
            this.SearchGroupBox.SuspendLayout();
            this.PropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.errorLabel);
            this.SearchGroupBox.Controls.Add(this.searchButton);
            this.SearchGroupBox.Controls.Add(this.flatRadioButton);
            this.SearchGroupBox.Controls.Add(this.houseRadioButton);
            this.SearchGroupBox.Controls.Add(this.rentTextBox);
            this.SearchGroupBox.Controls.Add(this.rentLabel);
            this.SearchGroupBox.Controls.Add(this.typeLabel);
            this.SearchGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchGroupBox.Location = new System.Drawing.Point(406, 80);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchGroupBox.Size = new System.Drawing.Size(885, 175);
            this.SearchGroupBox.TabIndex = 1;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorLabel.Location = new System.Drawing.Point(235, 135);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = global::DreamHome.Properties.Resources.search_icon;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(720, 121);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(140, 40);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // flatRadioButton
            // 
            this.flatRadioButton.AutoSize = true;
            this.flatRadioButton.Location = new System.Drawing.Point(341, 54);
            this.flatRadioButton.Name = "flatRadioButton";
            this.flatRadioButton.Size = new System.Drawing.Size(58, 24);
            this.flatRadioButton.TabIndex = 5;
            this.flatRadioButton.TabStop = true;
            this.flatRadioButton.Text = "Flat";
            this.flatRadioButton.UseVisualStyleBackColor = true;
            // 
            // houseRadioButton
            // 
            this.houseRadioButton.AutoSize = true;
            this.houseRadioButton.Location = new System.Drawing.Point(235, 54);
            this.houseRadioButton.Name = "houseRadioButton";
            this.houseRadioButton.Size = new System.Drawing.Size(79, 24);
            this.houseRadioButton.TabIndex = 4;
            this.houseRadioButton.TabStop = true;
            this.houseRadioButton.Text = "House";
            this.houseRadioButton.UseVisualStyleBackColor = true;
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(235, 95);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(100, 27);
            this.rentTextBox.TabIndex = 3;
            // 
            // rentLabel
            // 
            this.rentLabel.AutoSize = true;
            this.rentLabel.Location = new System.Drawing.Point(63, 98);
            this.rentLabel.Name = "rentLabel";
            this.rentLabel.Size = new System.Drawing.Size(135, 20);
            this.rentLabel.TabIndex = 1;
            this.rentLabel.Text = "Rent is less than";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(153, 56);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(45, 20);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Type";
            // 
            // PropertiesGroupBox
            // 
            this.PropertiesGroupBox.Controls.Add(this.PropertiesDataGridView);
            this.PropertiesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesGroupBox.Location = new System.Drawing.Point(406, 279);
            this.PropertiesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PropertiesGroupBox.Name = "PropertiesGroupBox";
            this.PropertiesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PropertiesGroupBox.Size = new System.Drawing.Size(885, 497);
            this.PropertiesGroupBox.TabIndex = 2;
            this.PropertiesGroupBox.TabStop = false;
            this.PropertiesGroupBox.Text = "Properties";
            // 
            // PropertiesDataGridView
            // 
            this.PropertiesDataGridView.AllowUserToAddRows = false;
            this.PropertiesDataGridView.AllowUserToDeleteRows = false;
            this.PropertiesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.PropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertiesDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.PropertiesDataGridView.Location = new System.Drawing.Point(24, 62);
            this.PropertiesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PropertiesDataGridView.Name = "PropertiesDataGridView";
            this.PropertiesDataGridView.ReadOnly = true;
            this.PropertiesDataGridView.RowTemplate.Height = 24;
            this.PropertiesDataGridView.Size = new System.Drawing.Size(839, 384);
            this.PropertiesDataGridView.TabIndex = 0;
            // 
            // headerUserControl1
            // 
            this.headerUserControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerUserControl1.Location = new System.Drawing.Point(375, 0);
            this.headerUserControl1.Name = "headerUserControl1";
            this.headerUserControl1.Size = new System.Drawing.Size(950, 47);
            this.headerUserControl1.TabIndex = 3;
            // 
            // menuUserControl1
            // 
            this.menuUserControl1.BackColor = System.Drawing.Color.Navy;
            this.menuUserControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuUserControl1.Location = new System.Drawing.Point(0, 0);
            this.menuUserControl1.Name = "menuUserControl1";
            this.menuUserControl1.Size = new System.Drawing.Size(375, 800);
            this.menuUserControl1.TabIndex = 4;
            // 
            // SearchPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 800);
            this.Controls.Add(this.menuUserControl1);
            this.Controls.Add(this.headerUserControl1);
            this.Controls.Add(this.PropertiesGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Properties";
            this.Load += new System.EventHandler(this.AvailablePropertiesForm_Load);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.PropertiesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.GroupBox PropertiesGroupBox;
        private System.Windows.Forms.DataGridView PropertiesDataGridView;
        private HeaderUserControl headerUserControl1;
        private System.Windows.Forms.RadioButton flatRadioButton;
        private System.Windows.Forms.RadioButton houseRadioButton;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.Label rentLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label errorLabel;
        private MenuUserControl menuUserControl1;
    }
}