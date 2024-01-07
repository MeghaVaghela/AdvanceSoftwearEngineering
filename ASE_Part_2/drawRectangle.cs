using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{

    /// <summary>
    /// Represents a class for drawing rectangles, extending the Design class.
    /// </summary>
    public class drawRectangle:Design
    {
        private int width;
        private int height;

        /// <summary>
        /// Initializes a new instance of the drawRectangle class with specified parameters.
        /// </summary>
        /// <param name="x">X-coordinate of the position.</param>
        /// <param name="y">Y-coordinate of the position.</param>
        /// <param name="width">Width of the rectangle.</param>
        /// <param name="height">Height of the rectangle.</param>
        public drawRectangle(int x, int y, int width, int height) : base(x, y)
        { 
            this.width = width; 
            this.height = height; 
        }

        /// <summary>
        /// Initializes a new instance of the drawRectangle class.
        /// </summary>
        public drawRectangle() { }

        /// <summary>
        /// Sets the parameters for the rectangle.
        /// </summary>
        /// <param name="list">Array of integers specifying position, width, and height.</param>
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Draws the rectangle using specified graphics, pen, and brush.
        /// </summary>
        /// <param name="graph">Graphics object for drawing.</param>
        /// <param name="pen">Pen for drawing the outline.</param>
        /// <param name="brush">Brush for filling the rectangle.</param>
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillRectangle(brush, x,y,width,height);
            graph.DrawRectangle(pen, x,y,width,height);
        }

    }
}
