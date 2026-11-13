using System;

namespace mundialFutbol
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
            this.btnBuscarJugador = new System.Windows.Forms.Button();
            this.btnModificarConArchivo = new System.Windows.Forms.Button();
            this.btnCalcularNomina = new System.Windows.Forms.Button();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbxEquipos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRutaFoto = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pbxFotoJugador = new System.Windows.Forms.PictureBox();
            this.pbxBandera = new System.Windows.Forms.PictureBox();
            this.lbxJugadores = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBandera)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarJugador
            // 
            this.btnBuscarJugador.Location = new System.Drawing.Point(12, 34);
            this.btnBuscarJugador.Name = "btnBuscarJugador";
            this.btnBuscarJugador.Size = new System.Drawing.Size(132, 47);
            this.btnBuscarJugador.TabIndex = 0;
            this.btnBuscarJugador.Text = "Buscar jugador";
            this.btnBuscarJugador.UseVisualStyleBackColor = true;
            // 
            // btnModificarConArchivo
            // 
            this.btnModificarConArchivo.Location = new System.Drawing.Point(12, 298);
            this.btnModificarConArchivo.Name = "btnModificarConArchivo";
            this.btnModificarConArchivo.Size = new System.Drawing.Size(132, 47);
            this.btnModificarConArchivo.TabIndex = 1;
            this.btnModificarConArchivo.Text = "Modificar con archivo";
            this.btnModificarConArchivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcularNomina
            // 
            this.btnCalcularNomina.Location = new System.Drawing.Point(12, 233);
            this.btnCalcularNomina.Name = "btnCalcularNomina";
            this.btnCalcularNomina.Size = new System.Drawing.Size(132, 47);
            this.btnCalcularNomina.TabIndex = 2;
            this.btnCalcularNomina.Text = "Calcular nomina";
            this.btnCalcularNomina.UseVisualStyleBackColor = true;
            // 
            // btnAgregarJugador
            // 
            this.btnAgregarJugador.Location = new System.Drawing.Point(12, 164);
            this.btnAgregarJugador.Name = "btnAgregarJugador";
            this.btnAgregarJugador.Size = new System.Drawing.Size(132, 47);
            this.btnAgregarJugador.TabIndex = 3;
            this.btnAgregarJugador.Text = "Agregar jugador";
            this.btnAgregarJugador.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(12, 101);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(132, 47);
            this.btnAgregarEquipo.TabIndex = 4;
            this.btnAgregarEquipo.Text = "Agregar equipo";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 527);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 60);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lbxEquipos
            // 
            this.lbxEquipos.FormattingEnabled = true;
            this.lbxEquipos.ItemHeight = 16;
            this.lbxEquipos.Location = new System.Drawing.Point(162, 50);
            this.lbxEquipos.Name = "lbxEquipos";
            this.lbxEquipos.Size = new System.Drawing.Size(266, 196);
            this.lbxEquipos.TabIndex = 6;
            this.lbxEquipos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "INFORMACION DEL MUNDIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(379, 304);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(379, 332);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(178, 22);
            this.txtEquipo.TabIndex = 17;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(379, 360);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(178, 22);
            this.txtEdad.TabIndex = 18;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(379, 389);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(178, 22);
            this.txtAltura.TabIndex = 19;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(379, 417);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(178, 22);
            this.txtPeso.TabIndex = 20;
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Location = new System.Drawing.Point(431, 550);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(134, 26);
            this.btnBuscarArchivo.TabIndex = 24;
            this.btnBuscarArchivo.Text = "Buscar archivo";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(291, 550);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(134, 26);
            this.btnGuardarCambios.TabIndex = 25;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "DETALLES DEL JUGADOR";
            // 
            // txtRutaFoto
            // 
            this.txtRutaFoto.Location = new System.Drawing.Point(379, 501);
            this.txtRutaFoto.Name = "txtRutaFoto";
            this.txtRutaFoto.Size = new System.Drawing.Size(178, 22);
            this.txtRutaFoto.TabIndex = 17;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(379, 473);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(178, 22);
            this.txtPosicion.TabIndex = 18;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(379, 445);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(178, 22);
            this.txtSalario.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "EQUIPO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "ALTURA(m):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "EDAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "PESO(kg):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "SALARIO(USD):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "POSICION:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "RUTA FOTO:";
            // 
            // pbxFotoJugador
            // 
            this.pbxFotoJugador.Location = new System.Drawing.Point(578, 304);
            this.pbxFotoJugador.Name = "pbxFotoJugador";
            this.pbxFotoJugador.Size = new System.Drawing.Size(96, 91);
            this.pbxFotoJugador.TabIndex = 34;
            this.pbxFotoJugador.TabStop = false;
            // 
            // pbxBandera
            // 
            this.pbxBandera.Location = new System.Drawing.Point(578, 401);
            this.pbxBandera.Name = "pbxBandera";
            this.pbxBandera.Size = new System.Drawing.Size(96, 50);
            this.pbxBandera.TabIndex = 35;
            this.pbxBandera.TabStop = false;
            // 
            // lbxJugadores
            // 
            this.lbxJugadores.FormattingEnabled = true;
            this.lbxJugadores.ItemHeight = 16;
            this.lbxJugadores.Location = new System.Drawing.Point(458, 50);
            this.lbxJugadores.Name = "lbxJugadores";
            this.lbxJugadores.Size = new System.Drawing.Size(302, 196);
            this.lbxJugadores.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 599);
            this.Controls.Add(this.lbxJugadores);
            this.Controls.Add(this.pbxBandera);
            this.Controls.Add(this.pbxFotoJugador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRutaFoto);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxEquipos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Controls.Add(this.btnAgregarJugador);
            this.Controls.Add(this.btnCalcularNomina);
            this.Controls.Add(this.btnModificarConArchivo);
            this.Controls.Add(this.btnBuscarJugador);
            this.Name = "Form1";
            this.Text = "Organizacion del mundial del Futbol";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBandera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnBuscarJugador;
        private System.Windows.Forms.Button btnModificarConArchivo;
        private System.Windows.Forms.Button btnCalcularNomina;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lbxEquipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRutaFoto;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbxFotoJugador;
        private System.Windows.Forms.PictureBox pbxBandera;
        private System.Windows.Forms.ListBox lbxJugadores;
    }
}

