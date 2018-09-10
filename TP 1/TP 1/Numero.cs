using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        public Numero()
        {
            numero= 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numeroA)
        {
            SetNumero(numeroA);
        }


        private string SetNumero(string numeroString)
        {
            double numeroValidado;
            numeroValidado = ValidarNumero(numeroString);
            if (numeroValidado != 0)
                this.numero = numeroValidado;
            return numeroString;
        }

        /// <summary>
        /// Convierte un numero binario en decimal
        /// </summary>
        /// <param name="binario">Numero binario</param>
        /// <returns>Numero convertido a base 10</returns>
        public static string BinarioDecimal(string binario)
        {
            string numeroString = "";
            double numeroDecimal = 0;
            int cantidadDeCifras;
            bool valido;
            valido = double.TryParse(binario, out numeroDecimal);

            if (valido)
            {
                cantidadDeCifras = binario.Length;
                numeroDecimal = 0;
                for (int i = 0; i < cantidadDeCifras; i++)
                {
                    if (binario.ElementAt(i) == '1')
                        numeroDecimal = numeroDecimal + Math.Pow(2, cantidadDeCifras - i - 1);
                    else if(binario.ElementAt(i) != '0')
                        return "Numero invalido";
                }
                numeroString = numeroDecimal + "";
            }
            else
                numeroString = "Numero invalido";
            return numeroString;
        }
        
        /// <summary>
        /// Convierte un numero de decimal a binario
        /// </summary>
        /// <param name="numero">Numero en tipo de dato double</param>
        /// <returns>Numero convertido a binario</returns>
        public static string DecimalBinario(double numero)
        {
            double potencia;
            int contador=0;
            double sumador = 0;
            string numeroEnBinario = "";
            do
            {
                potencia = Math.Pow(2, contador);
                contador++;
            } while (numero >= potencia);

            for(int i=contador-2;i>=0;i--)
            {
                potencia = Math.Pow(2, i);
                if (sumador + potencia <= numero)
                {
                    sumador = sumador + potencia;
                    numeroEnBinario = numeroEnBinario + "1";
                }
                else
                    numeroEnBinario = numeroEnBinario + "0";
                
            }
            return numeroEnBinario;
        }

        /// <summary>
        /// Convierte un numero de decimal a binario
        /// </summary>
        /// <param name="numeroB">Numero en string</param>
        /// <returns>Numero convertido a base 2</returns>
        public static string DecimalBinario(string numeroB)
        {
            bool valido;
            double numeroBase10;
            string numeroConvertido = "Numero invalido";
            valido = double.TryParse(numeroB, out numeroBase10);
            if (valido)
                numeroConvertido = DecimalBinario(numeroBase10);
            return numeroConvertido;
        }

        /// <summary>
        /// Verifica que el string pasado por parametro sea de  tipo numerico
        /// </summary>
        /// <param name="numeroString">String a validar</param>
        /// <returns>Devuelve numero en formato double si es valido, 0 si no lo es</returns>
        private static double ValidarNumero(string numeroString)
        {
            double numeroDecimal;
            bool esValido = false;
            esValido = double.TryParse(numeroString, out numeroDecimal);
            if (esValido)
                return numeroDecimal;
            else
                return 0;
        }

        public static double operator +(Numero num1, Numero num2)
        {
           return num1.numero + num2.numero;
        }

        public static double operator -(Numero num1,Numero num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if (num2.numero != 0)
                return num1.numero / num2.numero;
            else
                return double.MaxValue;
        }
    }
}
