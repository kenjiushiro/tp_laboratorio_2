using ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        #region Metodos
        private void _randomClases()
        {
            int numRandom1;
            int numRandom2;
            numRandom1 = random.Next(0, 3);
            Thread.Sleep(100);
            numRandom2 = random.Next(0, 3);
            this.clasesDelDia.Enqueue((Universidad.EClases)numRandom1);
            this.clasesDelDia.Enqueue((Universidad.EClases)numRandom2);
        }
    

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ToString());
            return datos.ToString();
        }

        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach(Universidad.EClases c in i.clasesDelDia)
                if(c==clase)
                    return true;
            return false;
        }

        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append("CLASES DEL DIA ");
            foreach(Universidad.EClases clase in this.clasesDelDia)
                datos.Append(clase.ToString());
            return datos.ToString();
        }

        static Profesor()
        {
            random = new Random();
        }

        private Profesor():base()
        {
            _randomClases();
            
        }

        public Profesor(int id,string nombre, string apellido,string dni, ENacionalidad nacionalidad):this()
        {


        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.ToString());
            datos.AppendLine(this.ParticiparEnClase());
            return datos.ToString();
        } 
        #endregion
    }
}
