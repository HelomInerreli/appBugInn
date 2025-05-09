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
            this.lbl_nomeReserva = new System.Windows.Forms.Label();
            this.txt_nomeReserva = new System.Windows.Forms.TextBox();
            this.lbl_telefoneReserva = new System.Windows.Forms.Label();
            this.txt_telefoneReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_dataInicioReserva = new System.Windows.Forms.Label();
            this.lbl_dataFimReserva = new System.Windows.Forms.Label();
            this.lbl_tipoQuartoReserva = new System.Windows.Forms.Label();
            this.lbl_emailReserva = new System.Windows.Forms.Label();
            this.txt_emailreserva = new System.Windows.Forms.TextBox();
            this.btn_registarReserva = new System.Windows.Forms.Button();
            this.btn_cancelarReserva = new System.Windows.Forms.Button();
            this.lbl_nrPessoasREserva = new System.Windows.Forms.Label();
            this.cb_NumeroPessoas = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_TipoQuarto = new MaterialSkin.Controls.MaterialComboBox();
            this.dtp_dataInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataFimReserva = new System.Windows.Forms.DateTimePicker();
            this.btn_recuaDiaFimReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_avançaDiaInicioReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_avançarDiaFimReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_recuarDiaInicioReserva = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_nomeReserva
            // 
            this.lbl_nomeReserva.AutoSize = true;
            this.lbl_nomeReserva.Location = new System.Drawing.Point(80, 217);
            this.lbl_nomeReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomeReserva.Name = "lbl_nomeReserva";
            this.lbl_nomeReserva.Size = new System.Drawing.Size(68, 25);
            this.lbl_nomeReserva.TabIndex = 0;
            this.lbl_nomeReserva.Text = "Nome";
            // 
            // txt_nomeReserva
            // 
            this.txt_nomeReserva.Location = new System.Drawing.Point(184, 217);
            this.txt_nomeReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeReserva.Name = "txt_nomeReserva";
            this.txt_nomeReserva.Size = new System.Drawing.Size(186, 31);
            this.txt_nomeReserva.TabIndex = 1;
            this.txt_nomeReserva.Leave += new System.EventHandler(this.txt_nomeReserva_Leave);
            // 
            // lbl_telefoneReserva
            // 
            this.lbl_telefoneReserva.AutoSize = true;
            this.lbl_telefoneReserva.Location = new System.Drawing.Point(80, 269);
            this.lbl_telefoneReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefoneReserva.Name = "lbl_telefoneReserva";
            this.lbl_telefoneReserva.Size = new System.Drawing.Size(96, 25);
            this.lbl_telefoneReserva.TabIndex = 3;
            this.lbl_telefoneReserva.Text = "Telefone";
            this.lbl_telefoneReserva.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_telefoneReserva
            // 
            this.txt_telefoneReserva.Location = new System.Drawing.Point(184, 269);
            this.txt_telefoneReserva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefoneReserva.Name = "txt_telefoneReserva";
            this.txt_telefoneReserva.Size = new System.Drawing.Size(186, 31);
            this.txt_telefoneReserva.TabIndex = 4;
            this.txt_telefoneReserva.Leave += new System.EventHandler(this.txt_telefoneReserva_Leave);
            this.txt_telefoneReserva.Validating += new System.ComponentModel.CancelEventHandler(this.txt_telefoneReserva_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(80, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informaçoes do cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(508, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reserva de Quartos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(664, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Detalhes da reserva";
            // 
            // lbl_dataInicioReserva
            // 
            this.lbl_dataInicioReserva.AutoSize = true;
            this.lbl_dataInicioReserva.Location = new System.Drawing.Point(564, 215);
            this.lbl_dataInicioReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dataInicioReserva.Name = "lbl_dataInicioReserva";
            this.lbl_dataInicioReserva.Size = new System.Drawing.Size(149, 25);
            this.lbl_dataInicioReserva.TabIndex = 8;
            this.lbl_dataInicioReserva.Text = "Data de inicio ";
            this.lbl_dataInicioReserva.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_dataFimReserva
            // 
            this.lbl_dataFimReserva.AutoSize = true;
            this.lbl_dataFimReserva.Location = new System.Drawing.Point(564, 269);
            this.lbl_dataFimReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dataFimReserva.Name = "lbl_dataFimReserva";
            this.lbl_dataFimReserva.Size = new System.Drawing.Size(121, 25);
            this.lbl_dataFimReserva.TabIndex = 9;
            this.lbl_dataFimReserva.Text = "Data de fim";
            // 
            // lbl_tipoQuartoReserva
            // 
            this.lbl_tipoQuartoReserva.AutoSize = true;
            this.lbl_tipoQuartoReserva.Location = new System.Drawing.Point(534, 465);
            this.lbl_tipoQuartoReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoQuartoReserva.Name = "lbl_tipoQuartoReserva";
            this.lbl_tipoQuartoReserva.Size = new System.Drawing.Size(151, 25);
            this.lbl_tipoQuartoReserva.TabIndex = 10;
            this.lbl_tipoQuartoReserva.Text = "Tipo de quarto";
            // 
            // lbl_emailReserva
            // 
            this.lbl_emailReserva.AutoSize = true;
            this.lbl_emailReserva.Location = new System.Drawing.Point(80, 321);
            this.lbl_emailReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emailReserva.Name = "lbl_emailReserva";
            this.lbl_emailReserva.Size = new System.Drawing.Size(70, 25);
            this.lbl_emailReserva.TabIndex = 14;
            this.lbl_emailReserva.Text = "e-mail";
            // 
            // txt_emailreserva
            // 
            this.txt_emailreserva.Location = new System.Drawing.Point(184, 321);
            this.txt_emailreserva.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emailreserva.Name = "txt_emailreserva";
            this.txt_emailreserva.Size = new System.Drawing.Size(186, 31);
            this.txt_emailreserva.TabIndex = 15;
            this.txt_emailreserva.Leave += new System.EventHandler(this.txt_emailreserva_Leave);
            // 
            // btn_registarReserva
            // 
            this.btn_registarReserva.Location = new System.Drawing.Point(232, 571);
            this.btn_registarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registarReserva.Name = "btn_registarReserva";
            this.btn_registarReserva.Size = new System.Drawing.Size(112, 58);
            this.btn_registarReserva.TabIndex = 16;
            this.btn_registarReserva.Text = "Registar";
            this.btn_registarReserva.UseVisualStyleBackColor = true;
            this.btn_registarReserva.Click += new System.EventHandler(this.btn_registarReserva_Click);
            // 
            // btn_cancelarReserva
            // 
            this.btn_cancelarReserva.Location = new System.Drawing.Point(720, 571);
            this.btn_cancelarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelarReserva.Name = "btn_cancelarReserva";
            this.btn_cancelarReserva.Size = new System.Drawing.Size(116, 58);
            this.btn_cancelarReserva.TabIndex = 17;
            this.btn_cancelarReserva.Text = "Cancelar";
            this.btn_cancelarReserva.UseVisualStyleBackColor = true;
            this.btn_cancelarReserva.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_nrPessoasREserva
            // 
            this.lbl_nrPessoasREserva.AutoSize = true;
            this.lbl_nrPessoasREserva.Location = new System.Drawing.Point(570, 321);
            this.lbl_nrPessoasREserva.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nrPessoasREserva.Name = "lbl_nrPessoasREserva";
            this.lbl_nrPessoasREserva.Size = new System.Drawing.Size(129, 25);
            this.lbl_nrPessoasREserva.TabIndex = 18;
            this.lbl_nrPessoasREserva.Text = "Nr. Pessoas";
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
            this.cb_NumeroPessoas.IntegralHeight = false;
            this.cb_NumeroPessoas.ItemHeight = 43;
            this.cb_NumeroPessoas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cb_NumeroPessoas.Location = new System.Drawing.Point(736, 321);
            this.cb_NumeroPessoas.Margin = new System.Windows.Forms.Padding(6);
            this.cb_NumeroPessoas.MaxDropDownItems = 4;
            this.cb_NumeroPessoas.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_NumeroPessoas.Name = "cb_NumeroPessoas";
            this.cb_NumeroPessoas.Size = new System.Drawing.Size(226, 49);
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
            this.cb_TipoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb_TipoQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_TipoQuarto.FormattingEnabled = true;
            this.cb_TipoQuarto.IntegralHeight = false;
            this.cb_TipoQuarto.ItemHeight = 43;
            this.cb_TipoQuarto.Items.AddRange(new object[] {
            "Simples",
            "Duplo",
            "Suite",
            "Deluxe"});
            this.cb_TipoQuarto.Location = new System.Drawing.Point(736, 456);
            this.cb_TipoQuarto.Margin = new System.Windows.Forms.Padding(6);
            this.cb_TipoQuarto.MaxDropDownItems = 4;
            this.cb_TipoQuarto.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_TipoQuarto.Name = "cb_TipoQuarto";
            this.cb_TipoQuarto.Size = new System.Drawing.Size(238, 49);
            this.cb_TipoQuarto.StartIndex = 0;
            this.cb_TipoQuarto.TabIndex = 21;
            this.cb_TipoQuarto.SelectedIndexChanged += new System.EventHandler(this.cb_TipoQuarto_SelectedIndexChanged);
            // 
            // dtp_dataInicioReserva
            // 
            this.dtp_dataInicioReserva.CustomFormat = "dd/MM/yyyy";
            this.dtp_dataInicioReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dataInicioReserva.Location = new System.Drawing.Point(736, 212);
            this.dtp_dataInicioReserva.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_dataInicioReserva.Name = "dtp_dataInicioReserva";
            this.dtp_dataInicioReserva.Size = new System.Drawing.Size(226, 31);
            this.dtp_dataInicioReserva.TabIndex = 22;
            // 
            // dtp_dataFimReserva
            // 
            this.dtp_dataFimReserva.CustomFormat = "dd/MM/yyyy";
            this.dtp_dataFimReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dataFimReserva.Location = new System.Drawing.Point(736, 263);
            this.dtp_dataFimReserva.Margin = new System.Windows.Forms.Padding(6);
            this.dtp_dataFimReserva.Name = "dtp_dataFimReserva";
            this.dtp_dataFimReserva.Size = new System.Drawing.Size(226, 31);
            this.dtp_dataFimReserva.TabIndex = 23;
            // 
            // btn_recuaDiaFimReserva
            // 
            this.btn_recuaDiaFimReserva.AutoSize = false;
            this.btn_recuaDiaFimReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recuaDiaFimReserva.BackColor = System.Drawing.Color.Transparent;
            this.btn_recuaDiaFimReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_recuaDiaFimReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_recuaDiaFimReserva.Depth = 0;
            this.btn_recuaDiaFimReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recuaDiaFimReserva.HighEmphasis = true;
            this.btn_recuaDiaFimReserva.Icon = global::appBugInn.Properties.Resources.left_arrow_10238776;
            this.btn_recuaDiaFimReserva.Location = new System.Drawing.Point(976, 262);
            this.btn_recuaDiaFimReserva.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_recuaDiaFimReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recuaDiaFimReserva.Name = "btn_recuaDiaFimReserva";
            this.btn_recuaDiaFimReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_recuaDiaFimReserva.Size = new System.Drawing.Size(76, 38);
            this.btn_recuaDiaFimReserva.TabIndex = 26;
            this.btn_recuaDiaFimReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_recuaDiaFimReserva.UseAccentColor = false;
            this.btn_recuaDiaFimReserva.UseVisualStyleBackColor = false;
            this.btn_recuaDiaFimReserva.Click += new System.EventHandler(this.btn_recuaDiaReserva_Click);
            // 
            // btn_avançaDiaInicioReserva
            // 
            this.btn_avançaDiaInicioReserva.AutoSize = false;
            this.btn_avançaDiaInicioReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_avançaDiaInicioReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_avançaDiaInicioReserva.Depth = 0;
            this.btn_avançaDiaInicioReserva.HighEmphasis = true;
            this.btn_avançaDiaInicioReserva.Icon = global::appBugInn.Properties.Resources.right_arrow;
            this.btn_avançaDiaInicioReserva.Location = new System.Drawing.Point(1100, 208);
            this.btn_avançaDiaInicioReserva.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_avançaDiaInicioReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_avançaDiaInicioReserva.Name = "btn_avançaDiaInicioReserva";
            this.btn_avançaDiaInicioReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_avançaDiaInicioReserva.Size = new System.Drawing.Size(76, 38);
            this.btn_avançaDiaInicioReserva.TabIndex = 27;
            this.btn_avançaDiaInicioReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_avançaDiaInicioReserva.UseAccentColor = false;
            this.btn_avançaDiaInicioReserva.UseVisualStyleBackColor = true;
            this.btn_avançaDiaInicioReserva.Click += new System.EventHandler(this.btn_avançaDiaReserva_Click);
            // 
            // btn_avançarDiaFimReserva
            // 
            this.btn_avançarDiaFimReserva.AutoSize = false;
            this.btn_avançarDiaFimReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_avançarDiaFimReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_avançarDiaFimReserva.Depth = 0;
            this.btn_avançarDiaFimReserva.HighEmphasis = true;
            this.btn_avançarDiaFimReserva.Icon = global::appBugInn.Properties.Resources.right_arrow;
            this.btn_avançarDiaFimReserva.Location = new System.Drawing.Point(1100, 261);
            this.btn_avançarDiaFimReserva.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_avançarDiaFimReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_avançarDiaFimReserva.Name = "btn_avançarDiaFimReserva";
            this.btn_avançarDiaFimReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_avançarDiaFimReserva.Size = new System.Drawing.Size(76, 38);
            this.btn_avançarDiaFimReserva.TabIndex = 28;
            this.btn_avançarDiaFimReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_avançarDiaFimReserva.UseAccentColor = false;
            this.btn_avançarDiaFimReserva.UseVisualStyleBackColor = true;
            this.btn_avançarDiaFimReserva.Click += new System.EventHandler(this.btn_avançarDiaFimReserva_Click);
            // 
            // btn_recuarDiaInicioReserva
            // 
            this.btn_recuarDiaInicioReserva.AutoSize = false;
            this.btn_recuarDiaInicioReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recuarDiaInicioReserva.BackColor = System.Drawing.Color.Transparent;
            this.btn_recuarDiaInicioReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_recuarDiaInicioReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_recuarDiaInicioReserva.Depth = 0;
            this.btn_recuarDiaInicioReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recuarDiaInicioReserva.HighEmphasis = true;
            this.btn_recuarDiaInicioReserva.Icon = global::appBugInn.Properties.Resources.left_arrow_10238776;
            this.btn_recuarDiaInicioReserva.Location = new System.Drawing.Point(976, 210);
            this.btn_recuarDiaInicioReserva.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_recuarDiaInicioReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recuarDiaInicioReserva.Name = "btn_recuarDiaInicioReserva";
            this.btn_recuarDiaInicioReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_recuarDiaInicioReserva.Size = new System.Drawing.Size(76, 38);
            this.btn_recuarDiaInicioReserva.TabIndex = 29;
            this.btn_recuarDiaInicioReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_recuarDiaInicioReserva.UseAccentColor = false;
            this.btn_recuarDiaInicioReserva.UseVisualStyleBackColor = false;
            this.btn_recuarDiaInicioReserva.Click += new System.EventHandler(this.btn_recuarDiaInicioReserva_Click);
            // 
            // F_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 833);
            this.Controls.Add(this.btn_recuarDiaInicioReserva);
            this.Controls.Add(this.btn_avançarDiaFimReserva);
            this.Controls.Add(this.btn_avançaDiaInicioReserva);
            this.Controls.Add(this.btn_recuaDiaFimReserva);
            this.Controls.Add(this.dtp_dataFimReserva);
            this.Controls.Add(this.dtp_dataInicioReserva);
            this.Controls.Add(this.cb_TipoQuarto);
            this.Controls.Add(this.cb_NumeroPessoas);
            this.Controls.Add(this.lbl_nrPessoasREserva);
            this.Controls.Add(this.btn_cancelarReserva);
            this.Controls.Add(this.btn_registarReserva);
            this.Controls.Add(this.txt_emailreserva);
            this.Controls.Add(this.lbl_emailReserva);
            this.Controls.Add(this.lbl_tipoQuartoReserva);
            this.Controls.Add(this.lbl_dataFimReserva);
            this.Controls.Add(this.lbl_dataInicioReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_telefoneReserva);
            this.Controls.Add(this.lbl_telefoneReserva);
            this.Controls.Add(this.txt_nomeReserva);
            this.Controls.Add(this.lbl_nomeReserva);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_reserva";
            this.Text = "F_reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomeReserva;
        private System.Windows.Forms.TextBox txt_nomeReserva;
        private System.Windows.Forms.Label lbl_telefoneReserva;
        private System.Windows.Forms.TextBox txt_telefoneReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_dataInicioReserva;
        private System.Windows.Forms.Label lbl_dataFimReserva;
        private System.Windows.Forms.Label lbl_tipoQuartoReserva;
        private System.Windows.Forms.Label lbl_emailReserva;
        private System.Windows.Forms.TextBox txt_emailreserva;
        private System.Windows.Forms.Button btn_registarReserva;
        private System.Windows.Forms.Button btn_cancelarReserva;
        private System.Windows.Forms.Label lbl_nrPessoasREserva;
        private MaterialSkin.Controls.MaterialComboBox cb_NumeroPessoas;
        private MaterialSkin.Controls.MaterialComboBox cb_TipoQuarto;
        private System.Windows.Forms.DateTimePicker dtp_dataInicioReserva;
        private System.Windows.Forms.DateTimePicker dtp_dataFimReserva;
        private MaterialSkin.Controls.MaterialButton btn_recuaDiaFimReserva;
        private MaterialSkin.Controls.MaterialButton btn_avançaDiaInicioReserva;
        private MaterialSkin.Controls.MaterialButton btn_avançarDiaFimReserva;
        private MaterialSkin.Controls.MaterialButton btn_recuarDiaInicioReserva;
    }
}