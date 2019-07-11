using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Campos

        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion

        #region Propiedades

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }

            set
            {
                this.paquetes = value;
            }
        }

        #endregion

        public Correo()
        {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }

        public void FinEntregas()
        {
            foreach (Thread hilo in mockPaquetes)
                if (hilo.IsAlive)
                    try
                    {
                        hilo.Abort();
                    }
                    catch(ThreadAbortException e)
                    {

                    }
        }


        public string MostrarDatos(IMostrar<List<Paquete>> paquetes)
        {
            StringBuilder datos = new StringBuilder();
            List<Paquete> lista = ((Correo)paquetes).paquetes;

            foreach (Paquete p in this.paquetes)
                datos.AppendFormat("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());

            return datos.ToString();
        }

        public static Correo operator + (Correo c, Paquete p)
        {
            Thread hilo;

            foreach (Paquete aux in c.paquetes)
            {
                if (aux == p)
                    throw new TrackingIdRepetidoException(string.Format("El tracking ID {0} ya existe",p.TrackingID));
            }
            c.paquetes.Add(p);
            hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            hilo.Start();

            return c;
        }
    }


}
