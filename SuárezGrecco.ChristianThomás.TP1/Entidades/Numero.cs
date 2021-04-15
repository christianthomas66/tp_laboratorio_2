using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;


namespace Entidades
{
    public class Numero
    {
        #region Atributo
        private double numero;
        #endregion

        #region Propiedades
        /// <summary>
        ///  Otorga un valor (ya validado) al atributo numero
        /// </summary>
        public string SetNumero 
        {
            set
            {
                this.numero = ValidarNumero(value);
            }            
        }        

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por default
        /// </summary>
        public Numero()
        {
            this.numero = 0;          
        }
        /// <summary>
        /// Sobrecarga de constructor en donde se define un numero 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero) 
        {
            this.numero = numero;            
        }
        /// <summary>
        /// Sobrecarga de constructor en donde se define un numero 
        /// </summary>
        /// <param name="num"></param>
        public Numero(string num)
        {
            SetNumero = num;
        }                                    
      
        #endregion

        #region Métodos

        /// <summary>
        /// Valida realmente si el valor recibido sea un numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns> Devuelve un formtato double </returns>
        private double ValidarNumero(string strNumero)
        {
            double numerovalidado = 0;
            double.TryParse(strNumero, out numerovalidado);
            return numerovalidado;
        }
       
        /// <summary>
        /// Comprueba si un valor es binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> Devuelve true o false </returns>
        private bool EsBinario(string binario)
        {
            bool retorno = true;

            foreach(char a in binario)
            {
                if(Regex.IsMatch(binario, "[^01]"))
                {
                    retorno = false;
                }
            }
            return retorno;
        }       

        /// <summary>
        /// Conversion de un numero binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Devuelve el numero binario convertido a decimal,en caso de error, valor inválido</returns>
        public string BinarioDecimal(string binario)
        {
            bool retorno;

            retorno = EsBinario(binario);
            if (retorno)
            {
                char[] arrayBinario = binario.ToCharArray();
                Array.Reverse(arrayBinario);
                double numero = 0;
                for(int i = 0; i < arrayBinario.Length; i++)
                {
                    if(arrayBinario[i] == '1')
                    {
                        if(i == 0)
                        {
                            numero += 1;
                        }
                        else
                        {
                            numero += (int)Math.Pow(2, i);
                        }
                    }
                }
                return numero.ToString();
            }
            else
            {
                return "ERROR! Valor no binario";
            }
        }

        /// <summary>
        /// Conversion de un numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Devuelve un numero decimal convertido a binario </returns>
        public string DecimalBinario(double numero)
        {
            string binario = "";
            int num = (int)numero;

            while(num > 0)
            {
                if(num % 2 == 0)
                {
                    binario = "0" + binario;
                }
                else
                {
                    binario = "1" + binario;
                }
                num = num / 2;
            }
            binario = '0' + binario;
            return binario;
        }

        /// <summary>
        /// Sobrecarga y conversion de un numero decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns> Devuelve un numero decimal convertido a binario </returns>
        public string DecimalBinario(string numero)
        {
            string retorno;
            double num;

            if(double.TryParse(numero, out num))
            {
                retorno = DecimalBinario(num);
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }
       
        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Suma entre 2 nmeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Devuelve resultado de la suma en formato double </returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Resta entre 2 numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Devuelve resultado de la resta en formato double </returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Multiplicación entre 2 numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Devuelve resultado de la multiplicación en formato double </returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// División entre 2 numeros
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns> Devuelve resultado de la división en formato double,
        /// en caso de que el 2do operando sea 0 devuelve double.MinValue </returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
        #endregion
    }
}

