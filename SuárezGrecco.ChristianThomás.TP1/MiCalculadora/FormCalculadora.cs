using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Inicializar calculadora
        public FormCalculadora()
        {
            InitializeComponent();
            cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;            
        }
        /// <summary>
        /// Inicializa la calculadora con el label en 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "0"; 
        }
        #endregion

        #region Botones
        /// <summary>
        /// Realiza la operacion entre los numeros ingresados a través de los textbox 1 y 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            while(txtNumero1.Text == null && txtNumero2.Text == null)
            {
                lblResultado.Text = "0";
            }
            lblResultado.Text = Convert.ToString(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));            
        }
        /// <summary>
        /// Llama al método limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Realiza la conversion del resultado(label) a Binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Numero().DecimalBinario(this.lblResultado.Text);
        }
        /// <summary>
        /// Realiza la conversion de Binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Numero().BinarioDecimal(this.lblResultado.Text);
        }
        #endregion

        #region Combobox
        /// <summary>
        /// Combobox que elige los operadores determinados por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion

        #region Textbox 1 y 2

        /// <summary>
        /// valida que en el txt1 lo que se ingresa no sean letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            bool confirmacion;
            float numero;

            confirmacion = float.TryParse(txtNumero1.Text, out numero);
            
            if(confirmacion == false)
            {
                Limpiar();
            }            
        }

        /// <summary>
        /// valida que en el txt2 lo que se ingresa no sean letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            bool confirmacion;
            float numero;

            confirmacion = float.TryParse(txtNumero2.Text, out numero);

            if (confirmacion == false)
            {
                Limpiar();               
            }
        }
        #endregion

        #region Label
        /// <summary>
        /// Muestra el resultado por pantalla en el label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblResultado_Click(object sender, EventArgs e)
        {           
        }
        #endregion

        #region Operar y Limpiar
        /// <summary>
        /// Realiza la operación matemática entre 2 numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private double Operar(string numero1, string numero2, string operador)
        {          
            Entidades.Numero num1 = new Entidades.Numero(numero1);
            Entidades.Numero num2 = new Entidades.Numero(numero2);
            
            if(operador == "")
            {
                operador = "+";
                cmbOperador.Text = "+";
            }

            return Entidades.Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Vacia todos los campos
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            this.cmbOperador.Text = null;
            txtNumero1.Focus();
            lblResultado.Text = "0";
        }
        #endregion

    }
}
