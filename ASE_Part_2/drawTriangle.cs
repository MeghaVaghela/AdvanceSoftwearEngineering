using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{
    public class drawTriangle
    {
        private Point[] point;

        public drawTriangle(Point[] point)
        {
            this.point = point;
        }
        public drawTriangle() { }

        public override void setTriangle(int x , int y, Point[] point)
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
