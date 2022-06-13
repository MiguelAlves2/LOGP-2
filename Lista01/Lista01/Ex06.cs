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
    public partial class Ex06 : Form
    {
        public Ex06()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float lados = float.Parse(txtLado.Text);

            if (lados == 3)
            {
                lblResultado.Text = "Triângulo";
            }
            else if(lados == 4)
            {
                lblResultado.Text = "Quadrado";
            }
            else
            {
                lblResultado.Text = "Inexistente";
            }
        }
    }
}
