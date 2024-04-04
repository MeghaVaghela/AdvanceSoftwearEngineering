using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdvanceSoftwear_2
{
    /// <summary>
    /// Represents the main form of the Shape Application.
    /// </summary>
    public partial class ShapeApplication : Form
    {
        // Variables declaration

        int x = 0;
        int y = 0;

        string[] Partition;
        string[] parmerter = new string[50];
        int[] stringPartition = new int[50];
        int[] Error = new int[50];

        int Loop_Max;
        int Loop_Initializ;
        int Loop_Finish;
        int Loop_Count;
        int Error_Count = 0;

        bool initial_Bit = false;
        bool string_Condition = false;
        bool Flag_Condition = false;

        private Color penColor = Color.Black;
        private Color brushcolor = Color.Gray;
        private Random random = new Random();

        //Design Factory
        private Shape shape;
        private ShapeFactory ShapeFactory = new ShapeFactory();


        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeApplication"/> class.
        /// </summary>
        public ShapeApplication()
        {
            InitializeComponent();
            DisplayShape.Image = new Bitmap(Size.Width, Size.Height);
        }


        /// <summary>
        /// Checks the specified condition between two integer values.
        /// </summary>
        /// /// <param name="left">The left-hand side value of the condition.</param>
        /// <param name="condition">The condition to be checked ( "=", ">", "<", "!").</param>
        /// <param name="right">The right-hand side value of the condition.</param>
        /// <returns>True if the condition is satisfied; otherwise, false.</returns>
        private bool ifcheck(int left, string condition, int right)
        {
            if (condition == "=")
            {
                initial_Bit = left == right;
            }
            else if (condition == ">")
            {
                initial_Bit = left > right;
            }
            else if (condition == "<")
            {
                initial_Bit = left < right;
            }
            else if (condition == "!")
            {
                initial_Bit = left != right;
            }
            else
            {
                MessageBox.Show("Condition is not correct. Please check.", "Error");
            }

            return initial_Bit;
        }

        /// <summary>
        /// Executes a series of commands based on the provided lines of code.
        /// </summary>
        /// <param name="currentLine">An ArrayList containing the current line of code being executed.</param>
        /// <param name="lines">An array of strings representing all the lines of code.</param>
        /// <param name="lineCount">The total number of lines in the code.</param>
        /// <remarks>
        /// This method iterates through each line of code, parses the commands, and executes them accordingly.
        /// It handles various commands such as drawing shapes, setting colors, defining variables, and controlling loops and conditions.
        /// </remarks>
        public void ExecuteCommand(ArrayList currentLine, string[] lines, int lineCount)
        {
            int jump = 0;

            for (int counter = 0; counter < lines.Length; counter++)
            {
                Graphics graphic = Graphics.FromImage(DisplayShape.Image);
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
                    string[] Partition = (string[])currentLine[counter];

                    if (Partition.Length > 0)
                    {
                        string command = Partition[0].ToLower();

                        if (command == "circle")
                        {
                            int radius;
                            if (!int.TryParse(Partition[1], out radius))
                            {
                                radius = varCall(Partition[1]);
                                new DrawCircle(x, y, radius).Draw(graphic, pen, brush);
                            }
                            else
                            {
                                int.TryParse(Partition[1], out radius);
                                new DrawCircle(x, y, radius).Draw(graphic, pen, brush);
                            }
                        }
                        else if (command == "rect")
                        {
                            int width, height;
                            if (!int.TryParse(Partition[1], out width) || !int.TryParse(Partition[2], out height))
                            {
                                width = varCall(Partition[1]);
                                height = varCall(Partition[2]);
                                new DrawRectangle(x, y, width, height).Draw(graphic, pen, brush);
                            }
                            else
                            {
                                int.TryParse(Partition[1], out width);
                                int.TryParse(Partition[2], out height);
                                new DrawRectangle(x, y, width, height).Draw(graphic, pen, brush);
                            }
                        }
                        else if (command == "square")
                        {
                            int side;
                            if (!int.TryParse(Partition[1], out side))
                            {
                                side = varCall(Partition[1]);
                                new DrawSquare(x, y, side).Draw(graphic, pen, brush);
                            }
                            else
                            {
                                int.TryParse(Partition[1], out side);
                                new DrawSquare(x, y, side).Draw(graphic, pen, brush);
                            }

                        }
                        else if (command == "drawto")
                        {
                            int point1, point2;
                            if (!int.TryParse(Partition[1], out point1) || !int.TryParse(Partition[2], out point2))
                            {
                                point1 = varCall(Partition[1]);
                                point2 = varCall(Partition[2]);
                                graphic.DrawLine(pen, x, y, point1, point1);

                            }
                            else
                            {
                                int.TryParse(Partition[1], out point1);
                                int.TryParse(Partition[2], out point2);
                                graphic.DrawLine(pen, x, y, point1, point2);

                            }
                        }
                        else if (command == "pen")
                        {
                            try
                            {
                                if (Partition[1] != "rand")
                                {
                                    penColor = Color.FromName(Partition[1]);
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
                        }
                        else if (command == "brush")
                        {
                            try
                            {
                                if (Partition[1] != "rand")
                                {
                                    brushcolor = Color.FromName(Partition[1]);
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
                        }
                        else if (command == "triangle")
                        {
                            int p1, p2, p3;
                            if (!int.TryParse(Partition[1], out p1) || !int.TryParse(Partition[2], out p2) || !int.TryParse(Partition[3], out p3))
                            {
                                p1 = varCall(Partition[1]);
                                p2 = varCall(Partition[2]);
                                p3 = varCall(Partition[3]);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new DrawTriangle(pnt1).Draw(graphic, pen, brush);
                            }
                            else
                            {
                                int.TryParse(Partition[1], out p1);
                                int.TryParse(Partition[2], out p2);
                                int.TryParse(Partition[3], out p3);
                                System.Drawing.Point pointa1 = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb1 = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc1 = new System.Drawing.Point(p3, p1);

                                System.Drawing.Point[] pnt1 = { pointa1, pointb1, pointc1 };
                                new DrawTriangle(pnt1).Draw(graphic, pen, brush);
                            }
                        }
                        else if (command == "clear")
                        {
                            graphic.Clear(Color.Transparent);
                            graphic.Dispose();
                        }
                        else if (command == "moveto")
                        {
                            if (int.TryParse(Partition[1], out x) && int.TryParse(Partition[2], out y))
                            {
                                int.TryParse(Partition[1], out x);
                                int.TryParse(Partition[2], out y);
                            }
                            else
                            {
                                x = varCall(Partition[1]);
                                y = varCall(Partition[2]);
                            }

                        }
                        else if (command == "var")
                        {
                            VarCheck(Partition[1], Partition[2]);
                        }
                        else if (command == "loop")
                        {
                            initial_Bit = true;
                            Loop_Max = 0;
                            Loop_Count = 0;
                            Loop_Initializ = counter;

                            if (int.TryParse(Partition[1], out Loop_Max))
                            {
                                int.TryParse(Partition[1], out Loop_Max);
                            }
                            else
                            {
                                Loop_Max = varCall(Partition[1]);
                            }

                            if (lines[counter] == "end" && Loop_Count != Loop_Max)
                            {
                                counter = Loop_Finish;
                                initial_Bit = false;
                            }
                            else if (lines[counter] == "end" && Loop_Count != Loop_Max)
                            {
                                Loop_Count++;
                                Loop_Finish = counter++;
                                counter = Loop_Initializ;
                            }
                            else
                            {
                                Loop_Count++;
                            }
                        }
                        else if (command == "end")
                        {
                            if (Loop_Count == Loop_Max || Loop_Count > Loop_Max)
                            {

                            }
                            else
                            {
                                counter = Loop_Initializ;
                            }
                        }
                        else if (command == "num")
                        {
                            int radius, height, width;
                            int p1, p2, p3;
                            x = random.Next(DisplayShape.Width);
                            y = random.Next(DisplayShape.Height);
                            brushcolor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                            penColor = Color.Black;

                            shape = ShapeFactory.GetShape(Partition[1]);
                            if (Partition[1].ToLower().Trim() == "circle")
                            {
                                radius = random.Next(Size.Width / 4);
                                shape.set(x, y, radius);
                            }
                            else if (Partition[1].ToLower().Trim() == "rectangle")
                            {
                                width = random.Next(DisplayShape.Width);
                                height = random.Next(DisplayShape.Height);
                                shape.set(x, y, width, height);
                            }
                            else if (Partition[1].ToLower().Trim() == "triangle")
                            {
                                p1 = random.Next(DisplayShape.Width);
                                p2 = random.Next(DisplayShape.Width);
                                p3 = random.Next(DisplayShape.Width);
                                System.Drawing.Point pointa = new System.Drawing.Point(p1, p2);
                                System.Drawing.Point pointb = new System.Drawing.Point(p2, p3);
                                System.Drawing.Point pointc = new System.Drawing.Point(p3, p1);
                                System.Drawing.Point[] pnt = { pointa, pointb, pointc };
                                shape.setTriangle(x, y, pnt);
                            }
                            shape.Draw(graphic, pen, brush);
                            DisplayShape.Refresh();
                        }
                        else if (command == "if")
                        {
                            int left;
                            int right;
                            string condition;
                            if (Partition.Length > 4)
                            {
                                MessageBox.Show("need more input", "Error");
                            }
                            else
                            {
                                if (!int.TryParse(Partition[1], out left))
                                {
                                    left = varCall(Partition[1]);
                                }
                                else
                                {
                                    int.TryParse(Partition[1], out left);
                                }

                                if (!int.TryParse(Partition[3], out right))
                                {
                                    right = varCall(Partition[3]);
                                }
                                else
                                {
                                    int.TryParse(Partition[3], out right);
                                }
                                condition = Partition[2];
                                ifcheck(left, condition, right);
                                if (initial_Bit == true)
                                {

                                    jump = counter;
                                    jump++;
                                    jump++;
                                }
                            }
                        }
                        else if (command == "endif")
                        {
                            jump = 0;
                            string_Condition = false;
                        }
                        else
                        {
                            if (Partition[0].Trim() == null)
                            {

                            }
                            else
                            {
                                int i = 0;
                                if (parmerter[0] != null)
                                {
                                    while (49 >= i)
                                    {
                                        if (parmerter[i] == Partition[0])
                                        {
                                            //  MessageBox.Show(element[0] + " called", "whoop");
                                            if (!int.TryParse(Partition[1], out stringPartition[i]))
                                            {
                                                MessageBox.Show(Partition[0] + "is all ready set to " + Partition[1], "info");
                                            }
                                            else
                                            {
                                                int.TryParse(Partition[1], out stringPartition[i]);
                                                MessageBox.Show(Partition[0] + " variable is set to " + Partition[1], "info");
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
                                    MessageBox.Show(Partition[0] + " not a Command", "Messgae");
                                }
                            }
                        }
                    }
                    if (initial_Bit)
                    {
                        Loop_Count++;
                    }
                    DisplayShape.Refresh();
                }
                catch
                {
                }
                pen.Dispose();
                brush.Dispose();
            }
        }
        private void VarCheck(string element1, string element2)
        {
            try
            {
                bool variableExists = false;
                int index;

                for (index = 0; index < parmerter.Length && parmerter[index] != null; index++)
                {
                    if (parmerter[index].Equals(element1))
                    {
                        variableExists = true;
                        break;
                    }
                }

                if (variableExists)
                {
                    MessageBox.Show("Variable already declared", "Error");
                }
                else
                {
                    
                    if (index < parmerter.Length)
                    {
                        parmerter[index] = element1;
                        int.TryParse(element2, out stringPartition[index]);
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

        /// <summary>
        /// Retrieves the value of a variable by its name.
        /// </summary>
        /// <param name="variable">The name of the variable to retrieve the value for.</param>
        /// <returns>
        /// The value of the variable if found; otherwise, -1.
        /// </returns>
        /// <remarks>
        /// This method searches for the specified variable name in the list of parameters and returns its corresponding value.
        /// If the variable is not found, it returns -1 and displays an error message.
        /// </remarks>
        private int varCall(string variable)
        {
            int i = 0;
            int number = -1;
            while (49 >= i)
            {
                if (parmerter[i] == variable)
                {

                    number = stringPartition[i];
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

        /// <summary>
        /// Handles the KeyDown event for the command line input.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">A KeyEventArgs that contains the event data.</param>
        /// <remarks>
        /// This method is used to execute the program when the Enter key is pressed. 
        /// It retrieves the command(s) entered by the user, parses them, and executes them accordingly.
        /// If the "run" command is entered, it processes multiple commands; otherwise, it handles a single command.
        /// After executing the commands, it checks for errors and displays them if any, or executes the commands.
        /// </remarks>

        private void Commandline_KeyDown(object sender, KeyEventArgs e) //used to run the program
        {
            if (e.KeyCode == Keys.Enter)
            {

                String txtdata = SingleCommnad.Text;
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
                        lines = MultiCommand.Lines.ToArray();
                        while (lines.Length != i)
                        {

                            line = lines[i].Split(' ');
                            Currentline.Add(line);
                            i++;
                        }

                    }
                    else
                    {
                        lines = SingleCommnad.Lines.ToArray();
                        line = SingleCommnad.Text.Split(' ');
                        Currentline.Add(line);


                    }
                    int length = lines.Length;

                    Check(Currentline, lines, length);
                    Array.Clear(parmerter, 0, parmerter.Length);//used to cleare the vars array befreo exicution
                    Array.Clear(stringPartition, 0, stringPartition.Length);
                    string errors = string.Join(", ", Error.Where(x => x != 0));


                    if (Flag_Condition == false)
                    {

                        MessageBox.Show("Errors on lines :" + errors + ".", "error");
                    }
                    else
                    {

                        ExecuteCommand(Currentline, lines, length);
                    }
                }
            }
        }

        /// <summary>
        /// Checks the syntax of each command line for errors.
        /// </summary>
        /// <param name="currentLine">An ArrayList containing the current command lines.</param>
        /// <param name="lines">An array of strings representing the lines of code.</param>
        /// <param name="length">The length of the lines array.</param>
        /// <remarks>
        /// This method iterates through each command line and checks for syntax errors in the commands.
        /// For each command, it validates the number of parameters required.
        /// If any syntax errors are found, it increments the error count and records the line number.
        /// </remarks>

        public void Check(ArrayList currentLine, string[] lines, int length)
        {
            int errors = 0;
            Error_Count = 0;
            Flag_Condition = true;
            int k = 0;
            int lineNumber = 0;

            for (int count = 0; count < lines.Length; count++)
            {
                errors = Error_Count;

                try
                {
                    string[] Partition = (string[])currentLine[count];

                    string command = Partition[0].ToLower();

                    if (command == "circle")
                    {
                        if (Partition.Length != 2)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "rect")
                    {
                        if (Partition.Length != 3)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "square")
                    {
                        if (Partition.Length != 3)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "drawto")
                    {
                        if (Partition.Length != 3)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "pen")
                    {
                        if (Partition.Length != 2)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "brushcolor")
                    {
                        if (Partition.Length != 2)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "triangle")
                    {
                        if (Partition.Length != 4)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "clear")
                    {
                        
                    }
                    else if (command == "movex")
                    {
                        if (Partition.Length != 2)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "movey")
                    {
                        if (Partition.Length != 2)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "moveto")
                    {
                        if (Partition.Length != 3)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "var")
                    {
                        if (Partition.Length != 3)
                        {
                            Error_Count++;
                        }
                        else
                        {
                            VarCheck(Partition[1], Partition[2]);
                        }
                    }
                    else if (command == "loop")
                    {
                        if (Partition.Length != 2)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "end")
                    {
                        if (Partition.Length != 1)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "factory")
                    {
                        if (Partition.Length != 2)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "if")
                    {
                        if (Partition.Length != 4)
                        {
                            Error_Count++;
                        }
                    }
                    else if (command == "endif")
                    {
                        if (Partition.Length != 1)
                        {
                            Error_Count++;
                        }
                    }
                    // Add more conditions for other commands...
                    else
                    {
                        if (Partition[0].Trim() == null)
                        {

                        }
                        else
                        {
                            int i = 0;
                            if (parmerter[0] != null)
                            {
                                while (49 >= i)
                                {
                                    if (parmerter[i] == Partition[0])
                                    {
                                        if (!int.TryParse(Partition[1], out stringPartition[i]))
                                        {
                                            MessageBox.Show(Partition[0] + "is all ready set to " + Partition[1], "whoop");
                                        }
                                        else
                                        {
                                            int.TryParse(Partition[1], out stringPartition[i]);
                                            MessageBox.Show(Partition[0] + " variable is set to " + Partition[1], "whoop");
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
                                Error_Count++;
                            }
                        }
                    }

                    if (errors != Error_Count)
                    {
                        lineNumber = count + 1;
                        Error[k] = lineNumber;
                        k++;
                        errors++;
                    }
                }
                catch
                {
                }

                if (Error_Count != 0)
                {
                    Flag_Condition = false;
                }
                else
                {
                    Flag_Condition = true;
                }
            }
        }

        /// <summary>
        /// Event handler for the "Run" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        /// <remarks>
        /// This method is called when the "Run" button is clicked.
        /// It retrieves the input commands from the MultiCommand text box.
        /// It checks if the input is empty and displays an error message if it is.
        /// If the input is not empty, it splits the input into individual lines and stores them in an ArrayList.
        /// Then, it checks the syntax of the input commands using the Check method.
        /// If there are syntax errors, it displays the line numbers with errors.
        /// Otherwise, it executes the input commands using the ExecuteCommand method.
        /// </remarks>

        private void Run_Click(object sender, EventArgs e)
        {
            String input = MultiCommand.Text;
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
                lines = MultiCommand.Lines.ToArray();
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
                Array.Clear(stringPartition, 0, stringPartition.Length);
                string errors = string.Join(", ", Error.Where(x => x != 0));


                if (Flag_Condition == false)
                {

                    MessageBox.Show("Error Occur in Line no. :" + errors + ".", "error");
                }
                else
                {

                    ExecuteCommand(Currentline, lines, length);
                }

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            MultiCommand.Text = "";
            SingleCommnad.Text = "";
        }


        /// <summary>
        /// Event handler for the "Save" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>  
        private void Save_Click(object sender, EventArgs e)
        {
            MemoryStream userInput = new MemoryStream(Encoding.UTF8.GetBytes(MultiCommand.Text));

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

        /// <summary>
        /// Event handler for the "Load" button click event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">An EventArgs that contains the event data.</param>
        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "TXT Files|*.txt";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                MultiCommand.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
            openFile1.Dispose();
        }
    }
}

    


