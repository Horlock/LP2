using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade2
{
    public partial class CalculaPesoIdeal : Form
    {
        public CalculaPesoIdeal()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;

            if (double.TryParse(txtPeso.Text, out peso) &&
                double.TryParse(txtAltura.Text, out altura))
            {
                double pesoIdeal;
                if (radioF.Checked)
                { // feminino
                    pesoIdeal = (62.1 * altura) - 44.7;
                }
                else
                { // masculino
                    pesoIdeal = (72.7 * altura) - 58;
                }
                string pesoIdealStr = pesoIdeal.ToString("N2");
                if(pesoIdeal < peso)
                {
                    MessageBox.Show("Peso acima do ideal: " + pesoIdealStr + "kg." +
                                    "\nSeu peso: " + peso + "kg.");
                }else if(pesoIdeal > peso)
                {
                    MessageBox.Show("Peso abaixo do ideal: " + pesoIdealStr + "kg." +
                                    "\nSeu peso: " + peso + "kg.");
                }
                else
                {
                    MessageBox.Show("Peso dentro do recomendado: " + pesoIdealStr + "kg.");
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }
        }
    }
}
