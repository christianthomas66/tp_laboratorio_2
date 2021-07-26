using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hierro : Metales
    {
        /// <summary>
        /// Constructor por default de Hierro
        /// </summary>
        public Hierro()
        {
        }
        /// <summary>
        /// Constructor parametrizado de Hierro que instancia los atributos peso, tamanio y TipoMetal
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="tamanio"></param>
        /// <param name="tipoMetal"></param>
        public Hierro(double peso, double tamanio, TipoMetal tipoMetal) : base(peso, tamanio, tipoMetal)
        {
        }
        /// <summary>
        /// Método mostrar que se encarga de mostrar la lista de metales
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine(base.MostrarDatos());
            return string1.ToString();
        }
        /// <summary>
        /// Método que llama a Mostrar
        /// </summary>
        /// <returns> devuelve el metodo MostrarDatos </returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Metodo Equals que comprueba que realmente sea ese objeto a comparar con metales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> el objeto en si comparado </returns>
        public override bool Equals(object obj)
        {
            return (obj is Hierro);
        }
    }
}
