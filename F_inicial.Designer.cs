namespace appBugInn
{
    partial class F_inicial
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
            this.btn_lerFicheiro = new System.Windows.Forms.Button();
            this.txt_basedados = new System.Windows.Forms.TextBox();
            this.rtxt_caixa = new System.Windows.Forms.RichTextBox();
            this.txt_addLinha = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_reservasInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lerFicheiro
            // 
            this.btn_lerFicheiro.Location = new System.Drawing.Point(728, 317);
            this.btn_lerFicheiro.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_lerFicheiro.Name = "btn_lerFicheiro";
            this.btn_lerFicheiro.Size = new System.Drawing.Size(150, 44);
            this.btn_lerFicheiro.TabIndex = 1;
            this.btn_lerFicheiro.Text = "Ler Ficheiro";
            this.btn_lerFicheiro.UseVisualStyleBackColor = true;
            this.btn_lerFicheiro.Click += new System.EventHandler(this.btn_lerFicheiro_Click);
            // 
            // txt_basedados
            // 
            this.txt_basedados.Location = new System.Drawing.Point(488, 323);
            this.txt_basedados.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_basedados.Name = "txt_basedados";
            this.txt_basedados.Size = new System.Drawing.Size(196, 31);
            this.txt_basedados.TabIndex = 2;
            this.txt_basedados.Text = "algo";
            // 
            // rtxt_caixa
            // 
            this.rtxt_caixa.Location = new System.Drawing.Point(278, 23);
            this.rtxt_caixa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtxt_caixa.Name = "rtxt_caixa";
            this.rtxt_caixa.Size = new System.Drawing.Size(932, 264);
            this.rtxt_caixa.TabIndex = 3;
            this.rtxt_caixa.Text = "";
            // 
            // txt_addLinha
            // 
            this.txt_addLinha.Location = new System.Drawing.Point(278, 396);
            this.txt_addLinha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_addLinha.Name = "txt_addLinha";
            this.txt_addLinha.Size = new System.Drawing.Size(932, 31);
            this.txt_addLinha.TabIndex = 4;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(664, 465);
            this.btn_gravar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(150, 44);
            this.btn_gravar.TabIndex = 5;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_reservasInicial
            // 
            this.btn_reservasInicial.Location = new System.Drawing.Point(1035, 606);
            this.btn_reservasInicial.Name = "btn_reservasInicial";
            this.btn_reservasInicial.Size = new System.Drawing.Size(141, 49);
            this.btn_reservasInicial.TabIndex = 6;
            this.btn_reservasInicial.Text = "Reservas";
            this.btn_reservasInicial.UseVisualStyleBackColor = true;
            this.btn_reservasInicial.Click += new System.EventHandler(this.btn_reservasInicial_Click);
            // 
            // F_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btn_reservasInicial);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_addLinha);
            this.Controls.Add(this.rtxt_caixa);
            this.Controls.Add(this.txt_basedados);
            this.Controls.Add(this.btn_lerFicheiro);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "F_inicial";
            this.Text = "F_inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_lerFicheiro;
        private System.Windows.Forms.TextBox txt_basedados;
        private System.Windows.Forms.RichTextBox rtxt_caixa;
        private System.Windows.Forms.TextBox txt_addLinha;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_reservasInicial;
    }
}