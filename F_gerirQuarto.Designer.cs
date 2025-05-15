namespace appBugInn
{
    partial class F_gerirQuarto
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_nomeReserva1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_emailReserva1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialLabel1.Location = new System.Drawing.Point(43, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(197, 29);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Número do quarto";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialTextBox2);
            this.materialCard1.Controls.Add(this.materialTextBox3);
            this.materialCard1.Controls.Add(this.txt_nomeReserva1);
            this.materialCard1.Controls.Add(this.txt_emailReserva1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 151);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(596, 250);
            this.materialCard1.TabIndex = 39;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Quarto";
            this.materialTextBox1.LeadingIcon = global::appBugInn.Properties.Resources.png_transparent_computer_icons_icon_design_bed_bed_room_text_rectangle_computer3;
            this.materialTextBox1.Location = new System.Drawing.Point(249, 84);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(104, 50);
            this.materialTextBox1.TabIndex = 33;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseAccent = false;
            // 
            // txt_nomeReserva1
            // 
            this.txt_nomeReserva1.AnimateReadOnly = false;
            this.txt_nomeReserva1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nomeReserva1.Depth = 0;
            this.txt_nomeReserva1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_nomeReserva1.Hint = "Tipo de quarto";
            this.txt_nomeReserva1.LeadingIcon = global::appBugInn.Properties.Resources.Personnome;
            this.txt_nomeReserva1.Location = new System.Drawing.Point(17, 17);
            this.txt_nomeReserva1.MaxLength = 50;
            this.txt_nomeReserva1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_nomeReserva1.Multiline = false;
            this.txt_nomeReserva1.Name = "txt_nomeReserva1";
            this.txt_nomeReserva1.Size = new System.Drawing.Size(562, 50);
            this.txt_nomeReserva1.TabIndex = 30;
            this.txt_nomeReserva1.Text = "";
            this.txt_nomeReserva1.TrailingIcon = null;
            this.txt_nomeReserva1.UseAccent = false;
            // 
            // txt_emailReserva1
            // 
            this.txt_emailReserva1.AnimateReadOnly = false;
            this.txt_emailReserva1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_emailReserva1.Depth = 0;
            this.txt_emailReserva1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_emailReserva1.Hint = "Status";
            this.txt_emailReserva1.LeadingIcon = global::appBugInn.Properties.Resources.email;
            this.txt_emailReserva1.Location = new System.Drawing.Point(17, 73);
            this.txt_emailReserva1.MaxLength = 50;
            this.txt_emailReserva1.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_emailReserva1.Multiline = false;
            this.txt_emailReserva1.Name = "txt_emailReserva1";
            this.txt_emailReserva1.Size = new System.Drawing.Size(562, 50);
            this.txt_emailReserva1.TabIndex = 32;
            this.txt_emailReserva1.Text = "";
            this.txt_emailReserva1.TrailingIcon = null;
            this.txt_emailReserva1.UseAccent = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.Hint = "Preço";
            this.materialTextBox2.LeadingIcon = global::appBugInn.Properties.Resources.Personnome;
            this.materialTextBox2.Location = new System.Drawing.Point(17, 129);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(562, 50);
            this.materialTextBox2.TabIndex = 33;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.UseAccent = false;
            this.materialTextBox2.TextChanged += new System.EventHandler(this.materialTextBox2_TextChanged);
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Email";
            this.materialTextBox3.LeadingIcon = global::appBugInn.Properties.Resources.email;
            this.materialTextBox3.Location = new System.Drawing.Point(17, 185);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(562, 50);
            this.materialTextBox3.TabIndex = 34;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            this.materialTextBox3.UseAccent = false;
            // 
            // F_gerirQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 630);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "F_gerirQuarto";
            this.Text = "Gerir Quartos";
            this.Load += new System.EventHandler(this.F_gerirQuarto_Load);
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txt_nomeReserva1;
        private MaterialSkin.Controls.MaterialTextBox txt_emailReserva1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
    }
}