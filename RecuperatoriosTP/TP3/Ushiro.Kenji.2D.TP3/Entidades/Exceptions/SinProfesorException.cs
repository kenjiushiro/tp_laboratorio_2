using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SinProfesorException:Exception
    {
        public SinProfesorException(string mensaje) : base(mensaje)
        {

        }
        public SinProfesorException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }

    }
}
