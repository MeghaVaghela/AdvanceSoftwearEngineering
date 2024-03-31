using System.Drawing;


namespace AdvanceSoftwear_2
{
    public class DrawRectangle:Shape
    {
        private int width;
        private int height;

        public DrawRectangle(int x, int y, int width, int height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        
        public DrawRectangle() { }

        
        public override void set(params int[] items)
        {
            base.set(items[0], items[1]);
            this.width = items[2];
            this.height = items[3];
        }

        
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillRectangle(brush, x, y, width, height);
            graph.DrawRectangle(pen, x, y, width, height);
        }
    }
}