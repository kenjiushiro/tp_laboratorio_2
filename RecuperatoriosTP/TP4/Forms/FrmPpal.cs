using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace Forms
{
    public partial class FrmPpal :Form
    {
        public Correo correo;


        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;
            string trackingID = mtxtTrackingID.Text;
            Paquete p = new Paquete(direccion, trackingID);

            p.InformaEstado += paq_InformaEstado;
            p.ErrorBaseDeDatos += paq_ErrorBaseDeDatos;

            try
            {
                correo = correo + p;
            }
            catch(TrackingIdRepetidoException excepcion)
            {
                MessageBox.Show(excepcion.Message, "Paquete repetido");
            }

            txtDireccion.Clear();
            mtxtTrackingID.Clear();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            correo = new Correo();
        }


        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                DelegadoEstado de = new DelegadoEstado(paq_InformaEstado);
                this.Invoke(de, new object[] { sender, e });
            }
            else
            {
                ActualizarEstados();
            }
        }

        public void paq_ErrorBaseDeDatos(Object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                DelegadoEstado d = new DelegadoEstado(paq_ErrorBaseDeDatos);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                NotificarErrorBaseDeDatos(sender);
            }
        }

        public void NotificarErrorBaseDeDatos(object sender)
        {
            string trackingPaquete = (((Dictionary<Paquete, Exception>)sender).First()).Key.TrackingID;
            string error = (((Dictionary<Paquete, Exception>)sender).First()).Value.Message;
            string errorString = String.Format("No se pudo insertar el packete: '{0}' en la base de datos: \n\n {1}",
                trackingPaquete, error);

            MessageBox.Show(errorString, "Problema con la base de datos");
        }

        public void MostrarInformacion<T>(IMostrar<T> elementos)
        {

            if (elementos != null)
            {
                Correo correo = (Correo)elementos;
                StringBuilder sb = new StringBuilder();
                foreach (Paquete p in correo.Paquetes)
                {
                    string datos = String.Format("{0} ({1})", p.ToString(), p.Estado.ToString());
                    sb.AppendLine(datos);
                    datos.Guardar("archivo.txt");
                }
                this.rtbMostrar.Text = sb.ToString();
            }
        }

        public void ActualizarEstados()
        {
            this.listBoxEntregado.Items.Clear();
            this.listBoxEnViaje.Items.Clear();
            this.listBoxIngresado.Items.Clear();

            foreach (Paquete p in correo.Paquetes)
            {
                if (p.Estado == Paquete.EEstado.Ingresado)
                    this.listBoxIngresado.Items.Add(p);
                else if (p.Estado == Paquete.EEstado.EnViaje)
                    this.listBoxEnViaje.Items.Add(p);
                else
                    this.listBoxEntregado.Items.Add(p);
            }
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete p = (Paquete)this.listBoxEntregado.SelectedItem;
                this.rtbMostrar.Text = String.Format("{0}", p.ToString());
            }
            catch (Exception)
            {

            }
        }
    }
}
