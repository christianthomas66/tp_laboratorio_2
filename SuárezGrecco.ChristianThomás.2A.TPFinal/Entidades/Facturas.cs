using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facturas
    {
        public static bool GenerarFactura(int precio)
        {
            StreamWriter streaWriter = null;
            bool retorno = false;
            try
            {
                streaWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\factura.log", false);
                streaWriter.WriteLine(DateTime.Now + "\n" + precio);
                retorno = true;
            }
            catch (Exception)
            {
            }
            finally
            {
                if (streaWriter != null)
                {
                    streaWriter.Close();
                }
            }
            return retorno;
        }
    }
}
