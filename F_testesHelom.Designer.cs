namespace appBugInn
{
    partial class F_testesHelom
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
            this.txt_vProcurar = new System.Windows.Forms.TextBox();
            this.txt_vBaseDados = new System.Windows.Forms.TextBox();
            this.txt_colunaProcurar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_vProcurar
            // 
            this.txt_vProcurar.Location = new System.Drawing.Point(127, 280);
            this.txt_vProcurar.Name = "txt_vProcurar";
            this.txt_vProcurar.Size = new System.Drawing.Size(190, 31);
            this.txt_vProcurar.TabIndex = 0;
            // 
            // txt_vBaseDados
            // 
            this.txt_vBaseDados.Location = new System.Drawing.Point(127, 139);
            this.txt_vBaseDados.Name = "txt_vBaseDados";
            this.txt_vBaseDados.Size = new System.Drawing.Size(190, 31);
            this.txt_vBaseDados.TabIndex = 1;
            this.txt_vBaseDados.Text = "algo";
            // 
            // txt_colunaProcurar
            // 
            this.txt_colunaProcurar.Location = new System.Drawing.Point(127, 379);
            this.txt_colunaProcurar.Name = "txt_colunaProcurar";
            this.txt_colunaProcurar.Size = new System.Drawing.Size(190, 31);
            this.txt_colunaProcurar.TabIndex = 2;
            this.txt_colunaProcurar.Leave += new System.EventHandler(this.txt_colunaProcurar_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Procurado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coluna Procurar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base Dados";
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(143, 438);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(139, 55);
            this.btn_procurar.TabIndex = 6;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(574, 321);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(318, 55);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "RESULTADO";
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(143, 529);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(139, 55);
            this.btn_apagar.TabIndex = 8;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // F_testesHelom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 856);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_colunaProcurar);
            this.Controls.Add(this.txt_vBaseDados);
            this.Controls.Add(this.txt_vProcurar);
            this.Name = "F_testesHelom";
            this.Text = "F_testesHelom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vProcurar;
        private System.Windows.Forms.TextBox txt_vBaseDados;
        private System.Windows.Forms.TextBox txt_colunaProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_apagar;
    }
}