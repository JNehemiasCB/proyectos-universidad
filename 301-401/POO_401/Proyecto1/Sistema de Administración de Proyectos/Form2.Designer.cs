namespace Sistema_de_Administración_de_Proyectos
{
    partial class FrmTareas
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
            this.lblProyecto = new System.Windows.Forms.Label();
            this.txtTituloTarea = new System.Windows.Forms.TextBox();
            this.dtpFechaInicioTarea = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinTarea = new System.Windows.Forms.DateTimePicker();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbAsignadoA = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblAsignado = new System.Windows.Forms.Label();
            this.btnAbrirFormulario = new System.Windows.Forms.Button();
            this.lblDescripcionProyecto = new System.Windows.Forms.Label();
            this.txtDescripcionTarea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(316, 20);
            this.lblProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(182, 25);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "Proyecto Asociado:";
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.Location = new System.Drawing.Point(517, 20);
            this.txtTituloTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(252, 22);
            this.txtTituloTarea.TabIndex = 2;
            // 
            // dtpFechaInicioTarea
            // 
            this.dtpFechaInicioTarea.Location = new System.Drawing.Point(985, 119);
            this.dtpFechaInicioTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicioTarea.Name = "dtpFechaInicioTarea";
            this.dtpFechaInicioTarea.Size = new System.Drawing.Size(275, 22);
            this.dtpFechaInicioTarea.TabIndex = 3;
            // 
            // dtpFechaFinTarea
            // 
            this.dtpFechaFinTarea.Location = new System.Drawing.Point(985, 70);
            this.dtpFechaFinTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFinTarea.Name = "dtpFechaFinTarea";
            this.dtpFechaFinTarea.Size = new System.Drawing.Size(275, 22);
            this.dtpFechaFinTarea.TabIndex = 4;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cmbPrioridad.Location = new System.Drawing.Point(583, 119);
            this.cmbPrioridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(252, 24);
            this.cmbPrioridad.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pendiente",
            "En Progreso",
            "Completada",
            "Bloqueada"});
            this.cmbEstado.Location = new System.Drawing.Point(985, 18);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(275, 24);
            this.cmbEstado.TabIndex = 6;
            // 
            // cmbAsignadoA
            // 
            this.cmbAsignadoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignadoA.Location = new System.Drawing.Point(480, 62);
            this.cmbAsignadoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAsignadoA.Name = "cmbAsignadoA";
            this.cmbAsignadoA.Size = new System.Drawing.Size(289, 24);
            this.cmbAsignadoA.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 15);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 28);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(121, 15);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(68, 28);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(227, 15);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 28);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(16, 203);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.Size = new System.Drawing.Size(730, 373);
            this.dgvTareas.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(781, 20);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(190, 25);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado del proyecto:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(819, 66);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(149, 25);
            this.lblFechaInicio.TabIndex = 14;
            this.lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(851, 119);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(113, 25);
            this.lblFechaFin.TabIndex = 15;
            this.lblFechaFin.Text = "Fecha final:";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(467, 121);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(95, 25);
            this.lblPrioridad.TabIndex = 1;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // lblAsignado
            // 
            this.lblAsignado.AutoSize = true;
            this.lblAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignado.Location = new System.Drawing.Point(345, 63);
            this.lblAsignado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignado.Name = "lblAsignado";
            this.lblAsignado.Size = new System.Drawing.Size(120, 25);
            this.lblAsignado.TabIndex = 1;
            this.lblAsignado.Text = "Asignado A:";
            // 
            // btnAbrirFormulario
            // 
            this.btnAbrirFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFormulario.Location = new System.Drawing.Point(12, 52);
            this.btnAbrirFormulario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirFormulario.Name = "btnAbrirFormulario";
            this.btnAbrirFormulario.Size = new System.Drawing.Size(287, 43);
            this.btnAbrirFormulario.TabIndex = 16;
            this.btnAbrirFormulario.Text = "Formulario: Gestión de proyectos";
            this.btnAbrirFormulario.UseVisualStyleBackColor = true;
            this.btnAbrirFormulario.Click += new System.EventHandler(this.btnAbrirFormulario_Click);
            // 
            // lblDescripcionProyecto
            // 
            this.lblDescripcionProyecto.AutoSize = true;
            this.lblDescripcionProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionProyecto.Location = new System.Drawing.Point(11, 139);
            this.lblDescripcionProyecto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionProyecto.Name = "lblDescripcionProyecto";
            this.lblDescripcionProyecto.Size = new System.Drawing.Size(231, 25);
            this.lblDescripcionProyecto.TabIndex = 18;
            this.lblDescripcionProyecto.Text = "Descripción del proyecto:";
            // 
            // txtDescripcionTarea
            // 
            this.txtDescripcionTarea.Location = new System.Drawing.Point(267, 102);
            this.txtDescripcionTarea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionTarea.Multiline = true;
            this.txtDescripcionTarea.Name = "txtDescripcionTarea";
            this.txtDescripcionTarea.Size = new System.Drawing.Size(191, 93);
            this.txtDescripcionTarea.TabIndex = 17;
            // 
            // FrmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 646);
            this.Controls.Add(this.lblDescripcionProyecto);
            this.Controls.Add(this.txtDescripcionTarea);
            this.Controls.Add(this.btnAbrirFormulario);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblAsignado);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.txtTituloTarea);
            this.Controls.Add(this.dtpFechaInicioTarea);
            this.Controls.Add(this.dtpFechaFinTarea);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbAsignadoA);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvTareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas del Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaFinTarea;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbAsignadoA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblAsignado;
        private System.Windows.Forms.Button btnAbrirFormulario;
        private System.Windows.Forms.Label lblDescripcionProyecto;
        private System.Windows.Forms.TextBox txtDescripcionTarea;
    }
}