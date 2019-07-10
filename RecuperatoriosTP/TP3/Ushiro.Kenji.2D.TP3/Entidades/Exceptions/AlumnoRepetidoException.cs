using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnoRepetidoException :Exception
    {
        public AlumnoRepetidoException(string mensaje) : base(mensaje)
        {

        }
        public AlumnoRepetidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
