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
    public partial class Ex02 : Form
    {
        public Ex02()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float Valor1 = float.Parse(txtValor01.Text);
            float resultado;

            resultado = 2022 - Valor1;

            if (resultado >= 16)
            {
                lblResultado.Text =  "Pode votar";
            }
            else
            {
                lblResultado.Text = "Não pode votar";
            }
        }
    }
}
