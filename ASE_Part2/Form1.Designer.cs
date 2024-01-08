using System;

namespace ASE_Part2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.PictureBox();
            this.ControlPannel = new System.Windows.Forms.RichTextBox();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.method1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(8, 534);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(127, 40);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "Run";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(209, 534);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(110, 40);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "Clear";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click_1);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(8, 580);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(123, 43);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "Save";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click_1);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(209, 580);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(110, 43);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Load";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.display.Location = new System.Drawing.Point(6, 21);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(604, 645);
            this.display.TabIndex = 5;
            this.display.TabStop = false;
            this.display.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ControlPannel
            // 
            this.ControlPannel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlPannel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.ControlPannel.Location = new System.Drawing.Point(6, 21);
            this.ControlPannel.Name = "ControlPannel";
            this.ControlPannel.Size = new System.Drawing.Size(380, 393);
            this.ControlPannel.TabIndex = 6;
            this.ControlPannel.Text = "";
            this.ControlPannel.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // CommandLine
            // 
            this.CommandLine.Location = new System.Drawing.Point(6, 21);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(380, 22);
            this.CommandLine.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ControlPannel);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 434);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multi line Command";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CommandLine);
            this.groupBox2.Location = new System.Drawing.Point(2, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 58);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Single Line Command";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.display);
            this.groupBox3.Location = new System.Drawing.Point(415, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 686);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DesignArea";
            // 
            // method1
            // 
            this.method1.Location = new System.Drawing.Point(12, 642);
            this.method1.Name = "method1";
            this.method1.Size = new System.Drawing.Size(331, 51);
            this.method1.TabIndex = 11;
            this.method1.Text = "Direct Method Call";
            this.method1.UseVisualStyleBackColor = true;
            this.method1.Click += new System.EventHandler(this.method1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 705);
            this.Controls.Add(this.method1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.RichTextBox ControlPannel;
        private System.Windows.Forms.TextBox CommandLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button method1;
    }
}

