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
    public partial class Ex03 : Form
    {
        public Ex03()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float senha = float.Parse(txtSenha.Text);
            string User = txtUsuario.Text;

            if(senha==1234 && User=="admin")
            {
                lblResultado.Text = "Acesso Permitido";
            }
            else
            {
                lblResultado.Text = "Acesso Negado";
            }
        }
    }
}
