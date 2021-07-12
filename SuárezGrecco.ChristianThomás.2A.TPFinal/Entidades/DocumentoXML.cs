using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class DocumentoXML : ISerializa, IDeserializa
    {
        public string Path
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path += "//SuarezGrecco.ChristianThomas.BiciMontaña.Xml";
                return path;
            }
        }

        /// <summary>
        /// Guarda el objeto xml en la ruta indicada
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="archivoGenerico"></param>
        /// <returns></returns>
        public bool Xml(List<Bicicleta> biciMontaña)
        {
            try
            {
                using (XmlTextWriter w = new XmlTextWriter(this.Path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(BiciMontaña));

                    ser.Serialize(w, biciMontaña);
                }
            }
            catch (Exception e)
            {
                throw e;
                return false;
            }
            return true;
        }
        /// <summary>
        /// Lee los datos de la ruta indicada
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="archivoGenerico"></param>
        /// <returns></returns>
        public bool Xml(out BiciMontaña biciMontaña)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(this.Path);

                XmlSerializer ser = new XmlSerializer(typeof(BiciMontaña));

                biciMontaña = (BiciMontaña)ser.Deserialize(reader);

                reader.Close();
                return true;
            }
            catch (Exception e)
            {
                biciMontaña = null;
                return false;
            }
        }
    }
}
