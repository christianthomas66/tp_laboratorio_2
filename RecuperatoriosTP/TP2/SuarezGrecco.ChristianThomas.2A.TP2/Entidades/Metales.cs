using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Enumerado de tipos de metal
    /// </summary>
    public enum TipoMetal
    {
        Acero,
        Cobre,
        Hierro
    }
    public abstract class Metales
    {
        private TipoMetal tipoMetal;
        private double peso;
        private double tamanio;

        /// <summary>
        /// propiedad del peso
        /// </summary>
        public double Peso
        {
            get { return this.peso; }
        }
        /// <summary>
        /// propiedad del tamanio
        /// </summary>
        public double Tamanio
        {
            get { return this.tamanio; }
        }

        /// <summary>
        /// propiedad del tipo de metal
        /// </summary>
        public TipoMetal TipoMetal
        {
            get { return this.tipoMetal; }
        }

        /// <summary>
        /// Constructor por default de Metales
        /// </summary>
        public Metales()
        {
        }
        /// <summary>
        /// Constructor parametrizado de Metales que toma los atributos de peso, tamanio y TipoMetal
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="tamanio"></param>
        /// <param name="tipoMetal"></param>
        public Metales(double peso, double tamanio, TipoMetal tipoMetal)
        {
            this.peso = peso;
            this.tamanio = tamanio;
            this.tipoMetal = tipoMetal;
        }

        /// <summary>
        /// Metodo que muestra los atributos de los metales
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine($"Peso: {this.peso}");
            string1.AppendLine($"Tamanio: {this.tamanio}");
            string1.AppendLine($"Tipo Metal: {this.TipoMetal.ToString()}");
            return string1.ToString();
        }

        /// <summary>
        /// Método que llama a Mostrar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        
        /// <summary>
        /// Sobrecarga == que llama a Equals y que compara metales
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns> devuelve un metal ya comparado con los tipos de metal </returns>
        public static bool operator ==(Metales m1, Metales m2)
        {
            return m1.Equals(m2);
        }
        /// <summary>
        /// Sobrecarga != que verifica que 2 metales no sean iguales
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator !=(Metales m1, Metales m2)
        {
            return !(m1 == m2);
        }                        
    }
}
