using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto:IArchivo<string>
    {
        bool IArchivo<string>.Guardar(string archivo, string datos)
        {
            StreamWriter file = new StreamWriter(archivo);
            file.Write(datos);
            file.Close();
            return true;
        }

        bool IArchivo<string>.Leer(string archivo, out string datos)
        {
            string text;
            StreamReader file = new StreamReader(archivo);
            text = file.ReadToEnd();
            file.Close();
            datos = text;
            return true;
        }
    }
}
