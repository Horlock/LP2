<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade3
{
    public partial class formTriangulo : Form
    {
        public formTriangulo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLadoA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;
            
            if(double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB) 
                && double.TryParse(txtLadoC.Text, out ladoC)){

                if (ladoA > 0 && ladoB > 0 && ladoC > 0){

                    if(ladoA.Equals(ladoB) && ladoA.Equals(ladoC)){
                        lblResultado.Text = "Triângulo Equilátero";
                    }else if (ladoA.Equals(ladoB) || ladoA.Equals(ladoC) || ladoB.Equals(ladoC))
                    {
                        lblResultado.Text = "Triângulo Isósceles";
                    }
                    else
                    {
                        lblResultado.Text = "Triângulo Escaleno";
                    }

                }
                else{
                    MessageBox.Show("Insira valores maiores que zero!");
                }

            }
            else{
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            lblResultado.Text = "";
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade3
{
    public partial class formTriangulo : Form
    {
        public formTriangulo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLadoA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;
            
            if(double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB) 
                && double.TryParse(txtLadoC.Text, out ladoC)){

                if (ladoA > 0 && ladoB > 0 && ladoC > 0){

                    if(ladoA.Equals(ladoB) && ladoA.Equals(ladoC)){
                        lblResultado.Text = "Triângulo Equilátero";
                    }else if (ladoA.Equals(ladoB) || ladoA.Equals(ladoC) || ladoB.Equals(ladoC))
                    {
                        lblResultado.Text = "Triângulo Isósceles";
                    }
                    else
                    {
                        lblResultado.Text = "Triângulo Escaleno";
                    }

                }
                else{
                    MessageBox.Show("Insira valores maiores que zero!");
                }

            }
            else{
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            lblResultado.Text = "";
        }
    }
}
>>>>>>> 6224b6ceb64bb36339e4e26cbd8f65ab1dd72395
