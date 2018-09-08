using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
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
            numeroValidado = validarNumero(numeroString);
            if (numeroValidado != 0)
                this.numero = numeroValidado;
            return numeroString;
        }
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
            } while (numero > potencia);

            for(int i=contador-2;i>=0;i--)
            {
                potencia = Math.Pow(2, i);
                if (sumador + potencia <= numero)
                {
                    sumador = sumador + potencia;
                    numeroEnBinario = numeroEnBinario + "1";
                }
                else
                {
                    numeroEnBinario = numeroEnBinario + "0";
                }
            }
            return numeroEnBinario;
        }

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

        private static double validarNumero(string numeroString)
        {
            double numeroDecimal;
            bool esValido = false;
            esValido = double.TryParse(numeroString, out numeroDecimal);
            if (esValido)
                return numeroDecimal;
            else
                return 0;
        }

    }
}
