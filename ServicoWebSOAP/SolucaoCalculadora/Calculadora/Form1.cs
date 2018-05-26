using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            ServicoWeb.ServicoWebClient proxy = new ServicoWeb.ServicoWebClient();

            txtResultado.Text = (proxy.soma(Convert.ToDouble(txtNum1.Text), Convert.ToDouble(txtNum2.Text))).ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            ServicoWeb.ServicoWebClient proxy = new ServicoWeb.ServicoWebClient();

            txtResultado.Text = (proxy.subtracao(Convert.ToDouble(txtNum1.Text), Convert.ToDouble(txtNum2.Text))).ToString();
        }
    }
}
