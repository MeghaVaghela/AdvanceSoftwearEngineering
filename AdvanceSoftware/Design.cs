using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSoftware
{
    internal class Design
    {
        //Graphics variable to execute graphics fuction
        Graphics graph;
        //declaire pen variable
        Pen pen;
        //declare two integer variable x and y which show currunt position of ponter 
        int x, y;
        //declare current position recangle to show current pointer
        Rectangle Cuurent_Position;
        //declare current shape recangle to for getting current shape
        Rectangle Current_Shape;

        public Design()
        {
            this.graph = Graphics.FromImage(DesignValues.newPic);
            pen =   new Pen(Color.Black, 1);
            x = DesignValues.x;
            y = DesignValues.y;
       
        }

        public void DrawSquare(int width)
        {
            try
            {
                int x_pos = x - (width / 2);
                int y_pos = y - (width / 2);
                Current_Shape = new Rectangle(x_pos, y_pos, width, width);
                if(DesignValues.isFill) 
                {
                    this.graph.FillRectangle(DesignValues.fillColour, Current_Shape);
                    this.graph.DrawRectangle(pen, Current_Shape);
                    DesignValues.isUnitTestValid = true;
                }

            }
            catch(Exception ex)
            {
                PrintMessage(ex.Message);
                DesignValues.isUnitTestValid=false;
            }

        }

        public void PrintMessage(string Error_Message) 
        {
            using(Font MyFont = new Font("Arial", 9))
            {
                graph.DrawString(Error_Message, MyFont, Brushes.Gray,new Point(5,5));
            }
        }

    }
}
