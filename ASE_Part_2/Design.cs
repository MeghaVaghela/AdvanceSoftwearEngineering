using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{
    public abstract class Design:designInterface
    {
        protected int x,y;

        public Design(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Design() { }

        public virtual void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
        }

        public virtual void setTriangle(int x, int y, Point[] points) 
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Draw(Graphics graph, Pen pen, Brush brush);

        public override string ToString()
        {
            return base.ToString() + "   " + this.x + "," + this.y + ":: ";
        }
    }
}
