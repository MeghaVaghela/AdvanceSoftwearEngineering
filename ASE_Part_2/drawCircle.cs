using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{
    public class drawCircle 
    {
        int diameter;

        public drawCircle(int diameter)
        { this.diameter = diameter; }

        public drawCircle(int x , int y,int diameter):base(x,y)
        {
            this.diameter = diameter;
        }

        public drawCircle():base()
        { }

        public override void Draw(Graphics graph, Pen Pen, Brush brush)
        {
            graph.FillEllipse(brush, x, y, diameter * 2, diameter * 2);
            graph.DrawEllipse(Pen, x, y, diameter * 2, diameter * 2);
        }

        public override void set(Parameter int[] list)
        {
            base.set(list[0], list[1]);
            this.diameter = list[2];
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.diameter;
        }
    }
}
