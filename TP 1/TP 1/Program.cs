using System;
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
            Numero numeroUno = new Numero(56);
            Numero numeroDos = new Numero(0);
            double resultado;
            resultado = Calculadora.Operar(numeroUno, numeroDos, "/");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
