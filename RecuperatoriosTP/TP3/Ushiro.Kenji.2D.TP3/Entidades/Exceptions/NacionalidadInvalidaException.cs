using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NacionalidadInvalidaException :Exception
    { 
        public NacionalidadInvalidaException(string mensaje) : base(mensaje)
        {

        }
        public NacionalidadInvalidaException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
