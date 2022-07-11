namespace SalesWinApp
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCompanyName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCity = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCountry = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnNew = new MaterialSkin.Controls.MaterialButton();
            this.txtID = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(39, 13);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(435, 391);
            this.dgvMemberList.TabIndex = 0;
            this.dgvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(488, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(488, 42);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(250, 36);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.UseTallSize = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HideSelection = true;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(488, 112);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 36);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(488, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Password";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AnimateReadOnly = false;
            this.txtCompanyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompanyName.Depth = 0;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyName.HideSelection = true;
            this.txtCompanyName.LeadingIcon = null;
            this.txtCompanyName.Location = new System.Drawing.Point(488, 182);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PrefixSuffixText = null;
            this.txtCompanyName.ReadOnly = false;
            this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(250, 36);
            this.txtCompanyName.TabIndex = 6;
            this.txtCompanyName.TabStop = false;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyName.TrailingIcon = null;
            this.txtCompanyName.UseSystemPasswordChar = false;
            this.txtCompanyName.UseTallSize = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(488, 160);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(115, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Company Name";
            // 
            // txtCity
            // 
            this.txtCity.AnimateReadOnly = false;
            this.txtCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCity.Depth = 0;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCity.HideSelection = true;
            this.txtCity.LeadingIcon = null;
            this.txtCity.Location = new System.Drawing.Point(488, 254);
            this.txtCity.MaxLength = 32767;
            this.txtCity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PrefixSuffixText = null;
            this.txtCity.ReadOnly = false;
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.ShortcutsEnabled = true;
            this.txtCity.Size = new System.Drawing.Size(250, 36);
            this.txtCity.TabIndex = 8;
            this.txtCity.TabStop = false;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCity.TrailingIcon = null;
            this.txtCity.UseSystemPasswordChar = false;
            this.txtCity.UseTallSize = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(488, 232);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(28, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "City";
            // 
            // txtCountry
            // 
            this.txtCountry.AnimateReadOnly = false;
            this.txtCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCountry.Depth = 0;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCountry.HideSelection = true;
            this.txtCountry.LeadingIcon = null;
            this.txtCountry.Location = new System.Drawing.Point(488, 325);
            this.txtCountry.MaxLength = 32767;
            this.txtCountry.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PasswordChar = '\0';
            this.txtCountry.PrefixSuffixText = null;
            this.txtCountry.ReadOnly = false;
            this.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountry.SelectedText = "";
            this.txtCountry.SelectionLength = 0;
            this.txtCountry.SelectionStart = 0;
            this.txtCountry.ShortcutsEnabled = true;
            this.txtCountry.Size = new System.Drawing.Size(250, 36);
            this.txtCountry.TabIndex = 10;
            this.txtCountry.TabStop = false;
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCountry.TrailingIcon = null;
            this.txtCountry.UseSystemPasswordChar = false;
            this.txtCountry.UseTallSize = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(488, 303);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(56, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Country";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(488, 370);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(117, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(621, 370);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(117, 36);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = false;
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNew.Depth = 0;
            this.btnNew.HighEmphasis = true;
            this.btnNew.Icon = ((System.Drawing.Image)(resources.GetObject("btnNew.Icon")));
            this.btnNew.Location = new System.Drawing.Point(695, 3);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNew.Name = "btnNew";
            this.btnNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNew.Size = new System.Drawing.Size(43, 36);
            this.btnNew.TabIndex = 13;
            this.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnNew.UseAccentColor = false;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtID
            // 
            this.txtID.AnimateReadOnly = false;
            this.txtID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtID.Depth = 0;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.HideSelection = true;
            this.txtID.LeadingIcon = null;
            this.txtID.Location = new System.Drawing.Point(488, 454);
            this.txtID.MaxLength = 32767;
            this.txtID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PrefixSuffixText = null;
            this.txtID.ReadOnly = false;
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(10, 36);
            this.txtID.TabIndex = 14;
            this.txtID.TabStop = false;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtID.TrailingIcon = null;
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.UseTallSize = false;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 489);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dgvMemberList);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmMembers";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMember";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMemberList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtCompanyName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtCity;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtCountry;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialButton btnNew;
        private MaterialSkin.Controls.MaterialTextBox2 txtID;
    }
}