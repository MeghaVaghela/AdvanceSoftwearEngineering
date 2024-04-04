using System.Drawing;

namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Represents a triangle shape to be drawn on a graphics surface.
    /// </summary>
    public class DrawTriangle:Shape
    {
        private Point[] point;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawTriangle"/> class with the specified points.
        /// </summary>
        public DrawTriangle(Point[] point)
        {
            this.point = point;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawTriangle"/> class.
        /// </summary>
        public DrawTriangle() { }

        /// <summary>
        /// Sets the coordinates and points defining the vertices of the triangle.
        /// </summary>
        public override void setTriangle(int x, int y, Point[] point)
        {
            base.set(x, y);
            this.point = point;
        }

        /// <summary>
        /// Draws the triangle on the specified graphics surface using the specified pen and brush.
        /// </summary>
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.DrawPolygon(pen, point);
            graph.FillPolygon(brush, point);
        }

    }
}
