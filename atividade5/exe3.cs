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
    public partial class Exe3 : Form
    {
        public Exe3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int index;
            index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            while (index >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, index) +
                    txtPalavra2.Text.Substring(index + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - index - txtPalavra1.Text.Length);

                index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string texto = txtPalavra1.Text;
            char[] arr = texto.ToCharArray();
            Array.Reverse(arr);
            texto = "";
            foreach (char c in arr)
                texto = texto + c.ToString();
            MessageBox.Show(texto);

            string textoDois = txtPalavra1.Text;
            char[] arr1 = textoDois.ToCharArray();
            Array.Reverse(arr1);
            textoDois = new string(arr1);
            MessageBox.Show(textoDois);

            string textoI = new string('a', 7);
        }

        private void lblPalavra1_Click(object sender, EventArgs e) {

        }

        private void txtPalavra1_TextChanged(object sender, EventArgs e) {

        }

        private void lblPalavra2_Click(object sender, EventArgs e) {

        }

        private void txtPalavra2_TextChanged(object sender, EventArgs e) {

        }
    }
}
