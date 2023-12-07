using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdvanceSoftware
{
    public partial class Form1 : Form
    {

        DesignControl d;

        public Form1()
        {
            InitializeComponent();
            DesignValues.x = DesignValues.y = 0;
            d = new DesignControl();
            d.Current_Point(false);
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flg = false;
            if (richTextBox1.Text.Trim() != string.Empty)
            {
                d.runCommands(richTextBox1.Text.Trim());
                richTextBox1.Focus();
                richTextBox1.Text = string.Empty;
                flg = true;
            }
            if (textBox2.Text.Trim() != string.Empty)
            {
                d.runCommands(textBox2.Text.Trim());
                textBox2.Focus();
                textBox2.Text = string.Empty;
                flg = true;
            }
            if (!flg)
            {
                d.PrintMessage("Please enter any command!");
                textBox2.Focus();
            }
            Refresh();
            DesignValues.isFill = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesignValues.newPic = new Bitmap(640, 480);
            d = new DesignControl();
            d.Current_Point(true);
            Refresh();
        }

        public override void Refresh()
        {
            pictureBox1.Image = DesignValues.newPic;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)    
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBox2.Text.Trim() != string.Empty)
                    d.runCommands(textBox2.Text.Trim());
                else
                    d.PrintMessage("Please enter any command!");

                textBox2.Text = string.Empty;
                Refresh();
                textBox2.Focus();
                DesignValues.isFill = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DesignValues.newPic = new Bitmap(640, 480);
            d = new DesignControl();
            d.Current_Point(false);
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG|*.jpeg";
            save.Title = "Assingmemnt";
            save.ShowDialog();

            if (save.FileName != "" && DesignValues.newPic != null)
            {
                DesignValues.newPic.Save(save.FileName);
            }
        }
    }
}
