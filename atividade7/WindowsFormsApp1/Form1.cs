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
using System.Collections;
using System.Net.Http.Headers;

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

        private void button4_Click(object sender, EventArgs e) {
            string[] alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
            "Leonardo", "Jose", "Nelma", "Tobby"};

            Int32 i, total = 0;
            Int32 n = alunos.Length;

            for (i = 0; i < n - 1; i++) {
                total += alunos[i].Length;
            }
            MessageBox.Show(total.ToString());
        }

        private void button5_Click(object sender, EventArgs e) {
            ArrayList alunos = new ArrayList() {"Ana", "André", "Débora", "Fátima", "João",
            "Janete", "Otávio", "Marcelo", "Pedro", "Thais"};

            alunos.Remove("Otávio");


            MessageBox.Show(string.Join(Environment.NewLine, alunos.OfType<Object>()));


            /*foreach (var i in alunos) { 
            MessageBox.Show(i.ToString());
            }*/
        }

        private void button6_Click(object sender, EventArgs e) {
            double[,] notas = new double[20, 3];
            string medias = "";
            string nota;
            bool validar;

            for (var i = 0; i < 19; i++) {
                double media = 0;
         
                for (var j = 0; j < 3; j++) {
                    do {
                        nota = Interaction.InputBox(
                            "Digite uma nota de 0 a 10 \n\n\n\n" +
                            "Digite a " + (j + 1) +
                            "ª nota do Aluno " + (i + 1) + ": ");

                        if (double.Parse(nota) < 0) {
                            MessageBox.Show("Por favor, digite uma nota maior ou igual a 0");
                            validar = false;
                        } else if (double.Parse(nota) > 10) {
                            MessageBox.Show("Por favor, digite uma nota menor ou igual a 10");
                            validar = false;
                        } else if (nota == "") {
                            MessageBox.Show("Entrada vazia");
                            validar = false;
                        } else {
                            validar = true;
                        }
                    }while (validar == false);

                    notas[i, j] = double.Parse(nota);
                    media += notas[i, j] * 3;
                }
                medias += "Aluno " + i.ToString() + ": média: " + media.ToString("N2") + "\n";
            }

            MessageBox.Show(medias);

        }
    }
}
