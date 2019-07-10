using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesInstanciables.Universidad;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region Metodos
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        public static  bool Guardar(Jornada jornada)
        {
            Texto txt = new Texto();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\Jornada.txt";
            try
            {
                txt.Guardar(path, jornada.ToString());
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        public static string Leer()
        {
            string datos;
            Texto txt = new Texto();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Jornada.txt";

            try
            {
                txt.Leer(path, out datos);
                return datos;
            }
            catch(Exception e)
            {
                return "No se pudo leer el archivo";
            }

        }


        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno al in j.alumnos)
                if (al == a)
                    throw new AlumnoRepetidoException("Alumno repetido.");
            return false;
        }

        public static bool operator !=(Jornada j,Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator + (Jornada j,Alumno a)
        {
            try
            {
                if(j!=a)
                {
                    j.alumnos.Add(a);
                }
            }
            catch(AlumnoRepetidoException e)
            {
                throw e;
            }
            return j;
        }


        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("JORNADA:");
            datos.AppendLine(string.Format("CLASE DE {0} POR {1}", this.clase, this.instructor.ToString()));
            datos.AppendLine("ALUMNOS:");

            foreach(Alumno al in this.alumnos)
            {
                datos.AppendLine(al.ToString());
            }
            datos.AppendLine("<------------------------------------------------>");
            return datos.ToString();

        }
        #endregion
    }
}
