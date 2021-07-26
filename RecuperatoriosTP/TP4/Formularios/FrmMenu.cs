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
using Formularios;
using Entidades;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmMenu : Form
    {
        public static Fabrica<Bicicleta> miFabrica;               
        DocumentoXML serializadorFrm;
        List<BiciMontaña> miListaXML;
        
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataTable dt;
                
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
        /// Botón que guarda los datos en un nuevo documento XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Bicicleta item in miFabrica.Bicicleta)
                {
                    if(item is BiciMontaña)
                    {
                        miListaXML.Add((BiciMontaña)item);
                    }
                }
                if(miListaXML.Count != 0 && serializadorFrm.Xml(miListaXML))
                {
                   MessageBox.Show("Archivo XML guardado con éxito!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No hay bicis del tipo montaña para serializar!!!");
                }
            }
            catch(Exception excepcion)
            {
                MessageBox.Show("No se pudo serializar el archivo!!! : " + excepcion.Message);
            }                        
        }                         
    }
}
