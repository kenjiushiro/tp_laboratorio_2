using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {

        #region Campos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion


        #region Metodos
        public Persona()
        {
        }


        public Persona(string nombre, string apellido,ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        public Persona(string nombre,string apellido,int dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }
        
        public Persona(string nombre,string apellido,string dni,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni + "";
        }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(string.Format("NOMBRE COMPLETO: {0}, {1} ",this.apellido,this.nombre ));
            datos.AppendLine(string.Format("NACIONALIDAD: {0}", this.nacionalidad));

            return datos.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad,int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato < 1 || dato > 89999999)
                    throw new NacionalidadInvalidaException("La nacionalidad no es valida");
            }
            else if(nacionalidad == ENacionalidad.Extranjero)
            {
                if(dato< 90000000 || dato> 99999999)
                    throw new NacionalidadInvalidaException("La nacionalidad no es valida");
            }
            return dato;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            bool parseado = int.TryParse(dato, out dni);
            if (!parseado)
                throw new Entidades.DniInvalidoException("El DNI no es valido");

            dni = ValidarDni(nacionalidad, dni);

            return dni;
        }

        private string ValidarNombreApellido(string dato)
        {
            bool valido = Regex.IsMatch(dato, @"^[a-zA-Z ]+$");
            if (valido)
                return dato;
            else
                return "";
        }

        #endregion  


        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
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
                this.dni =ValidarDni(this.nacionalidad,value);
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni( this.nacionalidad,value);
            }
        }
        #endregion


        public enum ENacionalidad
        {
            Argentino,Extranjero
        }
    }
}
