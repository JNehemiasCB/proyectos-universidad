namespace WFVisorDeImagenes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostrarImagen = new System.Windows.Forms.Button();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 401);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(3, 410);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Ajustar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMostrarImagen);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrarImagen);
            this.flowLayoutPanel1.Controls.Add(this.btnColorFondo);
            this.flowLayoutPanel1.Controls.Add(this.btnCerrar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(111, 410);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(608, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnMostrarImagen
            // 
            this.btnMostrarImagen.AutoSize = true;
            this.btnMostrarImagen.Location = new System.Drawing.Point(449, 3);
            this.btnMostrarImagen.Name = "btnMostrarImagen";
            this.btnMostrarImagen.Size = new System.Drawing.Size(156, 34);
            this.btnMostrarImagen.TabIndex = 0;
            this.btnMostrarImagen.Text = "Mostrar una imagen";
            this.btnMostrarImagen.UseVisualStyleBackColor = true;
            this.btnMostrarImagen.Click += new System.EventHandler(this.btnMostrarImagen_Click);
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.AutoSize = true;
            this.btnBorrarImagen.Location = new System.Drawing.Point(287, 3);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(156, 34);
            this.btnBorrarImagen.TabIndex = 1;
            this.btnBorrarImagen.Text = "Borrar la imagen";
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.AutoSize = true;
            this.btnColorFondo.Location = new System.Drawing.Point(87, 3);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.Size = new System.Drawing.Size(194, 34);
            this.btnColorFondo.TabIndex = 2;
            this.btnColorFondo.Text = "Establecer el color de fondo";
            this.btnColorFondo.UseVisualStyleBackColor = true;
            this.btnColorFondo.Click += new System.EventHandler(this.btnColorFondo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.Location = new System.Drawing.Point(6, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 34);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.*)|*.*";
            this.openFileDialog1.Title = "Seleciona un archivo de imagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Visor de imágenes";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMostrarImagen;
        private System.Windows.Forms.Button btnBorrarImagen;
        private System.Windows.Forms.Button btnColorFondo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

