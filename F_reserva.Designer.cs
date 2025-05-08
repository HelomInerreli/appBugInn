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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nomeReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefoneReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emailreserva = new System.Windows.Forms.TextBox();
            this.btn_registarReserva = new System.Windows.Forms.Button();
            this.btn_cancelarReserva = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_NumeroPessoas = new MaterialSkin.Controls.MaterialComboBox();
            this.cb_TipoQuarto = new MaterialSkin.Controls.MaterialComboBox();
            this.dtp_dataInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataFimReserva = new System.Windows.Forms.DateTimePicker();
            this.btn_recuaDiaReserva = new MaterialSkin.Controls.MaterialButton();
            this.btn_avançaDiaReserva = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data de inicio ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(564, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data de fim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(534, 465);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo de quarto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 321);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "e-mail";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 321);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nr. Pessoas";
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
          //  this.dtp_dataInicioReserva.ValueChanged += new System.EventHandler(this.dtp_dataInicioReserva_ValueChanged);
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
          //  this.dtp_dataFimReserva.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btn_recuaDiaReserva
            // 
            this.btn_recuaDiaReserva.AutoSize = false;
            this.btn_recuaDiaReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_recuaDiaReserva.BackColor = System.Drawing.Color.Transparent;
            this.btn_recuaDiaReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_recuaDiaReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_recuaDiaReserva.Depth = 0;
            this.btn_recuaDiaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recuaDiaReserva.HighEmphasis = true;
            this.btn_recuaDiaReserva.Icon = global::appBugInn.Properties.Resources.left_arrow_10238776;
            this.btn_recuaDiaReserva.Location = new System.Drawing.Point(976, 263);
            this.btn_recuaDiaReserva.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_recuaDiaReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_recuaDiaReserva.Name = "btn_recuaDiaReserva";
            this.btn_recuaDiaReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_recuaDiaReserva.Size = new System.Drawing.Size(76, 38);
            this.btn_recuaDiaReserva.TabIndex = 26;
            this.btn_recuaDiaReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_recuaDiaReserva.UseAccentColor = false;
            this.btn_recuaDiaReserva.UseVisualStyleBackColor = false;
            this.btn_recuaDiaReserva.Click += new System.EventHandler(this.btn_recuaDiaReserva_Click);
            // 
            // btn_avançaDiaReserva
            // 
            this.btn_avançaDiaReserva.AutoSize = false;
            this.btn_avançaDiaReserva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_avançaDiaReserva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_avançaDiaReserva.Depth = 0;
            this.btn_avançaDiaReserva.HighEmphasis = true;
            this.btn_avançaDiaReserva.Icon = global::appBugInn.Properties.Resources.right_arrow;
            this.btn_avançaDiaReserva.Location = new System.Drawing.Point(976, 210);
            this.btn_avançaDiaReserva.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_avançaDiaReserva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_avançaDiaReserva.Name = "btn_avançaDiaReserva";
            this.btn_avançaDiaReserva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_avançaDiaReserva.Size = new System.Drawing.Size(76, 38);
            this.btn_avançaDiaReserva.TabIndex = 27;
            this.btn_avançaDiaReserva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_avançaDiaReserva.UseAccentColor = false;
            this.btn_avançaDiaReserva.UseVisualStyleBackColor = true;
            this.btn_avançaDiaReserva.Click += new System.EventHandler(this.btn_avançaDiaReserva_Click);
            // 
            // F_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 833);
            this.Controls.Add(this.btn_avançaDiaReserva);
            this.Controls.Add(this.btn_recuaDiaReserva);
            this.Controls.Add(this.dtp_dataFimReserva);
            this.Controls.Add(this.dtp_dataInicioReserva);
            this.Controls.Add(this.cb_TipoQuarto);
            this.Controls.Add(this.cb_NumeroPessoas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_cancelarReserva);
            this.Controls.Add(this.btn_registarReserva);
            this.Controls.Add(this.txt_emailreserva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_telefoneReserva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nomeReserva);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_reserva";
            this.Text = "F_reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nomeReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telefoneReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_emailreserva;
        private System.Windows.Forms.Button btn_registarReserva;
        private System.Windows.Forms.Button btn_cancelarReserva;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialComboBox cb_NumeroPessoas;
        private MaterialSkin.Controls.MaterialComboBox cb_TipoQuarto;
        private System.Windows.Forms.DateTimePicker dtp_dataInicioReserva;
        private System.Windows.Forms.DateTimePicker dtp_dataFimReserva;
        private MaterialSkin.Controls.MaterialButton btn_recuaDiaReserva;
        private MaterialSkin.Controls.MaterialButton btn_avançaDiaReserva;
    }
}