using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wFiguras
{
    internal class clsFiguras
    {
        public void DibujarCuadrado(Graphics g, float x, float y, float lado, Pen lapiz)
        {
            g.DrawRectangle(lapiz, x, y, lado, lado);
        }

        public void DibujarTriangulo(Graphics g, float x, float y, float base_, float altura, Pen lapiz)
        {
            PointF[] puntos =
            {
            new PointF(x, y + altura),
            new PointF(x + base_ / 2, y),
            new PointF(x + base_, y + altura)
        };
            g.DrawPolygon(lapiz, puntos);
            }

        public void DibujarCirculo(Graphics g, float x, float y, float radio, Pen lapiz)
        {
            g.DrawEllipse(lapiz, x - radio, y - radio, radio * 2, radio * 2);
        }
    }

}
