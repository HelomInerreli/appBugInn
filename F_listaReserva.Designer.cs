namespace appBugInn
{
    partial class F_listaReserva
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
            this.mtv_dadosReserva = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // mtv_dadosReserva
            // 
            this.mtv_dadosReserva.AutoSizeTable = false;
            this.mtv_dadosReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtv_dadosReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtv_dadosReserva.Depth = 0;
            this.mtv_dadosReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtv_dadosReserva.FullRowSelect = true;
            this.mtv_dadosReserva.HideSelection = false;
            this.mtv_dadosReserva.Location = new System.Drawing.Point(3, 64);
            this.mtv_dadosReserva.MinimumSize = new System.Drawing.Size(200, 100);
            this.mtv_dadosReserva.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mtv_dadosReserva.MouseState = MaterialSkin.MouseState.OUT;
            this.mtv_dadosReserva.Name = "mtv_dadosReserva";
            this.mtv_dadosReserva.OwnerDraw = true;
            this.mtv_dadosReserva.Size = new System.Drawing.Size(1006, 627);
            this.mtv_dadosReserva.TabIndex = 0;
            this.mtv_dadosReserva.UseCompatibleStateImageBehavior = false;
            this.mtv_dadosReserva.View = System.Windows.Forms.View.Details;
            this.mtv_dadosReserva.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            this.mtv_dadosReserva.DoubleClick += new System.EventHandler(this.mtv_dadosReserva_MouseDC);
            this.mtv_dadosReserva.Enter += new System.EventHandler(this.f_listReservas_enter);
            // 
            // F_listaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 694);
            this.Controls.Add(this.mtv_dadosReserva);
            this.Name = "F_listaReserva";
            this.Text = "listaReserva";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView mtv_dadosReserva;
    }
}