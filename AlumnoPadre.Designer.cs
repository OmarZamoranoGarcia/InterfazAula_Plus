namespace InterfazAula_
{
    partial class AlumnoPadre
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
            this.buttonMessageAlumnoPadre = new System.Windows.Forms.Button();
            this.buttonCalificacionAlumnoPadre = new System.Windows.Forms.Button();
            this.buttonListaAlumnoPadre = new System.Windows.Forms.Button();
            this.panelInterno1A = new System.Windows.Forms.Panel();
            this.dataGridViewAlumnoPadre = new System.Windows.Forms.DataGridView();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.panelInterno1A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoPadre)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMessageAlumnoPadre
            // 
            this.buttonMessageAlumnoPadre.BackColor = System.Drawing.Color.Black;
            this.buttonMessageAlumnoPadre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMessageAlumnoPadre.ForeColor = System.Drawing.Color.White;
            this.buttonMessageAlumnoPadre.Location = new System.Drawing.Point(12, 300);
            this.buttonMessageAlumnoPadre.Name = "buttonMessageAlumnoPadre";
            this.buttonMessageAlumnoPadre.Size = new System.Drawing.Size(125, 57);
            this.buttonMessageAlumnoPadre.TabIndex = 63;
            this.buttonMessageAlumnoPadre.Text = "Mensajes";
            this.buttonMessageAlumnoPadre.UseVisualStyleBackColor = false;
            this.buttonMessageAlumnoPadre.Click += new System.EventHandler(this.buttonMessageAlumnoPadre_Click);
            // 
            // buttonCalificacionAlumnoPadre
            // 
            this.buttonCalificacionAlumnoPadre.BackColor = System.Drawing.Color.Black;
            this.buttonCalificacionAlumnoPadre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalificacionAlumnoPadre.ForeColor = System.Drawing.Color.White;
            this.buttonCalificacionAlumnoPadre.Location = new System.Drawing.Point(12, 226);
            this.buttonCalificacionAlumnoPadre.Name = "buttonCalificacionAlumnoPadre";
            this.buttonCalificacionAlumnoPadre.Size = new System.Drawing.Size(125, 57);
            this.buttonCalificacionAlumnoPadre.TabIndex = 52;
            this.buttonCalificacionAlumnoPadre.Text = "Calificaciones";
            this.buttonCalificacionAlumnoPadre.UseVisualStyleBackColor = false;
            this.buttonCalificacionAlumnoPadre.Click += new System.EventHandler(this.buttonCalificacionAlumnoPadre_Click);
            // 
            // buttonListaAlumnoPadre
            // 
            this.buttonListaAlumnoPadre.BackColor = System.Drawing.Color.Black;
            this.buttonListaAlumnoPadre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListaAlumnoPadre.ForeColor = System.Drawing.Color.White;
            this.buttonListaAlumnoPadre.Location = new System.Drawing.Point(12, 151);
            this.buttonListaAlumnoPadre.Name = "buttonListaAlumnoPadre";
            this.buttonListaAlumnoPadre.Size = new System.Drawing.Size(125, 57);
            this.buttonListaAlumnoPadre.TabIndex = 49;
            this.buttonListaAlumnoPadre.Text = "Lista de Asistencia";
            this.buttonListaAlumnoPadre.UseVisualStyleBackColor = false;
            this.buttonListaAlumnoPadre.Click += new System.EventHandler(this.buttonListaAlumnoPadre_Click);
            // 
            // panelInterno1A
            // 
            this.panelInterno1A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelInterno1A.Controls.Add(this.dataGridViewAlumnoPadre);
            this.panelInterno1A.Location = new System.Drawing.Point(145, 12);
            this.panelInterno1A.Name = "panelInterno1A";
            this.panelInterno1A.Size = new System.Drawing.Size(1219, 505);
            this.panelInterno1A.TabIndex = 48;
            // 
            // dataGridViewAlumnoPadre
            // 
            this.dataGridViewAlumnoPadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnoPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAlumnoPadre.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAlumnoPadre.Name = "dataGridViewAlumnoPadre";
            this.dataGridViewAlumnoPadre.Size = new System.Drawing.Size(1219, 505);
            this.dataGridViewAlumnoPadre.TabIndex = 0;
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenido.Location = new System.Drawing.Point(12, 12);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(116, 92);
            this.labelBienvenido.TabIndex = 64;
            this.labelBienvenido.Text = "Bienvenido \r\n(nombre de \r\nla persona \r\nque ingreso)";
            this.labelBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlumnoPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 529);
            this.Controls.Add(this.labelBienvenido);
            this.Controls.Add(this.buttonMessageAlumnoPadre);
            this.Controls.Add(this.buttonCalificacionAlumnoPadre);
            this.Controls.Add(this.buttonListaAlumnoPadre);
            this.Controls.Add(this.panelInterno1A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlumnoPadre";
            this.Text = "AlumnoPadre";
            this.panelInterno1A.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnoPadre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonMessageAlumnoPadre;
        private System.Windows.Forms.Button buttonCalificacionAlumnoPadre;
        private System.Windows.Forms.Button buttonListaAlumnoPadre;
        private System.Windows.Forms.Panel panelInterno1A;
        private System.Windows.Forms.DataGridView dataGridViewAlumnoPadre;
        private System.Windows.Forms.Label labelBienvenido;
    }
}