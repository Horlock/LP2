using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade4
{
    public partial class calculoINSS : Form
    {
        public calculoINSS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSalarioFamilia_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAliquotaINSS.Clear();
            txtAliquotaIRPF.Clear();
            txtDescontoINSS.Clear();
            txtDescontoIRPF.Clear();
            txtFilhos.Clear();
            txtNome.Clear();
            txtSalarioBruto.Clear();
            txtSalarioFamilia.Clear();
            txtSalarioLiquido.Clear();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int numFilhos;
            double salBruto, salLiquido, salFamilia, desINSS, desIRPF;
            string txtAliINSS, txtAliIRPF;
            
            if(double.TryParse(txtSalarioBruto.Text, out salBruto) && int.TryParse(txtFilhos.Text, out numFilhos) && 
                txtNome.Text != "" && (radioF.Checked || radioM.Checked))
            {
                
                // CALCULO INSS
                if(salBruto < 800.48)
                {
                    
                    salLiquido = salBruto * (1 - 0.0765);
                    desINSS = salBruto * 0.0765;
                    txtAliINSS = "7,65%";

                }else if(salBruto >= 800.48 && salBruto <= 1050)
                {
                    
                    salLiquido = salBruto * (1 - 0.0865);
                    desINSS = salBruto * 0.0865;
                    txtAliINSS = "8,65%";

                }else if(salBruto >= 1051.01 && salBruto <= 1400.77)
                {
                    
                    salLiquido = salBruto * (1 - 0.09);
                    desINSS = salBruto * 0.09;
                    txtAliINSS = "9,00%";

                }else if(salBruto >= 1400.78 && salBruto <= 2801.56)
                {
                    
                    salLiquido = salBruto * (1 - 0.11);
                    desINSS = salBruto * 0.11;
                    txtAliINSS = "11,00%";

                }
                else
                {
                    salLiquido = salBruto - 308.17;
                    desINSS = 308.17;
                    txtAliINSS = "Teto";
                }

                // CALCULO IRPF
                if(salBruto <= 1257.12)
                {
                    txtAliIRPF = "0,00";
                    desIRPF = 0;
                }else if(salBruto >= 1257.13 && salBruto <= 2512.08)
                {
                    salLiquido = salLiquido - (salBruto * 0.15);
                    desIRPF = salBruto * 0.15;
                    txtAliIRPF = "15,00%";
                }
                else
                {
                    salLiquido = salLiquido - (salBruto * 0.275);
                    desIRPF = salBruto * 0.275;
                    txtAliIRPF = "27,50%";
                }

                // CALCULO SALARIO FAMILIA
                if(salBruto <= 435.52)
                {
                    salFamilia = 22.33 * numFilhos;
                }else if(salBruto >= 435.53 && salBruto <= 654.61)
                {
                    salFamilia = 15.74 * numFilhos;
                }
                else
                {
                    salFamilia = 0;
                }

                salLiquido = salLiquido + salFamilia;

                txtAliquotaINSS.Text = txtAliINSS;
                txtAliquotaIRPF.Text = txtAliIRPF;
                txtSalarioFamilia.Text = salFamilia.ToString("N2");
                txtSalarioLiquido.Text = salLiquido.ToString("N2");
                txtDescontoINSS.Text = desINSS.ToString("N2");
                txtDescontoIRPF.Text = desIRPF.ToString("N2");


            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }


        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calculoINSS_Load(object sender, EventArgs e)
        {

        }

        private void txtSalarioBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }
    }
}
