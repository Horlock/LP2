using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++) {
                valor = Interaction.InputBox("Digite um valor na posição: " + (x + 1),
                    "Entrada de Dados");

                if (valor == ""){
                    break;
                }

                if (int.TryParse(valor, out Vetor[x])){
                    //auxiliar = auxiliar + "\n" + Vetor[x].ToString();
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                }else{
                    MessageBox.Show("Número inválido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++){
                valor = Interaction.InputBox("Entre com dado da posição: " + (x + 1),
                    "Entrada de Dados");

                if (valor == ""){
                    break;
                }

                if(!int.TryParse(valor, out Vetor[x])){
                    MessageBox.Show("Digite número válido!!");
                    x--;
                }
            }

            Array.Reverse(Vetor);
            for (var x = 0; x < 20; x++) {
                auxiliar = auxiliar + "\n" + Vetor[x];
            }
            MessageBox.Show(auxiliar);

        }

        private void button3_Click(object sender, EventArgs e) {
            int[] Quantidade = new int[10];
            double[] Preco = new double[10];

            string quantidade;
            string preco;
            double faturamento = 0;

            for (int i = 0; i < 10; i++) {
                quantidade = Interaction.InputBox("Digite a quantidade do produto" + (i + i), 
                    ": ");

                if(quantidade == "") {
                    break;
                }
                if (!int.TryParse(quantidade, out Quantidade[i])) {
                    MessageBox.Show("Digite uma quantidade válida!");
                    i--;
                } else {
                    preco = Interaction.InputBox("Digite o valor do produto" + (i + 1),
                    ":");

                    if (preco == "") {
                        break;
                    }
                    if (!double.TryParse(preco, out Preco[i])) {
                        MessageBox.Show("Digite um valor válido!");
                        i--;
                    } else {
                        faturamento += Quantidade[i] * Preco[i];
                    }
                 }
                }

            MessageBox.Show("Faturamento" + faturamento.ToString("N2"));
        }
    }
}
