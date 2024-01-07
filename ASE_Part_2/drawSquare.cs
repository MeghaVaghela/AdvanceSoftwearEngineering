using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{

    /// <summary>
    /// Represents a class for drawing squares, extending the drawRectangle class.
    /// </summary>
    public class drawSquare:drawRectangle
    {
        readonly int size;

        /// <summary>
        /// Initializes a new instance of the drawSquare class.
        /// </summary>
        public drawSquare()
        {
        }

        /// <summary>
        /// Initializes a new instance of the drawSquare class with specified parameters.
        /// </summary>
        /// <param name="x">X-coordinate of the position.</param>
        /// <param name="y">Y-coordinate of the position.</param>
        /// <param name="size">Size of the square (width and height).</param>
        public drawSquare(int x, int y,int size): base(x,y,size,size)
        {
            this.size = size;
        }

        /// <summary>
        /// Draws the square using specified graphics, pen, and brush.
        /// </summary>
        /// <param name="graph">Graphics object for drawing.</param>
        /// <param name="pen">Pen for drawing the outline.</param>
        /// <param name="brush">Brush for filling the square.</param>
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            base.Draw(graph, pen, brush);
        }
    }
}
