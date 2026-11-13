namespace AdministracionDeProyectos
{
    partial class frmProyectos
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
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionProyecto = new System.Windows.Forms.TextBox();
            this.dtpFechaInicioProyecto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFinProyecto = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoProyecto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardarProyecto = new System.Windows.Forms.Button();
            this.btnNuevoProyecto = new System.Windows.Forms.Button();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.dgvListaProyectos = new System.Windows.Forms.DataGridView();
            this.btnSeguimientoProgreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(169, 6);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(149, 22);
            this.txtNombreProyecto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre del proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "descripcion del proyecto";
            // 
            // txtDescripcionProyecto
            // 
            this.txtDescripcionProyecto.Location = new System.Drawing.Point(169, 34);
            this.txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            this.txtDescripcionProyecto.Size = new System.Drawing.Size(149, 22);
            this.txtDescripcionProyecto.TabIndex = 2;
            // 
            // dtpFechaInicioProyecto
            // 
            this.dtpFechaInicioProyecto.Location = new System.Drawing.Point(449, 25);
            this.dtpFechaInicioProyecto.Name = "dtpFechaInicioProyecto";
            this.dtpFechaInicioProyecto.Size = new System.Drawing.Size(274, 22);
            this.dtpFechaInicioProyecto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "fecha de inicio del proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "fecha de fin del proyecto";
            // 
            // dtpFechaFinProyecto
            // 
            this.dtpFechaFinProyecto.Location = new System.Drawing.Point(449, 85);
            this.dtpFechaFinProyecto.Name = "dtpFechaFinProyecto";
            this.dtpFechaFinProyecto.Size = new System.Drawing.Size(274, 22);
            this.dtpFechaFinProyecto.TabIndex = 6;
            // 
            // cmbEstadoProyecto
            // 
            this.cmbEstadoProyecto.FormattingEnabled = true;
            this.cmbEstadoProyecto.Location = new System.Drawing.Point(169, 66);
            this.cmbEstadoProyecto.Name = "cmbEstadoProyecto";
            this.cmbEstadoProyecto.Size = new System.Drawing.Size(163, 24);
            this.cmbEstadoProyecto.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "estado del proyecto";
            // 
            // btnGuardarProyecto
            // 
            this.btnGuardarProyecto.Location = new System.Drawing.Point(16, 468);
            this.btnGuardarProyecto.Name = "btnGuardarProyecto";
            this.btnGuardarProyecto.Size = new System.Drawing.Size(137, 40);
            this.btnGuardarProyecto.TabIndex = 10;
            this.btnGuardarProyecto.Text = "guardar proyecto";
            this.btnGuardarProyecto.UseVisualStyleBackColor = true;
            // 
            // btnNuevoProyecto
            // 
            this.btnNuevoProyecto.Location = new System.Drawing.Point(359, 468);
            this.btnNuevoProyecto.Name = "btnNuevoProyecto";
            this.btnNuevoProyecto.Size = new System.Drawing.Size(137, 40);
            this.btnNuevoProyecto.TabIndex = 11;
            this.btnNuevoProyecto.Text = "nuevo proyecto";
            this.btnNuevoProyecto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.Location = new System.Drawing.Point(186, 468);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(137, 40);
            this.btnEliminarProyecto.TabIndex = 12;
            this.btnEliminarProyecto.Text = "eliminar proyecto";
            this.btnEliminarProyecto.UseVisualStyleBackColor = true;
            // 
            // dgvListaProyectos
            // 
            this.dgvListaProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProyectos.Location = new System.Drawing.Point(16, 139);
            this.dgvListaProyectos.Name = "dgvListaProyectos";
            this.dgvListaProyectos.RowHeadersWidth = 51;
            this.dgvListaProyectos.RowTemplate.Height = 24;
            this.dgvListaProyectos.Size = new System.Drawing.Size(480, 323);
            this.dgvListaProyectos.TabIndex = 13;
            // 
            // btnSeguimientoProgreso
            // 
            this.btnSeguimientoProgreso.Location = new System.Drawing.Point(587, 227);
            this.btnSeguimientoProgreso.Name = "btnSeguimientoProgreso";
            this.btnSeguimientoProgreso.Size = new System.Drawing.Size(136, 76);
            this.btnSeguimientoProgreso.TabIndex = 14;
            this.btnSeguimientoProgreso.Text = "seguimiento del progreso";
            this.btnSeguimientoProgreso.UseVisualStyleBackColor = true;
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 576);
            this.Controls.Add(this.btnSeguimientoProgreso);
            this.Controls.Add(this.dgvListaProyectos);
            this.Controls.Add(this.btnEliminarProyecto);
            this.Controls.Add(this.btnNuevoProyecto);
            this.Controls.Add(this.btnGuardarProyecto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEstadoProyecto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaFinProyecto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInicioProyecto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcionProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProyecto);
            this.Name = "frmProyectos";
            this.Text = "frmProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionProyecto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioProyecto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFinProyecto;
        private System.Windows.Forms.ComboBox cmbEstadoProyecto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardarProyecto;
        private System.Windows.Forms.Button btnNuevoProyecto;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.DataGridView dgvListaProyectos;
        private System.Windows.Forms.Button btnSeguimientoProgreso;
    }
}

