using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void EventoDelegadoFactura(object sender, EventArgs e);
    public class Fabrica<T> where T : Bicicleta
    {
        protected int stock;
        protected List<T> miListaBicis;
        public event EventoDelegadoFactura EventoFactura;


        /// <summary>
        /// Propiedad del Stock
        /// </summary>
        public int Stock 
        {
            get => stock;
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public int PrecioTotal
        {
            get
            {
                int precioTotal = 0;
                foreach (T item in miListaBicis)
                {
                    precioTotal += (int)item.precio;
                }
                return precioTotal;
            }
        }
        /// <summary>
        /// Propiedad que obtiene y settea la lista de bicicletas
        /// </summary>
        public List<T> Bicicletas
        {
            get => this.miListaBicis;                  
        }
        public List<Bicicleta> Bicicleta 
        { 
            get; 
            set;
        }


        /// <summary>
        /// Constructor que instancia la lista de bicicletas
        /// </summary>
        public Fabrica()
        {
            this.miListaBicis = new List<T>();
        }
        /// <summary>
        /// Constructor que instancia el stock
        /// </summary>
        /// <param name="stock"></param>
        public Fabrica(int stock) : this()
        {            
            this.stock = stock;                     
        }
        /// <summary>
        /// Sobrecarga del == que compara si la bicicleta de la lista en la fábrica no sean nulas
        /// </summary>
        /// <param name="f"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 
        /*
        public static bool operator ==(Fabrica f, Bicicleta b)
        {
            if(!(f is null) && !(b is null))
            {
                foreach (Bicicleta item in f.miListaBicis)
                {
                    if (item == b)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        */
        /// <summary>
        /// Sobrecarga del operador != que verifica que los objetos no sean iguales
        /// </summary>
        /// <param name="f"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /*
        public static bool operator !=(Fabrica f, Bicicleta b)
        {
            return !(f == b);
        }
        */
        /// <summary>
        /// Sobrecarga del + que se encarga de agregar una bicicleta a la lista
        /// </summary>
        /// <param name="f"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fabrica<T> operator +(Fabrica<T>f, Bicicleta b)
        {
            if (f.PrecioTotal > 100)
            {
                f.EventoFactura(f, EventArgs.Empty);
            }
            if (!(f is null) && !(b is null))
            {
                if((b is BiciCarrera) || (b is BiciMontaña))
                {
                    if(f.miListaBicis.Count() < f.stock && f.stock > 0)
                    {
                        f.miListaBicis.Add((T)b);                       
                    }                   
                    else
                    {                        
                        throw new FabricaExcepcion();
                    }
                }
            }
            return f;
        }

        /// <summary>
        /// Método mostrar que se encarga de mostrar la lista entera de bicicletas
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine($"Stock: {this.Stock}");
            string1.AppendLine($"Precio Total: {this.PrecioTotal}");
            foreach(Bicicleta item in Bicicletas)
            {
                string1.Append(item.ToString());
                string1.Append("________________________________________________________________\n");
            }
            return string1.ToString();
        }

        /// <summary>
        /// Método que se encarga de agregar un elemento(bicicletas) la lista de la fábrica
        /// </summary>
        /// <param name="b1"></param>
        /*private void AgregarBicicleta(Bicicleta b1)
        {
            this.miListaBicis.Add((T)b1);
        }*/

        /// <summary>
        /// Método que llama a Mostrar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }        
    }
}
