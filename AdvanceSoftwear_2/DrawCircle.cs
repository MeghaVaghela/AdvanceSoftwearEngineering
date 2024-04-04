using System;
using System.Drawing;

namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Represents a circle shape to be drawn on a graphics surface.
    /// </summary>
        public class DrawCircle:Shape
    {
       private int diameter;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircle"/> class with the specified diameter.
        /// </summary>
        public DrawCircle(int diameter)
        {
            this.diameter = diameter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircle"/> class with the specified coordinates and diameter.
        /// </summary>
        public DrawCircle(int x, int y, int diameter) : base(x, y)
        {
            this.diameter = diameter;
        }

        /// <summary>
        /// Gets or sets the diameter of the circle.
        /// </summary>
        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawCircle"/> class.
        /// </summary>
        public DrawCircle() : base()
        { }

        /// <summary>
        /// Draws the circle on the specified graphics surface using the specified pen and brush.
        /// </summary>
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillEllipse(brush, x, y, diameter * 2, diameter * 2);
            graph.DrawEllipse(pen, x, y, diameter * 2, diameter * 2);
        }

        /// <summary>
        /// Sets the coordinates and diameter of the circle using the specified parameters.
        /// </summary>
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            if (list.Length >= 3)
            {
                diameter = list[2];
            }
        }

    }
}
