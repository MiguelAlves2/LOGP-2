using System;
using System.Windows.Forms;

namespace Lista01
{
    public partial class Ex07 : Form
    {
        public Ex07()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float altura = float.Parse(txtAltura.Text);
            float peso = float.Parse(txtPeso.Text);
            string sexo = txtSexo.Text;
            float resultado;

            if (sexo == "Masculino")
            {
                resultado = (peso * altura) - 58;
                lblResultado.Text = resultado.ToString("f");
            }
            else if (sexo == "Feminino")
            {
                resultado = (peso * altura) - 44.7f;
                lblResultado.Text = resultado.ToString("f");
            }
            else
            {
                lblResultado.Text = "Informações Inválidas";
            }
        }
    }
}
