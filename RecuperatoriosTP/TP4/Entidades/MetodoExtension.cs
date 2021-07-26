using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtension
    {
        /// <summary>
        /// Metodo de extension estatico que se encarga de informar que la capacidad de elementos se supero
        /// </summary>
        /// <param name="fabricaLlena"></param>
        /// <returns></returns>
        public static string InformarNovedad(this FabricaExcepcion fabricaLlena)
        {
            string mensaje = "Se ha superado la cantidad maxima de la fabrica";

            return mensaje;
        }
        /// <summary>
        /// Sobrecarbar del metodo de extension estatico que se encarga de informar que la capacidad de elementos se supero con un string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>       
        public static string InformarNovedad(string str)
        {
            string mensaje = "Se ha superado la cantidad maxima de la fabrica de " + str;
            return mensaje;
        }
    }
}
