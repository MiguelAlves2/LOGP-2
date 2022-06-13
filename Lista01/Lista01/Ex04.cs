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
    public partial class Ex04 : Form
    {
        public Ex04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float maca = float.Parse(txtMaca.Text);
            float resultado;
            
            if (maca > 11)
            {
                resultado = maca * 0.25f;
                lblResultado.Text = resultado.ToString("C");
                
            }

            else
            {
                resultado = maca * 0.30f;
                lblResultado.Text = resultado.ToString("C");
            }
        }
    }
}
