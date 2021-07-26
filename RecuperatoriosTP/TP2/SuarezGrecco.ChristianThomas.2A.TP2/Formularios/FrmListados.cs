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
    public partial class FrmListados : Form
    {

        public Metalurgica misMetales;
        private TipoMetal tipoMetal;

        /// <summary>
        /// Propiedad del Tipo de metal
        /// </summary>
        public TipoMetal TipoMetal
        {
            get
            {
                return this.tipoMetal;
            }
            set
            {
                tipoMetal = value;
            }
        }
        /// <summary>
        /// Constructor de FrmListados
        /// </summary>
        public FrmListados()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor parametrizado de FrmListados que toma los metales de la Metalurgica
        /// </summary>
        /// <param name="metales"></param>
        public FrmListados(Metalurgica metales) : this()
        {
            this.misMetales = metales;
        }
        /// <summary>
        /// Formulario que inicializa con las listas guardadas y a mostrar con cada tipo de metal en un richTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListados_Load(object sender, EventArgs e)
        {
            this.rtbListados.Text = misMetales.MetalPorTipo(this.TipoMetal);
        }
    }
}
