using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSoftwear_2
{
    internal class DrawTriangle
    {
        private Point[] point;

        public DrawTriangle(Point[] point)
        {
            this.point = point;
        }
        public DrawTriangle() { }

        public override void setTriangle(int x, int y, Point[] point)
        {
            base.set(x, y);
            this.point = point;
        }

        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.DrawPolygon(pen, point);
            graph.FillPolygon(brush, point);
        }

    }
}
