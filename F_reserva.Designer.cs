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
            this.btn_adicionarDia = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nomeReserva
            // 
            this.txt_nomeReserva.Location = new System.Drawing.Point(92, 113);
            this.txt_nomeReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nomeReserva.Name = "txt_nomeReserva";
            this.txt_nomeReserva.Size = new System.Drawing.Size(95, 20);
            this.txt_nomeReserva.TabIndex = 1;
            this.txt_nomeReserva.Leave += new System.EventHandler(this.txt_nomeReserva_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_telefoneReserva
            // 
            this.txt_telefoneReserva.Location = new System.Drawing.Point(92, 140);
            this.txt_telefoneReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefoneReserva.Name = "txt_telefoneReserva";
            this.txt_telefoneReserva.Size = new System.Drawing.Size(95, 20);
            this.txt_telefoneReserva.TabIndex = 4;
            this.txt_telefoneReserva.Leave += new System.EventHandler(this.txt_telefoneReserva_Leave);
            this.txt_telefoneReserva.Validating += new System.ComponentModel.CancelEventHandler(this.txt_telefoneReserva_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informaçoes do cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(254, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reserva de Quartos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(332, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Detalhes da reserva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data de inicio ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data de fim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 242);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo de quarto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "e-mail";
            // 
            // txt_emailreserva
            // 
            this.txt_emailreserva.Location = new System.Drawing.Point(92, 167);
            this.txt_emailreserva.Margin = new System.Windows.Forms.Padding(2);
            this.txt_emailreserva.Name = "txt_emailreserva";
            this.txt_emailreserva.Size = new System.Drawing.Size(95, 20);
            this.txt_emailreserva.TabIndex = 15;
            this.txt_emailreserva.Leave += new System.EventHandler(this.txt_emailreserva_Leave);
            // 
            // btn_registarReserva
            // 
            this.btn_registarReserva.Location = new System.Drawing.Point(116, 297);
            this.btn_registarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registarReserva.Name = "btn_registarReserva";
            this.btn_registarReserva.Size = new System.Drawing.Size(56, 30);
            this.btn_registarReserva.TabIndex = 16;
            this.btn_registarReserva.Text = "Registar";
            this.btn_registarReserva.UseVisualStyleBackColor = true;
            this.btn_registarReserva.Click += new System.EventHandler(this.btn_registarReserva_Click);
            // 
            // btn_cancelarReserva
            // 
            this.btn_cancelarReserva.Location = new System.Drawing.Point(360, 297);
            this.btn_cancelarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelarReserva.Name = "btn_cancelarReserva";
            this.btn_cancelarReserva.Size = new System.Drawing.Size(58, 30);
            this.btn_cancelarReserva.TabIndex = 17;
            this.btn_cancelarReserva.Text = "Cancelar";
            this.btn_cancelarReserva.UseVisualStyleBackColor = true;
            this.btn_cancelarReserva.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
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
            this.cb_NumeroPessoas.Location = new System.Drawing.Point(368, 167);
            this.cb_NumeroPessoas.MaxDropDownItems = 4;
            this.cb_NumeroPessoas.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_NumeroPessoas.Name = "cb_NumeroPessoas";
            this.cb_NumeroPessoas.Size = new System.Drawing.Size(115, 49);
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
            this.cb_TipoQuarto.Location = new System.Drawing.Point(368, 237);
            this.cb_TipoQuarto.MaxDropDownItems = 4;
            this.cb_TipoQuarto.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_TipoQuarto.Name = "cb_TipoQuarto";
            this.cb_TipoQuarto.Size = new System.Drawing.Size(121, 49);
            this.cb_TipoQuarto.StartIndex = 0;
            this.cb_TipoQuarto.TabIndex = 21;
            this.cb_TipoQuarto.SelectedIndexChanged += new System.EventHandler(this.cb_TipoQuarto_SelectedIndexChanged);
            // 
            // dtp_dataInicioReserva
            // 
            this.dtp_dataInicioReserva.CustomFormat = "dd/MM/yyyy";
            this.dtp_dataInicioReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dataInicioReserva.Location = new System.Drawing.Point(368, 110);
            this.dtp_dataInicioReserva.Name = "dtp_dataInicioReserva";
            this.dtp_dataInicioReserva.Size = new System.Drawing.Size(115, 20);
            this.dtp_dataInicioReserva.TabIndex = 22;
            this.dtp_dataInicioReserva.ValueChanged += new System.EventHandler(this.dtp_dataInicioReserva_ValueChanged);
            // 
            // dtp_dataFimReserva
            // 
            this.dtp_dataFimReserva.CustomFormat = "dd/MM/yyyy";
            this.dtp_dataFimReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dataFimReserva.Location = new System.Drawing.Point(368, 137);
            this.dtp_dataFimReserva.Name = "dtp_dataFimReserva";
            this.dtp_dataFimReserva.Size = new System.Drawing.Size(115, 20);
            this.dtp_dataFimReserva.TabIndex = 23;
            this.dtp_dataFimReserva.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btn_adicionarDia
            // 
            this.btn_adicionarDia.AutoSize = false;
            this.btn_adicionarDia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_adicionarDia.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_adicionarDia.Depth = 0;
            this.btn_adicionarDia.HighEmphasis = true;
            this.btn_adicionarDia.Icon = null;
            this.btn_adicionarDia.Location = new System.Drawing.Point(505, 107);
            this.btn_adicionarDia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_adicionarDia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_adicionarDia.Name = "btn_adicionarDia";
            this.btn_adicionarDia.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_adicionarDia.Size = new System.Drawing.Size(34, 26);
            this.btn_adicionarDia.TabIndex = 24;
            this.btn_adicionarDia.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_adicionarDia.UseAccentColor = false;
            this.btn_adicionarDia.UseVisualStyleBackColor = true;
            this.btn_adicionarDia.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(504, 137);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(35, 34);
            this.materialButton1.TabIndex = 25;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // F_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 433);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btn_adicionarDia);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private MaterialSkin.Controls.MaterialButton btn_adicionarDia;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}