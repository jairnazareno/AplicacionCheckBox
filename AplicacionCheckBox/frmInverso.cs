using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCheckBox
{
    public partial class frmInverso : Form
    {
        public frmInverso()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero.Text.Substring(0, 1);
            string numero2 = txtNumero.Text.Substring(1, 1);
            string numero3 = txtNumero.Text.Substring(2, 1);
            string numero4 = txtNumero.Text.Substring(3, 1);
            lblRespuesta.Text = numero4 + numero3 + numero2 + numero1;
        }
    }
}
