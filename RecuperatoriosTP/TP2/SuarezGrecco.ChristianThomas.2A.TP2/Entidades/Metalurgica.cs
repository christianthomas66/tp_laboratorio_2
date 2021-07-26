using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Metalurgica : Metales
    {
        private List<Metales> listaMetales;
        private int capacidad;
        /// <summary>
        /// Propiedad de solo lectura para la lista de meteales
        /// </summary>
        public List<Metales> ListaMetales
        {
            get => this.listaMetales;
        }
        /// <summary>
        /// propiedad de get y set para la capacidad
        /// </summary>
        public int Capacidad
        {
            get => capacidad;
            set
            {
                if (value >= 0)
                {
                    this.capacidad = value;
                }
            }
        }
        /// <summary>
        /// Constructor de Metalurgica que instancia una nueva lista
        /// </summary>
        public Metalurgica()
        {
            this.listaMetales = new List<Metales>();
        }
        /// <summary>
        /// Constructor parametrizado que instancia el atributo capacidad
        /// </summary>
        /// <param name="capacidad"></param>
        public Metalurgica(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        /// <summary>
        /// Método mostrar que se encarga de mostrar la lista de metales
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine("$ Capacidad: " + this.Capacidad);
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
        /// Metodo que recorre la lista y comprueba que lo que se esta mostrando sean metales de TipoMetal
        /// </summary>
        /// <param name="tipoMetal"></param>
        /// <returns> devuelve la lista con su respectivo tipo de metal </returns>
        public string MetalPorTipo(TipoMetal tipoMetal)
        {
            StringBuilder string1 = new StringBuilder();
            foreach(Metales item in listaMetales)
            {
                if(item.TipoMetal == tipoMetal)
                {
                    string1.Append(item.ToString());
                }               
            }
            return string1.ToString();
        }
        /// <summary>
        /// Sobrecarga del == que verifica si un metal de la metalurgica sea igual que si se quiere ingresar ese mismo metal por 2da vez
        /// </summary>
        /// <param name="metalurgica"></param>
        /// <param name="metales"></param>
        /// <returns> devuelve false </returns>
        public static bool operator ==(Metalurgica metalurgica, Metales metales)
        {
            if(!(metalurgica is null) && !(metales is null))
            {
                foreach(Metales item in metalurgica.listaMetales)
                {
                    if(item == metales)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del != que verifica que 2 metales no sean iguales
        /// </summary>
        /// <param name="metalurgica"></param>
        /// <param name="metales"></param>
        /// <returns> devuelve los objetos que no sean iguales </returns>
        public static bool operator !=(Metalurgica metalurgica, Metales metales)
        {
            return !(metalurgica == metales);
        }
        /// <summary>
        /// Sobrecarga del + que agrega elementos a la lista de metales
        /// </summary>
        /// <param name="metalurgica"></param>
        /// <param name="metal"></param>
        /// <returns> devuelve true si se agrego un elemento a la lista </returns>
        public static bool operator +(Metalurgica metalurgica, Metales metal)
        {
            if(!(metalurgica is null) && !(metal is null))
            {                
                if(metalurgica.Capacidad > metalurgica.listaMetales.Count)
                {
                    metalurgica.AgregarMetal(metal);
                    return true;
                }                               
            }
            return false;           
        }
        /// <summary>
        /// Metodo que se utiliza en la sobrecarga del +
        /// </summary>
        /// <param name="metal"></param>
        public void AgregarMetal(Metales metal)
        {
            this.listaMetales.Add(metal);
        }                        
    }
}