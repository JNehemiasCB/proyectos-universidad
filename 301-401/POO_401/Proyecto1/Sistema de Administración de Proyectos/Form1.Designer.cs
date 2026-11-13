namespace Sistema_de_Administración_de_Proyectos
{
    partial class FrmProyectos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.txtDescripcionProyecto = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.pgbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblDescripcionProyecto = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAbrirFormulario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(336, 18);
            this.txtNombreProyecto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(237, 22);
            this.txtNombreProyecto.TabIndex = 1;
            // 
            // txtDescripcionProyecto
            // 
            this.txtDescripcionProyecto.Location = new System.Drawing.Point(372, 63);
            this.txtDescripcionProyecto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionProyecto.Multiline = true;
            this.txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            this.txtDescripcionProyecto.Size = new System.Drawing.Size(259, 63);
            this.txtDescripcionProyecto.TabIndex = 2;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(807, 59);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(271, 22);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(807, 100);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(271, 22);
            this.dtpFechaFin.TabIndex = 4;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Completado",
            "Pausado",
            "Cancelado"});
            this.cmbEstado.Location = new System.Drawing.Point(807, 17);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(271, 24);
            this.cmbEstado.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 59);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 98);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(9, 18);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 28);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(9, 144);
            this.dgvProyectos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.Size = new System.Drawing.Size(685, 322);
            this.dgvProyectos.TabIndex = 9;
            this.dgvProyectos.SelectionChanged += new System.EventHandler(this.dgvProyectos_SelectionChanged);
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.Location = new System.Drawing.Point(807, 414);
            this.pgbProgreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Size = new System.Drawing.Size(273, 39);
            this.pgbProgreso.TabIndex = 10;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgreso.Location = new System.Drawing.Point(702, 414);
            this.lblProgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(97, 25);
            this.lblProgreso.TabIndex = 11;
            this.lblProgreso.Text = "Progreso:";
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProyecto.Location = new System.Drawing.Point(121, 18);
            this.lblNombreProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(198, 25);
            this.lblNombreProyecto.TabIndex = 12;
            this.lblNombreProyecto.Text = "Nombre del proyecto:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(640, 60);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(149, 25);
            this.lblFechaInicio.TabIndex = 12;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(677, 100);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(113, 25);
            this.lblFechaFin.TabIndex = 12;
            this.lblFechaFin.Text = "Fecha final:";
            // 
            // lblDescripcionProyecto
            // 
            this.lblDescripcionProyecto.AutoSize = true;
            this.lblDescripcionProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProyecto.Location = new System.Drawing.Point(121, 79);
            this.lblDescripcionProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionProyecto.Name = "lblDescripcionProyecto";
            this.lblDescripcionProyecto.Size = new System.Drawing.Size(231, 25);
            this.lblDescripcionProyecto.TabIndex = 12;
            this.lblDescripcionProyecto.Text = "Descripción del proyecto:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(593, 18);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(190, 25);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado del proyecto:";
            // 
            // btnAbrirFormulario
            // 
            this.btnAbrirFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFormulario.Location = new System.Drawing.Point(878, 163);
            this.btnAbrirFormulario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirFormulario.Name = "btnAbrirFormulario";
            this.btnAbrirFormulario.Size = new System.Drawing.Size(202, 85);
            this.btnAbrirFormulario.TabIndex = 6;
            this.btnAbrirFormulario.Text = "Formulario: Tareas del proyecto";
            this.btnAbrirFormulario.UseVisualStyleBackColor = true;
            this.btnAbrirFormulario.Click += new System.EventHandler(this.btnAbrirFormulario_Click);
            // 
            // FrmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 490);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcionProyecto);
            this.Controls.Add(this.lblNombreProyecto);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.txtDescripcionProyecto);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnAbrirFormulario);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.pgbProgreso);
            this.Controls.Add(this.lblProgreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Proyectos";
            this.Load += new System.EventHandler(this.FrmProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.TextBox txtDescripcionProyecto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.ProgressBar pgbProgreso;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblDescripcionProyecto;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAbrirFormulario;
    }
}