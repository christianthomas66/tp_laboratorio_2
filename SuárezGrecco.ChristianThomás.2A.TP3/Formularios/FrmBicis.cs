using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class FrmBicis : Form
    {
        private Fábrica miFábrica;
        private Bicicleta.TipoBici biciTipo;
        
        /// <summary>
        /// Constructor por default del tipo FrmBicis
        /// </summary>
        public FrmBicis()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor que inicia el formulario del menú
        /// </summary>
        /// <param name="frmFábrica"></param>

        public FrmBicis(Fábrica frmFábrica)
        {
            miFábrica = frmFábrica;
            InitializeComponent();
        }
        /// <summary>
        /// Propiedad de miFábrica
        /// </summary>
       public Fábrica GetFrmFábrica{ get=> miFábrica;}

        /// <summary>
        /// Inicia el 2do form con los atributos combox por default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBicis_Load(object sender, EventArgs e)
        {
            cmbColor.SelectedIndex = -1;
            cmbRuedas.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbNumeroSerie.SelectedIndex = -1;
        }

            
        /// <summary>
        /// Boton fabricar, al presionarlo se fabricará una nueva bicicleta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabricar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(cmbColor.Text) && !String.IsNullOrWhiteSpace(cmbRuedas.Text) && !String.IsNullOrWhiteSpace(cmbMarca.Text))
            {
                try
                {
                   
                    if(!(cmbNumeroSerie.Text.StartsWith("Sin serie")))
                    {
                        BiciMontaña miBiciMontaña = new BiciMontaña(cmbColor.Text, cmbRuedas.Text, cmbMarca.Text, (BiciMontaña.NumeroDeSerie)cmbNumeroSerie.SelectedIndex /*cmbAltura.ToString(altura)*/ );
                        miFábrica = miFábrica + miBiciMontaña;
                        MessageBox.Show("Bicicleta del tipo montaña fabricada con exito!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    else
                    {
                        BiciCarrera miBiciCarrera = new BiciCarrera(cmbColor.Text, cmbRuedas.Text, cmbMarca.Text /*cmbAltura.ToString()*/);
                        miFábrica = miFábrica + miBiciCarrera;
                        MessageBox.Show("Bicicleta del tipo carrera fabricada con exito!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    if(biciTipo is Bicicleta.TipoBici.BiciCarrera)
                    {
                        rtbBicisFabricadas.Text = $" Bici carrera: {miFábrica.Mostrar()}";                       
                    }
                    else if(biciTipo is Bicicleta.TipoBici.BiciMontaña)
                    {
                        rtbBicisFabricadas.Text = $"Bici montaña: {miFábrica.Mostrar()}"; 
                    }
                }

                catch(FábricaExcepcion fábricaExcepcion)
                {
                    FrmExcepcion miFrmExcepcion = new FrmExcepcion(fábricaExcepcion);
                    miFrmExcepcion.Location = this.Location;
                    MessageBox.Show($"Error: Exception.", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    miFrmExcepcion.ShowDialog();

                }                               
                btnLimpiar_Click(sender, e);
            }
        }
        /// <summary>
        /// Boton que limpia los atributos combobox y los resetea
        /// </summary>
        private void Limpiar()
        {
            cmbColor.SelectedIndex = -1;
            cmbRuedas.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbNumeroSerie.SelectedIndex = -1;
        }
        /// <summary>
        /// Boton que llama al método limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }                
        /// <summary>
        /// Botón que cierra el 2do form y vuelve al menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmFábrica.miFábrica.Bicicletas = miFábrica.Bicicletas;
            Dispose();
        }
        
    }
}
