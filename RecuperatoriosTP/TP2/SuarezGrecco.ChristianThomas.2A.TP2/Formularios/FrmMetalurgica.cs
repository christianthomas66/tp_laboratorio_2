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

namespace Formularios
{
    public partial class FrmMetalurgica : Form
    {
        public Metalurgica misMetalurgica;

        /// <summary>
        /// Constructor de FrmMetalurgica
        /// </summary>
        public FrmMetalurgica()
        {
            InitializeComponent();
            cmbTipoMetales.DataSource = Enum.GetValues(typeof(TipoMetal));
        }
        /// <summary>
        /// Constructor parametrizado que toma los metales de Metalurgica
        /// </summary>
        /// <param name="metales"></param>
        public FrmMetalurgica(Metalurgica metales) : this()
        {
            this.misMetalurgica = metales;
        }                                
        /// <summary>
        /// txt1 que permite ingresar solo numeros, si se ingresan letras los txt(campos) se borrarán automaticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesoBox1_TextChanged(object sender, EventArgs e)
        {
            bool confirmacion;
            double numero;

            confirmacion = double.TryParse(txtPesoBox1.Text, out numero);

            if(confirmacion == false)
            {
                Limpiar();
            }
        }
        /// <summary>
        /// txt2 que permite ingresar solo numeros, si se ingresan letras los txt(campos) se borrarán automaticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTamanioBox2_TextChanged(object sender, EventArgs e)
        {
            bool confirmacion;
            double numero;
            confirmacion = double.TryParse(txtTamanioBox2.Text, out numero);

            if(confirmacion == false)
            {                
                Limpiar();
            }
        }
        /// <summary>
        /// Metodo Limpiar que vacia los txts si se ingresan letras
        /// </summary>
        private void Limpiar()
        {          
            txtPesoBox1.Clear();
            txtTamanioBox2.Clear();            
        }
        /// <summary>
        /// Boton que regresa al menu del formulario inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        /// <summary>
        /// Boton que limpia los txts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPesoBox1.Text = String.Empty;
            txtTamanioBox2.Text = String.Empty;
        }
        /// <summary>
        /// Boton que forja los metales siempre y cuando eligiendo el tipo de metal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForjar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtPesoBox1.Text) && !string.IsNullOrWhiteSpace(txtTamanioBox2.Text))
            {   

                double peso = Convert.ToDouble(txtPesoBox1.Text);
                double tamanio = Convert.ToDouble(txtTamanioBox2.Text);
                bool inicializar = false;

                if(cmbTipoMetales.SelectedIndex == 0)
                {                      
                    Acero miAcero = new Acero(peso, tamanio, TipoMetal.Acero);                 
                    inicializar = misMetalurgica + miAcero;
                    if (inicializar)
                    {
                        MessageBox.Show("Metal acero forjado con exito!!!", "exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }                                                          

                }                
                if(cmbTipoMetales.SelectedIndex == 1)
                {
                    Cobre miCobre = new Cobre(peso, tamanio, TipoMetal.Cobre);
                    inicializar = misMetalurgica + miCobre;
                    if (inicializar)
                    {
                        MessageBox.Show("Metal cobre forjado con exito!!!", "exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                if(cmbTipoMetales.SelectedIndex == 2)
                {
                    Hierro miHierro = new Hierro(peso, tamanio, TipoMetal.Hierro);
                    inicializar = misMetalurgica + miHierro;
                    if(inicializar)
                    {
                        MessageBox.Show("Metal hierro forjado con exito!!!", "exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                if(!inicializar)
                {
                    MessageBox.Show("No se agrego el metal a la metalurgica porque se supero la capacidad maxima", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, ingrese valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnLimpiar_Click(sender, e);            
        }
    }
}
