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
            this.SuspendLayout();
            // 
            // btn_lerFicheiro
            // 
            this.btn_lerFicheiro.Location = new System.Drawing.Point(351, 320);
            this.btn_lerFicheiro.Name = "btn_lerFicheiro";
            this.btn_lerFicheiro.Size = new System.Drawing.Size(75, 23);
            this.btn_lerFicheiro.TabIndex = 1;
            this.btn_lerFicheiro.Text = "Ler Ficheiro";
            this.btn_lerFicheiro.UseVisualStyleBackColor = true;
            this.btn_lerFicheiro.Click += new System.EventHandler(this.btn_lerFicheiro_Click);
            // 
            // txt_basedados
            // 
            this.txt_basedados.Location = new System.Drawing.Point(224, 322);
            this.txt_basedados.Name = "txt_basedados";
            this.txt_basedados.Size = new System.Drawing.Size(100, 20);
            this.txt_basedados.TabIndex = 2;
            this.txt_basedados.Text = "algo";
            // 
            // rtxt_caixa
            // 
            this.rtxt_caixa.Location = new System.Drawing.Point(120, 151);
            this.rtxt_caixa.Name = "rtxt_caixa";
            this.rtxt_caixa.Size = new System.Drawing.Size(468, 139);
            this.rtxt_caixa.TabIndex = 3;
            this.rtxt_caixa.Text = "";
            // 
            // F_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxt_caixa);
            this.Controls.Add(this.txt_basedados);
            this.Controls.Add(this.btn_lerFicheiro);
            this.Name = "F_inicial";
            this.Text = "F_inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_lerFicheiro;
        private System.Windows.Forms.TextBox txt_basedados;
        private System.Windows.Forms.RichTextBox rtxt_caixa;
    }
}