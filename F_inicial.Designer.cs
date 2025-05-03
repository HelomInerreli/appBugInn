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
            this.btn_logins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lerFicheiro
            // 
            this.btn_lerFicheiro.Location = new System.Drawing.Point(364, 165);
            this.btn_lerFicheiro.Name = "btn_lerFicheiro";
            this.btn_lerFicheiro.Size = new System.Drawing.Size(75, 23);
            this.btn_lerFicheiro.TabIndex = 1;
            this.btn_lerFicheiro.Text = "Ler Ficheiro";
            this.btn_lerFicheiro.UseVisualStyleBackColor = true;
            this.btn_lerFicheiro.Click += new System.EventHandler(this.btn_lerFicheiro_Click);
            // 
            // txt_basedados
            // 
            this.txt_basedados.Location = new System.Drawing.Point(244, 168);
            this.txt_basedados.Name = "txt_basedados";
            this.txt_basedados.Size = new System.Drawing.Size(100, 20);
            this.txt_basedados.TabIndex = 2;
            this.txt_basedados.Text = "algo";
            // 
            // rtxt_caixa
            // 
            this.rtxt_caixa.Location = new System.Drawing.Point(139, 12);
            this.rtxt_caixa.Name = "rtxt_caixa";
            this.rtxt_caixa.Size = new System.Drawing.Size(468, 139);
            this.rtxt_caixa.TabIndex = 3;
            this.rtxt_caixa.Text = "";
            // 
            // txt_addLinha
            // 
            this.txt_addLinha.Location = new System.Drawing.Point(139, 206);
            this.txt_addLinha.Name = "txt_addLinha";
            this.txt_addLinha.Size = new System.Drawing.Size(468, 20);
            this.txt_addLinha.TabIndex = 4;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(332, 242);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar.TabIndex = 5;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_logins
            // 
            this.btn_logins.Location = new System.Drawing.Point(608, 352);
            this.btn_logins.Name = "btn_logins";
            this.btn_logins.Size = new System.Drawing.Size(75, 23);
            this.btn_logins.TabIndex = 6;
            this.btn_logins.Text = "Logins";
            this.btn_logins.UseVisualStyleBackColor = true;
            this.btn_logins.Click += new System.EventHandler(this.btn_logins_Click);
            // 
            // F_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logins);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_addLinha);
            this.Controls.Add(this.rtxt_caixa);
            this.Controls.Add(this.txt_basedados);
            this.Controls.Add(this.btn_lerFicheiro);
            this.Name = "F_inicial";
            this.Text = "F_inicial";
            this.Load += new System.EventHandler(this.F_inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_lerFicheiro;
        private System.Windows.Forms.TextBox txt_basedados;
        private System.Windows.Forms.RichTextBox rtxt_caixa;
        private System.Windows.Forms.TextBox txt_addLinha;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_logins;
    }
}