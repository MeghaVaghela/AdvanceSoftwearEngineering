using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceSoftwear_2
{
    internal class DrawCircle
    {
        int diameter;

        public DrawCircle(int diameter)
        {
            this.diameter = diameter;
        }

        public DrawCircle(int x, int y, int diameter):base(x, y)
        {
            this.diameter = diameter;
        }

        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillEllipse(brush, X, Y, diameter * 2, diameter * 2);
            graph.DrawEllipse(pen, X, Y, diameter * 2, diameter * 2);
        }
        public override void Set(params int[] list)
        {
            base.Set(list[0], list[1]);
            if (list.Length >= 3)
            {
                diameter = list[2];
            }
        }
        public override string ToString()
        {
            return base.ToString() + " " + diameter;
        }
    }
}
