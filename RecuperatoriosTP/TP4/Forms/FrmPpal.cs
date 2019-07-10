using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FrmPpal :Form
    {
        Correo correo;


        public FrmPpal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;
            string trackingID = mtxtTrackingID.Text;
            Paquete p = new Paquete(direccion, trackingID);

            try
            {
                correo = correo + p;
            }
            catch(TrackingIdRepetidoException excepcion)
            {
                MessageBox.Show(excepcion.Message, "");
            }

            txtDireccion.Clear();
            mtxtTrackingID.Clear();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {

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
            throw new NotImplementedException();
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
    }
}
