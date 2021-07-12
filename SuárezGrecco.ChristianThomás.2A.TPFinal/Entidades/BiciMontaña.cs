using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BiciMontaña : Bicicleta
    {
        private NumeroDeSerie numeroDeSerie;
        /// <summary>
        /// Enumerados
        /// </summary>
        public enum NumeroDeSerie{Sin_serie, Serie_1, Serie_2, Serie_3}

        /// <summary>
        /// Propiedad del enum que obtiene y settea el enumerado
        /// </summary>
        public NumeroDeSerie Serie
        {
            get { return this.numeroDeSerie; }
            set { this.numeroDeSerie = value; }
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
            string1.AppendLine("Bici Montaña: ");
            string1.AppendLine($"Los datos de la lista de bicicletas son: {base.Mostrar()}");
            string1.AppendLine($"Los numeros de serie son: {this.numeroDeSerie}");

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
