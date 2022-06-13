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
    public partial class Ex05 : Form
    {
        public Ex05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float lanche = float.Parse(txtLanche.Text);
            float vlrPago = float.Parse(txtPago.Text);
            float troco;

            if (vlrPago - lanche >= 0)
            {
                troco = vlrPago - lanche;
                lblResultado.Text = troco.ToString("C");
            }
            else
            {
                lblResultado.Text = "Valor insuficiente";
            }
        }
    }
}
