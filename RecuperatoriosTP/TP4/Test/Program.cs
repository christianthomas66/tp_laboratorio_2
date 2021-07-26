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
            Fabrica<Bicicleta> fabrica = new Fabrica <Bicicleta>(1);
            // Mis 2 bicicletas
            BiciCarrera biciCarrera = new BiciCarrera("Negro", "HED", "Scott");
            BiciMontaña biciMontaña = new BiciMontaña("Blanco", "Supra", "Giant", BiciMontaña.NumeroDeSerie.Serie_1);
            try
            {
                fabrica += biciCarrera;
                fabrica += biciMontaña;               
            }
            catch(FabricaExcepcion fabricaException)
            {
                Console.WriteLine(fabricaException.InformarNovedad());
            }
            catch(FalloConsolaExcepcion fc)
            {
                Console.WriteLine(fc.Message);
            }
            Console.WriteLine(fabrica.ToString());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________");        
            Console.ReadKey();

        }
    }
}
