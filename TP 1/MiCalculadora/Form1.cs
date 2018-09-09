using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Operar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(textBox1.Text);
            Numero num2 = new Numero(textBox2.Text);
            string operador = ComboBoxOperador.Text;
            double resultado;
            resultado = Calculadora.Operar(num1, num2, operador);
            Resultado.Text = resultado + "";
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            ComboBoxOperador.Text = "";
            Resultado.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Salir?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(respuesta == DialogResult.Yes)
                this.Close();
        }

        private void ConvertirABinario_Click(object sender, EventArgs e)
        {
            Resultado.Text = Numero.DecimalBinario(Resultado.Text);
        }

        private void ConvertirADecimal_Click(object sender, EventArgs e)
        {
            Resultado.Text = Numero.BinarioDecimal(Resultado.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
