using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class BiciCarrera : Bicicleta
    {
        /// <summary>
        /// Propiedad de bicicleta sin serie
        /// </summary>
        public override string Serie
        {
            get
            {
                return "Sin_serie";
            }  
        }

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
        public BiciCarrera(string color, string ruedas, string marca) : base(color, ruedas, marca)
        {
            this.factura = (int)NumeroDeSerie.Sin_serie;
        }

        /// <summary>
        /// Muestra los datos de la lista de bicicletas del base
        /// </summary>
        /// <returns> Devuelve el objeto convertido a ToString con todos los datos en formato string </returns>
        protected override string Mostrar()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine($"La bicicleta fabricada es:\nBicicleta Carrera y sus datos son: {base.Mostrar()}");
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
