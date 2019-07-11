﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto,string archivo)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\" + archivo;
            StreamWriter sw = new StreamWriter(path, true);
                try
                {
                    sw.WriteLine(texto);
                }
                catch (Exception e)
                {
                }
                finally
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
                return false;
        }

    }
}
