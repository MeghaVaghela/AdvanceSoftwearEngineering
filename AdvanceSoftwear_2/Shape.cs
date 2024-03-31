using System.Drawing;

namespace AdvanceSoftwear_2
{
    public  abstract class Shape:IShapeInterface
    {
        protected int x, y;

        
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
                
        public Shape() { }
                
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


    }
}
