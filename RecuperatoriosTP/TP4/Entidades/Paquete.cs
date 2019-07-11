using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoEstado(object sender, EventArgs e);

    public class Paquete : IMostrar<Paquete>
    {
        #region Campos

        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        public event DelegadoEstado InformaEstado;
        public event DelegadoEstado ErrorBaseDeDatos;


        #endregion

        #region Propiedades


        public string DireccionEntrega
        {
            set
            {
                this.direccionEntrega = value;
            }
            get
            {
                return this.direccionEntrega;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }


        #endregion

        #region Metodos

        public void MockCicloDeVida()
        {
            do
            {
                InformaEstado.Invoke(this, null);
                System.Threading.Thread.Sleep(4000);

                this.Estado++;
            } while (this.Estado != EEstado.Entregado);

            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                Dictionary<Paquete, Exception> paqueteException = new Dictionary<Paquete, Exception>()
                {
                    {this, e}
                };
                ErrorBaseDeDatos.Invoke(paqueteException, null);
            }

            InformaEstado.Invoke(this, null);
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            StringBuilder datos = new StringBuilder(string.Format("{0} para {1}", p.TrackingID, p.DireccionEntrega));

            return datos.ToString();
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if(p1.trackingID == p2.trackingID)
                return true;
            return false;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
            this.estado = EEstado.Ingresado;
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

    }



}
