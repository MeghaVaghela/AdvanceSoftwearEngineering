using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// This class represents a collection of design-related values and settings used for drawing.
/// </summary>
namespace AdvanceSoftware
{

    /// <summary>
    /// A class that holds various design-related values and settings for drawing.
    /// </summary>
    public class DesignValues
    {
        // variable declaration.
        // Initialize a new Bitmap with dimensions 60x480 pixels for drawing.
        static private Bitmap _newPic = new Bitmap(640, 480); 
        //Initialize variables to store the current position (_x,_y).
        private static int _x, _y;
        // Initialize a SolidBrush for filling shapes with color.
        static SolidBrush _fillColour;
        // A flag to determine if filling is enabled for shapes.
        static Boolean _isFill;
        // A flag to indicate if the unit test is valid or not.
        static Boolean _isUnitTestValid;
        // Store the color for a pointer or cursor.
        static Color _pointerColor;


        /// <summary>
        /// Gets or sets the Bitmap used for drawing, initialized with dimensions 640x480 pixels.
        /// </summary>
        public static Bitmap newPic
        {
            get
            {
                return _newPic;
            }
            set { _newPic = value; }
        }


        /// <summary>
        /// Gets or sets the X-coordinate of the current position.
        /// </summary>
        public static int x
        {
            get { return _x; }  
            set { _x = value; }
        }


        /// <summary>
        /// Gets or sets the Y-coordinate of the current position.
        /// </summary>
        public static int y
        {
            get { return _y; }
            set { _y = value; }
        }


        /// <summary>
        /// Gets or sets the SolidBrush used for filling shapes with color.
        /// </summary>
        public static SolidBrush fillColour
        {
            get {
            return _fillColour;}
            set { _fillColour = value; }
        }



        /// <summary>
        /// Gets or sets a flag to determine if filling is enabled for shapes.
        /// </summary>
        public static Boolean isUnitTestValid
        {
            get
            {
                return _isUnitTestValid;
            }
            set
            {
                _isUnitTestValid = value;
            }
        }

        /// <summary>
        /// Gets or sets a flag to indicate if the unit test is valid or not.
        /// </summary>
        public static Color pointerColor
        {
            get
            {
                return _pointerColor;
            }
            set { _pointerColor = value; }
        }

        /// <summary>
        /// Gets or sets the color for a pointer or cursor.
        /// </summary>
        public static Boolean isFill
        {
            get
            {
                return _isFill;
            }
            set
            {
                _isFill = value;
            }
        }
            

    }
}
