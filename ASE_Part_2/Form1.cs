using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace ASE_Part_2
{
    public partial class Form1 : Form
    {
        private int x = 0, y = 0;

        // Variable For Partition
        private string[] split;
        private string[] parmerter = new string[50];
        private int[] stringSplit = new int[50];
        private int[] stringError = new int[50];

        // Variable for looping
        private int loopMax;
        private int loopStart;
        private int loopEnd;
        private int loopCount;
        private int errorCount = 0;

        // Flag Bits
        private bool FirstBit = false;
        private bool resultIf = false;
        private bool stringIf = false;
        private bool conditionFlag = false;

        // Univseral Color
        private Color penColor = Color.Black;
        private Color brushcolor = Color.Gray;
        private Random random = new Random();

        //Design Factory
        private Design Design1;
        private designFactory designFactory = new designFactory();
        private object display;

        public Form1()
        {
            InitializeComponent();
            display.Image = new Bitmap(Size.Width, Size.Height);
        }
        public void excecuteCommand(ArrayList Currentline, string[] lines, int linecount)
        {


            int counter = 0;
            int jump = 0;


            while (lines.Length >= counter)
            {
                Graphics graph = Graphics.FromImage(display.Image);
                Pen pen = new Pen(penColor, 2);
                Brush brush = new SolidBrush(brushcolor);

                try
                {
                    if (jump != 0)
                    {
                        if (jump == counter)
                        {
                            counter++;
                            jump = 0;
                        }
                    }

                    split = (string[])Currentline[counter];


                    switch (split[0].ToLower())
                    {
                        case "circle":

                            int radius;
                            if (!int.TryParse(split[1], out radius))
                            {

                                radius = varCall((string)split[1]);
                                new drawCircle(x, y, radius).Draw(graph, pen, brush);
                            }
                            else if (int.TryParse(split[1], out radius))
                            {
                                int.TryParse(split[1], out radius);
                                new drawCircle(x, y, radius).Draw(graph, pen, brush);
                            }
                            else
                            {
                                MessageBox.Show("enter a radius or use a variable", "error");
                            }
                            break;
                        case "rect":

                            int width;

                            int height;
                            if (!int.TryParse(split[1], out width) || !int.TryParse(split[2], out height))
                            {
                                width = varCall(split[1]);
                                height = varCall(split[2]);
                                new drawRectangle(x, y, width, height).Draw(graph, pen, brush);

                            }
                            else
                            {
                                int.TryParse(split[1], out width);
                                int.TryParse(split[2], out height);
                                new drawRectangle(x, y, width, height).Draw(graph, pen, brush);
                            }
                            break;
                        case "square":
                            int side;
                            if (!int.TryParse(split[1], out side))
                            {
                                side = varCall(split[1]);
                                new drawSquare(x, y, side).Draw(graph, pen, brush);
                            }
                            else
                            {
                                int.TryParse(split[1], out side);
                                new drawSquare(x, y, side).Draw(graph, pen, brush);
                            }

                            break;
                        case "drawto":
                            int point1, point2;
                            if (!int.TryParse(split[1], out point1) || !int.TryParse(split[2], out point2))
                            {
                                point1 = varCall(split[1]);
                                point2 = varCall(split[2]);
                                g.DrawLine(pen, x, y, point1, point1);

                            }
                            else
                            {
                                int.TryParse(split[1], out point1);
                                int.TryParse(split[2], out point2);
                                g.DrawLine(pen, x, y, point1, point2);

                            }
                            break;
                        case "pen":
                            try
                            {
                                if (split[1] != "rand")
                                {
                                    penColor = Color.FromName(split[1]);
                                }
                                else
                                {
                                    penColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                                }
                            }
                            catch
                            {
                                penColor = Color.Black;
                            }
                            break;
                        case "brush":
                            try
                            {
                                if (split[1] != "rand")
                                {
                                    brushcolor = Color.FromName(split[1]);
                                }
                                else
                                {
                                    brushcolor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                                }

                            }
                            catch
                            {
                                brushcolor = Color.Black;
                            }
                            break;
                        case "triangle":
                            int p1, p2, p3;

                            if (!int.TryParse(split[1], out p1) || !int.TryParse(split[2], out p2) || !int.TryParse(split[3], out p3))
                            {
                                p1 = varCall(split[1]);
                                p2 = varCall(split[2]);
                                p3 = varCall(split[3]);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new drawTriangle(pnt1).Draw(graph, pen, brush);
                            }
                            else
                            {
                                int.TryParse(split[1], out p1);
                                int.TryParse(split[2], out p2);
                                int.TryParse(split[3], out p3);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new drawTriangle(pnt1).Draw(graph, pen, brush);
                            }
                            break;
                        case "clear":
                            graph.Clear(Color.Transparent);
                            graph.Dispose();
                            break;

                        case "moveto":

                            if (int.TryParse(split[1], out x) && int.TryParse(split[2], out y))
                            {
                                int.TryParse(split[1], out x);
                                int.TryParse(split[2], out y);
                            }
                            else
                            {
                                x = varCall(split[1]);
                                y = varCall(split[2]);
                            }

                            break;

                        case "var":
                            VarCheck(split[1], split[2]);
                            break;

                        case "loop":
                            FirstBit = true;
                            loopMax = 0;
                            loopCount = 0;
                            loopStart = counter;

                            if (int.TryParse(split[1], out loopMax))
                            {
                                int.TryParse(split[1], out loopMax);
                            }
                            else
                            {
                                loopMax = varCall(split[1]);
                            }

                            if (lines[counter] == "end" && loopCount != loopMax)
                            {
                                counter = loopEnd;
                                FirstBit = false;
                                break;
                            }
                            else if (lines[counter] == "end" && loopCount != loopMax)
                            {
                                loopCount++;
                                loopEnd = counter++;
                                counter = loopStart;
                                counter++;
                                break;

                            }
                            else
                            {
                                loopCount++;
                                break;
                            }
                        case "end":
                            if (loopCount == loopMax || loopCount > loopMax)
                            {

                            }
                            else
                            {
                                counter = loopStart;
                            }


                            break;
                        case "num":

                            x = random.Next(display.Width);
                            y = random.Next(display.Height);
                            brushcolor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                            penColor = Color.Black;

                            Design1 = designFactory.getDesign(split[1]);
                            if (split[1].ToLower().Trim() == "circle")
                            {
                                radius = random.Next(Size.Width / 4);
                                Design1.set(x, y, radius);
                            }
                            else if (split[1].ToLower().Trim() == "rectangle")
                            {
                                width = random.Next(display.Width);
                                height = random.Next(display.Height);
                                Design1.set(x, y, width, height);
                            }
                            else if (split[1].ToLower().Trim() == "triangle")
                            {
                                p1 = random.Next(display.Width);
                                p2 = random.Next(display.Width);
                                p3 = random.Next(display.Width);
                                System.Drawing.Point pointa = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc = new System.Drawing.Point(p3, p1);
                                System.Drawing.Point[] pnt = { pointa, pointb, pointc };
                                Design1.setTriangle(x, y, pnt);
                            }
                            Design1.Draw(graph, pen, brush);
                            display.Refresh();
                            break;
                        case "if":
                            int left;
                            int right;
                            string condition;
                            if (split.Length > 4)
                            {
                                MessageBox.Show("need more input", "Error");
                            }
                            else
                            {
                                if (!int.TryParse(split[1], out left))
                                {
                                    left = varCall(split[1]);
                                }
                                else
                                {
                                    int.TryParse(split[1], out left);
                                }

                                if (!int.TryParse(split[3], out right))
                                {
                                    right = varCall(split[3]);
                                }
                                else
                                {
                                    int.TryParse(split[3], out right);
                                }
                                condition = split[2];
                                ifcheck(left, condition, right);
                                if (FirstBit == true)
                                {

                                    jump = counter;
                                    jump++;
                                    jump++;



                                    break;
                                }
                                else
                                {

                                    counter++;

                                }




                            }

                            break;
                        case "endif":
                            jump = 0;
                            stringIf = false;
                            break;


                        default:
                            if (split[0].Trim() == null)
                            {

                            }
                            else
                            {
                                int i = 0;
                                if (parmerter[0] != null)
                                {
                                    while (49 >= i)
                                    {
                                        if (parmerter[i] == split[0])
                                        {
                                            //  MessageBox.Show(element[0] + " called", "whoop");
                                            if (!int.TryParse(split[1], out stringSplit[i]))
                                            {
                                                MessageBox.Show(split[0] + "is all ready set to " + split[1], "info");
                                            }
                                            else
                                            {
                                                int.TryParse(split[1], out stringSplit[i]);
                                                MessageBox.Show(split[0] + " variable is set to " + split[1], "info");
                                            }
                                            i = 50;
                                        }
                                        else if (i != parmerter.Length)
                                        {
                                            i++;
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show(split[0] + " not a Command", "Messgae");
                                }
                            }
                            break;

                    }
                    if (FirstBit == true)
                    {
                        loopCount++;
                    }
                    display.Referesh();

                }
                catch
                {
                }
                pen.Dispose();
                brush.Dispose();


                counter++;
            }



        }
        private bool ifcheck(int left, string condition, int right) // used to check if sattment 
        {
            switch (condition)
            {

                case "=":
                    if (left == right)
                    {
                        FirstBit = true;
                    }
                    else
                    {
                        FirstBit = false;
                    }
                    break;
                case ">":
                    if (left > right)
                    {
                        FirstBit = true;
                    }
                    else
                    {
                        FirstBit = false;
                    }

                    break;
                case "<":
                    if (left < right)
                    {
                        FirstBit = true;
                    }
                    else
                    {
                        FirstBit = false;
                    }

                    break;
                case "!":
                    if (left != right)
                    {
                        FirstBit = true;
                    }
                    else
                    {
                        FirstBit = false;
                    }

                    break;

                default:
                    MessageBox.Show("condition is not correct please check", "error");

                    break;

            }

            return FirstBit;
        }
        private void VarCheck(string element1, string element2) //used to check if the var is set if not to set it or re set it 
        {
            int i = 0;
            try
            {
                if (parmerter[0] == null && stringSplit[0] == 0)  // arrays max is [49];
                {
                    parmerter[0] = element1;//name 
                    int.TryParse(element2, out stringSplit[0]);//value
                }
                else
                {
                    while (49 >= i)
                    {
                        if (parmerter[i].Equals(element1))//if names are the same
                        {
                            if (stringSplit[i].Equals(element2))
                            {
                                MessageBox.Show("Variable already decleard", "Error");

                                i = parmerter.Length;
                            }
                            else
                            {
                                i++;
                            }
                        }
                        else if (i >= parmerter.Length)
                        {
                            i++;
                        }
                        else
                        {
                            parmerter[i++] = element1;
                            int.TryParse(element2, out stringSplit[i]);

                        }
                    }
                }

            }
            catch
            {

            }

        }
        private int varCall(string variable)
        {
            int i = 0;
            int number = -1;
            while (49 >= i)
            {
                if (parmerter[i] == variable)
                {

                    number = stringSplit[i];
                    i = 50;
                }
                else
                {
                    i++;
                }

            }
            if (number == 0)
            {
                MessageBox.Show("not a variable", "error");
            }
            return number;

        }

        private void Commandline_KeyDown(object sender, KeyEventArgs e) //used to run the program
        {
            if (e.KeyCode == Keys.Enter)
            {

                String txtdata = commandline.Text;
                if (txtdata.Trim() == "")
                {
                    MessageBox.Show("Kindly enter any command first", "ERROR");

                }
                else
                {
                    String[] line;
                    String[] lines;
                    ArrayList Currentline = new ArrayList();
                    int i = 0;
                    if (txtdata.ToLower().Trim() == "run")
                    {
                        lines = ControlePanel.Lines.ToArray();
                        while (lines.Length != i)
                        {

                            line = lines[i].Split(' ');
                            Currentline.Add(line);
                            i++;
                        }

                    }
                    else
                    {
                        lines = commandline.Lines.ToArray();
                        line = commandline.Text.Split(' ');
                        Currentline.Add(line);


                    }
                    int length = lines.Length;

                    Check(Currentline, lines, length);
                    int L = 0;
                    Array.Clear(parmerter, 0, parmerter.Length);//used to cleare the vars array befreo exicution
                    Array.Clear(stringSplit, 0, stringSplit.Length);
                    string errors = string.Join(", ", stringError.Where(x => x != 0));


                    if (conditionFlag == false)
                    {

                        MessageBox.Show("Errors on lines :" + errors + ".", "error");
                    }
                    else
                    {

                        excecuteCommand(Currentline, lines, length);
                    }


                }
            }


        }
        public void Check(ArrayList currentline, string[] lines, int length)// checks the syntax of the user input
        {
            int count = 0;
            int errors = 0;
            errorCount = 0;
            conditionFlag = true;
            int k = 0;
            int linenumber = 0;


            while (lines.Length >= count)
            {

                errors = errorCount;
                try
                {
                    split = (String[])currentline[count];


                    switch (split[0].ToLower())
                    {
                        case "circle":
                            if (split.Length != 2)
                            {
                                errorCount++;
                            }

                            break;

                        case "rect":
                            if (split.Length != 3)
                            {
                                errorCount++;
                            }

                            break;

                        case "square":
                            if (split.Length != 3)
                            {
                                errorCount++;
                            }
                            break;

                        case "drawto":
                            if (split.Length != 3)
                            {
                                errorCount++;
                            }

                            break;
                        case "pen":
                            if (split.Length != 2)
                            {
                                errorCount++;
                            }
                            break;
                        case "brushcolor":
                            if (split.Length != 2)
                            {
                                errorCount++;
                            }
                            break;
                        case "triangle":
                            if (split.Length != 4)
                            {
                                errorCount++;
                            }

                            break;
                        case "clear":


                            break;
                        case "movex":
                            if (split.Length != 2)
                            {
                                errorCount++;
                            }

                            break;
                        case "movey":
                            if (split.Length != 2)
                            {
                                errorCount++;
                            }

                            break;
                        case "moveto":
                            if (split.Length != 3)
                            {
                                errorCount++;
                            }


                            break;

                        case "var":

                            if (split.Length != 3)
                            {
                                errorCount++;
                            }
                            else
                            {
                                VarCheck(split[1], split[2]);
                            }

                            break;

                        case "loop":
                            if (split.Length != 2)
                            {
                                errorCount++;
                            }
                            break;
                        case "end":
                            if (split.Length != 1)
                            {
                                errorCount++;
                            }
                            break;
                        case "factory":
                            if (split.Length != 2)
                            {
                                errorCount++;
                            }

                            break;
                        case "if":
                            if (split.Length != 4)
                            {
                                errorCount++;
                            }

                            break;
                        case "endif":
                            if (split.Length != 1)
                            {
                                errorCount++;
                            }
                            break;
                        default:
                            if (split[0].Trim() == null)
                            {

                            }
                            else
                            {
                                int i = 0;
                                if (parmerter[0] != null)
                                {
                                    while (49 >= i)
                                    {
                                        if (parmerter[i] == split[0])
                                        {
                                            //  MessageBox.Show(element[0] + " called", "whoop");
                                            if (!int.TryParse(split[1], out stringSplit[i]))
                                            {
                                                MessageBox.Show(split[0] + "is all ready set to " + split[1], "whoop");
                                            }
                                            else
                                            {
                                                int.TryParse(split[1], out stringSplit[i]);
                                                MessageBox.Show(split[0] + " variable is set to " + split[1], "whoop");
                                            }
                                            i = 50;
                                        }
                                        else if (i != parmerter.Length)
                                        {
                                            i++;
                                        }

                                    }
                                }
                                else
                                {
                                    errorCount++;
                                }
                            }
                            break;


                    }
                    if (errors != errorCount)
                    {
                        linenumber = count;
                        linenumber++;
                        stringError[k] = linenumber;
                        k++;
                        errors++;


                    }
                }
                catch
                {

                }
                count++;
                if (errorCount != 0)
                {
                    conditionFlag = false;
                }
                else
                {
                    conditionFlag = true;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {

        }
    }
}