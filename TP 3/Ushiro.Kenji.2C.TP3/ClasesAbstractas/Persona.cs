using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Campos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades
        public string Apellido
        {
            set
            {

            }
            get
            {

            }
        }

        public int DNI
        {
            get
            {

            }
            set
            {

            }
        }

        public ENacionalidad Nacionalidad
        {
            set
            {

            }
            get
            {

            }
        }

        public string Nombre
        {
            set
            {

            }
            get
            {

            }
        }

        public string StringToDNI
        {
            set
            {

            }
        }
        #endregion

        #region Metodos
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            
        }

        public Persona(string nombre,string apellido,int dni,ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("NOMBRE COMPLETO: " + this.apellido + ", " + this.nombre);
            if (this.nacionalidad == ENacionalidad.Extranjero)
                retorno.AppendLine("NACIONALIDAD: Extranjero");
            else
                retorno.AppendLine("NACIONALIDAD: Argentina");
            return retorno.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato > 99999999 || dato < 1)
                throw (new DniInvalidoException("El DNI no es valido"));
            else if((nacionalidad == ENacionalidad.Argentino && dato > 89999999) ||
                (nacionalidad == ENacionalidad.Extranjero && dato < 90000000))
                throw (new NacionalidadInvalidaException("La nacionalidad no es valida"));
            else
                return dato;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int aux;
            if (dato.Length != 10 || int.TryParse(dato, out aux))
                throw (new DniInvalidoException("El DNI no es valido"));
            else
                return aux;
        }

        private string ValidarNombre(string dato)
        {
            string retorno=dato;

            for(int i=0;i<dato.Length;i++)
            {
                if ((dato.ToCharArray()[i] < 'a' || dato.ToCharArray()[i] > 'z') && (dato.ToCharArray()[i] < 'A' || dato.ToCharArray()[i] > 'Z') && dato.ToCharArray()[i] != ' ')
                {
                    retorno = "asdasd";
                    break;
                }
            }
            return retorno;

        }
        #endregion

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

    }
}
