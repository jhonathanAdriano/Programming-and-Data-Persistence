using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula01EAD
{
    public partial class Form1 : Form
    {
        double valor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            valor = double.Parse(tbTexto.Text) + valor;
            tbResultado.Text = valor.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            valor = valor - double.Parse(tbTexto.Text);
            tbResultado.Text = valor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = valor / double.Parse(tbTexto.Text);
            tbResultado.Text = valor.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            valor = valor * double.Parse(tbTexto.Text);
            tbResultado.Text = valor.ToString();
        }
    }
}
