namespace appBugInn
{
    partial class lb_nome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lb_nome));
            this.bt_login = new MaterialSkin.Controls.MaterialButton();
            this.btn_newuser = new MaterialSkin.Controls.MaterialButton();
            this.txt_nome = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_showpass = new MaterialSkin.Controls.MaterialButton();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_login.Depth = 0;
            this.bt_login.HighEmphasis = true;
            this.bt_login.Icon = null;
            this.bt_login.Location = new System.Drawing.Point(162, 261);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bt_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_login.Name = "bt_login";
            this.bt_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bt_login.Size = new System.Drawing.Size(64, 36);
            this.bt_login.TabIndex = 8;
            this.bt_login.Text = "Login";
            this.bt_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bt_login.UseAccentColor = false;
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click_1);
            // 
            // btn_newuser
            // 
            this.btn_newuser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_newuser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_newuser.Depth = 0;
            this.btn_newuser.HighEmphasis = true;
            this.btn_newuser.Icon = null;
            this.btn_newuser.Location = new System.Drawing.Point(28, 295);
            this.btn_newuser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_newuser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_newuser.Name = "btn_newuser";
            this.btn_newuser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_newuser.Size = new System.Drawing.Size(93, 36);
            this.btn_newuser.TabIndex = 9;
            this.btn_newuser.Text = "New User";
            this.btn_newuser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_newuser.UseAccentColor = false;
            this.btn_newuser.UseVisualStyleBackColor = true;
            this.btn_newuser.Click += new System.EventHandler(this.btn_newuser_Click_1);
            // 
            // txt_nome
            // 
            this.txt_nome.AnimateReadOnly = false;
            this.txt_nome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_nome.Depth = 0;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nome.HideSelection = true;
            this.txt_nome.Hint = "Utilizador";
            this.txt_nome.LeadingIcon = global::appBugInn.Properties.Resources.Personnome;
            this.txt_nome.Location = new System.Drawing.Point(54, 90);
            this.txt_nome.MaxLength = 32767;
            this.txt_nome.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txt_nome.PrefixSuffixText = null;
            this.txt_nome.ReadOnly = false;
            this.txt_nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_nome.SelectedText = "";
            this.txt_nome.SelectionLength = 0;
            this.txt_nome.SelectionStart = 0;
            this.txt_nome.ShortcutsEnabled = true;
            this.txt_nome.Size = new System.Drawing.Size(294, 48);
            this.txt_nome.TabIndex = 11;
            this.txt_nome.TabStop = false;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome.TrailingIcon = null;
            this.txt_nome.UseSystemPasswordChar = false;
            this.txt_nome.Click += new System.EventHandler(this.txt_nome_Click);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_focusLeave);
            // 
            // btn_showpass
            // 
            this.btn_showpass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_showpass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_showpass.Depth = 0;
            this.btn_showpass.HighEmphasis = true;
            this.btn_showpass.Icon = null;
            this.btn_showpass.Location = new System.Drawing.Point(269, 261);
            this.btn_showpass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_showpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_showpass.Name = "btn_showpass";
            this.btn_showpass.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_showpass.Size = new System.Drawing.Size(104, 36);
            this.btn_showpass.TabIndex = 14;
            this.btn_showpass.Text = "Show pass";
            this.btn_showpass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_showpass.UseAccentColor = false;
            this.btn_showpass.UseVisualStyleBackColor = true;
            this.btn_showpass.Click += new System.EventHandler(this.btn_showpass_Click);
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.HideSelection = true;
            this.txt_password.Hint = "Password";
            this.txt_password.LeadingIcon = global::appBugInn.Properties.Resources._1151429;
            this.txt_password.Location = new System.Drawing.Point(54, 182);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txt_password.PrefixSuffixText = null;
            this.txt_password.ReadOnly = false;
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(294, 48);
            this.txt_password.TabIndex = 15;
            this.txt_password.TabStop = false;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TrailingIcon = null;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txt_nome);
            this.materialCard1.Controls.Add(this.btn_newuser);
            this.materialCard1.Controls.Add(this.btn_showpass);
            this.materialCard1.Controls.Add(this.txt_password);
            this.materialCard1.Controls.Add(this.bt_login);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(39, 104);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(391, 351);
            this.materialCard1.TabIndex = 16;
            // 
            // lb_nome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 571);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lb_nome";
            this.Text = "Show pass";
            this.Load += new System.EventHandler(this.F_login_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton bt_login;
        private MaterialSkin.Controls.MaterialButton btn_newuser;
        private MaterialSkin.Controls.MaterialTextBox2 txt_nome;
        private MaterialSkin.Controls.MaterialButton btn_showpass;
        private MaterialSkin.Controls.MaterialTextBox2 txt_password;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}