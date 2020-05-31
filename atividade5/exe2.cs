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
    public partial class exe2 : Form
    {
        public exe2()
        {
            InitializeComponent();
        }

        private void btnTesta_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0) { 
                MessageBox.Show("Palavras iguais.");
            } else { 
                MessageBox.Show("Palavras diferentes.");
            }
        }

        private void btnInsere1_Click(object sender, EventArgs e)
        {
            int aux;
            aux = txtPalavra2.Text.Length / 2;

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, aux) +
                txtPalavra1.Text +
                txtPalavra2.Text.Substring(aux, txtPalavra2.Text.Length- aux);
        }

        private void btnInsere2_Click(object sender, EventArgs e)
        {
            int aux;

            aux = txtPalavra1.Text.Length / 2;

            txtPalavra2.Text = txtPalavra1.Text.Insert(aux, "**");
        }

        private void exe2_Load(object sender, EventArgs e) {

        }
    }
}
