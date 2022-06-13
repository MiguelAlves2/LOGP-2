using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista01
{
    public partial class Ex01 : Form
    {
        public Ex01()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float valor1 = float.Parse(txtVlr01.Text);
            float valor2 = float.Parse(txtVlr02.Text);

            if (valor1 > valor2)
            {
                lblResultado.Text = "O Valor1 é maior que Valor2.";
            }
            else
            {
                lblResultado.Text = "O Valor2 é maior que Valor1.";
            }
        }
    }
}
