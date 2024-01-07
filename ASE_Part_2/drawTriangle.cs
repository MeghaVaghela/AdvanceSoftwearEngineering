using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{

    /// <summary>
    /// Represents a class for drawing triangles extending the Design class.
    /// </summary>
    public class drawTriangle:Design
    {
        private Point[] point;

        /// <summary>
        /// Initializes a new instance of the drawTriangle class with specified points.
        /// </summary>
        /// <param name="point">Array of points defining the triangle.</param>
        public drawTriangle(Point[] point)
        {
            this.point = point;
        }

        /// <summary>
        /// Initializes a new instance of the drawTriangle class.
        /// </summary>
        public drawTriangle() { }

        /// <summary>
        /// Sets the triangle's position and points.
        /// </summary>
        /// <param name="x">X-coordinate of the position.</param>
        /// <param name="y">Y-coordinate of the position.</param>
        /// <param name="point">Array of points defining the triangle.</param>
        public override void setTriangle(int x , int y, Point[] point)
        {
            base.set(x, y);
            this.point = point;
        }

        /// <summary>
        /// Draws the triangle using specified graphics, pen, and brush.
        /// </summary>
        /// <param name="graph">Graphics object for drawing.</param>
        /// <param name="pen">Pen for drawing the outline.</param>
        /// <param name="brush">Brush for filling the triangle.</param>
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.DrawPolygon(pen, point);
            graph.FillPolygon(brush, point);
        }

    }
}
