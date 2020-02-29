using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaVolume {
    public partial class titulo : Form {
        public titulo() {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            double raio, altura;
            if (double.TryParse(raioTxt.Text, out raio) &&
                double.TryParse(alturaTxt.Text, out altura)) {
                    double volume = Math.PI * Math.Pow(raio,2) * altura;
                    volumeTxt.Text = volume.ToString("N2");
            } else {
                MessageBox.Show("Dados inválidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            raioTxt.Clear();
            alturaTxt.Clear();
            volumeTxt.Clear();
        }

        private void button3_Click(object sender, EventArgs e) {
            Close();
        }

        private void volumeTxt_TextChanged(object sender, EventArgs e) {

        }
    }
}
