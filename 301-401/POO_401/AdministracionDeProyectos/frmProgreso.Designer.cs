namespace AdministracionDeProyectos
{
    partial class frmProgreso
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
            this.pgbProgresoProyecto = new System.Windows.Forms.ProgressBar();
            this.lblPorcentajeCompletado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbProgresoProyecto
            // 
            this.pgbProgresoProyecto.Location = new System.Drawing.Point(26, 57);
            this.pgbProgresoProyecto.Name = "pgbProgresoProyecto";
            this.pgbProgresoProyecto.Size = new System.Drawing.Size(127, 23);
            this.pgbProgresoProyecto.TabIndex = 0;
            // 
            // lblPorcentajeCompletado
            // 
            this.lblPorcentajeCompletado.AutoSize = true;
            this.lblPorcentajeCompletado.Location = new System.Drawing.Point(67, 9);
            this.lblPorcentajeCompletado.Name = "lblPorcentajeCompletado";
            this.lblPorcentajeCompletado.Size = new System.Drawing.Size(44, 16);
            this.lblPorcentajeCompletado.TabIndex = 1;
            this.lblPorcentajeCompletado.Text = "label1";
            // 
            // frmProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 117);
            this.Controls.Add(this.lblPorcentajeCompletado);
            this.Controls.Add(this.pgbProgresoProyecto);
            this.Name = "frmProgreso";
            this.Text = "frmProgreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbProgresoProyecto;
        private System.Windows.Forms.Label lblPorcentajeCompletado;
    }
}