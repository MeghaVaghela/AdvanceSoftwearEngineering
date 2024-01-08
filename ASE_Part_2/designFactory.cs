using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{

    /// <summary>
    /// Represents a factory class to create different designs based on specified types.
    /// </summary>
    public class designFactory
    {

        /// <summary>
        /// Gets the specific design object based on the provided DesignType.
        /// </summary>
        /// <param name="DesignType">Type of design to be created.</param>
        /// <returns>A Design object based on the specified type.</returns>
        public Design GetDesign(String DesignType)
        {
            DesignType = DesignType.ToLower().Trim();

            if (DesignType.Equals("circle"))
            {
                return new drawCircle();
            }
            else if (DesignType.Equals("square"))
            {
                return new drawSquare();
            }
            else if (DesignType.Equals("triangle"))
            {
                return new drawTriangle();
            }
            else if (DesignType.Equals("rect"))
            {
                return new drawRectangle();
            }
            else
            {
                // If the provided DesignType is not recognized, throw an ArgumentException.
                throw new System.ArgumentException("Factory Exception occur: " + DesignType + " is not available");
            }
        }

    }
}
