using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        List<int> listaInt;
        List<double> listaDouble;
        public Form1()
        {
            InitializeComponent();
            listaInt = new List<int>();
            listaDouble = new List<double>();
            pbxAmarillo.Visible = false;
            pbxRojo.Visible = false;
            pbxVerde.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Métodos Comunes
        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void LimpiarList()
        {
            listaDouble.Clear();
            listaInt.Clear();
            txtNumero.Clear();
        }
        #endregion

        #region Problema 1
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                listaInt.Add(Convert.ToInt32(txtNumArreglo.Text));
                txtNumArreglo.Clear();
                txtNumArreglo.Focus();
            }
            catch (Exception)
            {

                return;
            }
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listaInt.Count; i++)
            {
                lstArreglo.Items.Add(listaInt[i]);
            }

            var ordenar = (from ordenado in listaInt
                          orderby ordenado descending
                          select ordenado).Take(4);
            foreach (var orden in ordenar) lstCuatroMayores.Items.Add(orden);
        }

        private void txtNumArreglo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }
        #endregion

        #region problema 2
        private void btnAgregarProblema2_Click(object sender, EventArgs e)
        {
            try
            {
                listaInt.Add(Convert.ToInt32(txtIngresarProblema2.Text));
                txtIngresarProblema2.Clear();
                txtIngresarProblema2.Focus();
            }
            catch (Exception ex)
            {

                return;
            }
            
        }
        
        private void btnMostrarProblema2_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < listaInt.Count; i++)
            {
                for (int j = 0; j < listaInt.Count; j++)
                {
                    if (i != j)
                    {
                        lstMultArreglo.Items.Add(listaInt[i] * listaInt[j]);                    
                    }
                }
                lstNumerosArreglo.Items.Add(listaInt[i]);
            }
        }
        private void txtIngresarProblema2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void btnLimpiarProblema1_Click(object sender, EventArgs e)
        {
            LimpiarList();
            lstCuatroMayores.Items.Clear();
            lstArreglo.Items.Clear();
            txtNumArreglo.Clear();
        }

        private void btnLimpiarProblema2_Click(object sender, EventArgs e)
        {
            LimpiarList();
            lstNumerosArreglo.Items.Clear();
            lstMultArreglo.Items.Clear();
            txtIngresarProblema2.Clear();
        }
        #endregion

        #region Problema 3
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            double valorMinimo = 0;           
            double valorMax = 0;
            double num = 0;           
            listaDouble.Add(Convert.ToDouble(txtNumero.Text));
            //txtNumero.Clear();
            valorMax = listaDouble.Max(x => x);
            valorMinimo = listaDouble.Min(x => x);

            num = Convert.ToDouble(txtNumero.Text);
            if (valorMax == num) 
            {
                pbxVerde.Visible = false;
                pbxRojo.Visible = true;
            }
            else if (valorMinimo == num) 
            {
                pbxRojo.Visible = false;
                pbxVerde.Visible = true;
            }
            else
	        {
                pbxVerde.Visible = false;
                pbxAmarillo.Visible = true;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarList();
        }



        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) ||
                e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator
                )
                e.Handled = false;
            else
                e.Handled = true;
        }



        #endregion

        #region Problema 4
        private void btnCalcularCuadrados_Click(object sender, EventArgs e)
        {
            
            int numero = Convert.ToInt32(txtN.Text);
            if (numero ==0)
            {
                MessageBox.Show("No puede ingresar el número cero '0'");
            }
            else
            {
                int cuadrados = ((numero * (numero + 1)) * (2 * numero + 1)) / 6;
                txtCuadradosCalculados.Text = Convert.ToString(cuadrados);
                txtN.Clear();
            }
            
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        #endregion

        
    }
}
