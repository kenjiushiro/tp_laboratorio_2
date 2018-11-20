using Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

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

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornada.ElementAt(i);
            }
            set
            {
                this.jornada.Insert(i, value);
            }
        }



        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }
        #endregion

        #region Metodos                       

        public static bool Guardar(Universidad uni)
        {
            return true;
        }
            


        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        private string MostrarDatos(Universidad uni)
        {
            return "asd";
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno al in g.Alumnos)
                if (al == a)
                    return true;
            return false;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }


        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor p in g.profesores)
                if (p == i)
                    return true;
            return false;
        }

        public static bool operator !=(Universidad g,Profesor i)
        {
            return !(g == i);
        }

        public static bool operator ==(Universidad u, EClases clase)
        {
            foreach (Jornada j in u.jornada)
                if (j.Clase == clase)
                    return true;
            return false;
        }

        public static bool operator !=(Universidad u,EClases clase)
        {
            return !(u == clase);
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
                u.alumnos.Add(a);
            return u;
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
                u.profesores.Add(i);
            return u;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j;
            foreach(Profesor p in g.Instructores)
            {
                if(p==clase)
                {
                    j = new Jornada(clase,p);
                    g.Jornadas.Add(j);
                }
            }

            return g;
        }

        public override string ToString()
        {
            return base.ToString(); 
        }



        #endregion

    }
}
