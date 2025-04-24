namespace appBugInn
{
    partial class F_login
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
            this.bt_login = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.bt_mostrarPassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(164, 285);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.TabIndex = 0;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(164, 51);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 22);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(164, 124);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 22);
            this.txt_password.TabIndex = 2;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(53, 57);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(44, 16);
            this.lb_nome.TabIndex = 3;
            this.lb_nome.Text = "Nome";
            this.lb_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(53, 130);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(67, 16);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password";
            // 
            // bt_mostrarPassword
            // 
            this.bt_mostrarPassword.Location = new System.Drawing.Point(164, 179);
            this.bt_mostrarPassword.Name = "bt_mostrarPassword";
            this.bt_mostrarPassword.Size = new System.Drawing.Size(78, 47);
            this.bt_mostrarPassword.TabIndex = 5;
            this.bt_mostrarPassword.Text = "Mostrar Password";
            this.bt_mostrarPassword.UseVisualStyleBackColor = true;
            this.bt_mostrarPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.bt_mostrarPassword);
            this.panel1.Controls.Add(this.bt_login);
            this.panel1.Controls.Add(this.lb_password);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Controls.Add(this.lb_nome);
            this.panel1.Location = new System.Drawing.Point(263, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 385);
            this.panel1.TabIndex = 6;
            // 
            // F_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 593);
            this.Controls.Add(this.panel1);
            this.Name = "F_login";
            this.Text = "F_login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button bt_mostrarPassword;
        private System.Windows.Forms.Panel panel1;
    }
}