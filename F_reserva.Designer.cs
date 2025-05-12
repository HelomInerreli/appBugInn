namespace appBugInn
{
    partial class F_reserva
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
            this.cb_NumeroPessoas = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_TipoQuarto = new MaterialSkin.Controls.MaterialComboBox();
            this.dtp_dataInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataFimReserva = new System.Windows.Forms.DateTimePicker();
            this.txt_emailReserva1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_telefoneReserva1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nomeReserva1 = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_recuarDiaInicioReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_avançarDiaFimReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_avançaDiaInicioReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_recuaDiaFimReserva = new MaterialSkin.Controls.MaterialButton();
            this.lbl_dataFimReserva = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.btn_registarReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancelarReserva = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_NumeroPessoas
            // 
            this.cb_NumeroPessoas.AutoResize = false;
            this.cb_NumeroPessoas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_NumeroPessoas.Depth = 0;
            this.cb_NumeroPessoas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_NumeroPessoas.DropDownHeight = 174;
            this.cb_NumeroPessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_NumeroPessoas.DropDownWidth = 121;
            this.cb_NumeroPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_NumeroPessoas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_NumeroPessoas.FormattingEnabled = true;
            this.cb_NumeroPessoas.Hint = "Número de pessoas";
            this.cb_NumeroPessoas.IntegralHeight = false;
            this.cb_NumeroPessoas.ItemHeight = 43;
            this.cb_NumeroPessoas.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.cb_NumeroPessoas.Location = new System.Drawing.Point(7, 17);
            this.cb_NumeroPessoas.MaxDropDownItems = 4;
            this.cb_NumeroPessoas.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_NumeroPessoas.Name = "cb_NumeroPessoas";
            this.cb_NumeroPessoas.Size = new System.Drawing.Size(133, 49);
            this.cb_NumeroPessoas.StartIndex = 0;
            this.cb_NumeroPessoas.TabIndex = 20;
            this.cb_NumeroPessoas.SelectedIndexChanged += new System.EventHandler(this.cb_NumeroPessoas_SelectedIndexChanged);
            // 
            // cb_TipoQuarto
            // 
            this.cb_TipoQuarto.AutoResize = false;
            this.cb_TipoQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_TipoQuarto.Depth = 0;
            this.cb_TipoQuarto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_TipoQuarto.DropDownHeight = 174;
            this.cb_TipoQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoQuarto.DropDownWidth = 121;
            this.cb_TipoQuarto.Enabled = false;
            this.cb_TipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_TipoQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_TipoQuarto.FormattingEnabled = true;
            this.cb_TipoQuarto.Hint = "Tipo de quarto";
            this.cb_TipoQuarto.IntegralHeight = false;
            this.cb_TipoQuarto.ItemHeight = 43;
            this.cb_TipoQuarto.Items.AddRange(new object[] {
            "",
            "Simples",
            "Duplo",
            "Suite",
            "Deluxe"});
            this.cb_TipoQuarto.Location = new System.Drawing.Point(146, 17);
            this.cb_TipoQuarto.MaxDropDownItems = 4;
            this.cb_TipoQuarto.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_TipoQuarto.Name = "cb_TipoQuarto";
            this.cb_TipoQuarto.Size = new System.Drawing.Size(176, 49);
            this.cb_TipoQuarto.StartIndex = 0;
            this.cb_TipoQuarto.TabIndex = 21;
            this.cb_TipoQuarto.SelectedIndexChanged += new System.EventHandler(this.cb_TipoQuarto_SelectedIndexChanged);
            // 
            // dtp_dataInicioReserva
            // 
            this.dtp_dataInicioReserva.CustomFormat = "dd/MM/yyyy";
            this.dtp_dataInicioReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dataInicioReserva.Location = new System.Drawing.Point(346, 29);
            this.dtp_dataInicioReserva.Name = "dtp_dataInicioReserva";
            this.dtp_dataInicioReserva.Size = new System.Drawing.Size(115, 20);
            this.dtp_dataInicioReserva.TabIndex = 22;
            this.dtp_dataInicioReserva.ValueChanged += new System.EventHandler(this.dtp_dataInicioReserva_ValueChanged);
            this.dtp_dataInicioReserva.Leave += new System.EventHandler(this.dtp_dataInicioReserva_Leave);
            // 
            // dtp_dataFimReserva
            // 
            this.dtp_dataFimReserva.CustomFormat = "dd/MM/yyyy";
            this.dtp_dataFimReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dataFimReserva.Location = new System.Drawing.Point(467, 29);
            this.dtp_dataFimReserva.Name = "dtp_dataFimReserva";
            this.dtp_dataFimReserva.Size = new System.Drawing.Size(115, 20);
            this.dtp_dataFimReserva.TabIndex = 23;
            // 
            // txt_emailReserva1
            // 
            this.txt_emailReserva1.AnimateReadOnly = false;
            this.txt_emailReserva1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_emailReserva1.Depth = 0;
            this.txt_emailReserva1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_emailReserva1.Hint = "Email";
            this.txt_emailReserva1.LeadingIcon = global::appBugInn.Properties.Resources.email;
            this.txt_emailReserva1.Location = new System.Drawing.Point(17, 73);
            this.txt_emailReserva1.MaxLength = 50;
            this.txt_emailReserva1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_emailReserva1.Multiline = false;
            this.txt_emailReserva1.Name = "txt_emailReserva1";
            this.txt_emailReserva1.Size = new System.Drawing.Size(562, 50);
            this.txt_emailReserva1.TabIndex = 32;
            this.txt_emailReserva1.Text = "";
            this.txt_emailReserva1.TrailingIcon = null;
            this.txt_emailReserva1.UseAccent = false;
            this.txt_emailReserva1.Leave += new System.EventHandler(this.txt_emailReserva1_Leave);
            // 
            // txt_telefoneReserva1
            // 
            this.txt_telefoneReserva1.AnimateReadOnly = false;
            this.txt_telefoneReserva1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefoneReserva1.Depth = 0;
            this.txt_telefoneReserva1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_telefoneReserva1.Hint = "Telefone";
            this.txt_telefoneReserva1.LeadingIcon = global::appBugInn.Properties.Resources.tele;
            this.txt_telefoneReserva1.Location = new System.Drawing.Point(17, 129);
            this.txt_telefoneReserva1.MaxLength = 50;
            this.txt_telefoneReserva1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_telefoneReserva1.Multiline = false;
            this.txt_telefoneReserva1.Name = "txt_telefoneReserva1";
            this.txt_telefoneReserva1.Size = new System.Drawing.Size(286, 50);
            this.txt_telefoneReserva1.TabIndex = 31;
            this.txt_telefoneReserva1.Text = "";
            this.txt_telefoneReserva1.TrailingIcon = null;
            this.txt_telefoneReserva1.UseAccent = false;
            this.txt_telefoneReserva1.Leave += new System.EventHandler(this.txt_telefoneReserva1_Leave);
            // 
            // txt_nomeReserva1
            // 
            this.txt_nomeReserva1.AnimateReadOnly = false;
            this.txt_nomeReserva1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeReserva1.Depth = 0;
            this.txt_nomeReserva1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nomeReserva1.Hint = "Nome";
            this.txt_nomeReserva1.LeadingIcon = global::appBugInn.Properties.Resources.Personnome;
            this.txt_nomeReserva1.Location = new System.Drawing.Point(17, 17);
            this.txt_nomeReserva1.MaxLength = 50;
            this.txt_nomeReserva1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nomeReserva1.Multiline = false;
            this.txt_nomeReserva1.Name = "txt_nomeReserva1";
            this.txt_nomeReserva1.Size = new System.Drawing.Size(562, 50);
            this.txt_nomeReserva1.TabIndex = 30;
            this.txt_nomeReserva1.Text = "";
            this.txt_nomeReserva1.TrailingIcon = null;
            this.txt_nomeReserva1.UseAccent = false;
            this.txt_nomeReserva1.TextChanged += new System.EventHandler(this.txt_nomeReserva1_TextChanged);
            this.txt_nomeReserva1.Leave += new System.EventHandler(this.txt_nomeReserva1_Leave);
            // 
            // btn_recuarDiaInicioReserva
            // 
            this.btn_recuarDiaInicioReserva.AutoSize = false;
            this.btn_recuarDiaInicioReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recuarDiaInicioReserva.BackColor = System.Drawing.Color.Transparent;
            this.btn_recuarDiaInicioReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_recuarDiaInicioReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_recuarDiaInicioReserva.Depth = 0;
            this.btn_recuarDiaInicioReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_recuarDiaInicioReserva.HighEmphasis = true;
            this.btn_recuarDiaInicioReserva.Icon = global::appBugInn.Properties.Resources.left_arrow_10238776;
            this.btn_recuarDiaInicioReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_recuarDiaInicioReserva.Location = new System.Drawing.Point(364, 53);
            this.btn_recuarDiaInicioReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_recuarDiaInicioReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recuarDiaInicioReserva.Name = "btn_recuarDiaInicioReserva";
            this.btn_recuarDiaInicioReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_recuarDiaInicioReserva.Size = new System.Drawing.Size(38, 20);
            this.btn_recuarDiaInicioReserva.TabIndex = 29;
            this.btn_recuarDiaInicioReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_recuarDiaInicioReserva.UseAccentColor = false;
            this.btn_recuarDiaInicioReserva.UseVisualStyleBackColor = false;
            this.btn_recuarDiaInicioReserva.Click += new System.EventHandler(this.btn_recuarDiaInicioReserva_Click);
            // 
            // btn_avançarDiaFimReserva
            // 
            this.btn_avançarDiaFimReserva.AutoSize = false;
            this.btn_avançarDiaFimReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_avançarDiaFimReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_avançarDiaFimReserva.Depth = 0;
            this.btn_avançarDiaFimReserva.HighEmphasis = true;
            this.btn_avançarDiaFimReserva.Icon = global::appBugInn.Properties.Resources.right_arrow;
            this.btn_avançarDiaFimReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_avançarDiaFimReserva.Location = new System.Drawing.Point(522, 53);
            this.btn_avançarDiaFimReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_avançarDiaFimReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_avançarDiaFimReserva.Name = "btn_avançarDiaFimReserva";
            this.btn_avançarDiaFimReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_avançarDiaFimReserva.Size = new System.Drawing.Size(38, 20);
            this.btn_avançarDiaFimReserva.TabIndex = 28;
            this.btn_avançarDiaFimReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_avançarDiaFimReserva.UseAccentColor = false;
            this.btn_avançarDiaFimReserva.UseVisualStyleBackColor = true;
            this.btn_avançarDiaFimReserva.Click += new System.EventHandler(this.btn_avançarDiaFimReserva_Click);
            // 
            // btn_avançaDiaInicioReserva
            // 
            this.btn_avançaDiaInicioReserva.AutoSize = false;
            this.btn_avançaDiaInicioReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_avançaDiaInicioReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_avançaDiaInicioReserva.Depth = 0;
            this.btn_avançaDiaInicioReserva.HighEmphasis = true;
            this.btn_avançaDiaInicioReserva.Icon = global::appBugInn.Properties.Resources.right_arrow;
            this.btn_avançaDiaInicioReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_avançaDiaInicioReserva.Location = new System.Drawing.Point(401, 53);
            this.btn_avançaDiaInicioReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_avançaDiaInicioReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_avançaDiaInicioReserva.Name = "btn_avançaDiaInicioReserva";
            this.btn_avançaDiaInicioReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_avançaDiaInicioReserva.Size = new System.Drawing.Size(38, 20);
            this.btn_avançaDiaInicioReserva.TabIndex = 27;
            this.btn_avançaDiaInicioReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_avançaDiaInicioReserva.UseAccentColor = false;
            this.btn_avançaDiaInicioReserva.UseVisualStyleBackColor = true;
            this.btn_avançaDiaInicioReserva.Click += new System.EventHandler(this.btn_avançaDiaReserva_Click);
            // 
            // btn_recuaDiaFimReserva
            // 
            this.btn_recuaDiaFimReserva.AutoSize = false;
            this.btn_recuaDiaFimReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recuaDiaFimReserva.BackColor = System.Drawing.Color.Transparent;
            this.btn_recuaDiaFimReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_recuaDiaFimReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_recuaDiaFimReserva.Depth = 0;
            this.btn_recuaDiaFimReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_recuaDiaFimReserva.HighEmphasis = true;
            this.btn_recuaDiaFimReserva.Icon = global::appBugInn.Properties.Resources.left_arrow_10238776;
            this.btn_recuaDiaFimReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_recuaDiaFimReserva.Location = new System.Drawing.Point(486, 53);
            this.btn_recuaDiaFimReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_recuaDiaFimReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recuaDiaFimReserva.Name = "btn_recuaDiaFimReserva";
            this.btn_recuaDiaFimReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_recuaDiaFimReserva.Size = new System.Drawing.Size(38, 20);
            this.btn_recuaDiaFimReserva.TabIndex = 26;
            this.btn_recuaDiaFimReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_recuaDiaFimReserva.UseAccentColor = false;
            this.btn_recuaDiaFimReserva.UseVisualStyleBackColor = false;
            this.btn_recuaDiaFimReserva.Click += new System.EventHandler(this.btn_recuaDiaReserva_Click);
            // 
            // lbl_dataFimReserva
            // 
            this.lbl_dataFimReserva.AutoSize = true;
            this.lbl_dataFimReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataFimReserva.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_dataFimReserva.Location = new System.Drawing.Point(470, 12);
            this.lbl_dataFimReserva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dataFimReserva.Name = "lbl_dataFimReserva";
            this.lbl_dataFimReserva.Size = new System.Drawing.Size(44, 9);
            this.lbl_dataFimReserva.TabIndex = 9;
            this.lbl_dataFimReserva.Text = "Data de fim";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txt_nomeReserva1);
            this.materialCard1.Controls.Add(this.txt_telefoneReserva1);
            this.materialCard1.Controls.Add(this.txt_emailReserva1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(22, 114);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(596, 189);
            this.materialCard1.TabIndex = 33;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label1);
            this.materialCard2.Controls.Add(this.cb_NumeroPessoas);
            this.materialCard2.Controls.Add(this.cb_TipoQuarto);
            this.materialCard2.Controls.Add(this.btn_avançarDiaFimReserva);
            this.materialCard2.Controls.Add(this.btn_recuaDiaFimReserva);
            this.materialCard2.Controls.Add(this.btn_recuarDiaInicioReserva);
            this.materialCard2.Controls.Add(this.dtp_dataFimReserva);
            this.materialCard2.Controls.Add(this.dtp_dataInicioReserva);
            this.materialCard2.Controls.Add(this.btn_avançaDiaInicioReserva);
            this.materialCard2.Controls.Add(this.lbl_dataFimReserva);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(22, 339);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(596, 91);
            this.materialCard2.TabIndex = 34;
            // 
            // btn_registarReserva
            // 
            this.btn_registarReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_registarReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_registarReserva.Depth = 0;
            this.btn_registarReserva.HighEmphasis = true;
            this.btn_registarReserva.Icon = null;
            this.btn_registarReserva.Location = new System.Drawing.Point(204, 450);
            this.btn_registarReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_registarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_registarReserva.Name = "btn_registarReserva";
            this.btn_registarReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_registarReserva.Size = new System.Drawing.Size(90, 36);
            this.btn_registarReserva.TabIndex = 35;
            this.btn_registarReserva.Text = "Registar";
            this.btn_registarReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_registarReserva.UseAccentColor = false;
            this.btn_registarReserva.UseVisualStyleBackColor = true;
            this.btn_registarReserva.Click += new System.EventHandler(this.btn_registarReserva_Click);
            // 
            // btn_cancelarReserva
            // 
            this.btn_cancelarReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelarReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelarReserva.Depth = 0;
            this.btn_cancelarReserva.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelarReserva.HighEmphasis = true;
            this.btn_cancelarReserva.Icon = null;
            this.btn_cancelarReserva.Location = new System.Drawing.Point(323, 450);
            this.btn_cancelarReserva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelarReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelarReserva.Name = "btn_cancelarReserva";
            this.btn_cancelarReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelarReserva.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelarReserva.TabIndex = 36;
            this.btn_cancelarReserva.Text = "Cancelar";
            this.btn_cancelarReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_cancelarReserva.UseAccentColor = true;
            this.btn_cancelarReserva.UseVisualStyleBackColor = true;
            this.btn_cancelarReserva.Click += new System.EventHandler(this.btn_cancelarReserva_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(23, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(249, 29);
            this.materialLabel1.TabIndex = 37;
            this.materialLabel1.Text = "Informações do cliente";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(23, 307);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(213, 29);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Detalhes da reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(351, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 9);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data de início";
            // 
            // F_reserva
            // 
            this.AcceptButton = this.btn_registarReserva;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelButton = this.btn_cancelarReserva;
            this.ClientSize = new System.Drawing.Size(641, 551);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_cancelarReserva);
            this.Controls.Add(this.btn_registarReserva);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_reserva";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 2, 2);
            this.Text = "                                          Reserva de quartos";
            this.Load += new System.EventHandler(this.F_reserva_Load);
           // this.Leave += new System.EventHandler(this.txt_emailreserva_Leave);
            this.materialCard1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.TextBox txt_telefoneReserva;
        private MaterialSkin.Controls.MaterialComboBox cb_NumeroPessoas;
        private MaterialSkin.Controls.MaterialComboBox cb_TipoQuarto;
        private System.Windows.Forms.DateTimePicker dtp_dataInicioReserva;
        private System.Windows.Forms.DateTimePicker dtp_dataFimReserva;
        private MaterialSkin.Controls.MaterialButton btn_recuaDiaFimReserva;
        private MaterialSkin.Controls.MaterialButton btn_avançaDiaInicioReserva;
        private MaterialSkin.Controls.MaterialButton btn_avançarDiaFimReserva;
        private MaterialSkin.Controls.MaterialButton btn_recuarDiaInicioReserva;
        private MaterialSkin.Controls.MaterialTextBox txt_nomeReserva1;
        private MaterialSkin.Controls.MaterialTextBox txt_telefoneReserva1;
        private MaterialSkin.Controls.MaterialTextBox txt_emailReserva1;
        private System.Windows.Forms.Label lbl_dataFimReserva;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton btn_registarReserva;
        private MaterialSkin.Controls.MaterialButton btn_cancelarReserva;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label label1;
    }
}