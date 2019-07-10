using EntidadesInstanciables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario:Persona 
    {
        private int legajo;

        #region Metodos
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.ToString());
            datos.AppendLine(string.Format("LEGAJO NUMERO: {0}", this.legajo));

            return datos.ToString();

        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (((pg1 is Alumno && pg2 is Alumno) || (pg1 is Profesor && pg2 is Profesor)) && ((pg1.DNI == pg2.DNI) || pg1.legajo == pg2.legajo))
                return true;
            return false;
        }

        public static bool operator !=(Universitario pg1,Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected string ParticiparEnClase()
        {
            return "";
        }

        public Universitario()
        {

        }

        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion
    }
}
