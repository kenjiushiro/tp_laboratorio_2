using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Metodos

        public Universitario()
        {
        }
        
        public Universitario(int legajo,string nombre, string apellido, string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.ToString());
            datos.AppendLine("LEGAJO NÚMERO: " + this.legajo);
            return datos.ToString();
        }

        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            if (pg1.legajo == pg2.legajo)
                return true;
            return false;
        }

        public static bool operator !=(Universitario pg1,Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected abstract string ParticiparEnClase();
        
        #endregion
    }
}
