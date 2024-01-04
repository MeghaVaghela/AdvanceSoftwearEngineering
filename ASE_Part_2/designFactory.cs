using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Part_2
{
    public class designFactory
    {
        public Design getDesign(String DesignType)
        {
            DesignType = DesignType.ToLower().Trim();

            if(DesignType.Equals("circle"))
            {
                return new drawCircle();
            }
            else if(DesignType.Equals("square"))
            {
                return new drawSquare();
            }
            else if(DesignType.Equals("triangle"))
            {
                return new drawTriangle();
            }
            else if (DesignType.Equals("rect"))
            {
                return new drawRectangle();
            }
            else
            {
                System.ArgumentException argumentException = new System.ArgumentException("Factory Exception occur :" + DesignType + " is not available");
            }
        }
    }
}
;