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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exe4 frm4 = new exe4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void exercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exe2 frm2 = new exe2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou no copiar.");
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exe3 frm3 = new Exe3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exe5 frm5 = new Exe5();
            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Maximized;
            frm5.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Home_Load(object sender, EventArgs e) {

        }
    }
}
