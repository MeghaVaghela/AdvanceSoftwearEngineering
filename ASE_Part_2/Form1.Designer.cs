namespace ASE_Part_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            button2 = new Button();
            runButton = new Button();
            button4 = new Button();
            display = new PictureBox();
            groupBox2 = new GroupBox();
            commandline = new TextBox();
            groupBox3 = new GroupBox();
            ControlePanel = new RichTextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)display).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(48, 553);
            button3.Name = "button3";
            button3.Size = new Size(128, 29);
            button3.TabIndex = 2;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 494);
            button2.Name = "button2";
            button2.Size = new Size(135, 29);
            button2.TabIndex = 1;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // runButton
            // 
            runButton.Location = new Point(48, 494);
            runButton.Name = "runButton";
            runButton.Size = new Size(128, 29);
            runButton.TabIndex = 0;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(281, 553);
            button4.Name = "button4";
            button4.Size = new Size(135, 29);
            button4.TabIndex = 3;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // display
            // 
            display.Location = new Point(6, 26);
            display.Name = "display";
            display.Size = new Size(486, 561);
            display.TabIndex = 0;
            display.TabStop = false;
            display.Click += display_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(display);
            groupBox2.Location = new Point(482, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(498, 593);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Drawing Area";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // commandline
            // 
            commandline.Location = new Point(6, 26);
            commandline.Name = "commandline";
            commandline.Size = new Size(437, 27);
            commandline.TabIndex = 4;
            commandline.TextChanged += textBox1_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(commandline);
            groupBox3.Location = new Point(18, 428);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(449, 60);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "single line command";
            // 
            // ControlePanel
            // 
            ControlePanel.Location = new Point(7, 28);
            ControlePanel.Name = "ControlePanel";
            ControlePanel.Size = new Size(442, 375);
            ControlePanel.TabIndex = 0;
            ControlePanel.Text = "";
            ControlePanel.TextChanged += ControlePanel_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ControlePanel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 409);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "MultiCommand";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(992, 618);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(runButton);
            Name = "Form1";
            Text = "ASE_Assingment_2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)display).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button runButton;
        private Button button4;
        private PictureBox display;
        private GroupBox groupBox2;
        private TextBox commandline;
        private GroupBox groupBox3;
        private RichTextBox ControlePanel;
        private GroupBox groupBox1;
    }
}