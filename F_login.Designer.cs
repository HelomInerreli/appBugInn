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
            this.btn_showpass = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.flButton_ShowPassowrd = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txt_nome = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.bt_login.Location = new System.Drawing.Point(216, 321);
            this.bt_login.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            this.btn_newuser.Location = new System.Drawing.Point(37, 363);
            this.btn_newuser.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            // btn_showpass
            // 
            this.btn_showpass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_showpass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_showpass.Depth = 0;
            this.btn_showpass.HighEmphasis = true;
            this.btn_showpass.Icon = null;
            this.btn_showpass.Location = new System.Drawing.Point(359, 321);
            this.btn_showpass.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.flButton_ShowPassowrd);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.txt_nome);
            this.materialCard1.Controls.Add(this.btn_newuser);
            this.materialCard1.Controls.Add(this.btn_showpass);
            this.materialCard1.Controls.Add(this.txt_password);
            this.materialCard1.Controls.Add(this.bt_login);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(52, 128);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.Size = new System.Drawing.Size(521, 432);
            this.materialCard1.TabIndex = 16;
            // 
            // flButton_ShowPassowrd
            // 
            this.flButton_ShowPassowrd.Depth = 0;
            this.flButton_ShowPassowrd.DrawShadows = false;
            this.flButton_ShowPassowrd.Icon = global::appBugInn.Properties.Resources.icons8_visível_24;
            this.flButton_ShowPassowrd.Location = new System.Drawing.Point(423, 224);
            this.flButton_ShowPassowrd.Margin = new System.Windows.Forms.Padding(0);
            this.flButton_ShowPassowrd.Mini = true;
            this.flButton_ShowPassowrd.MouseState = MaterialSkin.MouseState.HOVER;
            this.flButton_ShowPassowrd.Name = "flButton_ShowPassowrd";
            this.flButton_ShowPassowrd.Size = new System.Drawing.Size(40, 48);
            this.flButton_ShowPassowrd.TabIndex = 17;
            this.flButton_ShowPassowrd.Text = "materialFloatingActionButton1";
            this.flButton_ShowPassowrd.UseVisualStyleBackColor = true;
            this.flButton_ShowPassowrd.Click += new System.EventHandler(this.flButton_ShowPassowrd_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = false;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Image = ((System.Drawing.Image)(resources.GetObject("materialButton1.Image")));
            this.materialButton1.Location = new System.Drawing.Point(287, 385);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 17;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
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
            this.txt_nome.Location = new System.Drawing.Point(72, 111);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
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
            this.txt_nome.Size = new System.Drawing.Size(392, 48);
            this.txt_nome.TabIndex = 11;
            this.txt_nome.TabStop = false;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome.TrailingIcon = null;
            this.txt_nome.UseSystemPasswordChar = false;
            this.txt_nome.Click += new System.EventHandler(this.txt_nome_Click);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_focusLeave);
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
            this.txt_password.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txt_password.LeadingIcon")));
            this.txt_password.Location = new System.Drawing.Point(72, 224);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
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
            this.txt_password.Size = new System.Drawing.Size(392, 48);
            this.txt_password.TabIndex = 15;
            this.txt_password.TabStop = false;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TrailingIcon = null;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // lb_nome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 703);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "lb_nome";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Login";
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton flButton_ShowPassowrd;
    }
}