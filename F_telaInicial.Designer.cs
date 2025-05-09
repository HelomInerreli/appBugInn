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
            this.tb_reservas = new System.Windows.Forms.TabPage();
            this.tb_checkIn = new System.Windows.Forms.TabPage();
            this.tb_checkOut = new System.Windows.Forms.TabPage();
            this.tb_gerirQuartos = new System.Windows.Forms.TabPage();
            this.tb_funcionarios = new System.Windows.Forms.TabPage();
            this.tb_diretoria = new System.Windows.Forms.TabPage();
            this.tb_configuracoes = new System.Windows.Forms.TabPage();
            this.sw_darkMode = new MaterialSkin.Controls.MaterialSwitch();
            this.iconesMenu = new System.Windows.Forms.ImageList(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.tb_home = new System.Windows.Forms.TabPage();
            this.materialFloatingActionButton3 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialTabControl1.SuspendLayout();
            this.tb_diretoria.SuspendLayout();
            this.tb_configuracoes.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(995, 604);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tb_reservas
            // 
            this.tb_reservas.ImageKey = "icons8-livro-32.png";
            this.tb_reservas.Location = new System.Drawing.Point(4, 39);
            this.tb_reservas.Name = "tb_reservas";
            this.tb_reservas.Padding = new System.Windows.Forms.Padding(3);
            this.tb_reservas.Size = new System.Drawing.Size(961, 512);
            this.tb_reservas.TabIndex = 1;
            this.tb_reservas.Text = "RESERVAS";
            this.tb_reservas.UseVisualStyleBackColor = true;
            // 
            // tb_checkIn
            // 
            this.tb_checkIn.ImageKey = "icons8-check-in-hotel-32.png";
            this.tb_checkIn.Location = new System.Drawing.Point(4, 39);
            this.tb_checkIn.Name = "tb_checkIn";
            this.tb_checkIn.Size = new System.Drawing.Size(961, 512);
            this.tb_checkIn.TabIndex = 2;
            this.tb_checkIn.Text = "CHECK IN";
            this.tb_checkIn.UseVisualStyleBackColor = true;
            // 
            // tb_checkOut
            // 
            this.tb_checkOut.ImageKey = "icons8-hotel-chekc-fora-32.png";
            this.tb_checkOut.Location = new System.Drawing.Point(4, 39);
            this.tb_checkOut.Name = "tb_checkOut";
            this.tb_checkOut.Size = new System.Drawing.Size(961, 512);
            this.tb_checkOut.TabIndex = 3;
            this.tb_checkOut.Text = "CHECK OUT";
            this.tb_checkOut.UseVisualStyleBackColor = true;
            // 
            // tb_gerirQuartos
            // 
            this.tb_gerirQuartos.ImageKey = "icons8-quarto-32.png";
            this.tb_gerirQuartos.Location = new System.Drawing.Point(4, 39);
            this.tb_gerirQuartos.Name = "tb_gerirQuartos";
            this.tb_gerirQuartos.Size = new System.Drawing.Size(961, 512);
            this.tb_gerirQuartos.TabIndex = 4;
            this.tb_gerirQuartos.Text = "GERIR QUARTOS";
            this.tb_gerirQuartos.UseVisualStyleBackColor = true;
            // 
            // tb_funcionarios
            // 
            this.tb_funcionarios.ImageKey = "icons8-contrato-de-trabalho-32.png";
            this.tb_funcionarios.Location = new System.Drawing.Point(4, 39);
            this.tb_funcionarios.Name = "tb_funcionarios";
            this.tb_funcionarios.Size = new System.Drawing.Size(961, 512);
            this.tb_funcionarios.TabIndex = 5;
            this.tb_funcionarios.Text = "FUNCIONARIOS";
            this.tb_funcionarios.UseVisualStyleBackColor = true;
            // 
            // tb_diretoria
            // 
            this.tb_diretoria.Controls.Add(this.materialCard4);
            this.tb_diretoria.Controls.Add(this.materialFloatingActionButton3);
            this.tb_diretoria.Controls.Add(this.materialFloatingActionButton2);
            this.tb_diretoria.Controls.Add(this.materialCard3);
            this.tb_diretoria.Controls.Add(this.materialCard2);
            this.tb_diretoria.Controls.Add(this.materialFloatingActionButton1);
            this.tb_diretoria.Controls.Add(this.materialCard1);
            this.tb_diretoria.ImageKey = "icons8-dashboard-32.png";
            this.tb_diretoria.Location = new System.Drawing.Point(4, 39);
            this.tb_diretoria.Name = "tb_diretoria";
            this.tb_diretoria.Size = new System.Drawing.Size(987, 561);
            this.tb_diretoria.TabIndex = 6;
            this.tb_diretoria.Text = "DASHBOARD";
            this.tb_diretoria.UseVisualStyleBackColor = true;
            // 
            // tb_configuracoes
            // 
            this.tb_configuracoes.Controls.Add(this.sw_darkMode);
            this.tb_configuracoes.ImageKey = "icons8-config-32.png";
            this.tb_configuracoes.Location = new System.Drawing.Point(4, 39);
            this.tb_configuracoes.Name = "tb_configuracoes";
            this.tb_configuracoes.Size = new System.Drawing.Size(961, 512);
            this.tb_configuracoes.TabIndex = 7;
            this.tb_configuracoes.Text = "CONFIGURAÇÕES";
            this.tb_configuracoes.UseVisualStyleBackColor = true;
            // 
            // sw_darkMode
            // 
            this.sw_darkMode.BackColor = System.Drawing.Color.Transparent;
            this.sw_darkMode.Depth = 0;
            this.sw_darkMode.Location = new System.Drawing.Point(36, 33);
            this.sw_darkMode.Margin = new System.Windows.Forms.Padding(0);
            this.sw_darkMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sw_darkMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.sw_darkMode.Name = "sw_darkMode";
            this.sw_darkMode.Ripple = true;
            this.sw_darkMode.Size = new System.Drawing.Size(202, 44);
            this.sw_darkMode.TabIndex = 1;
            this.sw_darkMode.Text = "Modo Escuro";
            this.sw_darkMode.UseVisualStyleBackColor = false;
            this.sw_darkMode.CheckedChanged += new System.EventHandler(this.sw_darkMode_CheckedChanged);
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
            this.iconesMenu.Images.SetKeyName(8, "icons8-home-32.png");
            this.iconesMenu.Images.SetKeyName(9, "icons8-dashboard-32.png");
            this.iconesMenu.Images.SetKeyName(10, "icons8-profit-48.png");
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialProgressBar1);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(30, 31);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(231, 100);
            this.materialCard1.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(341, 31);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(231, 100);
            this.materialCard2.TabIndex = 2;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(672, 31);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(231, 100);
            this.materialCard3.TabIndex = 4;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(30, 159);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(900, 319);
            this.materialCard4.TabIndex = 6;
            // 
            // tb_home
            // 
            this.tb_home.BackgroundImage = global::appBugInn.Properties.Resources.tbi_sem_fundo;
            this.tb_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tb_home.ImageKey = "icons8-home-32.png";
            this.tb_home.Location = new System.Drawing.Point(4, 39);
            this.tb_home.Name = "tb_home";
            this.tb_home.Padding = new System.Windows.Forms.Padding(3);
            this.tb_home.Size = new System.Drawing.Size(961, 512);
            this.tb_home.TabIndex = 0;
            this.tb_home.Text = "HOME";
            this.tb_home.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton3
            // 
            this.materialFloatingActionButton3.Depth = 0;
            this.materialFloatingActionButton3.Icon = global::appBugInn.Properties.Resources.icons8_satisfaction_48;
            this.materialFloatingActionButton3.ImageList = this.iconesMenu;
            this.materialFloatingActionButton3.Location = new System.Drawing.Point(874, 53);
            this.materialFloatingActionButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton3.Name = "materialFloatingActionButton3";
            this.materialFloatingActionButton3.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton3.TabIndex = 5;
            this.materialFloatingActionButton3.TabStop = false;
            this.materialFloatingActionButton3.UseVisualStyleBackColor = false;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = global::appBugInn.Properties.Resources.icons8_profit_48;
            this.materialFloatingActionButton2.ImageList = this.iconesMenu;
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(543, 53);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 3;
            this.materialFloatingActionButton2.TabStop = false;
            this.materialFloatingActionButton2.UseVisualStyleBackColor = false;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = global::appBugInn.Properties.Resources.icons8_profit_48;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(232, 53);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 1;
            this.materialFloatingActionButton1.TabStop = false;
            this.materialFloatingActionButton1.UseVisualStyleBackColor = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Entradas Ano";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(7, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Nível Satisfação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entradas Mensal";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(49, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "7.845,12 €";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "45% da arrecadação prevista";
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(22, 68);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(173, 5);
            this.materialProgressBar1.TabIndex = 3;
            this.materialProgressBar1.Value = 45;
            // 
            // F_telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 671);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_telaInicial";
            this.Text = "The Bug Inn";
            this.Load += new System.EventHandler(this.F_telaInicial_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tb_diretoria.ResumeLayout(false);
            this.tb_configuracoes.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
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
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
    }
}