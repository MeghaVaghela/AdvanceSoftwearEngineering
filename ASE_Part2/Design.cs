using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part2
{
    /// <summary>
    /// Represents a base class for designing shapes.
    /// </summary>
    public abstract class Design : DesignInterface
    {
        protected int x, y;

        /// <summary>
        /// Initializes a new instance of the Design class with specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate.</param>
        /// <param name="y">The y-coordinate.</param>
        public Design(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

        /// <summary>
        /// Default constructor for the Design class.
        /// </summary>
        public Design() { }

        /// <summary>
        /// Sets the coordinates for the design using an array of integers.
        /// </summary>
        /// <param name="list">An array of integers representing coordinates.</param>
        public virtual void set(params int[] list)
            {
                this.x = list[0];
                this.y = list[1];
            }

        /// <summary>
        /// Sets the coordinates for a triangle design.
        /// </summary>
        /// <param name="x">The x-coordinate.</param>
        /// <param name="y">The y-coordinate.</param>
        /// <param name="points">An array of points representing the triangle vertices.</param>
            public virtual void setTriangle(int x, int y, Point[] points)
            {
                this.x = x;
                this.y = y;
            }
        /// <summary>
        /// Draws the design using specified graphics, pen, and brush.
        /// </summary>
        /// <param name="graph">The graphics object to draw on.</param>
        /// <param name="pen">The pen to outline the design.</param>
        /// <param name="brush">The brush to fill the design.</param>
        public abstract void Draw(Graphics graph, Pen pen, Brush brush);

        /// <summary>
        /// Overrides the ToString method to provide coordinates information.
        /// </summary>
        /// <returns>A string representation of the design's coordinates.</returns>
        public override string ToString()
            {
                return base.ToString() + "   " + this.x + "," + this.y + ":: ";
            }
        }
    }

