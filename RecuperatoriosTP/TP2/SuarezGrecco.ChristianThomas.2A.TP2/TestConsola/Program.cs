using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Christian Thomas Suarez Grecco";
            Metalurgica metalurgica = new Metalurgica(6);
            bool agregado;

            Acero acero1 = new Acero(10, 20, TipoMetal.Acero);
            Acero acero2 = new Acero(20, 30, TipoMetal.Acero);

            Cobre cobre1 = new Cobre(10, 20, TipoMetal.Cobre);
            Cobre cobre2 = new Cobre(20, 30, TipoMetal.Cobre);

            Hierro hierro1 = new Hierro(50, 50, TipoMetal.Hierro);
            Hierro hierro2 = new Hierro(60, 60, TipoMetal.Hierro);

            agregado = metalurgica + acero1;
            agregado = metalurgica + acero2;

            agregado = metalurgica + cobre1;
            agregado = metalurgica + cobre2;

            agregado = metalurgica + hierro1;
            agregado = metalurgica + hierro2;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------ Acero ------");
            Console.WriteLine(metalurgica.MetalPorTipo(TipoMetal.Acero));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------ Cobre ------");
            Console.WriteLine(metalurgica.MetalPorTipo(TipoMetal.Cobre));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------ Hierro ------");
            Console.WriteLine(metalurgica.MetalPorTipo(TipoMetal.Hierro));

            if(agregado)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Se agregaron todos los metales con exito!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"La cantidad de metales a agregar supero la capacidad, solo se agregaron {metalurgica.Capacidad}");
            }

            Console.ReadKey();
        }
    }
}
