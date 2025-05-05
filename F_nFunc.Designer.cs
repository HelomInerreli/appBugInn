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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_gestor = new System.Windows.Forms.Label();
            this.btn_criar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.chb_gestor = new System.Windows.Forms.CheckBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
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
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(243, 148);
            this.lbl_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 16);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(243, 194);
            this.lbl_telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(61, 16);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "Telefone";
            this.lbl_telefone.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_gestor
            // 
            this.lbl_gestor.AutoSize = true;
            this.lbl_gestor.Location = new System.Drawing.Point(243, 228);
            this.lbl_gestor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gestor.Name = "lbl_gestor";
            this.lbl_gestor.Size = new System.Drawing.Size(47, 16);
            this.lbl_gestor.TabIndex = 3;
            this.lbl_gestor.Text = "Gestor";
            this.lbl_gestor.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(284, 319);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(100, 28);
            this.btn_criar.TabIndex = 4;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(380, 144);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(132, 22);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(380, 188);
            this.txt_telefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(132, 22);
            this.txt_telefone.TabIndex = 6;
            // 
            // chb_gestor
            // 
            this.chb_gestor.AutoSize = true;
            this.chb_gestor.Location = new System.Drawing.Point(380, 228);
            this.chb_gestor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chb_gestor.Name = "chb_gestor";
            this.chb_gestor.Size = new System.Drawing.Size(18, 17);
            this.chb_gestor.TabIndex = 7;
            this.chb_gestor.UseVisualStyleBackColor = true;
            this.chb_gestor.CheckedChanged += new System.EventHandler(this.chb_gestor_CheckedChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(243, 263);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(67, 16);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(380, 260);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(132, 22);
            this.txt_password.TabIndex = 9;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // F_nFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.chb_gestor);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.lbl_gestor);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_nFunc";
            this.Text = "Novo Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_gestor;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.CheckBox chb_gestor;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
    }
}