﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroEnBinario = "0";
            string binario;
            string numero = "123";
            string numeroEnDecimal;
            numeroEnDecimal = Numero.BinarioDecimal(numeroEnBinario);
            binario = Numero.DecimalBinario(numero);
            Console.WriteLine(Numero.BinarioDecimal(numeroEnBinario));
            Console.WriteLine(binario);
            Console.ReadKey();
        }
    }
}
