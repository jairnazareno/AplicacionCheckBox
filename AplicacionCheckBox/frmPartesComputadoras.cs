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
    public partial class frmPartesComputadoras : Form
    {
        public frmPartesComputadoras()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String cad = "";
            if (this.radioButton4GB.Checked) 
            {
                cad = "Computadora con memoria con 4 GB de Memoria Ram";

            }
            else if(this.radioButton8GB.Checked)
            {
                cad = "Computadora con memoria con 8 GB de Memoria Ram";
            }
            else if (this.radioButton12GB.Checked)
            {
                cad = "Computadora con memoria con 12 GB de Memoria Ram";
            }
            String cad1 = "";

            if (this.radioButton80GB.Checked)
            {
                cad1 = "; Con 80GB de Disco Solido";
            }
            else if (this.radioButton300GB.Checked)
            {
                cad1 = "; Con 300GB de Disco Solido";
            }
            else if (this.radioButton500GB.Checked)
            {
                cad1 = "; Con 500GB de Disco Solido";
            }

            String cad2 = "";
            if (this.radioButtoni3.Checked)
            {
                cad2 = "; De un procesador i3";
            }
            else if (this.radioButtoni5.Checked)
            {
                cad2 = "; De un procesador i5";
            }
            else if (this.radioButtoni7.Checked)
            {
                cad2 = "; De un procesador i7";
            }
            String cad3 = "";
            if (this.checkBoxCamWeb.Checked)
            {
                cad3 = " Y una camara web";
            }
            String cad4 = "";
             if (this.checkBoxImpreHp.Checked)
            {
                cad4 = ", Impresora Hp";
            }
            String cad5 = "";
            if (this.checkBoxMouseGamer.Checked)
            {
                cad5 = ", Mouse Inalambrico";
            }
            this.txtResultado.Text = cad + cad1 + cad2 + cad3 + cad4 + cad5;
        }   
    }
}
