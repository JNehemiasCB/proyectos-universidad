namespace AdministracionDeProyectos
{
    partial class frmTareas
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
            this.lblProyectoAsociado = new System.Windows.Forms.Label();
            this.txtTituloTarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFinTarea = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicioTarea = new System.Windows.Forms.DateTimePicker();
            this.cmbPrioridadTarea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstadoTarea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbmAsignadoA = new System.Windows.Forms.ComboBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.btnEditarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.dgvListaTarea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProyectoAsociado
            // 
            this.lblProyectoAsociado.AutoSize = true;
            this.lblProyectoAsociado.Location = new System.Drawing.Point(345, 9);
            this.lblProyectoAsociado.Name = "lblProyectoAsociado";
            this.lblProyectoAsociado.Size = new System.Drawing.Size(44, 16);
            this.lblProyectoAsociado.TabIndex = 0;
            this.lblProyectoAsociado.Text = "label1";
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.Location = new System.Drawing.Point(124, 39);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(157, 22);
            this.txtTituloTarea.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "titulo de la tarea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "fecha de fin de la tarea";
            // 
            // dtpFechaFinTarea
            // 
            this.dtpFechaFinTarea.Location = new System.Drawing.Point(486, 97);
            this.dtpFechaFinTarea.Name = "dtpFechaFinTarea";
            this.dtpFechaFinTarea.Size = new System.Drawing.Size(274, 22);
            this.dtpFechaFinTarea.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "fecha de inicio de la tarea";
            // 
            // dtpFechaInicioTarea
            // 
            this.dtpFechaInicioTarea.Location = new System.Drawing.Point(486, 37);
            this.dtpFechaInicioTarea.Name = "dtpFechaInicioTarea";
            this.dtpFechaInicioTarea.Size = new System.Drawing.Size(274, 22);
            this.dtpFechaInicioTarea.TabIndex = 8;
            // 
            // cmbPrioridadTarea
            // 
            this.cmbPrioridadTarea.FormattingEnabled = true;
            this.cmbPrioridadTarea.Location = new System.Drawing.Point(124, 70);
            this.cmbPrioridadTarea.Name = "cmbPrioridadTarea";
            this.cmbPrioridadTarea.Size = new System.Drawing.Size(157, 24);
            this.cmbPrioridadTarea.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "estado";
            // 
            // cmbEstadoTarea
            // 
            this.cmbEstadoTarea.FormattingEnabled = true;
            this.cmbEstadoTarea.Location = new System.Drawing.Point(124, 100);
            this.cmbEstadoTarea.Name = "cmbEstadoTarea";
            this.cmbEstadoTarea.Size = new System.Drawing.Size(157, 24);
            this.cmbEstadoTarea.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "asignado a:";
            // 
            // cbmAsignadoA
            // 
            this.cbmAsignadoA.FormattingEnabled = true;
            this.cbmAsignadoA.Location = new System.Drawing.Point(124, 130);
            this.cbmAsignadoA.Name = "cbmAsignadoA";
            this.cbmAsignadoA.Size = new System.Drawing.Size(157, 24);
            this.cbmAsignadoA.TabIndex = 16;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(421, 403);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(119, 35);
            this.btnAgregarTarea.TabIndex = 18;
            this.btnAgregarTarea.Text = "agregar tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.Location = new System.Drawing.Point(546, 403);
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.Size = new System.Drawing.Size(101, 35);
            this.btnEditarTarea.TabIndex = 19;
            this.btnEditarTarea.Text = "editar tarea";
            this.btnEditarTarea.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(653, 403);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(97, 35);
            this.btnEliminarTarea.TabIndex = 20;
            this.btnEliminarTarea.Text = "eliminar tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            // 
            // dgvListaTarea
            // 
            this.dgvListaTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTarea.Location = new System.Drawing.Point(15, 171);
            this.dgvListaTarea.Name = "dgvListaTarea";
            this.dgvListaTarea.RowHeadersWidth = 51;
            this.dgvListaTarea.RowTemplate.Height = 24;
            this.dgvListaTarea.Size = new System.Drawing.Size(357, 267);
            this.dgvListaTarea.TabIndex = 21;
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaTarea);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnEditarTarea);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbmAsignadoA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEstadoTarea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPrioridadTarea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaFinTarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInicioTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloTarea);
            this.Controls.Add(this.lblProyectoAsociado);
            this.Name = "frmTareas";
            this.Text = "frmTareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProyectoAsociado;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFinTarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioTarea;
        private System.Windows.Forms.ComboBox cmbPrioridadTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstadoTarea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbmAsignadoA;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnEditarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.DataGridView dgvListaTarea;
    }
}