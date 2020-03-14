using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInstanciarSimples_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista();

            mensalista.NomeEmpregado = txtNome.Text;
            mensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            mensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            mensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);

            MessageBox.Show(
                            "Nome = " + mensalista.NomeEmpregado + "\n" +
                            "Matrícula = " + mensalista.Matricula + "\n" +
                            "Tempo Trabalho: " +
                            mensalista.TempoTrabalho().ToString() +
                            "\n" +
                            "Salário Final = R$ " +
                            mensalista.SalarioBruto().ToString("N2")
                            );
        }

        private void btnInstanciarParametros_Click(object sender, EventArgs e)
        {
            Mensalista mensalista = new Mensalista(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text,
                Convert.ToDateTime(txtDataEntrada.Text),
                Convert.ToDouble(txtSalario.Text)
               );

            MessageBox.Show(
                            "Nome = " + mensalista.NomeEmpregado + "\n" +
                            "Matrícula = " + mensalista.Matricula + "\n" +
                            "Tempo Trabalho: " +
                            mensalista.TempoTrabalho().ToString() +
                            "\n" +
                            "Salário Final = R$ " +
                            mensalista.SalarioBruto().ToString("N2")
                            );
        }
    }
}
