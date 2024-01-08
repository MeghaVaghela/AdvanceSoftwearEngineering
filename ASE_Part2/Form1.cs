using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Part2
{

    /// <summary>
    /// Represents the main form of the application.
    /// </summary>
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



        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            display.Image = new Bitmap(Size.Width, Size.Height);
        }

        /// <summary>
        /// Executes a command based on provided parameters.
        /// </summary>
        /// <param name="Currentline">ArrayList containing the current line.</param>
        /// <param name="lines">Array of strings containing lines.</param>
        /// <param name="linecount">Count of lines.</param>


        public void excecuteCommand(ArrayList Currentline, string[] lines, int linecount)
        {
            int counter = 0;
            int jump = 0;

            // Begin the loop that iterates through the lines of the code
            while (lines.Length >= counter)
            {
                // Initialize graphics, pen, and brush objects for drawing
                Graphics graph = Graphics.FromImage(display.Image);
                Pen pen = new Pen(penColor, 2);
                Brush brush = new SolidBrush(brushcolor);

                try
                {
                    // Check for 'jump' and adjust the counter
                    if (jump != 0)
                    {
                        if (jump == counter)
                        {
                            counter++;
                            jump = 0;
                        }
                    }
                    split = (string[])Currentline[counter];

                    // Switch statement to handle different commands
                    switch (split[0].ToLower())
                    {
                        // Individual cases for different drawing commands and operations
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
                                graph.DrawLine(pen, x, y, point1, point1);

                            }
                            else
                            {
                                int.TryParse(split[1], out point1);
                                int.TryParse(split[2], out point2);
                                graph.DrawLine(pen, x, y, point1, point2);

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

                            Design1 = designFactory.GetDesign(split[1]);
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
                    display.Refresh();
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
        /// <summary>
        /// Checks if a variable is set; if not, sets or resets it based on provided elements.
        /// </summary>
        /// <param name="element1">The variable name to be checked or set.</param>
        /// <param name="element2">The value to assign to the variable.</param>
        private void VarCheck(string element1, string element2) //used to check if the var is set if not to set it or re set it 
        {
            try
            {
                bool variableExists = false;
                int index = 0;

                // Check if the variable already exists
                while (index < parmerter.Length && parmerter[index] != null)
                {
                    if (parmerter[index].Equals(element1))
                    {
                        variableExists = true;
                        break;
                    }
                    index++;
                }

                if (variableExists)
                {
                    MessageBox.Show("Variable already declared", "Error");
                }
                else
                {
                    // Find an empty slot or the first null element
                    index = 0;
                    while (index < parmerter.Length && parmerter[index] != null)
                    {
                        index++;
                    }

                    if (index < parmerter.Length)
                    {
                        parmerter[index] = element1;
                        int.TryParse(element2, out stringSplit[index]);
                    }
                    else
                    {
                        MessageBox.Show("Reached maximum variable limit", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
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

                String txtdata = CommandLine.Text;
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
                        lines = ControlPannel.Lines.ToArray();
                        while (lines.Length != i)
                        {

                            line = lines[i].Split(' ');
                            Currentline.Add(line);
                            i++;
                        }

                    }
                    else
                    {
                        lines = CommandLine.Lines.ToArray();
                        line = CommandLine.Text.Split(' ');
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

        private void Btn1_Click(object sender, EventArgs e)
        {
            String input = ControlPannel.Text;
            if (input.Trim() == "")
            {
                MessageBox.Show("Enter a command", "ERROR");

            }
            else
            {
                String[] line;
                String[] lines;
                ArrayList Currentline = new ArrayList();
                int i = 0;
                lines = ControlPannel.Lines.ToArray();
                while (lines.Length != i)
                {

                    line = lines[i].Split(' ');
                    Currentline.Add(line);
                    i++;
                }
                int length = lines.Length;

                Check(Currentline, lines, length);
                int L = 0;
                Array.Clear(parmerter, 0, parmerter.Length);//used to cleare the vars array befreo exicution
                Array.Clear(stringSplit, 0, stringSplit.Length);
                string errors = string.Join(", ", stringError.Where(x => x != 0));


                if (conditionFlag == false)
                {

                    MessageBox.Show("Error Occur in Line no. :" + errors + ".", "error");
                }
                else
                {

                    excecuteCommand(Currentline, lines, length);
                }

            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ControlPannel.Text = "";
            CommandLine.Text = "";
        }

        /// <summary>
        /// Handles the button click event to save text from a control panel to a text file.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btn3_Click_1(object sender, EventArgs e)
        {

            // Create a memory stream from the text entered in the ControlPanel.
            MemoryStream userInput = new MemoryStream(Encoding.UTF8.GetBytes(ControlPannel.Text));

            // Initialize and configure the SaveFileDialog.
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";
            save.Filter = "Text files (.txt)|.txt|All files (.)|.";


            // Display the SaveFileDialog and capture the user's choice.
            DialogResult result = save.ShowDialog();
            Stream fileStream;

            // If the user chose to save the file, proceed with saving.
            if (result == DialogResult.OK)
            {
                // Open the file stream to save the user input.
                fileStream = save.OpenFile();


                // Reset the position of the userInput stream to the beginning.
                userInput.Position = 0;


                // Write the content of the userInput stream to the fileStream.
                userInput.WriteTo(fileStream);

                // Close the fileStream and userInput stream.
                fileStream.Close();
                userInput.Close();

            }
            // Dispose of the SaveFileDialog to free up resources.
            save.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void display_Click(object sender, EventArgs e)
        {

        }

        private void ControlePanel_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesignComplexShape(Graphics g, Pen pen, Brush brush, int circleSize, int rectangleWidth, int rectangleHeight, int triangleSize)
        {
            // Get the center of the display
            int centerX = display.Width / 2;
            int centerY = display.Height / 2;

            // Draw a circle
            drawCircle circle = new drawCircle(centerX, centerY, circleSize);
            circle.Draw(g, pen, brush);

            // Draw a rectangle
            drawRectangle rectangle = new drawRectangle(centerX + 40, centerY, rectangleWidth, rectangleHeight);
            rectangle.Draw(g, pen, brush);

            // Draw a triangle
            System.Drawing.Point[] trianglePoints = { new Point(centerX + 100, centerY), new Point(centerX + 150, centerY + triangleSize), new Point(centerX + 200, centerY) };
            drawTriangle triangle = new drawTriangle();
            triangle.setTriangle(centerX, centerY, trianglePoints);
            triangle.Draw(g, pen, brush);
        }

        private void method1_Click(object sender, EventArgs e)
        {
            ExampleTask2();
        }

        private void Btn3_Click_1(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream(Encoding.UTF8.GetBytes(ControlPannel.Text));

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "txt";
            save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult result = save.ShowDialog();
            Stream fileStream;

            if (result == DialogResult.OK)
            {

                fileStream = save.OpenFile();
                userInput.Position = 0;
                userInput.WriteTo(fileStream);
                fileStream.Close();
                userInput.Close();

            }
            save.Dispose();
        }

        private void Btn2_Click_1(object sender, EventArgs e)
        {
            ControlPannel.Text = "";
            CommandLine.Text = "";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "TXT Files|*.txt";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                ControlPannel.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
            openFile1.Dispose();
        }

        private void ExampleTask2()
        {
            // Use the existing Graphics object from the display
            Graphics g = Graphics.FromImage(display.Image);
            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Cyan);

            // Specify the sizes
            int circleSize = 40;
            int rectangleWidth = 50;
            int rectangleHeight = 30;
            int triangleSize = 20;

            // Call the DrawCustomShape method
            DesignComplexShape(g, pen, brush, circleSize, rectangleWidth, rectangleHeight, triangleSize);
            MessageBox.Show("Drawing completed!");


            display.Refresh();
        }




    }

}

