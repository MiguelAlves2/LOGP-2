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
    public partial class Ex08 : Form
    {
        public Ex08()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string sexo = txtSexo.Text;

            if (sexo == "F")
            {
                lblResultado.Text = "Sexo feminino";
            }
            else
            {
                lblResultado.Text = "Sexo  inválido pois é um projeto de mulheres";   
            }
        }
    }
}
