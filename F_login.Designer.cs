namespace appBugInn
{
    partial class F_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_login));
            this.bt_login = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flButton_ShowPassowrd = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.txt_nome = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bt_login.Depth = 0;
            this.bt_login.HighEmphasis = true;
            this.bt_login.Icon = null;
            this.bt_login.Location = new System.Drawing.Point(143, 293);
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.flButton_ShowPassowrd);
            this.materialCard1.Controls.Add(this.txt_nome);
            this.materialCard1.Controls.Add(this.txt_password);
            this.materialCard1.Controls.Add(this.bt_login);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(360, 349);
            this.materialCard1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appBugInn.Properties.Resources.tbi_sem_fundo1;
            this.pictureBox1.Location = new System.Drawing.Point(125, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // flButton_ShowPassowrd
            // 
            this.flButton_ShowPassowrd.Depth = 0;
            this.flButton_ShowPassowrd.DrawShadows = false;
            this.flButton_ShowPassowrd.Icon = global::appBugInn.Properties.Resources.icons8_visível_24;
            this.flButton_ShowPassowrd.Location = new System.Drawing.Point(279, 188);
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
            this.txt_nome.Location = new System.Drawing.Point(26, 91);
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
            this.txt_password.Location = new System.Drawing.Point(26, 184);
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
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel1.Location = new System.Drawing.Point(104, 441);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(175, 14);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Desenvolvido por @Grupo2 Atec";
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 467);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_login";
            this.Text = "Login - The Bug Inn";
            this.Load += new System.EventHandler(this.F_login_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton bt_login;
        private MaterialSkin.Controls.MaterialTextBox2 txt_nome;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton flButton_ShowPassowrd;
        private MaterialSkin.Controls.MaterialTextBox2 txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}