using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFiguras1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCalcularCuadrado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLado1.Text))
            {
                MessageBox.Show("Por favor ingrese el valor del lado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double lado = double.Parse(txtLado1.Text);
            lblAreaCuadrado.Text = "ÁREA: " + (lado * lado).ToString();
            double areaCuadrado = lado * lado;
            MessageBox.Show("El área del cuadrado es: " + areaCuadrado.ToString());

            // Dibujar el cuadrado
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(pictureBox1.BackColor);
            g.DrawRectangle(Pens.Black, new Rectangle(10, 10, (int)lado, (int)lado));
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBase.Text) || string.IsNullOrEmpty(txtAltura.Text))
            {
                MessageBox.Show("Por favor ingrese los valores de la base y la altura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double base_ = double.Parse(txtBase.Text);
            double altura = double.Parse(txtAltura.Text);
            lblAreaTriangulo.Text = "ÁREA: " + (base_ * altura / 2).ToString();
            double areaTriangulo = base_ * altura / 2;
            MessageBox.Show("El área del triangulo es: " + areaTriangulo.ToString());

            // Dibujar el triángulo
            Graphics g = pictureBox2.CreateGraphics();
            g.Clear(pictureBox2.BackColor);
            PointF[] puntos =
            {
            new PointF((float)base_ / 2, 0),
            new PointF(0, (float)altura),
            new PointF((float)base_, (float)altura)
            };
            g.DrawPolygon(Pens.Black, puntos);
        }

        private void btnCalcularCirculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRadio.Text))
            {
                MessageBox.Show("Por favor ingrese el valor del radio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double Radio = double.Parse(txtRadio.Text);
            lblAreaCirculo.Text = "ÁREA: " + Math.PI * Radio * Radio;
            double areaCirculo = Math.PI * Radio * Radio;
            MessageBox.Show("El área del círculo es: " + areaCirculo.ToString());

            // Dibujar el círculo
            Graphics g = pictureBox3.CreateGraphics();
            g.Clear(pictureBox3.BackColor);
            g.DrawEllipse(Pens.Black, new RectangleF(0, 0, (float)Radio * 2, (float)Radio * 2));
        }
    }
}
