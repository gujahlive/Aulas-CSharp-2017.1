using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Repetição for

            //for(inicio, ate, salto);
            double dinheiro = 1000.0;
            for (int i = 1; i <= 15; i++) {

                dinheiro = dinheiro + i;
            }

            MessageBox.Show("A quantidade acumulado de dinheiro foi " + dinheiro);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            While wl = new While();

            wl.Show();
            this.Hide();
        }
    }
}
