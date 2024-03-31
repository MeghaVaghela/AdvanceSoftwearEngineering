using System.Drawing;

namespace AdvanceSoftwear_2
{
    public class DrawCircle:Shape
    {
       private int diameter;

        //public DrawCircle(int diameter)
        //{
        //    this.diameter = diameter;
        //}

        public DrawCircle(int x, int y, int diameter) : base(x, y)
        {
            this.diameter = diameter;
        }

    //public int Diameter
    //{
    //    get { return diameter; }
    //    set { diameter = value; }
    //}
    public DrawCircle() : base()
        { }
        public override void Draw(Graphics graph, Pen pen, Brush brush)
        {
            graph.FillEllipse(brush, x, y, diameter * 2, diameter * 2);
            graph.DrawEllipse(pen, x, y, diameter * 2, diameter * 2);
        }
        public override void set(params int[] list)
        {
            base.set(list[0], list[1]);
            if (list.Length >= 3)
            {
                diameter = list[2];
            }
        }
        
    }
}
