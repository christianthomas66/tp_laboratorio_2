using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FalloLogicaExcepcion : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        /// <summary>
        /// Obtiene el nombre de la clase
        /// </summary>
        public string NombreClase{ get => this.nombreClase;}
        /// <summary>
        /// Obtiene el nombre del método
        /// </summary>
        public string NombreMetodo{ get => this.nombreMetodo;}
        /// <summary>
        /// Crea una excepción de FalloLogicaException
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="clase"></param>
        /// <param name="metodo"></param>
        public FalloLogicaExcepcion(string mensaje, string clase, string metodo): this(mensaje, clase, metodo, null)
        {
        }
        /// <summary>
        /// Crea una excepción de FalloLogicaException
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="clase"></param>
        /// <param name="metodo"></param>
        /// <param name="excepcion"></param>
        public FalloLogicaExcepcion(string mensaje, string clase, string metodo, Exception excepcion): base(mensaje, excepcion)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
