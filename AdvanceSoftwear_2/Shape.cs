using System.Drawing;

namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Represents a base class for shapes to be drawn on a graphics surface.
    /// </summary>  
    public abstract class Shape:IShapeInterface
    {
        
        protected int x, y;

        // <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class with the specified coordinates.
        /// </summary>
        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>   
        public Shape() { }


        /// <summary>
        /// Sets the x-coordinate and y-coordinate of the shape's position using the specified parameters.
        /// </summary>
        public virtual void set(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
        }

        /// <summary>
        /// Sets the coordinates and points defining the vertices of a triangle shape.
        /// </summary>
        public virtual void setTriangle(int x, int y, Point[] points)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Draws the shape on the specified graphics surface using the specified pen and brush.
        /// </summary>
        public abstract void Draw(Graphics graph, Pen pen, Brush brush);


    }
}
