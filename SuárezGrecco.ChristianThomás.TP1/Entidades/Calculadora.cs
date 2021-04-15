using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Métodos de calculadora
        /// <summary>
        /// Valida si lo que se está ingresando sea realmente un operador matematico
        /// </summary>
        /// <param name="operador"></param>
        /// <returns> Devuelve el operador convertido a string y si no es válido devuelve + </returns>
        private static string ValidarOperador(char operador)
        {
            string retorno = "+";

            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = Char.ToString(operador);
            }
            else
            {
                return "+";
            }
            return retorno;
        }
        /// <summary>
        /// Realiza la operacion entre 2 números
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns> Devuelve el resultado de la operacion </returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno = 0;

            while(num1 == null && num2 == null)
            {
                operador = "0";
                operador = ValidarOperador(Convert.ToChar(operador));
            }
            
            if(operador == "+")
            {
                retorno = num1 + num2;
            }

            else if(operador == "-")
            {
                retorno = num1 - num2;
            }
            
            else if(operador == "*")
            {
                retorno = num1 * num2;
            }
            else if(operador == "/")
            {
                retorno = num1 / num2;
            }    
            return retorno;            
        }
        #endregion
    }
}
