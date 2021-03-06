﻿using System;
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
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        Numero num1;
        Numero num2;
        string operador;
        double resultado;

        private void btnOperar_Click(object sender, EventArgs e)
        {
            num1.SetNumero = txtNumero1.Text;
            num2.SetNumero = txtNumero2.Text;
            operador = cmbOperador.Text;
            resultado = Calculadora.Operar(num1, num2, operador);
            lblResultado.Text = resultado + "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { 
            Limpiar();
        }

        private void Limpiar()
        {
            cmbOperador.Text = "";
            lblResultado.Text = "";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
        }            

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Salir?", "Continuar", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(respuesta == DialogResult.Yes)
                this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num1 = new Numero(txtNumero1.Text);
            num2 = new Numero(txtNumero2.Text);
        }
    }
}
