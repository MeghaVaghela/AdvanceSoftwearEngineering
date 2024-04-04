using System;

namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Represents a factory class for creating instances of different shapes.
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Gets the shape based on the specified shape type.
        /// </summary>
        public Shape GetShape(String ShapeType)
        {
            ShapeType = ShapeType.ToLower().Trim();

            if (ShapeType.Contains("circle"))
            {
                return new DrawCircle();
            }
            else if (ShapeType.Contains("square"))
            {
                return new DrawSquare();
            }
            else if (ShapeType.Contains("triangle"))
            {
                return new DrawTriangle();
            }
            else if (ShapeType.Contains("rect"))
            {
                return new DrawRectangle();
            }
            else
            {
                // If the provided DesignType is not recognized, throw an ArgumentException.
                throw new System.ArgumentException("Factory Exception occur: " + ShapeType + " is not available");
            }
        }
    }
}
