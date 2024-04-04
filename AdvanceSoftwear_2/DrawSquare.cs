using System.Drawing;

namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Represents a square shape to be drawn on a graphics surface.
    /// </summary>
    public class DrawSquare:DrawRectangle
    {
        private int size;

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawSquare"/> class with the specified coordinates and size.
        /// </summary>
        public DrawSquare()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DrawSquare"/> class.
        /// </summary>
        public DrawSquare(int x, int y, int size) : base(x, y, size, size)
        {
            this.size = size;
        }

        /// <summary>
        /// Draws the square on the specified graphics surface using the specified pen and brush.
        /// </summary>
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            base.Draw(graph, pen, brush);
        }

    }
}
