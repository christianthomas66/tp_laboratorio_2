using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructor
        /// <summary>
        /// Constructor parametrizado inicializa ciclomotor con constructor de base Vehiculo 
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="chasis">Chasis a asignar</param>
        /// <param name="color">Color a asignar</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        #endregion

        #region Propiedad
        /// <summary>
        /// Retorna el tamaño del Ciclomotor,  los ciclomotor son 'Chico' de tamaño.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
               return ETamanio.Chico;
            }
        }
        #endregion

        #region Método
        /// <summary>
        /// Muestra todos los datos de vehiculo y ciclomotor
        /// </summary>
        /// <returns>string con datos</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CICLOMOTOR\n");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendFormat("\n---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
