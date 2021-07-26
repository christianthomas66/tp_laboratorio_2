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
    public partial class FrmMenu : Form
    {
        public Metalurgica misMetales;
        /// <summary>
        /// Constructor de FrmMenu
        /// </summary>
        public FrmMenu()
        {
            InitializeComponent();
            misMetales = new Metalurgica(3);
        }        
        /// <summary>
        /// Boton que accede a la metalurgica de FrmMetalurgica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMetalurgica_Click(object sender, EventArgs e)
        {
            FrmMetalurgica frmMetalurgica = new FrmMetalurgica(misMetales);
            frmMetalurgica.Location = this.Location;
            frmMetalurgica.ShowDialog();            
        }

        /// <summary>
        /// Boton que muestra el listado de Acero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarListaAcero_Click(object sender, EventArgs e)
        {
            FrmListados frmlistados = new FrmListados(misMetales);
            frmlistados.TipoMetal = TipoMetal.Acero;

            frmlistados.Location = this.Location;
            frmlistados.ShowDialog();
        }
        /// <summary>
        /// Boton que muestra el listado de Cobre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarListaCobre_Click(object sender, EventArgs e)
        {
            FrmListados frmlistados = new FrmListados(misMetales);
            frmlistados.TipoMetal = TipoMetal.Cobre;

            frmlistados.Location = this.Location;
            frmlistados.ShowDialog();
        }
        /// <summary>
        /// Boton que muestra el listado de Hierro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarListaHierro_Click(object sender, EventArgs e)
        {
            FrmListados frmlistados = new FrmListados(misMetales);
            frmlistados.TipoMetal = TipoMetal.Hierro;

            frmlistados.Location = this.Location;
            frmlistados.ShowDialog();
        }
        /// <summary>
        /// Boton que cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
