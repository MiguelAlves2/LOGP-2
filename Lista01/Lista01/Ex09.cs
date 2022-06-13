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
    public partial class Ex09 : Form
    {
        public Ex09()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            float num = float.Parse(txtNum.Text);
            if (num >= 1)
            {
                lblResultado.Text = "Positivo";
            }
            else if (num <= -1)
            {
                lblResultado.Text = "Negativo";
            }
            else
            {
                lblResultado.Text = "Neutro";            }

        }
    }
}
