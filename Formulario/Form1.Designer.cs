namespace Formulario
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Problema1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCuatroMayores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstArreglo = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumArreglo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Problema2 = new System.Windows.Forms.TabPage();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstMultArreglo = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMostrarProblema2 = new System.Windows.Forms.Button();
            this.lstNumerosArreglo = new System.Windows.Forms.ListBox();
            this.btnAgregarProblema2 = new System.Windows.Forms.Button();
            this.txtIngresarProblema2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Problema3 = new System.Windows.Forms.TabPage();
            this.Problema4 = new System.Windows.Forms.TabPage();
            this.pbxAmarillo = new System.Windows.Forms.PictureBox();
            this.pbxRojo = new System.Windows.Forms.PictureBox();
            this.pbxVerde = new System.Windows.Forms.PictureBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalcularCuadrados = new System.Windows.Forms.Button();
            this.txtCuadradosCalculados = new System.Windows.Forms.TextBox();
            this.btnLimpiarProblema1 = new System.Windows.Forms.Button();
            this.btnLimpiarProblema2 = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.Problema1.SuspendLayout();
            this.Problema2.SuspendLayout();
            this.Problema3.SuspendLayout();
            this.Problema4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Problema1);
            this.Tabs.Controls.Add(this.Problema2);
            this.Tabs.Controls.Add(this.Problema3);
            this.Tabs.Controls.Add(this.Problema4);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(469, 322);
            this.Tabs.TabIndex = 0;
            // 
            // Problema1
            // 
            this.Problema1.BackColor = System.Drawing.Color.Gainsboro;
            this.Problema1.Controls.Add(this.btnLimpiarProblema1);
            this.Problema1.Controls.Add(this.label3);
            this.Problema1.Controls.Add(this.lstCuatroMayores);
            this.Problema1.Controls.Add(this.label2);
            this.Problema1.Controls.Add(this.btnMostrar);
            this.Problema1.Controls.Add(this.lstArreglo);
            this.Problema1.Controls.Add(this.btnAgregar);
            this.Problema1.Controls.Add(this.txtNumArreglo);
            this.Problema1.Controls.Add(this.label1);
            this.Problema1.Location = new System.Drawing.Point(4, 22);
            this.Problema1.Name = "Problema1";
            this.Problema1.Padding = new System.Windows.Forms.Padding(3);
            this.Problema1.Size = new System.Drawing.Size(461, 296);
            this.Problema1.TabIndex = 0;
            this.Problema1.Text = "Problema1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "4 mayores valores almacenados";
            // 
            // lstCuatroMayores
            // 
            this.lstCuatroMayores.FormattingEnabled = true;
            this.lstCuatroMayores.Location = new System.Drawing.Point(263, 136);
            this.lstCuatroMayores.Name = "lstCuatroMayores";
            this.lstCuatroMayores.Size = new System.Drawing.Size(149, 95);
            this.lstCuatroMayores.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Todos los números del Arreglo";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(182, 165);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstArreglo
            // 
            this.lstArreglo.FormattingEnabled = true;
            this.lstArreglo.Location = new System.Drawing.Point(27, 136);
            this.lstArreglo.Name = "lstArreglo";
            this.lstArreglo.Size = new System.Drawing.Size(149, 95);
            this.lstArreglo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(134, 53);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumArreglo
            // 
            this.txtNumArreglo.Location = new System.Drawing.Point(27, 53);
            this.txtNumArreglo.Name = "txtNumArreglo";
            this.txtNumArreglo.Size = new System.Drawing.Size(100, 20);
            this.txtNumArreglo.TabIndex = 1;
            this.txtNumArreglo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumArreglo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese los números del Arreglo";
            // 
            // Problema2
            // 
            this.Problema2.Controls.Add(this.btnLimpiarProblema2);
            this.Problema2.Controls.Add(this.lblPrueba);
            this.Problema2.Controls.Add(this.label5);
            this.Problema2.Controls.Add(this.lstMultArreglo);
            this.Problema2.Controls.Add(this.label6);
            this.Problema2.Controls.Add(this.btnMostrarProblema2);
            this.Problema2.Controls.Add(this.lstNumerosArreglo);
            this.Problema2.Controls.Add(this.btnAgregarProblema2);
            this.Problema2.Controls.Add(this.txtIngresarProblema2);
            this.Problema2.Controls.Add(this.label4);
            this.Problema2.Location = new System.Drawing.Point(4, 22);
            this.Problema2.Name = "Problema2";
            this.Problema2.Padding = new System.Windows.Forms.Padding(3);
            this.Problema2.Size = new System.Drawing.Size(461, 296);
            this.Problema2.TabIndex = 1;
            this.Problema2.Text = "Problema2";
            this.Problema2.UseVisualStyleBackColor = true;
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(88, 265);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(0, 13);
            this.lblPrueba.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Multiplicación de arreglos";
            // 
            // lstMultArreglo
            // 
            this.lstMultArreglo.FormattingEnabled = true;
            this.lstMultArreglo.Location = new System.Drawing.Point(260, 111);
            this.lstMultArreglo.Name = "lstMultArreglo";
            this.lstMultArreglo.Size = new System.Drawing.Size(149, 95);
            this.lstMultArreglo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Todos los números del Arreglo";
            // 
            // btnMostrarProblema2
            // 
            this.btnMostrarProblema2.Location = new System.Drawing.Point(179, 140);
            this.btnMostrarProblema2.Name = "btnMostrarProblema2";
            this.btnMostrarProblema2.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarProblema2.TabIndex = 9;
            this.btnMostrarProblema2.Text = "Mostrar";
            this.btnMostrarProblema2.UseVisualStyleBackColor = true;
            this.btnMostrarProblema2.Click += new System.EventHandler(this.btnMostrarProblema2_Click);
            // 
            // lstNumerosArreglo
            // 
            this.lstNumerosArreglo.FormattingEnabled = true;
            this.lstNumerosArreglo.Location = new System.Drawing.Point(24, 111);
            this.lstNumerosArreglo.Name = "lstNumerosArreglo";
            this.lstNumerosArreglo.Size = new System.Drawing.Size(149, 95);
            this.lstNumerosArreglo.TabIndex = 8;
            // 
            // btnAgregarProblema2
            // 
            this.btnAgregarProblema2.Location = new System.Drawing.Point(131, 43);
            this.btnAgregarProblema2.Name = "btnAgregarProblema2";
            this.btnAgregarProblema2.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProblema2.TabIndex = 5;
            this.btnAgregarProblema2.Text = "Agregar";
            this.btnAgregarProblema2.UseVisualStyleBackColor = true;
            this.btnAgregarProblema2.Click += new System.EventHandler(this.btnAgregarProblema2_Click);
            // 
            // txtIngresarProblema2
            // 
            this.txtIngresarProblema2.Location = new System.Drawing.Point(24, 43);
            this.txtIngresarProblema2.Name = "txtIngresarProblema2";
            this.txtIngresarProblema2.Size = new System.Drawing.Size(100, 20);
            this.txtIngresarProblema2.TabIndex = 4;
            this.txtIngresarProblema2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresarProblema2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ingrese los números del Arreglo";
            // 
            // Problema3
            // 
            this.Problema3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Problema3.Controls.Add(this.label8);
            this.Problema3.Controls.Add(this.button1);
            this.Problema3.Controls.Add(this.label7);
            this.Problema3.Controls.Add(this.txtNumero);
            this.Problema3.Controls.Add(this.btnCambiar);
            this.Problema3.Controls.Add(this.pbxVerde);
            this.Problema3.Controls.Add(this.pbxRojo);
            this.Problema3.Controls.Add(this.pbxAmarillo);
            this.Problema3.Location = new System.Drawing.Point(4, 22);
            this.Problema3.Name = "Problema3";
            this.Problema3.Padding = new System.Windows.Forms.Padding(3);
            this.Problema3.Size = new System.Drawing.Size(461, 296);
            this.Problema3.TabIndex = 2;
            this.Problema3.Text = "Problema 3";
            // 
            // Problema4
            // 
            this.Problema4.Controls.Add(this.txtCuadradosCalculados);
            this.Problema4.Controls.Add(this.btnCalcularCuadrados);
            this.Problema4.Controls.Add(this.label10);
            this.Problema4.Controls.Add(this.txtN);
            this.Problema4.Controls.Add(this.label9);
            this.Problema4.Location = new System.Drawing.Point(4, 22);
            this.Problema4.Name = "Problema4";
            this.Problema4.Padding = new System.Windows.Forms.Padding(3);
            this.Problema4.Size = new System.Drawing.Size(461, 296);
            this.Problema4.TabIndex = 3;
            this.Problema4.Text = "Problema 4";
            this.Problema4.UseVisualStyleBackColor = true;
            // 
            // pbxAmarillo
            // 
            this.pbxAmarillo.Image = global::Formulario.Properties.Resources.amarillo;
            this.pbxAmarillo.Location = new System.Drawing.Point(21, 6);
            this.pbxAmarillo.Name = "pbxAmarillo";
            this.pbxAmarillo.Size = new System.Drawing.Size(102, 230);
            this.pbxAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAmarillo.TabIndex = 0;
            this.pbxAmarillo.TabStop = false;
            // 
            // pbxRojo
            // 
            this.pbxRojo.Image = global::Formulario.Properties.Resources.rojo;
            this.pbxRojo.Location = new System.Drawing.Point(21, 6);
            this.pbxRojo.Name = "pbxRojo";
            this.pbxRojo.Size = new System.Drawing.Size(102, 230);
            this.pbxRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRojo.TabIndex = 1;
            this.pbxRojo.TabStop = false;
            // 
            // pbxVerde
            // 
            this.pbxVerde.Image = global::Formulario.Properties.Resources.verde;
            this.pbxVerde.Location = new System.Drawing.Point(21, 6);
            this.pbxVerde.Name = "pbxVerde";
            this.pbxVerde.Size = new System.Drawing.Size(102, 230);
            this.pbxVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVerde.TabIndex = 2;
            this.pbxVerde.TabStop = false;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(301, 94);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(186, 97);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ingrese un Número decimal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comenzar de nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Limpia la lista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ingrese el número de N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(170, 47);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 1;
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "La cantidad de cuadrados que se pueden formar es";
            // 
            // btnCalcularCuadrados
            // 
            this.btnCalcularCuadrados.Location = new System.Drawing.Point(50, 94);
            this.btnCalcularCuadrados.Name = "btnCalcularCuadrados";
            this.btnCalcularCuadrados.Size = new System.Drawing.Size(220, 23);
            this.btnCalcularCuadrados.TabIndex = 3;
            this.btnCalcularCuadrados.Text = "Calcular";
            this.btnCalcularCuadrados.UseVisualStyleBackColor = true;
            this.btnCalcularCuadrados.Click += new System.EventHandler(this.btnCalcularCuadrados_Click);
            // 
            // txtCuadradosCalculados
            // 
            this.txtCuadradosCalculados.Location = new System.Drawing.Point(304, 125);
            this.txtCuadradosCalculados.Name = "txtCuadradosCalculados";
            this.txtCuadradosCalculados.ReadOnly = true;
            this.txtCuadradosCalculados.Size = new System.Drawing.Size(100, 20);
            this.txtCuadradosCalculados.TabIndex = 4;
            // 
            // btnLimpiarProblema1
            // 
            this.btnLimpiarProblema1.Location = new System.Drawing.Point(183, 195);
            this.btnLimpiarProblema1.Name = "btnLimpiarProblema1";
            this.btnLimpiarProblema1.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarProblema1.TabIndex = 8;
            this.btnLimpiarProblema1.Text = "Limpiar";
            this.btnLimpiarProblema1.UseVisualStyleBackColor = true;
            this.btnLimpiarProblema1.Click += new System.EventHandler(this.btnLimpiarProblema1_Click);
            // 
            // btnLimpiarProblema2
            // 
            this.btnLimpiarProblema2.Location = new System.Drawing.Point(179, 169);
            this.btnLimpiarProblema2.Name = "btnLimpiarProblema2";
            this.btnLimpiarProblema2.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarProblema2.TabIndex = 14;
            this.btnLimpiarProblema2.Text = "Limpiar";
            this.btnLimpiarProblema2.UseVisualStyleBackColor = true;
            this.btnLimpiarProblema2.Click += new System.EventHandler(this.btnLimpiarProblema2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 342);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Postulacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.Problema1.ResumeLayout(false);
            this.Problema1.PerformLayout();
            this.Problema2.ResumeLayout(false);
            this.Problema2.PerformLayout();
            this.Problema3.ResumeLayout(false);
            this.Problema3.PerformLayout();
            this.Problema4.ResumeLayout(false);
            this.Problema4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Problema1;
        private System.Windows.Forms.TabPage Problema2;
        private System.Windows.Forms.TabPage Problema3;
        private System.Windows.Forms.TabPage Problema4;
        private System.Windows.Forms.ListBox lstArreglo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCuatroMayores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstMultArreglo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMostrarProblema2;
        private System.Windows.Forms.ListBox lstNumerosArreglo;
        private System.Windows.Forms.Button btnAgregarProblema2;
        private System.Windows.Forms.TextBox txtIngresarProblema2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.PictureBox pbxVerde;
        private System.Windows.Forms.PictureBox pbxRojo;
        private System.Windows.Forms.PictureBox pbxAmarillo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuadradosCalculados;
        private System.Windows.Forms.Button btnCalcularCuadrados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpiarProblema1;
        private System.Windows.Forms.Button btnLimpiarProblema2;
    }
}

