using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulos2
{
    public partial class FrmTriangulos : Form
    {
        public FrmTriangulos()
        {
            InitializeComponent();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            // declarar variaveis e passar o valor dela

            decimal lado1 = nudLado1.Value;
            decimal lado2 = nudLado2.Value;
            decimal lado3 = nudLado3.Value;

            // fazer o if para verificar o tipo de triangulo
            // o teste logico do if tem que ficar entre ()
            // == igualdade != diferente >= <= > <
            picEquilatero.Visible = false;
            picEscaleno.Visible = false;
            picIsosceles.Visible = false;

            if (lado1 == lado2 && lado2 == lado3)
            {
                lblTpo.Text = "Equilatero";
                picEquilatero.Visible = true;
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                lblTpo.Text = "Escaleno";
                picEscaleno.Visible = true;
            }
            else
            {
                lblTpo.Text = "Isosceles";
                picIsosceles.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picEscaleno_Click(object sender, EventArgs e)
        {

        }
    }
}
