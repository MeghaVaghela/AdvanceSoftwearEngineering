using System.Drawing;


namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Defines methods for setting properties and drawing shapes on a graphics surface.
    /// </summary>
    interface IShapeInterface
    {
        /// <summary>
        /// Sets the properties of the shape using the specified list of parameters.
        /// </summary>
        /// <param name="list">An array containing the parameters to set for the shape.</param>
        void set(params int[] list);

        /// <summary>
        /// Sets the coordinates and points defining the vertices of a triangle shape.
        /// </summary>
        /// <param name="x">The x-coordinate of the top-left corner of the triangle's bounding rectangle.</param>
        /// <param name="y">The y-coordinate of the top-left corner of the triangle's bounding rectangle.</param>
        /// <param name="points">The array of points defining the vertices of the triangle.</param>
        void setTriangle(int x, int y, Point[] points);


        /// <summary>
        /// Draws the shape on the specified graphics surface using the specified pen and brush.
        /// </summary>
        /// <param name="graph">The graphics surface on which to draw the shape.</param>
        /// <param name="pen">The pen with which to draw the outline of the shape.</param>
        /// <param name="brush">The brush with which to fill the shape.</param>
        void Draw(Graphics graph, Pen pen, Brush brush);
    }
}
