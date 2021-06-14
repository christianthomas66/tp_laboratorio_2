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
            Fábrica f = new Fábrica(5);
            // Mis 2 bicicletas
            BiciCarrera bici1 = new BiciCarrera("Negro", "Michelin", "scott");
            BiciMontaña bici2 = new BiciMontaña("Blanco", "Scott", "Supra", BiciMontaña.NumeroDeSerie.Serie_1);
            try
            {
                f += bici1;
                f += bici2;               
            }
            catch(FábricaExcepcion fábricaException)
            {
                Console.WriteLine($"Error: {fábricaException.Message} producido en {fábricaException.NombreClase} al usar {fábricaException.NombreMetodo}.");
            }
            catch(FalloLogicaExcepcion fl)
            {
                Console.WriteLine($"Error: {fl.Message} producido en {fl.NombreClase} al usar {fl.NombreMetodo}.");
            }
            Console.WriteLine(f.ToString());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________________");        
            Console.ReadKey();

        }
    }
}
