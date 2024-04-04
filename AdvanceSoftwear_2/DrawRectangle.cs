using System;
using System.Drawing;


namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Represents a rectangle shape to be drawn on a graphics surface.
    /// </summary>
    public class DrawRectangle:Shape
    {
        /// <summary>
        /// Gets or sets the width of the rectangle.
        /// </summary>
        public int width { get; private set; }
        /// <summary>
        /// Gets or sets the height of the rectangle.
        /// </summary>
        public int height { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawRectangle"/> class with the specified coordinates, width, and height.
        /// </summary>
        public DrawRectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawRectangle"/> class.
        /// </summary>
        public DrawRectangle() { }

        /// <summary>
        /// Sets the coordinates, width, and height of the rectangle.
        /// </summary>
        public void set(int x, int y, int width, int height)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Width and height must be non-negative.");
            }

            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Sets the coordinates, width, and height of the rectangle.
        /// </summary>
        public void Set(int x, int y, int width, int height)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Width and height must be non-negative.");
            }

          width = width;
          height = height;
        }

        /// <summary>
        /// Sets the coordinates, width, and height of the rectangle.
        /// </summary>
        public override void set(params int[] items)
        {
            base.set(items[0], items[1]);
            this.width = items[2];
            this.height = items[3];
        }

        /// <summary>
        /// Draws the rectangle on the specified graphics surface using the specified pen and brush.
        /// </summary>
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillRectangle(brush, x, y, width, height);
            graph.DrawRectangle(pen, x, y, width, height);
        }
       
    }
}