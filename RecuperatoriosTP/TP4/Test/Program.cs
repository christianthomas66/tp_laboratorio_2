using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Christian Thomás Suárez Grecco";
            // Si cambiamos la capacidad de 1 a 4 no se lanzaría la excepcion
            Fabrica<Bicicleta> fabrica = new Fabrica<Bicicleta>(1);
            // Mis 2 bicicletas
            BiciCarrera biciCarrera = new BiciCarrera("Negro", "HED", "Scott");
            BiciMontaña biciMontaña = new BiciMontaña("Blanco", "Supra", "Giant", BiciMontaña.NumeroDeSerie.Serie_1);
            try
            {
                fabrica += biciCarrera;
                // Al querer agregar la 2da bicicleta se va a generar una excepcion porque se excede la capacidad maxima del stock
                fabrica += biciMontaña;                
            }
            
            catch(FabricaExcepcion fabricaException)
            {
                Console.WriteLine(fabricaException.InformarNovedad());
            }
            
            Console.WriteLine(fabrica.ToString());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________");        
            Console.ReadKey();

        }
    }
}
