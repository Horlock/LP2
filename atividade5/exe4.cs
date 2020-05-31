using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenus
{
    public partial class exe4 : Form
    {
        public exe4()
        {
            InitializeComponent();
        }

        private void btnCaractNum_Click(object sender, EventArgs e)
        {
            int cont = 0;

            for (var i = 0; i <= rchtxtTexto.Text.Length - 1; i++)
            {
                if (Char.IsNumber(rchtxtTexto.Text[i]))
                    cont += 1;
            }
            MessageBox.Show("Quantidade de caracteres numericos: " + cont);
        }

        private void btnPrimBranco_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            while (i < rchtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(rchtxtTexto.Text[i]))
                {
                    MessageBox.Show("Posição do primeiro espaço: " + (i + 1));
                    break;
                }
                i += 1;
            }
        }

        private void btnCaractAlfab_Click(object sender, EventArgs e)
        {

            int i = 0;
            foreach (char c in rchtxtTexto.Text)
            {
                if (Char.IsLetter(c))
                    i += 1;
            }
            MessageBox.Show("Quantidade de caracteres alfabeticos: " + i);
        }

        private void exe4_Load(object sender, EventArgs e) {

        }
    }
}
