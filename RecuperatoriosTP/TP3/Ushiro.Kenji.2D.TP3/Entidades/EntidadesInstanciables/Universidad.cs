using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesInstanciables
{
    public class Universidad
    {

        #region Campos

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region  Propiedades

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
                return jornada.ElementAt(i);
            }
            set
            {
                jornada.Insert(i, value);
            }
        }


        #endregion

        #region Metodos

        public Universidad()
        {
            alumnos = new List<Alumno>();
            jornada = new List<Jornada>();
            profesores = new List<Profesor>();

        }

        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Universidad.txt";

            try
            {
                xml.Guardar(path, uni);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static Universidad Leer()
        {
            
            Xml<Universidad> xml = new Xml<Universidad>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Universidad.txt";
            Universidad aux;

            try
            {
                xml.Leer(path,out aux);
                return aux;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private string MostrarDatos(Universidad uni)
        {
            StringBuilder datos = new StringBuilder();
            foreach (Jornada j in uni.jornada)
                datos.AppendLine(j.ToString());
            return datos.ToString();
        }
        
        public static Profesor operator ==(Universidad g,EClases clase)
        {
            foreach(Profesor prof in g.profesores)
                if (prof == clase)
                    return prof;
            throw new SinProfesorException("No hay profesor para la clase");
        }
        
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach (Profesor prof in g.profesores)
                if (prof != clase)
                    return prof;
            throw new SinProfesorException("No hay profesor que no de la clase");
        }

        public static bool operator ==(Universidad g,Alumno a)
        {
            foreach (Alumno al in g.alumnos)
                if (al == a)
                    throw new AlumnoRepetidoException("El alumno ya esta inscripto");
            return false;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor prof in g.Instructores)
                if (prof == i)
                    return true;
            return false;

        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Universidad operator +(Universidad g,EClases clase)
        {
            Profesor p;
            try
            {
                p = (g == clase);

            }
            catch(SinProfesorException e)
            {
                throw e;
            }

            Jornada j = new Jornada(clase, p);

            foreach (Alumno al in g.alumnos)
                if(al==clase)
                    j = j + al;

            g.Jornadas.Add(j);

            return g;
        }              

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if(u!=a)
                u.alumnos.Add(a);
            return u;
        }

        public static Universidad operator +(Universidad u,Profesor i)
        {
            if (u != i)
                u.profesores.Add(i);
            return u;
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion

        public enum EClases
        {
            Programacion,Laboratorio,Legislacion,SPD
        }
    }
}
