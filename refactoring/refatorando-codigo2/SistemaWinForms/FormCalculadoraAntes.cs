﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateObservedData
{
    public partial class FormCalculadoraAntes : Form, ICalculadoraObserver
    {
        CalculadoraIMC calculadora;
        public FormCalculadoraAntes()
        {
            InitializeComponent();
            calculadora = new CalculadoraIMC();
            calculadora.Adicionar(this);
        }

        public void ResultadoIMC(double imc)
        {
            txtIMC.Text = $"IMC calculado: {imc:0.00}";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double.TryParse(txtAltura.Text, out double altura);
            double.TryParse(txtPeso.Text, out double peso);

            try
            {
                calculadora.Calcular(altura, peso);
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
