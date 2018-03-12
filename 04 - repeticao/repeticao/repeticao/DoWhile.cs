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
    public partial class DoWhile : Form
    {
        public DoWhile()
        {
            InitializeComponent();

            int i = 1;
            do {

                MessageBox.Show("Sua nota é um show! ");
               // txtDoWhile.Text = Convert.ToString(i);
               
                i++;
            } while (i < 5);

        }

        
    }
}
