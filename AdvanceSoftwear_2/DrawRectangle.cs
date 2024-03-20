using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSoftwear_2
{
    internal class DrawRectangle
    {
        private int width;
        private int height;

        public DrawRectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        
        public DrawRectangle() { }

        
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            this.width = list[2];
            this.height = list[3];
        }

        
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillRectangle(brush, x, y, width, height);
            graph.DrawRectangle(pen, x, y, width, height);
        }
    }
}