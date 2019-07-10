using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosException:Exception
    {
        public ArchivosException(string mensaje) : base(mensaje)
        {

        }
        public ArchivosException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
