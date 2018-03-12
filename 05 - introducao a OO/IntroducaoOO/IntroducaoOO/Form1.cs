using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroducaoOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Conta altamirando = new Conta();
            Conta rodopiando = new Conta();

            altamirando.titularConta = "Antonio Carlos Altamirando Junior";
            altamirando.saldo = 500;
            altamirando.codigoConta = 1;

            rodopiando.codigoConta = 2;
            rodopiando.titularConta = "Rodopiando José da Silva";
            rodopiando.saldo = 1000;

            txtCodigoConta.Text = Convert.ToString(altamirando.codigoConta);
            txtTitularConta.Text = altamirando.titularConta;
            txtSaldoConta.Text = Convert.ToString(altamirando.saldo);

            altamirando.Sacar();
            MessageBox.Show("Novo Saldo de altamirando " + altamirando.saldo);

        }
    }
}
