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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefoneReserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_dataInicioReserva = new System.Windows.Forms.TextBox();
            this.txt_dataFimReserva = new System.Windows.Forms.TextBox();
            this.txt_tipoQuartoReserva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emailreserva = new System.Windows.Forms.TextBox();
            this.btn_registarReserva = new System.Windows.Forms.Button();
            this.btn_cancelarReserva = new System.Windows.Forms.Button();
            this.txt_nomeReserva = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
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
            this.txt_telefoneReserva.TextChanged += new System.EventHandler(this.txt_telefoneReserva_TextChanged);
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
            this.label8.Location = new System.Drawing.Point(282, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo de quarto";
            // 
            // txt_dataInicioReserva
            // 
            this.txt_dataInicioReserva.Location = new System.Drawing.Point(368, 113);
            this.txt_dataInicioReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dataInicioReserva.Name = "txt_dataInicioReserva";
            this.txt_dataInicioReserva.Size = new System.Drawing.Size(93, 20);
            this.txt_dataInicioReserva.TabIndex = 11;
            this.txt_dataInicioReserva.TextChanged += new System.EventHandler(this.txt_dataInicioReserva_TextChanged);
            this.txt_dataInicioReserva.Leave += new System.EventHandler(this.txt_dataInicioReserva_Leave);
            // 
            // txt_dataFimReserva
            // 
            this.txt_dataFimReserva.Location = new System.Drawing.Point(368, 140);
            this.txt_dataFimReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dataFimReserva.Name = "txt_dataFimReserva";
            this.txt_dataFimReserva.Size = new System.Drawing.Size(93, 20);
            this.txt_dataFimReserva.TabIndex = 12;
            this.txt_dataFimReserva.TextChanged += new System.EventHandler(this.txt_dataFimReserva_TextChanged);
            this.txt_dataFimReserva.Leave += new System.EventHandler(this.txt_dataFimReserva_Leave);
            // 
            // txt_tipoQuartoReserva
            // 
            this.txt_tipoQuartoReserva.Location = new System.Drawing.Point(368, 165);
            this.txt_tipoQuartoReserva.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tipoQuartoReserva.Name = "txt_tipoQuartoReserva";
            this.txt_tipoQuartoReserva.Size = new System.Drawing.Size(93, 20);
            this.txt_tipoQuartoReserva.TabIndex = 13;
            this.txt_tipoQuartoReserva.TextChanged += new System.EventHandler(this.txt_tipoQuartoReserva_TextChanged);
            this.txt_tipoQuartoReserva.Leave += new System.EventHandler(this.txt_tipoQuartoReserva_Leave);
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
            this.txt_emailreserva.TextChanged += new System.EventHandler(this.txt_emailreserva_TextChanged);
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
            // txt_nomeReserva
            // 
            this.txt_nomeReserva.AnimateReadOnly = false;
            this.txt_nomeReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeReserva.Depth = 0;
            this.txt_nomeReserva.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nomeReserva.Hint = "Nome";
            this.txt_nomeReserva.LeadingIcon = null;
            this.txt_nomeReserva.Location = new System.Drawing.Point(43, 93);
            this.txt_nomeReserva.MaxLength = 50;
            this.txt_nomeReserva.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nomeReserva.Multiline = false;
            this.txt_nomeReserva.Name = "txt_nomeReserva";
            this.txt_nomeReserva.Size = new System.Drawing.Size(264, 50);
            this.txt_nomeReserva.TabIndex = 18;
            this.txt_nomeReserva.Text = "";
            this.txt_nomeReserva.TrailingIcon = null;
            this.txt_nomeReserva.Leave += new System.EventHandler(this.txt_nomeReserva_Leave);
            // 
            // F_reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 433);
            this.Controls.Add(this.txt_nomeReserva);
            this.Controls.Add(this.btn_cancelarReserva);
            this.Controls.Add(this.btn_registarReserva);
            this.Controls.Add(this.txt_emailreserva);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tipoQuartoReserva);
            this.Controls.Add(this.txt_dataFimReserva);
            this.Controls.Add(this.txt_dataInicioReserva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_telefoneReserva);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_reserva";
            this.Text = "F_reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telefoneReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dataInicioReserva;
        private System.Windows.Forms.TextBox txt_dataFimReserva;
        private System.Windows.Forms.TextBox txt_tipoQuartoReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_emailreserva;
        private System.Windows.Forms.Button btn_registarReserva;
        private System.Windows.Forms.Button btn_cancelarReserva;
        private MaterialSkin.Controls.MaterialTextBox txt_nomeReserva;
    }
}