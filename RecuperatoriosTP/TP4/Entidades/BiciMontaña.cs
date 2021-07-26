using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class BiciMontaña : Bicicleta
    {
        private NumeroDeSerie numeroDeSerie;                
        /// <summary>
        /// Propiedad del enum que obtiene y settea el enumerado
        /// </summary>
        public override string Serie
        {
            get 
            {                
                return Enum.GetName(typeof(NumeroDeSerie), this.numeroDeSerie); 
            }            
        }        
        /// <summary>
        /// Constructor por default de BiciMontaña
        /// </summary>
        public BiciMontaña()
        {

        }
        /// <summary>
        /// Constructor parametrizado de BiciMontaña que instancia el color, ruedas y marca de las bicicletas de tipo BiciMontaña
        /// </summary>
        /// <param name="color"></param>
        /// <param name="ruedas"></param>
        /// <param name="marca"></param>
        /// <param name="numeroDeSerie"></param>
        public BiciMontaña(string color, string ruedas, string marca, NumeroDeSerie numeroDeSerie): base(color, ruedas, marca)            
        {
            this.numeroDeSerie = numeroDeSerie;           
        }

        /// <summary>
        /// Método mostrar que muestra todos los datos del base, incluyendo el enumerado del tipo BiciMontaña
        /// </summary>
        /// <returns> Devuelve el objeto convertido a ToString con todos los datos en formato string </returns>
        protected override string Mostrar()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine($"La bicicleta fabricada es:\nBicicleta Montaña y sus datos son: {base.Mostrar()}");                        
            string1.AppendLine($"Su numero de serie es: {this.numeroDeSerie}");
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
            return (obj is BiciMontaña);
        }        
    }
}
