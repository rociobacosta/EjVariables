using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sumando1 = 10;
            int suma2 = 50;
            int suma3 = 40;
            int resultado;

            resultado = sumando1 + suma2 + suma3;

            label1.Text = resultado.ToString();
        }
    }
}
