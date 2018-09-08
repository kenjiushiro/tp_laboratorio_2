using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        double numeroDecimal;

        public Numero()
        {
            numeroDecimal = 0;
        }

        public Numero(double numero)
        {
            numeroDecimal = numero;
        }

        public Numero(string numero)
        {
            double.TryParse(numero, out numeroDecimal);
        }

        public static string BinarioDecimal(string binario)
        {
            string numeroString = "";
            double numeroDecimal = 0;
            int cantidadDeCifras;

            numeroDecimal = validarNumero(binario);
            if (numeroDecimal != 0)
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
