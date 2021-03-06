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

namespace WindowsFormsApp1
{
    public partial class FrmExcepcion : Form
    {
        /// <summary>
        /// Crea una excepcion de FrmExcepcion
        /// </summary>
        /// <param name="fábricaExcepcion"></param>
        public FrmExcepcion(FabricaExcepcion fábricaExcepcion)
        {
            InitializeComponent();
            StringBuilder string1 = new StringBuilder();
            DateTime string2 = DateTime.Now;
            string1.AppendLine($"Error: {fábricaExcepcion.Message} producido en al usar .");
            string1.AppendLine($"Source: {fábricaExcepcion.Source}");
            string1.AppendLine($"Método: {fábricaExcepcion.TargetSite}");
            string1.AppendLine($"InnerException: {fábricaExcepcion.InnerException}");

            richTextBoxExcepcion.Text = string1.ToString();
            LblDatoExcepcion.Text = string2.ToString();
        }
        /// <summary>
        /// Botón de ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }                        
    }
}
