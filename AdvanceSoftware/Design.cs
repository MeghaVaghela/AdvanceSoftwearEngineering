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
        Rectangle Current_Position;
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
                DesignValues.isUnitTestValid = false;   
            }
        }
        public void DrawCircle(int width)
        {
            try
            {
                int x_pos = x - (width / 2);
                int y_pos = y - (width / 2);
                Current_Shape = new Rectangle(x_pos, y_pos, width, width);
                if(DesignValues.isFill)
                {
                    this.graph.FillEllipse(DesignValues.fillColour, Current_Shape);
                    this.graph.DrawEllipse(pen, x_pos, y_pos, width, width);
                    DesignValues.isUnitTestValid = true;    
                }
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DesignValues.isUnitTestValid = false;
            }
        }

        public  void DrawLine(int x_pos, int y_pos)
        {
            try
            {
                if (DesignValues.isFill)
                {
                    pen = new Pen(DesignValues.pointerColor, 1);
                    this.graph.DrawLine(pen, x, y, x_pos, y_pos);
                }
                else
                {
                    this.graph.DrawLine(pen, x, y, x_pos, y_pos);
                    pen = new Pen(Color.Gray, 1);
                    DesignValues.isUnitTestValid = true;
                }
            }
            catch(Exception ex)
            {
                PrintMessage(ex.Message);
                DesignValues.isUnitTestValid= false;
            }
        }

        public void DrawRectangle(int width, int height)
        {
            try
            {
                int x_pos = x - (width / 2);
                int y_pos = y - (width / 2);
                Current_Shape = new Rectangle(x_pos,y_pos,width,height);
                if (DesignValues.isFill)
                    this.graph.FillRectangle(DesignValues.fillColour, Current_Shape);
                this.graph.DrawRectangle(pen, Current_Shape);
            }
            catch (Exception ex) { 
                PrintMessage(ex.Message);
                DesignValues.isUnitTestValid = false;
            }
        }

        public void MovePoint(int x_pos, int y_pos)
        {
            try
            {
                pen = new Pen(SystemColors.ActiveBorder, 2);
                this.graph.DrawRectangle(pen, Current_Position);
                pen = new Pen(Color.Blue,2);
                Current_Position = GetRectangle(x_pos, y_pos, 2, 2);
                this.graph.DrawRectangle(pen, Current_Position);
                x = DesignValues.x = x_pos;
                y = DesignValues.y = y_pos;
                pen = new Pen(Color.Gray, 1);
                DesignValues.isUnitTestValid = true;
            }
            catch(Exception ex)
            {
                PrintMessage(ex.Message);
                DesignValues.isUnitTestValid=false;
            }
        }
        public void DrawTriangle(int x_pos,int y_pos, int z_pos)
        {
            try
            {
                int tx, ty, cx, cy;
                cx = Convert.ToInt32(x - (x_pos / 3));
                cy = Convert.ToInt32(y - (y_pos / 3));
                tx = Convert.ToInt32(cx + x_pos);
                ty = Convert.ToInt32(cy + y_pos);

                Point[] point = new Point[3];
                point[0] = new Point(cx, cy);
                point[1] = new Point(tx, cy);
                point[2] = new Point(cx, ty);

                if (DesignValues.isFill)
                    this.graph.FillPolygon(DesignValues.fillColour, point);
                this.graph.DrawPolygon(pen,point);
                DesignValues.isUnitTestValid = true;
            }
            catch (Exception ex)
            {
                PrintMessage(ex.Message);
                DesignValues.isUnitTestValid=false;
            }
        }
        public void Current_Point(Boolean flag)
        {
            pen = new Pen(Color.Black,2);
            if (flag)
            {
                Current_Position = GetRectangle(DesignValues.x, DesignValues.y, 2, 2);
                this.graph.DrawRectangle(pen,Current_Position);
            }
            else
            {
                x = y = 0;
                DesignValues.x=DesignValues.y=0;
                Current_Position=GetRectangle(x, y, 2, 2);
                this.graph.DrawRectangle(pen, Current_Position);
            }
            pen = new Pen(Color.Gray,2);
        }

        public void PrintMessage(string Error_Message) 
        {
            using(Font MyFont = new Font("Arial", 9))
            {
                graph.DrawString(Error_Message, MyFont, Brushes.Gray,new Point(5,5));
            }
        }

        private Rectangle GetRectangle(int Rec_x, int Rec_y, int Rec_width, int Rec_height)
        {
            return new Rectangle(Rec_x, Rec_y, Rec_width, Rec_height);
        }

    }
}
