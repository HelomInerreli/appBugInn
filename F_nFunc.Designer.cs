namespace appBugInn
{
    partial class F_nFunc
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
            this.label1 = new System.Windows.Forms.Label();
            this.chb_gestor = new MaterialSkin.Controls.MaterialSwitch();
            this.btn_criar = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txt_nome = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_telefone = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.cb_Funcionarios = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_excluir = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // chb_gestor
            // 
            this.chb_gestor.AutoSize = true;
            this.chb_gestor.Depth = 0;
            this.chb_gestor.Location = new System.Drawing.Point(449, 177);
            this.chb_gestor.Margin = new System.Windows.Forms.Padding(0);
            this.chb_gestor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chb_gestor.MouseState = MaterialSkin.MouseState.HOVER;
            this.chb_gestor.Name = "chb_gestor";
            this.chb_gestor.Ripple = true;
            this.chb_gestor.Size = new System.Drawing.Size(104, 37);
            this.chb_gestor.TabIndex = 13;
            this.chb_gestor.Text = "Gestor";
            this.chb_gestor.UseVisualStyleBackColor = true;
            // 
            // btn_criar
            // 
            this.btn_criar.AutoSize = false;
            this.btn_criar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_criar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_criar.Depth = 0;
            this.btn_criar.HighEmphasis = true;
            this.btn_criar.Icon = null;
            this.btn_criar.Location = new System.Drawing.Point(242, 503);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_criar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_criar.Size = new System.Drawing.Size(110, 50);
            this.btn_criar.TabIndex = 17;
            this.btn_criar.Text = "Criar";
            this.btn_criar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_criar.UseAccentColor = false;
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txt_nome);
            this.materialCard1.Controls.Add(this.txt_telefone);
            this.materialCard1.Controls.Add(this.chb_gestor);
            this.materialCard1.Controls.Add(this.txt_password);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(43, 233);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(696, 249);
            this.materialCard1.TabIndex = 18;
            // 
            // txt_nome
            // 
            this.txt_nome.AnimateReadOnly = false;
            this.txt_nome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_nome.Depth = 0;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nome.HideSelection = true;
            this.txt_nome.Hint = "Nome";
            this.txt_nome.LeadingIcon = global::appBugInn.Properties.Resources.Personnome;
            this.txt_nome.Location = new System.Drawing.Point(34, 30);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.MaxLength = 32767;
            this.txt_nome.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.PrefixSuffixText = null;
            this.txt_nome.ReadOnly = false;
            this.txt_nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_nome.SelectedText = "";
            this.txt_nome.SelectionLength = 0;
            this.txt_nome.SelectionStart = 0;
            this.txt_nome.ShortcutsEnabled = true;
            this.txt_nome.Size = new System.Drawing.Size(589, 48);
            this.txt_nome.TabIndex = 12;
            this.txt_nome.TabStop = false;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome.TrailingIcon = null;
            this.txt_nome.UseSystemPasswordChar = false;
            this.txt_nome.Click += new System.EventHandler(this.txt_nome_Click);
            this.txt_nome.Leave += new System.EventHandler(this.txt_nome_leave);
            // 
            // txt_telefone
            // 
            this.txt_telefone.AnimateReadOnly = false;
            this.txt_telefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_telefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_telefone.Depth = 0;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_telefone.HideSelection = true;
            this.txt_telefone.Hint = "Telefone";
            this.txt_telefone.LeadingIcon = global::appBugInn.Properties.Resources.tele;
            this.txt_telefone.Location = new System.Drawing.Point(34, 98);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefone.MaxLength = 32767;
            this.txt_telefone.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.PasswordChar = '\0';
            this.txt_telefone.PrefixSuffixText = null;
            this.txt_telefone.ReadOnly = false;
            this.txt_telefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_telefone.SelectedText = "";
            this.txt_telefone.SelectionLength = 0;
            this.txt_telefone.SelectionStart = 0;
            this.txt_telefone.ShortcutsEnabled = true;
            this.txt_telefone.Size = new System.Drawing.Size(589, 48);
            this.txt_telefone.TabIndex = 11;
            this.txt_telefone.TabStop = false;
            this.txt_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_telefone.TrailingIcon = null;
            this.txt_telefone.UseSystemPasswordChar = false;
            this.txt_telefone.Click += new System.EventHandler(this.txt_telefone_Click);
            this.txt_telefone.Leave += new System.EventHandler(this.txt_telefone_leave);
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
            this.txt_password.LeadingIcon = global::appBugInn.Properties.Resources.icons8_trancar_24;
            this.txt_password.Location = new System.Drawing.Point(34, 166);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PrefixSuffixText = null;
            this.txt_password.ReadOnly = false;
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(306, 48);
            this.txt_password.TabIndex = 10;
            this.txt_password.TabStop = false;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TrailingIcon = null;
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_leave);
            // 
            // cb_Funcionarios
            // 
            this.cb_Funcionarios.AutoResize = false;
            this.cb_Funcionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_Funcionarios.Depth = 0;
            this.cb_Funcionarios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Funcionarios.DropDownHeight = 174;
            this.cb_Funcionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Funcionarios.DropDownWidth = 121;
            this.cb_Funcionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_Funcionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_Funcionarios.FormattingEnabled = true;
            this.cb_Funcionarios.Hint = "Funcionarios";
            this.cb_Funcionarios.IntegralHeight = false;
            this.cb_Funcionarios.ItemHeight = 43;
            this.cb_Funcionarios.Location = new System.Drawing.Point(43, 90);
            this.cb_Funcionarios.MaxDropDownItems = 4;
            this.cb_Funcionarios.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_Funcionarios.Name = "cb_Funcionarios";
            this.cb_Funcionarios.Size = new System.Drawing.Size(696, 49);
            this.cb_Funcionarios.StartIndex = 0;
            this.cb_Funcionarios.TabIndex = 19;
            this.cb_Funcionarios.SelectedIndexChanged += new System.EventHandler(this.cb_Funcionarios_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(38, 190);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(303, 29);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Informações do Funcionario";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.AutoSize = false;
            this.btn_excluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_excluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_excluir.Depth = 0;
            this.btn_excluir.HighEmphasis = true;
            this.btn_excluir.Icon = null;
            this.btn_excluir.Location = new System.Drawing.Point(458, 503);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_excluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_excluir.Size = new System.Drawing.Size(110, 50);
            this.btn_excluir.TabIndex = 39;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_excluir.UseAccentColor = false;
            this.btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Visible = cb_Funcionarios.SelectedIndex >= 0;
            this.btn_excluir.Visible = false;
            btn_excluir.Click += btn_excluir_Click;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // F_nFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cb_Funcionarios);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_nFunc";
            this.Text = "Novo Funcionario";
            this.Load += new System.EventHandler(this.F_nFunc_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txt_password;
        private MaterialSkin.Controls.MaterialTextBox2 txt_telefone;
        private MaterialSkin.Controls.MaterialTextBox2 txt_nome;
        private MaterialSkin.Controls.MaterialSwitch chb_gestor;
        private MaterialSkin.Controls.MaterialButton btn_criar;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox cb_Funcionarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_excluir;
    }
}