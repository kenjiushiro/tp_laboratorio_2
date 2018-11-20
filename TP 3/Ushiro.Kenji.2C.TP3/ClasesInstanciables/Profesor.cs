using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private Random random;

        #region Metodos
        private Profesor()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
        }

        public Profesor(int id, string nombre,string apellido,string dni,ENacionalidad nacionalidad): base(id,nombre,apellido,dni,nacionalidad)
        {

        }

        private void _randomClase()
        {

        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder(base.ToString());
            datos.AppendLine("CLASES DEL DIA:");
            foreach(Universidad.EClases clase in this.clasesDelDia)
            {
                datos.AppendLine(clase.ToString());
            }
            datos.AppendLine(this.ParticiparEnClase());

            return datos.ToString();
        }

        public static bool operator ==(Profesor i,Universidad.EClases clase)
        {
            if(i.clasesDelDia.Count > 0)
                foreach (Universidad.EClases cl in i.clasesDelDia)
                    if (cl == clase)
                        return true;
            return false;
        }

        public static bool operator !=(Profesor i,Universidad.EClases clase)
        {
            return !(i == clase);
        }
        
        protected override string ParticiparEnClase()
        {
            StringBuilder clasesQueDa = new StringBuilder("CLASES DEL DIA ");
            foreach (Universidad.EClases cl in this.clasesDelDia)
                clasesQueDa.Append(cl.ToString() + ", ");
            return clasesQueDa.ToString();
        }
        #endregion
    }
}
