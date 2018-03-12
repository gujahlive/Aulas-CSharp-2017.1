using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSacar_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.CodigoConta = 0002;
            MessageBox.Show(Convert.ToString(c1.CodigoConta));

          //  c1.NomeAgencia = "Gelton";
            MessageBox.Show(c1.NomeAgencia);


            //c1.titular = "Gelton Cruz";
            c1.Saldo = 1000.00;
          //  c1.codigoConta = 0001;
            txtSaldo.Text = Convert.ToString(c1.Sacar(Convert.ToDouble(txtValor.Text)));

            
        }
    }
}
