namespace InterfazAula_
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelGrupoActivo = new System.Windows.Forms.Label();
            this.panelGrupos = new System.Windows.Forms.Panel();
            this.buttonGrupo2B = new System.Windows.Forms.Button();
            this.buttonGrupo2A = new System.Windows.Forms.Button();
            this.buttonGrupo1B = new System.Windows.Forms.Button();
            this.buttonGrupo1A = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonGrupos = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.buttonMenuAdminSalir = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelGrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonMenuAdminSalir);
            this.panelMenu.Controls.Add(this.labelGrupoActivo);
            this.panelMenu.Controls.Add(this.panelGrupos);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.buttonGrupos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1428, 129);
            this.panelMenu.TabIndex = 1;
            // 
            // labelGrupoActivo
            // 
            this.labelGrupoActivo.AutoSize = true;
            this.labelGrupoActivo.BackColor = System.Drawing.Color.Transparent;
            this.labelGrupoActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupoActivo.ForeColor = System.Drawing.Color.White;
            this.labelGrupoActivo.Location = new System.Drawing.Point(438, 57);
            this.labelGrupoActivo.Name = "labelGrupoActivo";
            this.labelGrupoActivo.Size = new System.Drawing.Size(0, 20);
            this.labelGrupoActivo.TabIndex = 2;
            // 
            // panelGrupos
            // 
            this.panelGrupos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGrupos.BackgroundImage")));
            this.panelGrupos.Controls.Add(this.buttonGrupo2B);
            this.panelGrupos.Controls.Add(this.buttonGrupo2A);
            this.panelGrupos.Controls.Add(this.buttonGrupo1B);
            this.panelGrupos.Controls.Add(this.buttonGrupo1A);
            this.panelGrupos.Location = new System.Drawing.Point(499, -1);
            this.panelGrupos.Name = "panelGrupos";
            this.panelGrupos.Size = new System.Drawing.Size(219, 129);
            this.panelGrupos.TabIndex = 2;
            // 
            // buttonGrupo2B
            // 
            this.buttonGrupo2B.BackColor = System.Drawing.Color.Transparent;
            this.buttonGrupo2B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupo2B.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrupo2B.ForeColor = System.Drawing.Color.White;
            this.buttonGrupo2B.Location = new System.Drawing.Point(111, 66);
            this.buttonGrupo2B.Name = "buttonGrupo2B";
            this.buttonGrupo2B.Size = new System.Drawing.Size(105, 61);
            this.buttonGrupo2B.TabIndex = 5;
            this.buttonGrupo2B.Tag = "2B";
            this.buttonGrupo2B.Text = "2B";
            this.buttonGrupo2B.UseVisualStyleBackColor = false;
            this.buttonGrupo2B.Click += new System.EventHandler(this.buttonGrupo2B_Click);
            this.buttonGrupo2B.MouseEnter += new System.EventHandler(this.MouseEnterGrupo2B);
            this.buttonGrupo2B.MouseLeave += new System.EventHandler(this.MouseLeaveGrupo2B);
            // 
            // buttonGrupo2A
            // 
            this.buttonGrupo2A.BackColor = System.Drawing.Color.Transparent;
            this.buttonGrupo2A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupo2A.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrupo2A.ForeColor = System.Drawing.Color.White;
            this.buttonGrupo2A.Location = new System.Drawing.Point(111, 0);
            this.buttonGrupo2A.Name = "buttonGrupo2A";
            this.buttonGrupo2A.Size = new System.Drawing.Size(105, 61);
            this.buttonGrupo2A.TabIndex = 4;
            this.buttonGrupo2A.Tag = "2A";
            this.buttonGrupo2A.Text = "2A";
            this.buttonGrupo2A.UseVisualStyleBackColor = false;
            this.buttonGrupo2A.Click += new System.EventHandler(this.buttonGrupo2A_Click);
            this.buttonGrupo2A.MouseEnter += new System.EventHandler(this.MouseEnterGrupo2A);
            this.buttonGrupo2A.MouseLeave += new System.EventHandler(this.MouseLeaveGrupo2A);
            // 
            // buttonGrupo1B
            // 
            this.buttonGrupo1B.BackColor = System.Drawing.Color.Transparent;
            this.buttonGrupo1B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupo1B.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrupo1B.ForeColor = System.Drawing.Color.White;
            this.buttonGrupo1B.Location = new System.Drawing.Point(0, 66);
            this.buttonGrupo1B.Name = "buttonGrupo1B";
            this.buttonGrupo1B.Size = new System.Drawing.Size(105, 61);
            this.buttonGrupo1B.TabIndex = 3;
            this.buttonGrupo1B.Tag = "1B";
            this.buttonGrupo1B.Text = "1B";
            this.buttonGrupo1B.UseVisualStyleBackColor = false;
            this.buttonGrupo1B.Click += new System.EventHandler(this.buttonGrupo1B_Click);
            this.buttonGrupo1B.MouseEnter += new System.EventHandler(this.MouseEnterGrupo1B);
            this.buttonGrupo1B.MouseLeave += new System.EventHandler(this.MouseLeaveGrupo1B);
            // 
            // buttonGrupo1A
            // 
            this.buttonGrupo1A.BackColor = System.Drawing.Color.Transparent;
            this.buttonGrupo1A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupo1A.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrupo1A.ForeColor = System.Drawing.Color.White;
            this.buttonGrupo1A.Location = new System.Drawing.Point(0, 0);
            this.buttonGrupo1A.Name = "buttonGrupo1A";
            this.buttonGrupo1A.Size = new System.Drawing.Size(105, 61);
            this.buttonGrupo1A.TabIndex = 2;
            this.buttonGrupo1A.Tag = "1A";
            this.buttonGrupo1A.Text = "1A";
            this.buttonGrupo1A.UseVisualStyleBackColor = false;
            this.buttonGrupo1A.Click += new System.EventHandler(this.buttonGrupo1A_Click);
            this.buttonGrupo1A.MouseEnter += new System.EventHandler(this.MouseEnterGrupo1A);
            this.buttonGrupo1A.MouseLeave += new System.EventHandler(this.MouseLeaveGrupo1A);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.White;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(177, 114);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonGrupos
            // 
            this.buttonGrupos.BackColor = System.Drawing.Color.Transparent;
            this.buttonGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGrupos.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrupos.ForeColor = System.Drawing.Color.White;
            this.buttonGrupos.Location = new System.Drawing.Point(219, -1);
            this.buttonGrupos.Name = "buttonGrupos";
            this.buttonGrupos.Size = new System.Drawing.Size(202, 127);
            this.buttonGrupos.TabIndex = 0;
            this.buttonGrupos.Text = "Grupos";
            this.buttonGrupos.UseVisualStyleBackColor = false;
            this.buttonGrupos.Click += new System.EventHandler(this.buttonGrupos_Click);
            this.buttonGrupos.MouseEnter += new System.EventHandler(this.MouseEnterGrupos);
            this.buttonGrupos.MouseLeave += new System.EventHandler(this.MouseLeaveGrupos);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(25, 149);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1379, 529);
            this.panelContenedor.TabIndex = 3;
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.BackColor = System.Drawing.Color.Transparent;
            this.labelSaludo.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaludo.ForeColor = System.Drawing.Color.White;
            this.labelSaludo.Location = new System.Drawing.Point(265, 315);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(881, 125);
            this.labelSaludo.TabIndex = 4;
            this.labelSaludo.Text = "Welcome to Aula+";
            // 
            // buttonMenuAdminSalir
            // 
            this.buttonMenuAdminSalir.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenuAdminSalir.ForeColor = System.Drawing.Color.White;
            this.buttonMenuAdminSalir.Location = new System.Drawing.Point(1385, 6);
            this.buttonMenuAdminSalir.Name = "buttonMenuAdminSalir";
            this.buttonMenuAdminSalir.Size = new System.Drawing.Size(30, 30);
            this.buttonMenuAdminSalir.TabIndex = 3;
            this.buttonMenuAdminSalir.Text = "X";
            this.buttonMenuAdminSalir.UseVisualStyleBackColor = true;
            this.buttonMenuAdminSalir.Click += new System.EventHandler(this.buttonMenuAdminSalir_Click);
            this.buttonMenuAdminSalir.MouseEnter += new System.EventHandler(this.buttonMenuAdminSalir_MouseEnter);
            this.buttonMenuAdminSalir.MouseLeave += new System.EventHandler(this.buttonMenuAdminSalir_MouseLeave);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 702);
            this.Controls.Add(this.labelSaludo);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aula+";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGrupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonGrupos;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelGrupos;
        private System.Windows.Forms.Button buttonGrupo2B;
        private System.Windows.Forms.Button buttonGrupo2A;
        private System.Windows.Forms.Button buttonGrupo1B;
        private System.Windows.Forms.Button buttonGrupo1A;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label labelGrupoActivo;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.Button buttonMenuAdminSalir;
    }
}