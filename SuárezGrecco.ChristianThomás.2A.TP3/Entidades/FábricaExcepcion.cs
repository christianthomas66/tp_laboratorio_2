using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FábricaExcepcion : Exception
    {

        private string nombreClase;
        private string nombreMetodo;
        /// <summary>
        /// Propiedad del NombreClase
        /// </summary>
        public string NombreClase { get => this.nombreClase; }
        /// <summary>
        /// Propiedad del NombreMétodo
        /// </summary>
        public string NombreMetodo { get => this.nombreMetodo; }
        /// <summary>
        /// Constructor parametrizado que instancia el mensaje, clase, metodo de la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="clase"></param>
        /// <param name="metodo"></param>
        public FábricaExcepcion(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {
        }
        /// <summary>
        /// Sobrecarga del constructor parametrizado
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="clase"></param>
        /// <param name="metodo"></param>
        /// <param name="excepcion"></param>
        public FábricaExcepcion(string mensaje, string clase, string metodo, Exception excepcion) : base(mensaje, excepcion)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
