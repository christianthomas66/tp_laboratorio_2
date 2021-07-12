using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtension
    {
        public static string InformarNovedad(this FabricaExcepcion fabricaLlena)
        {
            string mensaje = "Se ha superado la cantidad maxima de la fabrica";

            return mensaje;
        }

        public static string InformarNovedad(string str)
        {
            string mensaje = "Se ha superado la cantidad maxima de la fabrica de " + str;
            return mensaje;
        }
    }
}
