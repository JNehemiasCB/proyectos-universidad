namespace VisorImagenes
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnColorFondo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CheckBox1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.03297F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.967033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 498);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 450);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCerrar);
            this.flowLayoutPanel1.Controls.Add(this.btnColorFondo);
            this.flowLayoutPanel1.Controls.Add(this.btnBorrar);
            this.flowLayoutPanel1.Controls.Add(this.btnMostrar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(124, 462);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(680, 32);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCerrar.Location = new System.Drawing.Point(3, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCerrar.Size = new System.Drawing.Size(84, 39);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnColorFondo
            // 
            this.btnColorFondo.AutoSize = true;
            this.btnColorFondo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnColorFondo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColorFondo.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorFondo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnColorFondo.Location = new System.Drawing.Point(93, 4);
            this.btnColorFondo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColorFondo.Name = "btnColorFondo";
            this.btnColorFondo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnColorFondo.Size = new System.Drawing.Size(242, 39);
            this.btnColorFondo.TabIndex = 2;
            this.btnColorFondo.Text = "Establecer color de fondo";
            this.btnColorFondo.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(341, 4);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrar.Size = new System.Drawing.Size(144, 36);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar imagen";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.AutoSize = true;
            this.btnMostrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(491, 4);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMostrar.Size = new System.Drawing.Size(154, 36);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar imagen";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // CheckBox1
            // 
            this.CheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CheckBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CheckBox1.Location = new System.Drawing.Point(3, 462);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(115, 32);
            this.CheckBox1.TabIndex = 1;
            this.CheckBox1.Text = "Ajustar";
            this.CheckBox1.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JPEG (*.jpg)|*.jpg|Archivos PNG (*.png)|*.png|Archivos BMP (*.bmp)|*.bmp" +
    "|Todos los Archivos(*.*)|*.*";
            this.openFileDialog1.Title = "Seleccionar un archivo de";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Visor de imágenes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnColorFondo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

