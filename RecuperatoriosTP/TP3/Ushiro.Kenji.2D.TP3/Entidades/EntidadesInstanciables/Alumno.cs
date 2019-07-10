using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntidadesInstanciables.Universidad;

namespace EntidadesInstanciables
{
    public sealed class Alumno:Universitario
    {
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {
        }

        public Alumno(int id, string nombre, string apellido, string dni,ENacionalidad nacionalidad,EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id,string nombre, string apellido, string dni, ENacionalidad nacionalidad,EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine(base.MostrarDatos());

            datos.Append("ESTADO DE CUENTA: ");
            switch(this.estadoCuenta)
            {
                case (EEstadoCuenta.AlDia):
                    datos.AppendLine("Cuota al dia");
                    break;
                case (EEstadoCuenta.Becado):
                    datos.AppendLine("Becado");
                    break;
                case (EEstadoCuenta.Deudor):
                    datos.AppendLine("Debe cuota");
                    break;
            }
            datos.AppendLine(this.ParticiparEnClase());
            return datos.ToString();
        }

        public static bool operator ==(Alumno a,EClases clase)
        {
            if (a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase)
                return true;
            return false;
        }

        public static bool operator !=(Alumno a,EClases clase)
        {
            if (a.claseQueToma != clase)
                return true;
            return false;
        }

        protected new string ParticiparEnClase()
        {
            return string.Format("TOMA CLASE DE {0}", this.claseQueToma.ToString());
        } 

        public override string ToString()
        {
            return this.MostrarDatos();
        }




        public enum EEstadoCuenta
        {
            AlDia,Deudor,Becado
        }
    }
}
