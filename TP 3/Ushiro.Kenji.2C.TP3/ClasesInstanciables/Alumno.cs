using ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        Universidad.EClases claseQueToma;
        EEstadoCuenta estadoCuenta;

        #region Metodos
        public Alumno()
        {
        }
        
        public Alumno(int id, string nombre,string apellido, string dni,ENacionalidad nacionalidad, Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma,EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ToString());
            datos.AppendLine("ESTADO DE CUENTA: " + estadoCuenta);
            datos.AppendLine("TOMA CLASES DE " + claseQueToma);
            return datos.ToString();
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.estadoCuenta != EEstadoCuenta.Deudor && a.claseQueToma == clase)
                return true;
            return false;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma != clase)
                return true;
            return false;
        }
        
        #endregion

        public enum EEstadoCuenta
        {
            AlDia,Deudor,Becado
        }

        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE " + this.claseQueToma.ToString();
        }
        
        
    }
}
