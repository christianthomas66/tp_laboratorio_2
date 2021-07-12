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
            Fabrica<Bicicleta> f = new Fabrica <Bicicleta>(1);
            // Mis 2 bicicletas
            BiciCarrera bici1 = new BiciCarrera("Negro", "Michelin", "scott");
            BiciMontaña bici2 = new BiciMontaña("Blanco", "Scott", "Supra", BiciMontaña.NumeroDeSerie.Serie_1);
            try
            {
                f += bici1;
                f += bici2;               
            }
            catch(FabricaExcepcion fabricaException)
            {
                Console.WriteLine(fabricaException.InformarNovedad());
            }
            catch(FalloLogicaExcepcion fl)
            {
                Console.WriteLine(fl.Message);
            }
            Console.WriteLine(f.ToString());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________");        
            Console.ReadKey();

        }
    }
}
