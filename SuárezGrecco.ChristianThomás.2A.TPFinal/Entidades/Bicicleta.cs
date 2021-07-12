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
    [XmlInclude(typeof(BiciMontaña))]   
    public abstract class Bicicleta
    {                
        
        private string color;
        private string ruedas;
        private string marca;
        public double precio;

        /// <summary>
        /// Enumerados
        /// </summary>
        public enum TipoBici
        {
            BiciCarrera,
            BiciMontaña,            
        }

        /// <summary>
        /// Propiedad que obtiene y settea el color
        /// </summary>
        public string Color { get{return this.color;} set{this.color = value;}}
        /// <summary>
        /// Propiedad que obtiene y settea las ruedas
        public string Ruedas { get{return this.ruedas;} set{this.ruedas = value;}}
        /// <summary>
        /// Propiedad que obtiene la marca
        /// </summary>
        public string Marca {get {return this.marca;} set{this.marca = value;}}

        /// <summary>
        /// Constructor por default de Bicicleta
        /// </summary>
        public Bicicleta()
        {
                
        }
        /// <summary>
        /// Constructor parametrizado que instancia el color, ruedas y marca de las bicicletas
        /// </summary>
        /// <param name="color"></param>
        /// <param name="ruedas"></param>
        /// <param name="marca"></param>
        public Bicicleta(string color, string ruedas, string marca) : this()
        {
            this.color = color;
            this.ruedas = ruedas;
            this.marca = marca;            
        }
        /// <summary>
        /// Sobrecarga del operador == que llama a Equals
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public static bool operator ==(Bicicleta b1, Bicicleta b2)
        {
            return b1.Equals(b2);
        }
        /// <summary>
        /// Sobrecarga del operador != que verifica que los objetos no sean iguales
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public static bool operator !=(Bicicleta b1, Bicicleta b2)
        {
            return !(b1 == b2);
        }
        
        /// <summary>
        /// Método mostrar que muestra todos los datos de los colores, ruedas y marcas de las bicicletas
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            StringBuilder string1 = new StringBuilder();

            string1.AppendLine($"\nColor : {this.color}");
            string1.AppendLine($"Ruedas : {this.ruedas}");
            string1.AppendLine($"Marca: {this.marca}");

            return string1.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }        
    }
}
