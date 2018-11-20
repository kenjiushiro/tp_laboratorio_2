using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T>:IArchivo<T>
    {
        public bool Guardar(string archivo, T datos)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            XmlTextWriter writer;

            if (!System.IO.File.Exists(archivo))
            {
                System.IO.Directory.CreateDirectory(archivo);
            }

            writer = new XmlTextWriter(archivo, System.Text.Encoding.Default);

            ser.Serialize(writer, datos);
            writer.Close();
            return true;
        }

        public bool Leer(string archivo, out T datos)
        {
            XmlSerializer deser = new XmlSerializer(typeof(T));
            XmlTextReader reader = new XmlTextReader(archivo);
            if (!deser.CanDeserialize(reader))
            {
                datos = default(T);
                return false;
            }
            else
                datos = (T)deser.Deserialize(reader);
            return true;
        }
    }
}
