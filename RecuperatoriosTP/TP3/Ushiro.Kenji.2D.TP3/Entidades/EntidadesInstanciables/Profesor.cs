using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static EntidadesInstanciables.Universidad;

namespace EntidadesInstanciables
{
    public sealed class Profesor:Universitario
    {
        private Queue<EClases> clasesDelDia;
        private static Random random;

        private void _randomClases()
        {
            Array values = Enum.GetValues(typeof(EClases));
            EClases claseRandom = (EClases)values.GetValue(random.Next(values.Length));
            this.clasesDelDia.Enqueue(claseRandom);
            Thread.Sleep(100);
            claseRandom = (EClases)values.GetValue(random.Next(values.Length));
            this.clasesDelDia.Enqueue(claseRandom);
        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.MostrarDatos());
            datos.AppendLine(this.ParticiparEnClase());
            return datos.ToString();
        }

        public static bool operator ==(Profesor i, EClases clase)
        {
            foreach(EClases claseDelDia in i.clasesDelDia)
                if (claseDelDia == clase)
                    return true;
            return false;
        }

        public static bool operator !=(Profesor i,EClases clase)
        {
            return !(i == clase);
        }

        protected new string ParticiparEnClase()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("CLASES DEL DIA ");
            foreach(EClases clase in this.clasesDelDia)
            {
                datos.AppendLine(clase.ToString());
            }
            return datos.ToString();
        }

        static Profesor()
        { 
            random = new Random();
        }

        private Profesor()
        {

        }


        public Profesor(int id,string nombre,string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            clasesDelDia = new Queue<EClases>();
            _randomClases();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
