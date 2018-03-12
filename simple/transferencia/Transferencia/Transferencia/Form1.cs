using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Saldo = 1000;
            int valor = Convert.ToInt32(txtValor.Text);
            txtSaldo.Text = Convert.ToString(c1.Sacar(valor));

        }
    }
}
