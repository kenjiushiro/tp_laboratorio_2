using Entidades.Serializacion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Texto:IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter sw = new StreamWriter(archivo);
            try
            {
                sw.Write(datos);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
        public bool Leer(string archivo, out string datos)
        {
            StreamReader sr = new StreamReader(archivo);
            datos = "";
            try
            {
                datos = sr.ReadToEnd();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
