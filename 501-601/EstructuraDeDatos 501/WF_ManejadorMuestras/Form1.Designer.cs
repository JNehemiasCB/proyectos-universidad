namespace WF_ManejadorMuestras
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.btnNuevaMuestra = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.labelMaximo = new System.Windows.Forms.Label();
            this.labelMinimo = new System.Windows.Forms.Label();
            this.labelLimite = new System.Windows.Forms.Label();
            this.labelTamano = new System.Windows.Forms.Label();
            this.groupBoxOrdenamiento = new System.Windows.Forms.GroupBox();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.txtTiempoBurbuja = new System.Windows.Forms.TextBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.txtTiempoSeleccion = new System.Windows.Forms.TextBox();
            this.btnInsercion = new System.Windows.Forms.Button();
            this.txtTiempoInsercion = new System.Windows.Forms.TextBox();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.labelValorBuscar = new System.Windows.Forms.Label();
            this.txtValorBuscar = new System.Windows.Forms.TextBox();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.txtTiempoSecuencial = new System.Windows.Forms.TextBox();
            this.btnBinaria = new System.Windows.Forms.Button();
            this.txtTiempoBinaria = new System.Windows.Forms.TextBox();
            this.groupBoxOtras = new System.Windows.Forms.GroupBox();
            this.labelInf = new System.Windows.Forms.Label();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.labelSup = new System.Windows.Forms.Label();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.btnEnRango = new System.Windows.Forms.Button();
            this.txtElementosRango = new System.Windows.Forms.TextBox();
            this.btnDistintos = new System.Windows.Forms.Button();
            this.txtDistintos = new System.Windows.Forms.TextBox();
            this.labelValOcurr = new System.Windows.Forms.Label();
            this.txtValorOcurrencia = new System.Windows.Forms.TextBox();
            this.btnOcurrencias = new System.Windows.Forms.Button();
            this.txtOcurrencias = new System.Windows.Forms.TextBox();
            this.btnMasFrecuente = new System.Windows.Forms.Button();
            this.txtMasFrecuente = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxOrdenamiento.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxOtras.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(144, 20);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(406, 21);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Manejador de Muestras - Ordenamiento y Búsqueda";
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.btnNuevaMuestra);
            this.groupBoxDatos.Controls.Add(this.txtPromedio);
            this.groupBoxDatos.Controls.Add(this.txtMaximo);
            this.groupBoxDatos.Controls.Add(this.txtMinimo);
            this.groupBoxDatos.Controls.Add(this.txtLimite);
            this.groupBoxDatos.Controls.Add(this.txtTamano);
            this.groupBoxDatos.Controls.Add(this.labelPromedio);
            this.groupBoxDatos.Controls.Add(this.labelMaximo);
            this.groupBoxDatos.Controls.Add(this.labelMinimo);
            this.groupBoxDatos.Controls.Add(this.labelLimite);
            this.groupBoxDatos.Controls.Add(this.labelTamano);
            this.groupBoxDatos.Location = new System.Drawing.Point(8, 105);
            this.groupBoxDatos.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDatos.Size = new System.Drawing.Size(183, 140);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos de la muestra";
            // 
            // btnNuevaMuestra
            // 
            this.btnNuevaMuestra.Location = new System.Drawing.Point(129, 18);
            this.btnNuevaMuestra.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaMuestra.Name = "btnNuevaMuestra";
            this.btnNuevaMuestra.Size = new System.Drawing.Size(50, 21);
            this.btnNuevaMuestra.TabIndex = 0;
            this.btnNuevaMuestra.Text = "Nueva";
            this.btnNuevaMuestra.Click += new System.EventHandler(this.btnNuevaMuestra_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(62, 116);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ReadOnly = true;
            this.txtPromedio.Size = new System.Drawing.Size(63, 20);
            this.txtPromedio.TabIndex = 1;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(53, 92);
            this.txtMaximo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.ReadOnly = true;
            this.txtMaximo.Size = new System.Drawing.Size(72, 20);
            this.txtMaximo.TabIndex = 2;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(53, 67);
            this.txtMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.ReadOnly = true;
            this.txtMinimo.Size = new System.Drawing.Size(72, 20);
            this.txtMinimo.TabIndex = 3;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(53, 44);
            this.txtLimite.Margin = new System.Windows.Forms.Padding(2);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(72, 20);
            this.txtLimite.TabIndex = 4;
            // 
            // txtTamano
            // 
            this.txtTamano.Location = new System.Drawing.Point(53, 18);
            this.txtTamano.Margin = new System.Windows.Forms.Padding(2);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(72, 20);
            this.txtTamano.TabIndex = 5;
            // 
            // labelPromedio
            // 
            this.labelPromedio.Location = new System.Drawing.Point(6, 119);
            this.labelPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(75, 15);
            this.labelPromedio.TabIndex = 6;
            this.labelPromedio.Text = "Promedio:";
            // 
            // labelMaximo
            // 
            this.labelMaximo.Location = new System.Drawing.Point(6, 95);
            this.labelMaximo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaximo.Name = "labelMaximo";
            this.labelMaximo.Size = new System.Drawing.Size(75, 15);
            this.labelMaximo.TabIndex = 7;
            this.labelMaximo.Text = "Máximo:";
            // 
            // labelMinimo
            // 
            this.labelMinimo.Location = new System.Drawing.Point(6, 73);
            this.labelMinimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinimo.Name = "labelMinimo";
            this.labelMinimo.Size = new System.Drawing.Size(75, 15);
            this.labelMinimo.TabIndex = 8;
            this.labelMinimo.Text = "Mínimo:";
            // 
            // labelLimite
            // 
            this.labelLimite.Location = new System.Drawing.Point(6, 47);
            this.labelLimite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLimite.Name = "labelLimite";
            this.labelLimite.Size = new System.Drawing.Size(46, 18);
            this.labelLimite.TabIndex = 9;
            this.labelLimite.Text = "Límite:";
            // 
            // labelTamano
            // 
            this.labelTamano.Location = new System.Drawing.Point(3, 22);
            this.labelTamano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTamano.Name = "labelTamano";
            this.labelTamano.Size = new System.Drawing.Size(49, 20);
            this.labelTamano.TabIndex = 10;
            this.labelTamano.Text = "Tamaño:";
            // 
            // groupBoxOrdenamiento
            // 
            this.groupBoxOrdenamiento.Controls.Add(this.btnBurbuja);
            this.groupBoxOrdenamiento.Controls.Add(this.txtTiempoBurbuja);
            this.groupBoxOrdenamiento.Controls.Add(this.btnSeleccion);
            this.groupBoxOrdenamiento.Controls.Add(this.txtTiempoSeleccion);
            this.groupBoxOrdenamiento.Controls.Add(this.btnInsercion);
            this.groupBoxOrdenamiento.Controls.Add(this.txtTiempoInsercion);
            this.groupBoxOrdenamiento.Location = new System.Drawing.Point(480, 85);
            this.groupBoxOrdenamiento.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOrdenamiento.Name = "groupBoxOrdenamiento";
            this.groupBoxOrdenamiento.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOrdenamiento.Size = new System.Drawing.Size(136, 140);
            this.groupBoxOrdenamiento.TabIndex = 2;
            this.groupBoxOrdenamiento.TabStop = false;
            this.groupBoxOrdenamiento.Text = "Ordenamiento";
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(5, 32);
            this.btnBurbuja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(62, 20);
            this.btnBurbuja.TabIndex = 0;
            this.btnBurbuja.Text = "Burbuja";
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // txtTiempoBurbuja
            // 
            this.txtTiempoBurbuja.Location = new System.Drawing.Point(76, 32);
            this.txtTiempoBurbuja.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempoBurbuja.Name = "txtTiempoBurbuja";
            this.txtTiempoBurbuja.ReadOnly = true;
            this.txtTiempoBurbuja.Size = new System.Drawing.Size(41, 20);
            this.txtTiempoBurbuja.TabIndex = 1;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(5, 71);
            this.btnSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(62, 22);
            this.btnSeleccion.TabIndex = 2;
            this.btnSeleccion.Text = "Selección";
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // txtTiempoSeleccion
            // 
            this.txtTiempoSeleccion.Location = new System.Drawing.Point(76, 73);
            this.txtTiempoSeleccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempoSeleccion.Name = "txtTiempoSeleccion";
            this.txtTiempoSeleccion.ReadOnly = true;
            this.txtTiempoSeleccion.Size = new System.Drawing.Size(41, 20);
            this.txtTiempoSeleccion.TabIndex = 3;
            // 
            // btnInsercion
            // 
            this.btnInsercion.Location = new System.Drawing.Point(4, 112);
            this.btnInsercion.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(63, 22);
            this.btnInsercion.TabIndex = 4;
            this.btnInsercion.Text = "Inserción";
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click);
            // 
            // txtTiempoInsercion
            // 
            this.txtTiempoInsercion.Location = new System.Drawing.Point(76, 112);
            this.txtTiempoInsercion.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempoInsercion.Name = "txtTiempoInsercion";
            this.txtTiempoInsercion.ReadOnly = true;
            this.txtTiempoInsercion.Size = new System.Drawing.Size(41, 20);
            this.txtTiempoInsercion.TabIndex = 5;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.labelValorBuscar);
            this.groupBoxBusqueda.Controls.Add(this.txtValorBuscar);
            this.groupBoxBusqueda.Controls.Add(this.btnSecuencial);
            this.groupBoxBusqueda.Controls.Add(this.txtTiempoSecuencial);
            this.groupBoxBusqueda.Controls.Add(this.btnBinaria);
            this.groupBoxBusqueda.Controls.Add(this.txtTiempoBinaria);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(8, 281);
            this.groupBoxBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxBusqueda.Size = new System.Drawing.Size(166, 117);
            this.groupBoxBusqueda.TabIndex = 3;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Búsqueda";
            // 
            // labelValorBuscar
            // 
            this.labelValorBuscar.Location = new System.Drawing.Point(12, 20);
            this.labelValorBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValorBuscar.Name = "labelValorBuscar";
            this.labelValorBuscar.Size = new System.Drawing.Size(33, 20);
            this.labelValorBuscar.TabIndex = 0;
            this.labelValorBuscar.Text = "Valor:";
            // 
            // txtValorBuscar
            // 
            this.txtValorBuscar.Location = new System.Drawing.Point(49, 17);
            this.txtValorBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorBuscar.Name = "txtValorBuscar";
            this.txtValorBuscar.Size = new System.Drawing.Size(55, 20);
            this.txtValorBuscar.TabIndex = 1;
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Location = new System.Drawing.Point(9, 41);
            this.btnSecuencial.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(68, 22);
            this.btnSecuencial.TabIndex = 2;
            this.btnSecuencial.Text = "Secuencial";
            this.btnSecuencial.Click += new System.EventHandler(this.btnSecuencial_Click);
            // 
            // txtTiempoSecuencial
            // 
            this.txtTiempoSecuencial.Location = new System.Drawing.Point(81, 43);
            this.txtTiempoSecuencial.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempoSecuencial.Name = "txtTiempoSecuencial";
            this.txtTiempoSecuencial.ReadOnly = true;
            this.txtTiempoSecuencial.Size = new System.Drawing.Size(76, 20);
            this.txtTiempoSecuencial.TabIndex = 3;
            // 
            // btnBinaria
            // 
            this.btnBinaria.Location = new System.Drawing.Point(9, 67);
            this.btnBinaria.Margin = new System.Windows.Forms.Padding(2);
            this.btnBinaria.Name = "btnBinaria";
            this.btnBinaria.Size = new System.Drawing.Size(68, 21);
            this.btnBinaria.TabIndex = 4;
            this.btnBinaria.Text = "Binaria";
            this.btnBinaria.Click += new System.EventHandler(this.btnBinaria_Click);
            // 
            // txtTiempoBinaria
            // 
            this.txtTiempoBinaria.Location = new System.Drawing.Point(81, 67);
            this.txtTiempoBinaria.Margin = new System.Windows.Forms.Padding(2);
            this.txtTiempoBinaria.Name = "txtTiempoBinaria";
            this.txtTiempoBinaria.ReadOnly = true;
            this.txtTiempoBinaria.Size = new System.Drawing.Size(76, 20);
            this.txtTiempoBinaria.TabIndex = 5;
            // 
            // groupBoxOtras
            // 
            this.groupBoxOtras.Controls.Add(this.labelInf);
            this.groupBoxOtras.Controls.Add(this.txtInferior);
            this.groupBoxOtras.Controls.Add(this.labelSup);
            this.groupBoxOtras.Controls.Add(this.txtSuperior);
            this.groupBoxOtras.Controls.Add(this.btnEnRango);
            this.groupBoxOtras.Controls.Add(this.txtElementosRango);
            this.groupBoxOtras.Controls.Add(this.btnDistintos);
            this.groupBoxOtras.Controls.Add(this.txtDistintos);
            this.groupBoxOtras.Controls.Add(this.labelValOcurr);
            this.groupBoxOtras.Controls.Add(this.txtValorOcurrencia);
            this.groupBoxOtras.Controls.Add(this.btnOcurrencias);
            this.groupBoxOtras.Controls.Add(this.txtOcurrencias);
            this.groupBoxOtras.Controls.Add(this.btnMasFrecuente);
            this.groupBoxOtras.Controls.Add(this.txtMasFrecuente);
            this.groupBoxOtras.Location = new System.Drawing.Point(259, 261);
            this.groupBoxOtras.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOtras.Name = "groupBoxOtras";
            this.groupBoxOtras.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOtras.Size = new System.Drawing.Size(357, 141);
            this.groupBoxOtras.TabIndex = 4;
            this.groupBoxOtras.TabStop = false;
            this.groupBoxOtras.Text = "Otras búsquedas";
            // 
            // labelInf
            // 
            this.labelInf.Location = new System.Drawing.Point(65, 23);
            this.labelInf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInf.Name = "labelInf";
            this.labelInf.Size = new System.Drawing.Size(44, 18);
            this.labelInf.TabIndex = 0;
            this.labelInf.Text = "Inferior:";
            // 
            // txtInferior
            // 
            this.txtInferior.Location = new System.Drawing.Point(113, 20);
            this.txtInferior.Margin = new System.Windows.Forms.Padding(2);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(46, 20);
            this.txtInferior.TabIndex = 1;
            // 
            // labelSup
            // 
            this.labelSup.Location = new System.Drawing.Point(171, 23);
            this.labelSup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSup.Name = "labelSup";
            this.labelSup.Size = new System.Drawing.Size(49, 14);
            this.labelSup.TabIndex = 2;
            this.labelSup.Text = "Superior:";
            // 
            // txtSuperior
            // 
            this.txtSuperior.Location = new System.Drawing.Point(224, 20);
            this.txtSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(46, 20);
            this.txtSuperior.TabIndex = 3;
            // 
            // btnEnRango
            // 
            this.btnEnRango.Location = new System.Drawing.Point(7, 52);
            this.btnEnRango.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnRango.Name = "btnEnRango";
            this.btnEnRango.Size = new System.Drawing.Size(113, 22);
            this.btnEnRango.TabIndex = 4;
            this.btnEnRango.Text = "Elementos en rango";
            this.btnEnRango.Click += new System.EventHandler(this.btnEnRango_Click);
            // 
            // txtElementosRango
            // 
            this.txtElementosRango.Location = new System.Drawing.Point(124, 52);
            this.txtElementosRango.Margin = new System.Windows.Forms.Padding(2);
            this.txtElementosRango.Name = "txtElementosRango";
            this.txtElementosRango.ReadOnly = true;
            this.txtElementosRango.Size = new System.Drawing.Size(46, 20);
            this.txtElementosRango.TabIndex = 5;
            // 
            // btnDistintos
            // 
            this.btnDistintos.Location = new System.Drawing.Point(187, 52);
            this.btnDistintos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDistintos.Name = "btnDistintos";
            this.btnDistintos.Size = new System.Drawing.Size(102, 22);
            this.btnDistintos.TabIndex = 6;
            this.btnDistintos.Text = "NúmDistintos";
            this.btnDistintos.Click += new System.EventHandler(this.btnDistintos_Click);
            // 
            // txtDistintos
            // 
            this.txtDistintos.Location = new System.Drawing.Point(293, 52);
            this.txtDistintos.Margin = new System.Windows.Forms.Padding(2);
            this.txtDistintos.Name = "txtDistintos";
            this.txtDistintos.ReadOnly = true;
            this.txtDistintos.Size = new System.Drawing.Size(46, 20);
            this.txtDistintos.TabIndex = 7;
            // 
            // labelValOcurr
            // 
            this.labelValOcurr.Location = new System.Drawing.Point(14, 87);
            this.labelValOcurr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValOcurr.Name = "labelValOcurr";
            this.labelValOcurr.Size = new System.Drawing.Size(106, 17);
            this.labelValOcurr.TabIndex = 8;
            this.labelValOcurr.Text = "Valor (ocurrencias):";
            // 
            // txtValorOcurrencia
            // 
            this.txtValorOcurrencia.Location = new System.Drawing.Point(124, 84);
            this.txtValorOcurrencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorOcurrencia.Name = "txtValorOcurrencia";
            this.txtValorOcurrencia.Size = new System.Drawing.Size(48, 20);
            this.txtValorOcurrencia.TabIndex = 9;
            // 
            // btnOcurrencias
            // 
            this.btnOcurrencias.Location = new System.Drawing.Point(85, 115);
            this.btnOcurrencias.Margin = new System.Windows.Forms.Padding(2);
            this.btnOcurrencias.Name = "btnOcurrencias";
            this.btnOcurrencias.Size = new System.Drawing.Size(104, 22);
            this.btnOcurrencias.TabIndex = 10;
            this.btnOcurrencias.Text = "NúmOcurrencias";
            this.btnOcurrencias.Click += new System.EventHandler(this.btnOcurrencias_Click);
            // 
            // txtOcurrencias
            // 
            this.txtOcurrencias.Location = new System.Drawing.Point(193, 117);
            this.txtOcurrencias.Margin = new System.Windows.Forms.Padding(2);
            this.txtOcurrencias.Name = "txtOcurrencias";
            this.txtOcurrencias.ReadOnly = true;
            this.txtOcurrencias.Size = new System.Drawing.Size(54, 20);
            this.txtOcurrencias.TabIndex = 11;
            // 
            // btnMasFrecuente
            // 
            this.btnMasFrecuente.Location = new System.Drawing.Point(203, 81);
            this.btnMasFrecuente.Margin = new System.Windows.Forms.Padding(2);
            this.btnMasFrecuente.Name = "btnMasFrecuente";
            this.btnMasFrecuente.Size = new System.Drawing.Size(88, 23);
            this.btnMasFrecuente.TabIndex = 12;
            this.btnMasFrecuente.Text = "Más frecuente";
            this.btnMasFrecuente.Click += new System.EventHandler(this.btnMasFrecuente_Click);
            // 
            // txtMasFrecuente
            // 
            this.txtMasFrecuente.Location = new System.Drawing.Point(293, 82);
            this.txtMasFrecuente.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasFrecuente.Name = "txtMasFrecuente";
            this.txtMasFrecuente.ReadOnly = true;
            this.txtMasFrecuente.Size = new System.Drawing.Size(46, 20);
            this.txtMasFrecuente.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(220, 85);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 160);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(632, 425);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxOrdenamiento);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.groupBoxOtras);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejador de Muestras";
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxOrdenamiento.ResumeLayout(false);
            this.groupBoxOrdenamiento.PerformLayout();
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.groupBoxOtras.ResumeLayout(false);
            this.groupBoxOtras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button btnNuevaMuestra;
        private System.Windows.Forms.TextBox txtPromedio, txtMaximo, txtMinimo, txtLimite, txtTamano;
        private System.Windows.Forms.Label labelPromedio, labelMaximo, labelMinimo, labelLimite, labelTamano;

        private System.Windows.Forms.GroupBox groupBoxOrdenamiento;
        private System.Windows.Forms.Button btnBurbuja, btnSeleccion, btnInsercion;
        private System.Windows.Forms.TextBox txtTiempoBurbuja, txtTiempoSeleccion, txtTiempoInsercion;

        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button btnSecuencial, btnBinaria;
        private System.Windows.Forms.TextBox txtTiempoSecuencial, txtTiempoBinaria, txtValorBuscar;
        private System.Windows.Forms.Label labelValorBuscar;

        private System.Windows.Forms.GroupBox groupBoxOtras;
        private System.Windows.Forms.TextBox txtMasFrecuente, txtDistintos, txtOcurrencias, txtElementosRango,
            txtValorOcurrencia, txtSuperior, txtInferior;
        private System.Windows.Forms.Button btnMasFrecuente, btnDistintos, btnOcurrencias, btnEnRango;
        private System.Windows.Forms.Label labelInf, labelSup, labelValOcurr;

        private System.Windows.Forms.ListBox listBox1;
    }
}