using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class EscrituraWrapper
    {
        public ConsoleColor color;
        public string texto;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }

    }
}
