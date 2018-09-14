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
            Numero asd = new Numero();
            asd.SetNumero = "5";
            Numero dsa = new Numero(20);
            double x = asd + dsa;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
