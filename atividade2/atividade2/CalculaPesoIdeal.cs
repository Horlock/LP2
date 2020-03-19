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

            if (double.TryParse(txtPeso.Text, out double peso) &&
                double.TryParse(txtAltura.Text, out double altura))
            {
                double pesoIdeal;
                if (radioF.Checked)
                { // feminino
                    pesoIdeal = Math.Round((62.1 * altura) - 44.7, 2);
                }
                else
                { // masculino
                    pesoIdeal = Math.Round((72.7 * altura) - 58, 2);
                }

                string pesoIdealStr = pesoIdeal.ToString();
                txtPesoIdeal.Text = pesoIdealStr;

                    if(pesoIdeal < peso)
                    {
                        lblMsg.Text = "Peso acima do ideal";
                        lblMsg.ForeColor = Color.Red;
                    }
                    else if(pesoIdeal > peso)
                    {
                        lblMsg.Text = "Peso abaixo do ideal";
                        lblMsg.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblMsg.Text = "Peso dentro do recomendado";
                        lblMsg.ForeColor = Color.Green;
                    }
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }
        }

        private void lblPesoIdeal_Click(object sender, EventArgs e)
        {

        }
    }
}
