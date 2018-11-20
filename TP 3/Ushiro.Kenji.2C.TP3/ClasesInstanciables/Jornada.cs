using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
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

        public Universidad.EClases Clase
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

        public Jornada(Universidad.EClases clase, Profesor instructor)
        {
            this.clase = clase;
            this.instructor = instructor;
        }



        public static bool Guardar(Jornada jornada)
        {
            return true;
        }

        public string Leer()
        {
            return "asd";
        }

        public static bool operator ==(Jornada j ,Alumno a)
        {
            foreach (Alumno al in j.alumnos)
                if (al == a)
                    return true;
            return false;
        }

        public static bool operator !=(Jornada j,Alumno a)
        {
            return !(j == a);
        }

        public static Jornada  operator +(Jornada j,Alumno a)
        {
            if (j != a)
                j.alumnos.Add(a);
            return j;
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("CLASE DE " + this.clase + " POR NOMBRE COMPLETO: " + this.instructor);
            datos.AppendLine(this.instructor.ToString());
            foreach(Alumno al in this.alumnos)
                datos.AppendLine(al.ToString());

            return datos.ToString();           
        }



        #endregion  
    }
}
