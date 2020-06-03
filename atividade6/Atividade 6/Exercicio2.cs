using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n = Convert.ToInt32(boxN.Text);
            double h = 1;
            
            for(i=2; i <= n; i++)
            {
                h += 1.0 / i;
            }
            MessageBox.Show("H = " + h.ToString("N2"));
        }

        private void Exercicio2_Load(object sender, EventArgs e) {

        }
    }
}
