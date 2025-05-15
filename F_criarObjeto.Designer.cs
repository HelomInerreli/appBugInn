namespace appBugInn
{
    partial class CriarObjeto
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_txt = new System.Windows.Forms.Label();
            this.lbl_objeto = new System.Windows.Forms.Label();
            this.txt_txt = new System.Windows.Forms.TextBox();
            this.txt_objeto = new System.Windows.Forms.TextBox();
            this.listBoxObjetos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Location = new System.Drawing.Point(44, 89);
            this.lbl_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(65, 13);
            this.lbl_txt.TabIndex = 1;
            this.lbl_txt.Text = "Base Dados";
            // 
            // lbl_objeto
            // 
            this.lbl_objeto.AutoSize = true;
            this.lbl_objeto.Location = new System.Drawing.Point(44, 155);
            this.lbl_objeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_objeto.Name = "lbl_objeto";
            this.lbl_objeto.Size = new System.Drawing.Size(32, 13);
            this.lbl_objeto.TabIndex = 2;
            this.lbl_objeto.Text = "Class";
            // 
            // txt_txt
            // 
            this.txt_txt.Location = new System.Drawing.Point(113, 89);
            this.txt_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_txt.Name = "txt_txt";
            this.txt_txt.Size = new System.Drawing.Size(76, 20);
            this.txt_txt.TabIndex = 3;
            this.txt_txt.TextChanged += new System.EventHandler(this.txt_txt_TextChanged);
            // 
            // txt_objeto
            // 
            this.txt_objeto.Location = new System.Drawing.Point(113, 148);
            this.txt_objeto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_objeto.Name = "txt_objeto";
            this.txt_objeto.Size = new System.Drawing.Size(76, 20);
            this.txt_objeto.TabIndex = 4;
            this.txt_objeto.TextChanged += new System.EventHandler(this.txt_objeto_TextChanged);
            // 
            // listBoxObjetos
            // 
            this.listBoxObjetos.FormattingEnabled = true;
            this.listBoxObjetos.Location = new System.Drawing.Point(204, 83);
            this.listBoxObjetos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxObjetos.Name = "listBoxObjetos";
            this.listBoxObjetos.Size = new System.Drawing.Size(385, 173);
            this.listBoxObjetos.TabIndex = 5;
            this.listBoxObjetos.SelectedIndexChanged += new System.EventHandler(this.listBoxObjetos_SelectedIndexChanged);
            // 
            // CriarObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listBoxObjetos);
            this.Controls.Add(this.txt_objeto);
            this.Controls.Add(this.txt_txt);
            this.Controls.Add(this.lbl_objeto);
            this.Controls.Add(this.lbl_txt);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CriarObjeto";
            this.Text = "CriarObjeto";
            this.Load += new System.EventHandler(this.CriarObjeto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_txt;
        private System.Windows.Forms.Label lbl_objeto;
        private System.Windows.Forms.TextBox txt_txt;
        private System.Windows.Forms.TextBox txt_objeto;
        private System.Windows.Forms.ListBox listBoxObjetos;
    }
}