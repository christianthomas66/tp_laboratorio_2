using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BiciCarrera : Bicicleta
    {
        /// <summary>
        /// Constructur por default de BiciCarrera
        /// </summary>
        public BiciCarrera()
        {
                
        }

        /// <summary>
        /// Constructor parametrizado de BiciCarrera que instancia el color, ruedas y marca de las bicicletas de tipo BiciCarrera
        /// </summary>
        /// <param name="color"></param>
        /// <param name="ruedas"></param>
        /// <param name="marca"></param>
        public BiciCarrera(string color, string ruedas, string marca): base(color, ruedas, marca)
        {

        }

        /// <summary>
        /// Muestra los datos de la lista de bicicletas del base
        /// </summary>
        /// <returns> Devuelve el objeto convertido a ToString con todos los datos en formato string </returns>
        protected override string Mostrar()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine($"Los datos de la lista de bicicletas son: {base.Mostrar()}");
            return string1.ToString();
        }

        /// <summary>
        /// Llama a mostrar
        /// </summary>
        /// <returns> Devuelve la instancia llamando al mostrar para mostrar todos los datos del ToString </returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        /// <summary>
        /// Método Equals que se encarga de comparar objetos si son del mismo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> Devuelve un objeto validado verificando que sea realmente un objeto </returns>
        public override bool Equals(object obj)
        {
            return obj is BiciCarrera;
        }
        
    }
}
