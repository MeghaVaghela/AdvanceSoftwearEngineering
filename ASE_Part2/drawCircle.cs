using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part2
{ /// <summary>
  /// Represents a class for drawing circles, extending the Design class.
  /// </summary>
    public class drawCircle : Design
    {
        int diameter;


        /// <summary>
        /// Initializes a new instance of the drawCircle class with a specified diameter.
        /// </summary>
        /// <param name="diameter">The diameter of the circle.</param>
        public drawCircle(int diameter)
        { this.diameter = diameter; }

        /// <summary>
        /// Initializes a new instance of the drawCircle class with specified parameters.
        /// </summary>
        /// <param name="x">X-coordinate of the position.</param>
        /// <param name="y">Y-coordinate of the position.</param>
        /// <param name="diameter">The diameter of the circle.</param>
        public drawCircle(int x, int y, int diameter) : base(x, y)
        {
            this.diameter = diameter;
        }

        public drawCircle() : base()
        { }

        /// <summary>
        /// Draws the circle using specified graphics, pen, and brush.
        /// </summary>
        /// <param name="graph">Graphics object for drawing.</param>
        /// <param name="Pen">Pen for drawing the outline.</param>
        /// <param name="brush">Brush for filling the circle.</param>
        public override void Draw(Graphics graph, Pen Pen, Brush brush)
        {
            graph.FillEllipse(brush, x, y, diameter * 2, diameter * 2);
            graph.DrawEllipse(Pen, x, y, diameter * 2, diameter * 2);
        }

        /// <summary>
        /// Sets the parameters for the circle.
        /// </summary>
        /// <param name="list">List of integers representing parameters.</param>
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            this.diameter = list[2];
        }

        /// <summary>
        /// Returns a string representation of the drawCircle object.
        /// </summary>
        /// <returns>A string containing information about the circle.</returns>
        public override string ToString()
        {
            return base.ToString() + " " + this.diameter;
        }
    }
}
