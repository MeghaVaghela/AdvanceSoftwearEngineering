using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{
    public class drawSquare:drawRectangle
    {
        readonly int size;

        public drawSquare()
        {
        }

        public drawSquare(int x, int y,int size): base(x,y,size,size)
        {
            this.size = size;
        }

        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            base.Draw(graph, pen, brush);
        }
    }
}
