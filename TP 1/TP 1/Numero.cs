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
            string numeroString;
            double numeroDecimal = 0;
            int cantidadDeCifras;

            numeroDecimal = validarNumero(binario);

            cantidadDeCifras = binario.Length;

            for(int i=0;i<cantidadDeCifras;i++)
            {
                if(binario.ElementAt(cantidadDeCifras) == 1)
                {
                    numeroDecimal = numeroDecimal + Math.Pow(2, cantidadDeCifras-i);
                }
            }
            numeroString = numeroDecimal + "";
            return numeroString;
        }
        

        private double validarNumero(string numeroString)
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
