using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Entidades;


namespace Entidades
{
    public class DocumentoXML <T> : InterfazGuardar<T>
    {
        /// <summary>
        /// Guarda el objeto xml en la ruta indicada
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="archivoGenerico"></param>
        /// <returns></returns>
        public bool Guardar(string ruta, T archivoGenerico)
        {
            using (XmlTextWriter serializador = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                XmlSerializer serial = new XmlSerializer(typeof(T));
                serial.Serialize(serializador, archivoGenerico);
                return true;
            }
        }
        /// <summary>
        /// Lee los datos de la ruta indicada
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="archivoGenerico"></param>
        /// <returns></returns>
        public bool Leer(string ruta, out T archivoGenerico)
        {
            if(File.Exists(ruta))
            {
                using (XmlTextReader serializador = new XmlTextReader(ruta))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(T));
                    archivoGenerico = (T)serial.Deserialize(serializador);
                }
                return true;
            }
            archivoGenerico = default(T);
            return false;
        }
    }
}
