using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
                                                        
        #region Propiedades
        public string Apellido
        {
            set
            {
                this.apellido = value;
            }
            get
            {
                return this.apellido;
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public ENacionalidad Nacionalidad
        {
            set
            {
                this.nacionalidad = value;
            }
            get
            {
                return this.nacionalidad;
            }
        }

        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = int.Parse(value);
            }
        }
        #endregion                                     
                                                        
        #region Metodos                                 
        public Persona()
        {
        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre,string apellido,int dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
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

        private string ValidarNombreApellido(string dato)
        {
            string retorno=dato;

            for(int i=0;i<dato.Length;i++)
            {
                if ((dato.ToCharArray()[i] < 'a' || dato.ToCharArray()[i] > 'z') && (dato.ToCharArray()[i] < 'A' || dato.ToCharArray()[i] > 'Z') && dato.ToCharArray()[i] != ' ')
                {
                    retorno = "";
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
