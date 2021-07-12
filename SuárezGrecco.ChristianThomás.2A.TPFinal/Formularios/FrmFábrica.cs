using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;



namespace WindowsFormsApp1
{
    public partial class FrmFábrica : Form
    {
        public static Fábrica miFábrica;
        DocumentoXML<List<Bicicleta>> serializadorFrm;
        List<Bicicleta> miListaXML;
        /// <summary>
        /// Constructor por default del tipo FrmFábrica
        /// </summary>
        public FrmFábrica()
        {
            InitializeComponent();
            miFábrica = new Fábrica(1000);
            serializadorFrm = new DocumentoXML<List<Bicicleta>>();
            miListaXML = new List<Bicicleta>();
        }
        /// <summary>
        /// Botón que inicia el 2do formulario de la fábrica de bicis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabrica_Click(object sender, EventArgs e)
        {
            FrmBicis bicisForm = new FrmBicis(miFábrica);
            bicisForm.Location = this.Location;
            bicisForm.ShowDialog();

        }
        /// <summary>
        /// Botón que cierra el menú principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento que llama a btnCargarXML_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFábrica_Load(object sender, EventArgs e)
        {
            btnCargarXML_Click(sender, e);
        }
        /// <summary>
        /// Botón que guarda los datos en un nuevo documento XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            if(serializadorFrm.Guardar("Bicicletas.xml", miFábrica.Bicicletas))
            {
                MessageBox.Show("Archivo XML guardado con éxito!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        /// <summary>
        /// Evento que carga el documento XML cuando ya hay anteriormente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarXML_Click(object sender, EventArgs e)
        {
            if(File.Exists("Bicicletas.xml"))
            {
                if(serializadorFrm.Leer("Bicicletas.xml", out miListaXML))
                {
                    miFábrica.Bicicletas = miListaXML;
                    MessageBox.Show("Archivo cargado!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
