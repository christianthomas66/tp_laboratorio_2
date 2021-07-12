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
    public partial class FrmMenu : Form
    {
        public static Fabrica<Bicicleta> miFabrica;
        private BiciCarrera biciCarrera;
        private BiciMontaña biciMontaña;
        DocumentoXML serializadorFrm;
        List<BiciMontaña> miListaXML;
        /// <summary>
        /// Constructor por default del tipo FrmMenu
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            miFabrica = new Fabrica<Bicicleta>(3);
            serializadorFrm = new DocumentoXML();
            miListaXML = new List<BiciMontaña>();
        }
        /// <summary>
        /// Botón que inicia el 2do formulario de la fábrica de bicis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFabrica_Click(object sender, EventArgs e)
        {
            FrmBicis bicisForm = new FrmBicis(miFabrica);
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
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //btnCargarXML_Click(sender, e);
        }
        /// <summary>
        /// Botón que guarda los datos en un nuevo documento XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            if(serializadorFrm.Xml(miFabrica.Bicicleta))
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
            /*if (File.Exists("Bicicletas.xml"))
            {
                if(serializadorFrm.Xml(out miListaXML))
                {
                    miFabrica.Bicicleta = miListaXML;
                    MessageBox.Show("Archivo cargado!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }*/
            /*
            BiciMontaña aux = null;

            if (this.serializadorFrm.Xml())
            {
                MessageBox.Show("Bicicleta del tipo montaña serializado OK");
            }
            else
            {
                MessageBox.Show("Bicicleta del tipo montaña NO serializado");
            }

            if (((IDeserializa)this.biciMontaña).Xml(out aux))
            {
                MessageBox.Show("Bicicleta del tipo montaña deserializado OK");
                MessageBox.Show(aux.ToString());
            }
            else
            {
                MessageBox.Show("Bicicleta del tipo montaña NO deserializado");
            }
            */
        }

        private void btnCargarSQL_Click(object sender, EventArgs e)
        {
          
        }
    }
}
