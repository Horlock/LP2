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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0, count = 0;
            while (i < rchTxt.Text.Length)
            {
                if (Char.IsWhiteSpace(rchTxt.Text[i]))
                {
                    count++;
                }
                i++;
            }
            MessageBox.Show("Quantidade de espaçoes em branco :" + count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0, count = 0;
            while (i < rchTxt.Text.Length)
            {
                if (Convert.ToChar(rchTxt.Text[i].ToString().ToLower()).Equals('r'))
                {
                    count++;
                }
                i++;
            }
            MessageBox.Show("Quantidade de letras R :" + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0, count = 0;
            char c, s;
            while (i < rchTxt.Text.Length -1 )
            {
                c = Convert.ToChar(rchTxt.Text[i].ToString().ToLower());
                s = Convert.ToChar(rchTxt.Text[i + 1].ToString().ToLower());
                if (c.Equals(s))
                {
                    count++;
                }
                i++;
            }
            MessageBox.Show("Quantidade de pares de letras:" + count);
        }

        private void Exercicio1_Load(object sender, EventArgs e) {

        }
    }
}
