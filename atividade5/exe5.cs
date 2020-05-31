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
    public partial class Exe5 : Form
    {
        public Exe5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int num = objRandom.Next(Convert.ToInt32(txtNum1.Text),
                Convert.ToInt32(txtNum2.Text));
            MessageBox.Show("Número: " + num);
        }

        private void Exe5_Load(object sender, EventArgs e) {

        }
    }
}
