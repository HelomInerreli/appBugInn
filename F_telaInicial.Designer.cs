namespace appBugInn
{
    partial class F_telaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_telaInicial));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tb_home = new System.Windows.Forms.TabPage();
            this.tb_reservas = new System.Windows.Forms.TabPage();
            this.iconesMenu = new System.Windows.Forms.ImageList(this.components);
            this.tb_checkIn = new System.Windows.Forms.TabPage();
            this.tb_checkOut = new System.Windows.Forms.TabPage();
            this.tb_gerirQuartos = new System.Windows.Forms.TabPage();
            this.tb_funcionarios = new System.Windows.Forms.TabPage();
            this.tb_diretoria = new System.Windows.Forms.TabPage();
            this.tb_configuracoes = new System.Windows.Forms.TabPage();
            this.sw_darkMode = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tb_home);
            this.materialTabControl1.Controls.Add(this.tb_reservas);
            this.materialTabControl1.Controls.Add(this.tb_checkIn);
            this.materialTabControl1.Controls.Add(this.tb_checkOut);
            this.materialTabControl1.Controls.Add(this.tb_gerirQuartos);
            this.materialTabControl1.Controls.Add(this.tb_funcionarios);
            this.materialTabControl1.Controls.Add(this.tb_diretoria);
            this.materialTabControl1.Controls.Add(this.tb_configuracoes);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.iconesMenu;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(969, 555);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tb_home
            // 
            this.tb_home.ImageKey = "icons8-casa-32.png";
            this.tb_home.Location = new System.Drawing.Point(4, 39);
            this.tb_home.Name = "tb_home";
            this.tb_home.Padding = new System.Windows.Forms.Padding(3);
            this.tb_home.Size = new System.Drawing.Size(961, 512);
            this.tb_home.TabIndex = 0;
            this.tb_home.Text = "HOME";
            this.tb_home.UseVisualStyleBackColor = true;
            // 
            // tb_reservas
            // 
            this.tb_reservas.ImageKey = "icons8-livro-32.png";
            this.tb_reservas.Location = new System.Drawing.Point(4, 39);
            this.tb_reservas.Name = "tb_reservas";
            this.tb_reservas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_reservas.Size = new System.Drawing.Size(786, 340);
            this.tb_reservas.TabIndex = 1;
            this.tb_reservas.Text = "RESERVAS";
            this.tb_reservas.UseVisualStyleBackColor = true;
            // 
            // iconesMenu
            // 
            this.iconesMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconesMenu.ImageStream")));
            this.iconesMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.iconesMenu.Images.SetKeyName(0, "icons8-hotel-chekc-fora-32.png");
            this.iconesMenu.Images.SetKeyName(1, "icons8-check-in-hotel-32.png");
            this.iconesMenu.Images.SetKeyName(2, "icons8-config-32.png");
            this.iconesMenu.Images.SetKeyName(3, "icons8-gerente-32.png");
            this.iconesMenu.Images.SetKeyName(4, "icons8-quarto-32.png");
            this.iconesMenu.Images.SetKeyName(5, "icons8-livro-32.png");
            this.iconesMenu.Images.SetKeyName(6, "icons8-casa-32.png");
            this.iconesMenu.Images.SetKeyName(7, "icons8-contrato-de-trabalho-32.png");
            // 
            // tb_checkIn
            // 
            this.tb_checkIn.ImageKey = "icons8-check-in-hotel-32.png";
            this.tb_checkIn.Location = new System.Drawing.Point(4, 39);
            this.tb_checkIn.Name = "tb_checkIn";
            this.tb_checkIn.Size = new System.Drawing.Size(786, 340);
            this.tb_checkIn.TabIndex = 2;
            this.tb_checkIn.Text = "CHECK IN";
            this.tb_checkIn.UseVisualStyleBackColor = true;
            // 
            // tb_checkOut
            // 
            this.tb_checkOut.ImageKey = "icons8-hotel-chekc-fora-32.png";
            this.tb_checkOut.Location = new System.Drawing.Point(4, 39);
            this.tb_checkOut.Name = "tb_checkOut";
            this.tb_checkOut.Size = new System.Drawing.Size(786, 340);
            this.tb_checkOut.TabIndex = 3;
            this.tb_checkOut.Text = "CHECK OUT";
            this.tb_checkOut.UseVisualStyleBackColor = true;
            // 
            // tb_gerirQuartos
            // 
            this.tb_gerirQuartos.ImageKey = "icons8-quarto-32.png";
            this.tb_gerirQuartos.Location = new System.Drawing.Point(4, 39);
            this.tb_gerirQuartos.Name = "tb_gerirQuartos";
            this.tb_gerirQuartos.Size = new System.Drawing.Size(786, 340);
            this.tb_gerirQuartos.TabIndex = 4;
            this.tb_gerirQuartos.Text = "GERIR QUARTOS";
            this.tb_gerirQuartos.UseVisualStyleBackColor = true;
            // 
            // tb_funcionarios
            // 
            this.tb_funcionarios.ImageKey = "icons8-contrato-de-trabalho-32.png";
            this.tb_funcionarios.Location = new System.Drawing.Point(4, 39);
            this.tb_funcionarios.Name = "tb_funcionarios";
            this.tb_funcionarios.Size = new System.Drawing.Size(786, 340);
            this.tb_funcionarios.TabIndex = 5;
            this.tb_funcionarios.Text = "FUNCIONARIOS";
            this.tb_funcionarios.UseVisualStyleBackColor = true;
            // 
            // tb_diretoria
            // 
            this.tb_diretoria.ImageKey = "icons8-gerente-32.png";
            this.tb_diretoria.Location = new System.Drawing.Point(4, 39);
            this.tb_diretoria.Name = "tb_diretoria";
            this.tb_diretoria.Size = new System.Drawing.Size(786, 340);
            this.tb_diretoria.TabIndex = 6;
            this.tb_diretoria.Text = "DIRETORIA";
            this.tb_diretoria.UseVisualStyleBackColor = true;
            // 
            // tb_configuracoes
            // 
            this.tb_configuracoes.ImageKey = "icons8-config-32.png";
            this.tb_configuracoes.Location = new System.Drawing.Point(4, 74);
            this.tb_configuracoes.Name = "tb_configuracoes";
            this.tb_configuracoes.Size = new System.Drawing.Size(786, 305);
            this.tb_configuracoes.TabIndex = 7;
            this.tb_configuracoes.Text = "CONFIGURAÇÕES";
            this.tb_configuracoes.UseVisualStyleBackColor = true;
            // 
            // sw_darkMode
            // 
            this.sw_darkMode.BackColor = System.Drawing.Color.Transparent;
            this.sw_darkMode.Depth = 0;
            this.sw_darkMode.Location = new System.Drawing.Point(871, 24);
            this.sw_darkMode.Margin = new System.Windows.Forms.Padding(0);
            this.sw_darkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sw_darkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.sw_darkMode.Name = "sw_darkMode";
            this.sw_darkMode.Ripple = true;
            this.sw_darkMode.Size = new System.Drawing.Size(52, 37);
            this.sw_darkMode.TabIndex = 1;
            this.sw_darkMode.UseVisualStyleBackColor = false;
            this.sw_darkMode.CheckedChanged += new System.EventHandler(this.sw_darkMode_CheckedChanged);
            // 
            // F_telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 622);
            this.Controls.Add(this.sw_darkMode);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "F_telaInicial";
            this.Text = "The Bug Inn";
            this.Load += new System.EventHandler(this.F_telaInicial_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tb_home;
        private System.Windows.Forms.TabPage tb_reservas;
        private System.Windows.Forms.ImageList iconesMenu;
        private System.Windows.Forms.TabPage tb_checkIn;
        private System.Windows.Forms.TabPage tb_checkOut;
        private System.Windows.Forms.TabPage tb_gerirQuartos;
        private System.Windows.Forms.TabPage tb_funcionarios;
        private System.Windows.Forms.TabPage tb_diretoria;
        private System.Windows.Forms.TabPage tb_configuracoes;
        private MaterialSkin.Controls.MaterialSwitch sw_darkMode;
    }
}