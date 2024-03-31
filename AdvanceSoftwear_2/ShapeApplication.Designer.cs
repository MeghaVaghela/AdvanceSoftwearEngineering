namespace AdvanceSoftwear_2
{
    partial class ShapeApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisplayShape = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SingleCommnad = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.MultiCommand = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayShape)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisplayShape);
            this.groupBox1.Location = new System.Drawing.Point(416, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 584);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DisplayShape
            // 
            this.DisplayShape.Location = new System.Drawing.Point(6, 21);
            this.DisplayShape.Name = "DisplayShape";
            this.DisplayShape.Size = new System.Drawing.Size(440, 553);
            this.DisplayShape.TabIndex = 0;
            this.DisplayShape.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MultiCommand);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multiple Command";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SingleCommnad);
            this.groupBox3.Location = new System.Drawing.Point(12, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 49);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Single Command";
            // 
            // SingleCommnad
            // 
            this.SingleCommnad.Location = new System.Drawing.Point(6, 13);
            this.SingleCommnad.Multiline = true;
            this.SingleCommnad.Name = "SingleCommnad";
            this.SingleCommnad.Size = new System.Drawing.Size(376, 30);
            this.SingleCommnad.TabIndex = 0;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(43, 493);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(112, 39);
            this.Run.TabIndex = 2;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.CausesValidation = false;
            this.Clear.Location = new System.Drawing.Point(243, 493);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(112, 39);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(43, 547);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 39);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(243, 547);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(112, 39);
            this.Load.TabIndex = 5;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            // 
            // MultiCommand
            // 
            this.MultiCommand.Location = new System.Drawing.Point(6, 21);
            this.MultiCommand.Name = "MultiCommand";
            this.MultiCommand.Size = new System.Drawing.Size(376, 367);
            this.MultiCommand.TabIndex = 0;
            this.MultiCommand.Text = "";
            // 
            // ShapeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 608);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShapeApplication";
            this.Text = "ShapeApplication";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayShape)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.PictureBox DisplayShape;
        private System.Windows.Forms.TextBox SingleCommnad;
        private System.Windows.Forms.RichTextBox MultiCommand;
    }
}