namespace SalesWinApp.forms
{
    partial class frmProfile
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
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCompany = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCity = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCountry = new MaterialSkin.Controls.MaterialTextBox2();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(17, 318);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(156, 318);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(124, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCancel.UseAccentColor = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = true;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HelperText = "Email field";
            this.txtEmail.HideSelection = true;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(17, 34);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtEmail.PrefixSuffixText = "Email";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(263, 36);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.UseTallSize = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = true;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HelperText = "Email field";
            this.txtPassword.HideSelection = true;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(17, 86);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtPassword.PrefixSuffixText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(263, 36);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.UseTallSize = false;
            // 
            // txtCompany
            // 
            this.txtCompany.AnimateReadOnly = true;
            this.txtCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompany.Depth = 0;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompany.HelperText = "Email field";
            this.txtCompany.HideSelection = true;
            this.txtCompany.LeadingIcon = null;
            this.txtCompany.Location = new System.Drawing.Point(17, 142);
            this.txtCompany.MaxLength = 32767;
            this.txtCompany.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtCompany.PrefixSuffixText = "Company";
            this.txtCompany.ReadOnly = false;
            this.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompany.SelectedText = "";
            this.txtCompany.SelectionLength = 0;
            this.txtCompany.SelectionStart = 0;
            this.txtCompany.ShortcutsEnabled = true;
            this.txtCompany.Size = new System.Drawing.Size(263, 36);
            this.txtCompany.TabIndex = 5;
            this.txtCompany.TabStop = false;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompany.TrailingIcon = null;
            this.txtCompany.UseSystemPasswordChar = false;
            this.txtCompany.UseTallSize = false;
            // 
            // txtCity
            // 
            this.txtCity.AnimateReadOnly = true;
            this.txtCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCity.Depth = 0;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCity.HelperText = "Email field";
            this.txtCity.HideSelection = true;
            this.txtCity.LeadingIcon = null;
            this.txtCity.Location = new System.Drawing.Point(17, 200);
            this.txtCity.MaxLength = 32767;
            this.txtCity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtCity.PrefixSuffixText = "City";
            this.txtCity.ReadOnly = false;
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.ShortcutsEnabled = true;
            this.txtCity.Size = new System.Drawing.Size(263, 36);
            this.txtCity.TabIndex = 6;
            this.txtCity.TabStop = false;
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCity.TrailingIcon = null;
            this.txtCity.UseSystemPasswordChar = false;
            this.txtCity.UseTallSize = false;
            // 
            // txtCountry
            // 
            this.txtCountry.AnimateReadOnly = true;
            this.txtCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCountry.Depth = 0;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCountry.HelperText = "Email field";
            this.txtCountry.HideSelection = true;
            this.txtCountry.LeadingIcon = null;
            this.txtCountry.Location = new System.Drawing.Point(17, 258);
            this.txtCountry.MaxLength = 32767;
            this.txtCountry.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PasswordChar = '\0';
            this.txtCountry.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtCountry.PrefixSuffixText = "Country";
            this.txtCountry.ReadOnly = false;
            this.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountry.SelectedText = "";
            this.txtCountry.SelectionLength = 0;
            this.txtCountry.SelectionStart = 0;
            this.txtCountry.ShortcutsEnabled = true;
            this.txtCountry.Size = new System.Drawing.Size(263, 36);
            this.txtCountry.TabIndex = 7;
            this.txtCountry.TabStop = false;
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCountry.TrailingIcon = null;
            this.txtCountry.UseSystemPasswordChar = false;
            this.txtCountry.UseTallSize = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 453);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "frmProfile";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtCompany;
        private MaterialSkin.Controls.MaterialTextBox2 txtCity;
        private MaterialSkin.Controls.MaterialTextBox2 txtCountry;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}