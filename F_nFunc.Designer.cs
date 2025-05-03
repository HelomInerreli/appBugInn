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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(182, 120);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(182, 156);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 2;
            this.lbl_telefone.Text = "Telefone";
            this.lbl_telefone.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_gestor
            // 
            this.lbl_gestor.AutoSize = true;
            this.lbl_gestor.Location = new System.Drawing.Point(182, 189);
            this.lbl_gestor.Name = "lbl_gestor";
            this.lbl_gestor.Size = new System.Drawing.Size(38, 13);
            this.lbl_gestor.TabIndex = 3;
            this.lbl_gestor.Text = "Gestor";
            this.lbl_gestor.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(213, 259);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(75, 23);
            this.btn_criar.TabIndex = 4;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(285, 117);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(285, 153);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 6;
            // 
            // chb_gestor
            // 
            this.chb_gestor.AutoSize = true;
            this.chb_gestor.Location = new System.Drawing.Point(285, 185);
            this.chb_gestor.Name = "chb_gestor";
            this.chb_gestor.Size = new System.Drawing.Size(15, 14);
            this.chb_gestor.TabIndex = 7;
            this.chb_gestor.UseVisualStyleBackColor = true;
            this.chb_gestor.CheckedChanged += new System.EventHandler(this.chb_gestor_CheckedChanged);
            // 
            // F_nFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chb_gestor);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.lbl_gestor);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label1);
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
    }
}