namespace appBugInn
{
    partial class F_telaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_telaInicial));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tb_home = new System.Windows.Forms.TabPage();
            this.tb_reservas = new System.Windows.Forms.TabPage();
            this.tb_checkIn = new System.Windows.Forms.TabPage();
            this.tb_checkOut = new System.Windows.Forms.TabPage();
            this.tb_gerirQuartos = new System.Windows.Forms.TabPage();
            this.tb_funcionarios = new System.Windows.Forms.TabPage();
            this.btn_excluir = new MaterialSkin.Controls.MaterialButton();
            this.cb_Funcionarios = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.txt_username = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_nome = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_telefone = new MaterialSkin.Controls.MaterialTextBox2();
            this.chb_gestor = new MaterialSkin.Controls.MaterialSwitch();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_criar = new MaterialSkin.Controls.MaterialButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_diretoria = new System.Windows.Forms.TabPage();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_configuracoes = new System.Windows.Forms.TabPage();
            this.sw_darkMode = new MaterialSkin.Controls.MaterialSwitch();
            this.iconesMenu = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tb_funcionarios.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.tb_diretoria.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tb_configuracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tb_home);
            this.materialTabControl1.Controls.Add(this.tb_reservas);
            this.materialTabControl1.Controls.Add(this.tb_checkIn);
            this.materialTabControl1.Controls.Add(this.tb_checkOut);
            this.materialTabControl1.Controls.Add(this.tb_gerirQuartos);
            this.materialTabControl1.Controls.Add(this.tb_funcionarios);
            this.materialTabControl1.Controls.Add(this.tb_diretoria);
            this.materialTabControl1.Controls.Add(this.tb_configuracoes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.iconesMenu;
            this.materialTabControl1.Location = new System.Drawing.Point(4, 79);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1327, 743);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tab_Funcionarios);
            // 
            // tb_home
            // 
            this.tb_home.BackgroundImage = global::appBugInn.Properties.Resources.tbi_sem_fundo;
            this.tb_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_home.ImageKey = "icons8-home-32.png";
            this.tb_home.Location = new System.Drawing.Point(4, 39);
            this.tb_home.Margin = new System.Windows.Forms.Padding(4);
            this.tb_home.Name = "tb_home";
            this.tb_home.Padding = new System.Windows.Forms.Padding(4);
            this.tb_home.Size = new System.Drawing.Size(1319, 700);
            this.tb_home.TabIndex = 0;
            this.tb_home.Text = "HOME";
            this.tb_home.UseVisualStyleBackColor = true;
            // 
            // tb_reservas
            // 
            this.tb_reservas.ImageKey = "icons8-livro-32.png";
            this.tb_reservas.Location = new System.Drawing.Point(4, 39);
            this.tb_reservas.Margin = new System.Windows.Forms.Padding(4);
            this.tb_reservas.Name = "tb_reservas";
            this.tb_reservas.Padding = new System.Windows.Forms.Padding(4);
            this.tb_reservas.Size = new System.Drawing.Size(1319, 700);
            this.tb_reservas.TabIndex = 1;
            this.tb_reservas.Text = "RESERVAS";
            this.tb_reservas.UseVisualStyleBackColor = true;
            // 
            // tb_checkIn
            // 
            this.tb_checkIn.ImageKey = "icons8-check-in-hotel-32.png";
            this.tb_checkIn.Location = new System.Drawing.Point(4, 39);
            this.tb_checkIn.Margin = new System.Windows.Forms.Padding(4);
            this.tb_checkIn.Name = "tb_checkIn";
            this.tb_checkIn.Size = new System.Drawing.Size(1319, 700);
            this.tb_checkIn.TabIndex = 2;
            this.tb_checkIn.Text = "CHECK IN";
            this.tb_checkIn.UseVisualStyleBackColor = true;
            // 
            // tb_checkOut
            // 
            this.tb_checkOut.ImageKey = "icons8-hotel-chekc-fora-32.png";
            this.tb_checkOut.Location = new System.Drawing.Point(4, 39);
            this.tb_checkOut.Margin = new System.Windows.Forms.Padding(4);
            this.tb_checkOut.Name = "tb_checkOut";
            this.tb_checkOut.Size = new System.Drawing.Size(1319, 700);
            this.tb_checkOut.TabIndex = 3;
            this.tb_checkOut.Text = "CHECK OUT";
            this.tb_checkOut.UseVisualStyleBackColor = true;
            // 
            // tb_gerirQuartos
            // 
            this.tb_gerirQuartos.ImageKey = "icons8-quarto-32.png";
            this.tb_gerirQuartos.Location = new System.Drawing.Point(4, 39);
            this.tb_gerirQuartos.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gerirQuartos.Name = "tb_gerirQuartos";
            this.tb_gerirQuartos.Size = new System.Drawing.Size(1319, 700);
            this.tb_gerirQuartos.TabIndex = 4;
            this.tb_gerirQuartos.Text = "GERIR QUARTOS";
            this.tb_gerirQuartos.UseVisualStyleBackColor = true;
            // 
            // tb_funcionarios
            // 
            this.tb_funcionarios.Controls.Add(this.cb_Funcionarios);
            this.tb_funcionarios.Controls.Add(this.materialCard5);
            this.tb_funcionarios.Controls.Add(this.label7);
            this.tb_funcionarios.ImageKey = "icons8-contrato-de-trabalho-32.png";
            this.tb_funcionarios.Location = new System.Drawing.Point(4, 39);
            this.tb_funcionarios.Margin = new System.Windows.Forms.Padding(4);
            this.tb_funcionarios.Name = "tb_funcionarios";
            this.tb_funcionarios.Size = new System.Drawing.Size(1319, 700);
            this.tb_funcionarios.TabIndex = 5;
            this.tb_funcionarios.Text = "FUNCIONARIOS";
            this.tb_funcionarios.UseVisualStyleBackColor = true;
            this.tb_funcionarios.Enter += new System.EventHandler(this.tb_funcionarios_Enter);
            // 
            // btn_excluir
            // 
            this.btn_excluir.AutoSize = false;
            this.btn_excluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_excluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_excluir.Depth = 0;
            this.btn_excluir.HighEmphasis = true;
            this.btn_excluir.Icon = null;
            this.btn_excluir.Location = new System.Drawing.Point(894, 180);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_excluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_excluir.Size = new System.Drawing.Size(151, 55);
            this.btn_excluir.TabIndex = 45;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_excluir.UseAccentColor = true;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Visible = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
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
            this.cb_Funcionarios.Location = new System.Drawing.Point(92, 287);
            this.cb_Funcionarios.MaxDropDownItems = 4;
            this.cb_Funcionarios.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_Funcionarios.Name = "cb_Funcionarios";
            this.cb_Funcionarios.Size = new System.Drawing.Size(696, 49);
            this.cb_Funcionarios.StartIndex = 0;
            this.cb_Funcionarios.TabIndex = 43;
            this.cb_Funcionarios.SelectedIndexChanged += new System.EventHandler(this.cb_Funcionarios_SelectedIndexChanged_1);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.btn_excluir);
            this.materialCard5.Controls.Add(this.txt_username);
            this.materialCard5.Controls.Add(this.txt_nome);
            this.materialCard5.Controls.Add(this.txt_telefone);
            this.materialCard5.Controls.Add(this.btn_criar);
            this.materialCard5.Controls.Add(this.chb_gestor);
            this.materialCard5.Controls.Add(this.txt_password);
            this.materialCard5.Depth = 0;
            this.materialCard5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(0, 0);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(1319, 270);
            this.materialCard5.TabIndex = 42;
            // 
            // txt_username
            // 
            this.txt_username.AnimateReadOnly = false;
            this.txt_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_username.Depth = 0;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_username.HideSelection = true;
            this.txt_username.Hint = "Username";
            this.txt_username.LeadingIcon = global::appBugInn.Properties.Resources.Personnome;
            this.txt_username.Location = new System.Drawing.Point(626, 30);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.MaxLength = 32767;
            this.txt_username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PrefixSuffixText = null;
            this.txt_username.ReadOnly = false;
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(527, 48);
            this.txt_username.TabIndex = 14;
            this.txt_username.TabStop = false;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TrailingIcon = null;
            this.txt_username.UseSystemPasswordChar = false;
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
            this.txt_nome.Size = new System.Drawing.Size(550, 48);
            this.txt_nome.TabIndex = 12;
            this.txt_nome.TabStop = false;
            this.txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nome.TrailingIcon = null;
            this.txt_nome.UseSystemPasswordChar = false;
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
            this.txt_telefone.Location = new System.Drawing.Point(34, 111);
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
            this.txt_telefone.Size = new System.Drawing.Size(550, 48);
            this.txt_telefone.TabIndex = 11;
            this.txt_telefone.TabStop = false;
            this.txt_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_telefone.TrailingIcon = null;
            this.txt_telefone.UseSystemPasswordChar = false;
            // 
            // chb_gestor
            // 
            this.chb_gestor.AutoSize = true;
            this.chb_gestor.Depth = 0;
            this.chb_gestor.Location = new System.Drawing.Point(480, 204);
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
            this.txt_password.Location = new System.Drawing.Point(34, 193);
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
            // 
            // btn_criar
            // 
            this.btn_criar.AutoSize = false;
            this.btn_criar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_criar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_criar.Depth = 0;
            this.btn_criar.HighEmphasis = true;
            this.btn_criar.Icon = null;
            this.btn_criar.Location = new System.Drawing.Point(678, 180);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_criar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_criar.Size = new System.Drawing.Size(151, 55);
            this.btn_criar.TabIndex = 41;
            this.btn_criar.Text = "Criar";
            this.btn_criar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_criar.UseAccentColor = false;
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 40;
            // 
            // tb_diretoria
            // 
            this.tb_diretoria.Controls.Add(this.materialFloatingActionButton3);
            this.tb_diretoria.Controls.Add(this.materialFloatingActionButton2);
            this.tb_diretoria.Controls.Add(this.materialCard3);
            this.tb_diretoria.Controls.Add(this.materialCard4);
            this.tb_diretoria.Controls.Add(this.materialCard2);
            this.tb_diretoria.Controls.Add(this.materialFloatingActionButton1);
            this.tb_diretoria.Controls.Add(this.materialCard1);
            this.tb_diretoria.ImageKey = "icons8-dashboard-32.png";
            this.tb_diretoria.Location = new System.Drawing.Point(4, 39);
            this.tb_diretoria.Margin = new System.Windows.Forms.Padding(4);
            this.tb_diretoria.Name = "tb_diretoria";
            this.tb_diretoria.Size = new System.Drawing.Size(1319, 700);
            this.tb_diretoria.TabIndex = 6;
            this.tb_diretoria.Text = "DASHBOARD";
            this.tb_diretoria.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.Icon = global::appBugInn.Properties.Resources.icons8_satisfaction_48;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(1201, 65);
            this.materialFloatingActionButton3.Margin = new System.Windows.Forms.Padding(4);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(75, 69);
            this.materialFloatingActionButton3.TabIndex = 7;
            this.materialFloatingActionButton3.TabStop = false;
            this.materialFloatingActionButton3.UseVisualStyleBackColor = false;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = global::appBugInn.Properties.Resources.icons8_profit_48;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(796, 65);
            this.materialFloatingActionButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(75, 69);
            this.materialFloatingActionButton2.TabIndex = 5;
            this.materialFloatingActionButton2.TabStop = false;
            this.materialFloatingActionButton2.UseVisualStyleBackColor = false;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.label8);
            this.materialCard3.Controls.Add(this.label9);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(909, 38);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard3.Size = new System.Drawing.Size(331, 123);
            this.materialCard3.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(120, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 45);
            this.label8.TabIndex = 1;
            this.label8.Text = "4,6";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 89);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nível de Satisfação dos clientes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.UseCompatibleTextRendering = true;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.cartesianChart1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(40, 196);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard4.Size = new System.Drawing.Size(1200, 393);
            this.materialCard4.TabIndex = 6;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(24, 22);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1153, 350);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialProgressBar2);
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(488, 38);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard2.Size = new System.Drawing.Size(347, 123);
            this.materialCard2.TabIndex = 4;
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(29, 84);
            this.materialProgressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(231, 5);
            this.materialProgressBar2.TabIndex = 3;
            this.materialProgressBar2.Value = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "37% da arrecadação prevista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(65, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "57.912,54 €";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 37);
            this.label6.TabIndex = 0;
            this.label6.Text = "Faturamento Anual";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = global::appBugInn.Properties.Resources.icons8_profit_48;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(377, 65);
            this.materialFloatingActionButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(75, 69);
            this.materialFloatingActionButton1.TabIndex = 1;
            this.materialFloatingActionButton1.TabStop = false;
            this.materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialProgressBar1);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(40, 38);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.Size = new System.Drawing.Size(376, 123);
            this.materialCard1.TabIndex = 0;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(29, 84);
            this.materialProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(231, 5);
            this.materialProgressBar1.TabIndex = 3;
            this.materialProgressBar1.Value = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "45% da arrecadação prevista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(65, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "7.845,12 €";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faturamento Mensal";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // tb_configuracoes
            // 
            this.tb_configuracoes.Controls.Add(this.sw_darkMode);
            this.tb_configuracoes.ImageKey = "icons8-config-32.png";
            this.tb_configuracoes.Location = new System.Drawing.Point(4, 39);
            this.tb_configuracoes.Margin = new System.Windows.Forms.Padding(4);
            this.tb_configuracoes.Name = "tb_configuracoes";
            this.tb_configuracoes.Size = new System.Drawing.Size(1319, 700);
            this.tb_configuracoes.TabIndex = 7;
            this.tb_configuracoes.Text = "CONFIGURAÇÕES";
            this.tb_configuracoes.UseVisualStyleBackColor = true;
            // 
            // sw_darkMode
            // 
            this.sw_darkMode.BackColor = System.Drawing.Color.Transparent;
            this.sw_darkMode.Depth = 0;
            this.sw_darkMode.Location = new System.Drawing.Point(48, 41);
            this.sw_darkMode.Margin = new System.Windows.Forms.Padding(0);
            this.sw_darkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sw_darkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.sw_darkMode.Name = "sw_darkMode";
            this.sw_darkMode.Ripple = true;
            this.sw_darkMode.Size = new System.Drawing.Size(269, 54);
            this.sw_darkMode.TabIndex = 1;
            this.sw_darkMode.Text = "Modo Escuro";
            this.sw_darkMode.UseVisualStyleBackColor = false;
            this.sw_darkMode.CheckedChanged += new System.EventHandler(this.sw_darkMode_CheckedChanged);
            // 
            // iconesMenu
            // 
            this.iconesMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconesMenu.ImageStream")));
            this.iconesMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.iconesMenu.Images.SetKeyName(0, "icons8-hotel-chekc-fora-32.png");
            this.iconesMenu.Images.SetKeyName(1, "icons8-check-in-hotel-32.png");
            this.iconesMenu.Images.SetKeyName(2, "icons8-config-32.png");
            this.iconesMenu.Images.SetKeyName(3, "icons8-gerente-32.png");
            this.iconesMenu.Images.SetKeyName(4, "icons8-quarto-32.png");
            this.iconesMenu.Images.SetKeyName(5, "icons8-livro-32.png");
            this.iconesMenu.Images.SetKeyName(6, "icons8-casa-32.png");
            this.iconesMenu.Images.SetKeyName(7, "icons8-contrato-de-trabalho-32.png");
            this.iconesMenu.Images.SetKeyName(8, "icons8-home-32.png");
            this.iconesMenu.Images.SetKeyName(9, "icons8-dashboard-32.png");
            this.iconesMenu.Images.SetKeyName(10, "icons8-profit-48.png");
            // 
            // F_telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 826);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_telaInicial";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "The Bug Inn";
            this.Load += new System.EventHandler(this.F_telaInicial_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tb_funcionarios.ResumeLayout(false);
            this.tb_funcionarios.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.tb_diretoria.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tb_configuracoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tb_home;
        private System.Windows.Forms.TabPage tb_reservas;
        private System.Windows.Forms.ImageList iconesMenu;
        private System.Windows.Forms.TabPage tb_checkIn;
        private System.Windows.Forms.TabPage tb_checkOut;
        private System.Windows.Forms.TabPage tb_gerirQuartos;
        private System.Windows.Forms.TabPage tb_funcionarios;
        private System.Windows.Forms.TabPage tb_diretoria;
        private System.Windows.Forms.TabPage tb_configuracoes;
        private MaterialSkin.Controls.MaterialSwitch sw_darkMode;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private MaterialSkin.Controls.MaterialButton btn_excluir;
        private MaterialSkin.Controls.MaterialComboBox cb_Funcionarios;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialTextBox2 txt_username;
        private MaterialSkin.Controls.MaterialTextBox2 txt_nome;
        private MaterialSkin.Controls.MaterialTextBox2 txt_telefone;
        private MaterialSkin.Controls.MaterialSwitch chb_gestor;
        private MaterialSkin.Controls.MaterialTextBox2 txt_password;
        private MaterialSkin.Controls.MaterialButton btn_criar;
        private System.Windows.Forms.Label label7;
    }
}