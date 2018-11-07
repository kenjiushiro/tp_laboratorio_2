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
        private List<Profesor> profesores;
        private List<Jornada> jornadas;

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
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        public Jornada this [int i]
        {
            get
            {
                return this.jornadas.ElementAt(i);
            }
            set
            {
                this.jornadas.Insert(i, value);
            }
        }
        #endregion  

        public enum EClases
        {
            Programacion,Laboratorio,Legislacion,SPD
        }
    }
}
