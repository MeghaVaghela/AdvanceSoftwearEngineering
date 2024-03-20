using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSoftwear_2
{
    internal class DrawSquare
    {
        readonly int size;

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
