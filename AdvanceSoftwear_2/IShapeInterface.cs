using System.Drawing;


namespace AdvanceSoftwear_2
{
    interface IShapeInterface
    {
        void set(params int[] list);

        void setTriangle(int x, int y, Point[] points);

        void Draw(Graphics graph, Pen pen, Brush brush);
    }
}
