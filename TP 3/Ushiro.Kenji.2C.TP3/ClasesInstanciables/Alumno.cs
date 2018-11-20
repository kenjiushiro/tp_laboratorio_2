using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;



        #region Metodos
        public Alumno()
        {

        }

        public Alumno(int id,string nombre,string apellido,string dni,Persona.ENacionalidad nacionalidad,Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.MostrarDatos());
            switch(this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    datos.AppendLine("ESTADO DE CUENTA: Cuota al dia");
                    break;
                case EEstadoCuenta.Becado:
                    datos.AppendLine("ESTADO DE CUENTA: Becado");
                    break;
                case EEstadoCuenta.Deudor:
                    datos.AppendLine("ESTADO DE CUENTA: Deudor");
                    break;
            }

            datos.AppendLine(this.ParticiparEnClase());
            return datos.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder clase = new StringBuilder("TOMA CLASES DE" + claseQueToma.ToString());
            return clase.ToString();
        }

        #endregion
        public enum EEstadoCuenta
        {
            AlDia,Deudor,Becado
        }
    }
}
