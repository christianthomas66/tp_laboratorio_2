using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public class Fábrica
    {
        public List<Bicicleta> miListaBicis;
        public int stock;
        
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
        /// <summary>
        /// Propiedad que obtiene y settea la lista de bicicletas
        /// </summary>
        public List<Bicicleta> Bicicletas 
        { 
            get => this.miListaBicis;
            set 
            {
                this.miListaBicis = value;
            }
        }

        /// <summary>
        /// Constructor que instancia la lista de bicicletas
        /// </summary>
        public Fábrica()
        {
            this.miListaBicis = new List<Bicicleta>();
        }
        /// <summary>
        /// Constructor que instancia el stock
        /// </summary>
        /// <param name="stock"></param>
        public Fábrica(int stock) : this()
        {            
            this.Stock = stock;                     
        }
        /// <summary>
        /// Sobrecarga del == que compara si la bicicleta de la lista en la fábrica no sean nulas
        /// </summary>
        /// <param name="f"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 
        
        public static bool operator ==(Fábrica f, Bicicleta b)
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

        /// <summary>
        /// Sobrecarga del operador != que verifica que los objetos no sean iguales
        /// </summary>
        /// <param name="f"></param>
        /// <param name="b"></param>
        /// <returns></returns>

        public static bool operator !=(Fábrica f, Bicicleta b)
        {
            return !(f == b);
        }
        
        /// <summary>
        /// Sobrecarga del + que se encarga de agregar una bicicleta a la lista
        /// </summary>
        /// <param name="f"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fábrica operator +(Fábrica f, Bicicleta b)
        {
            if(!(f is null) && !(b is null))
            {                                
                    if ((b is BiciCarrera) || (b is BiciMontaña))
                    {
                        f.AgregarBicicleta(b);                        
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
        private void AgregarBicicleta(Bicicleta b1)
        {
            this.miListaBicis.Add(b1);
        }

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
