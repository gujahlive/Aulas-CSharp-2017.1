using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String mes = cbMeses.Text;
            int nMes = cbMeses.SelectedIndex;
            txtMes.Text = (String) Convert.ToString(nMes);
            
            switch (nMes)
            {
                case 1:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 2:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 3:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 4:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 5:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 6:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 7:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 8:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 9:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 10:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 11:
                    txtMes.Text = cbMeses.Text;
                    break;
                case 12:
                    txtMes.Text = cbMeses.Text;
                    break;
                default:
                    txtMes.Text = "Nenhum mes associado";
                    break;
            }
            
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
