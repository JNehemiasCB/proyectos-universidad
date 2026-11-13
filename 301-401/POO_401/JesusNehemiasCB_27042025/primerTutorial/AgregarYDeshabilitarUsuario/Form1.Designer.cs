namespace AgregarYDeshabilitarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btDeshabilitarUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCrearUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(152, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(171, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // btDeshabilitarUsuario
            // 
            this.btDeshabilitarUsuario.Location = new System.Drawing.Point(353, 20);
            this.btDeshabilitarUsuario.Name = "btDeshabilitarUsuario";
            this.btDeshabilitarUsuario.Size = new System.Drawing.Size(147, 46);
            this.btDeshabilitarUsuario.TabIndex = 2;
            this.btDeshabilitarUsuario.Text = "Deshabilitar Usuario";
            this.btDeshabilitarUsuario.UseVisualStyleBackColor = true;
            this.btDeshabilitarUsuario.Click += new System.EventHandler(this.btDeshabilitarUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(152, 65);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(171, 22);
            this.txtContrasena.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 105);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupo de seguridad";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(152, 150);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(171, 22);
            this.txtGrupo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "<< El grupo de seguridad debe existir en el equipo";
            // 
            // btCrearUsuario
            // 
            this.btCrearUsuario.Location = new System.Drawing.Point(234, 239);
            this.btCrearUsuario.Name = "btCrearUsuario";
            this.btCrearUsuario.Size = new System.Drawing.Size(147, 46);
            this.btCrearUsuario.TabIndex = 10;
            this.btCrearUsuario.Text = "Crear Usuario";
            this.btCrearUsuario.UseVisualStyleBackColor = true;
            this.btCrearUsuario.Click += new System.EventHandler(this.btCrearUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 303);
            this.Controls.Add(this.btCrearUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDeshabilitarUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btDeshabilitarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCrearUsuario;
    }
}

