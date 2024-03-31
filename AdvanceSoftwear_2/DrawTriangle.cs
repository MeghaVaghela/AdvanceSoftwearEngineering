using System.Drawing;

namespace AdvanceSoftwear_2
{
    public class DrawTriangle:Shape
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
