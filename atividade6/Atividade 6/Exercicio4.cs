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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salBruto, gratificacao = 0;
            int b = 0, c = 0, d = 0;

            if (double.TryParse(boxSalario.Text, out double salario) && double.TryParse(boxGratif.Text, out gratificacao) &&
                int.TryParse(boxProd.Text, out int prod))
            {
                if (prod >= 100) b = 1;
                if (prod >= 120) c = 1;
                if (prod >= 150) d = 1;
                salBruto = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
                if (salBruto > 7000)
                {
                    if (prod < 150 || gratificacao == 0) salBruto = 7000.00;
                }
                MessageBox.Show("O Salário Bruto R$: " + salBruto.ToString("N2"));
            }
            else
                MessageBox.Show("Dados inválidos!");
        }

        private void Exercicio4_Load(object sender, EventArgs e) {

        }
    }
}
