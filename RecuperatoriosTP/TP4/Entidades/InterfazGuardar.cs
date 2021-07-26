using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface InterfazGuardar<T>
    {                       
        bool Leer(string ruta, out T aroGenerico);
        bool Guardar(string ruta, T archivoGenerico);        
    }
}
