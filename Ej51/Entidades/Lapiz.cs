using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class Lapiz : IAcciones
    {
        private float tamanioMina;

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }


    }
}
