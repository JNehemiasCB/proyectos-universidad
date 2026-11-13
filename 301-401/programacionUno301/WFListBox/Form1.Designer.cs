namespace WFListBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstBoxNombres = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(35, 170);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 41);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "button1";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(330, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lstBoxNombres
            // 
            this.lstBoxNombres.FormattingEnabled = true;
            this.lstBoxNombres.ItemHeight = 16;
            this.lstBoxNombres.Location = new System.Drawing.Point(168, 98);
            this.lstBoxNombres.Name = "lstBoxNombres";
            this.lstBoxNombres.Size = new System.Drawing.Size(330, 212);
            this.lstBoxNombres.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(558, 370);
            this.Controls.Add(this.lstBoxNombres);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstBoxNombres;
    }
}

