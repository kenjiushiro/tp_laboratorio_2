using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region Metodos

        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad): base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }

        public override bool Equals(object obj)
        {
            if(obj is Universitario)
            {
                Universitario aux = (Universitario)obj;
                if (this.DNI == aux.DNI || this.legajo == aux.legajo)
                    return true;
            }
            return false;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ToString());
            datos.AppendLine("LEGAJO NUMERO: " + this.legajo);
            return datos.ToString();
        }

        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            if(pg1.DNI == pg2.DNI && pg1.legajo == pg2.legajo)
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
