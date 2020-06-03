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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void atividade1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atividade2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio1 form_Exe2 = new Exercicio1();
            form_Exe2.MdiParent = this;
            form_Exe2.WindowState = FormWindowState.Maximized;
            form_Exe2.Show();
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio2 form_Exe3 = new Exercicio2();
            form_Exe3.MdiParent = this;
            form_Exe3.WindowState = FormWindowState.Maximized;
            form_Exe3.Show();
        }

        private void atividade4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio3 form_Exe4 = new Exercicio3();
            form_Exe4.MdiParent = this;
            form_Exe4.WindowState = FormWindowState.Maximized;
            form_Exe4.Show();
        }

        private void atividade5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio4 form_Exe5 = new Exercicio4();
            form_Exe5.MdiParent = this;
            form_Exe5.WindowState = FormWindowState.Maximized;
            form_Exe5.Show();
        }
    }
}
