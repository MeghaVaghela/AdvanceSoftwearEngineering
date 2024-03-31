using System.Drawing;

namespace AdvanceSoftwear_2
{
    public class DrawSquare:DrawRectangle
    {
        private int size;

        public DrawSquare()
        {
        }

        public DrawSquare(int x, int y, int size) : base(x, y, size, size)
        {
            this.size = size;
        }

        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            base.Draw(graph, pen, brush);
        }

    }
}
