using System;

namespace Entidades
{
    interface IAcciones
    {
        ConsoleColor color
        {
            get;
            set;
        }

        float UnidadesDeEscritura
        {
            get;
            set;
        }

        EscrituraWrapper Escribir();

        bool Recargar(int unidades);

    }
}
