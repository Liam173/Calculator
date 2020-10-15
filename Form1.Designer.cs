namespace Project_1._0__Calculator_
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
            this.tbScreen = new System.Windows.Forms.RichTextBox();
            this.butSeven = new System.Windows.Forms.Button();
            this.butEight = new System.Windows.Forms.Button();
            this.butNine = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.butFour = new System.Windows.Forms.Button();
            this.butFive = new System.Windows.Forms.Button();
            this.butSix = new System.Windows.Forms.Button();
            this.butMultiply = new System.Windows.Forms.Button();
            this.butDivide = new System.Windows.Forms.Button();
            this.butOne = new System.Windows.Forms.Button();
            this.butTwo = new System.Windows.Forms.Button();
            this.butThree = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.butSubtract = new System.Windows.Forms.Button();
            this.butZero = new System.Windows.Forms.Button();
            this.butPoint = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butEqual = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butOn = new System.Windows.Forms.Button();
            this.butOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbScreen
            // 
            this.tbScreen.Location = new System.Drawing.Point(12, 12);
            this.tbScreen.Name = "tbScreen";
            this.tbScreen.Size = new System.Drawing.Size(384, 80);
            this.tbScreen.TabIndex = 0;
            this.tbScreen.Text = "";
            this.tbScreen.TextChanged += new System.EventHandler(this.tbScreen_TextChanged);
            // 
            // butSeven
            // 
            this.butSeven.Location = new System.Drawing.Point(12, 167);
            this.butSeven.Name = "butSeven";
            this.butSeven.Size = new System.Drawing.Size(58, 56);
            this.butSeven.TabIndex = 1;
            this.butSeven.Text = "7";
            this.butSeven.UseVisualStyleBackColor = true;
            this.butSeven.Click += new System.EventHandler(this.butSeven_Click);
            // 
            // butEight
            // 
            this.butEight.Location = new System.Drawing.Point(95, 167);
            this.butEight.Name = "butEight";
            this.butEight.Size = new System.Drawing.Size(58, 56);
            this.butEight.TabIndex = 2;
            this.butEight.Text = "8";
            this.butEight.UseVisualStyleBackColor = true;
            this.butEight.Click += new System.EventHandler(this.butEight_Click);
            // 
            // butNine
            // 
            this.butNine.Location = new System.Drawing.Point(177, 167);
            this.butNine.Name = "butNine";
            this.butNine.Size = new System.Drawing.Size(58, 56);
            this.butNine.TabIndex = 3;
            this.butNine.Text = "9";
            this.butNine.UseVisualStyleBackColor = true;
            this.butNine.Click += new System.EventHandler(this.butNine_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(258, 167);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(58, 56);
            this.butDelete.TabIndex = 4;
            this.butDelete.Text = "DEL";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(338, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 56);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // butFour
            // 
            this.butFour.Location = new System.Drawing.Point(12, 255);
            this.butFour.Name = "butFour";
            this.butFour.Size = new System.Drawing.Size(58, 56);
            this.butFour.TabIndex = 6;
            this.butFour.Text = "4";
            this.butFour.UseVisualStyleBackColor = true;
            this.butFour.Click += new System.EventHandler(this.butFour_Click);
            // 
            // butFive
            // 
            this.butFive.Location = new System.Drawing.Point(95, 255);
            this.butFive.Name = "butFive";
            this.butFive.Size = new System.Drawing.Size(58, 56);
            this.butFive.TabIndex = 7;
            this.butFive.Text = "5";
            this.butFive.UseVisualStyleBackColor = true;
            this.butFive.Click += new System.EventHandler(this.butFive_Click);
            // 
            // butSix
            // 
            this.butSix.Location = new System.Drawing.Point(177, 255);
            this.butSix.Name = "butSix";
            this.butSix.Size = new System.Drawing.Size(58, 56);
            this.butSix.TabIndex = 8;
            this.butSix.Text = "6";
            this.butSix.UseVisualStyleBackColor = true;
            this.butSix.Click += new System.EventHandler(this.butSix_Click);
            // 
            // butMultiply
            // 
            this.butMultiply.Location = new System.Drawing.Point(258, 255);
            this.butMultiply.Name = "butMultiply";
            this.butMultiply.Size = new System.Drawing.Size(58, 56);
            this.butMultiply.TabIndex = 9;
            this.butMultiply.Text = "X";
            this.butMultiply.UseVisualStyleBackColor = true;
            this.butMultiply.Click += new System.EventHandler(this.butMultiply_Click);
            // 
            // butDivide
            // 
            this.butDivide.Location = new System.Drawing.Point(338, 255);
            this.butDivide.Name = "butDivide";
            this.butDivide.Size = new System.Drawing.Size(58, 56);
            this.butDivide.TabIndex = 10;
            this.butDivide.Text = "÷";
            this.butDivide.UseVisualStyleBackColor = true;
            this.butDivide.Click += new System.EventHandler(this.butDivide_Click);
            // 
            // butOne
            // 
            this.butOne.Location = new System.Drawing.Point(12, 335);
            this.butOne.Name = "butOne";
            this.butOne.Size = new System.Drawing.Size(58, 56);
            this.butOne.TabIndex = 11;
            this.butOne.Text = "1";
            this.butOne.UseVisualStyleBackColor = true;
            this.butOne.Click += new System.EventHandler(this.butOne_Click);
            // 
            // butTwo
            // 
            this.butTwo.Location = new System.Drawing.Point(95, 335);
            this.butTwo.Name = "butTwo";
            this.butTwo.Size = new System.Drawing.Size(58, 56);
            this.butTwo.TabIndex = 12;
            this.butTwo.Text = "2";
            this.butTwo.UseVisualStyleBackColor = true;
            this.butTwo.Click += new System.EventHandler(this.butTwo_Click);
            // 
            // butThree
            // 
            this.butThree.Location = new System.Drawing.Point(177, 335);
            this.butThree.Name = "butThree";
            this.butThree.Size = new System.Drawing.Size(58, 56);
            this.butThree.TabIndex = 13;
            this.butThree.Text = "3";
            this.butThree.UseVisualStyleBackColor = true;
            this.butThree.Click += new System.EventHandler(this.butThree_Click);
            // 
            // butPlus
            // 
            this.butPlus.Location = new System.Drawing.Point(258, 335);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(58, 56);
            this.butPlus.TabIndex = 14;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // butSubtract
            // 
            this.butSubtract.Location = new System.Drawing.Point(338, 335);
            this.butSubtract.Name = "butSubtract";
            this.butSubtract.Size = new System.Drawing.Size(58, 56);
            this.butSubtract.TabIndex = 15;
            this.butSubtract.Text = "-";
            this.butSubtract.UseVisualStyleBackColor = true;
            this.butSubtract.Click += new System.EventHandler(this.butSubtract_Click);
            // 
            // butZero
            // 
            this.butZero.Location = new System.Drawing.Point(12, 416);
            this.butZero.Name = "butZero";
            this.butZero.Size = new System.Drawing.Size(58, 56);
            this.butZero.TabIndex = 16;
            this.butZero.Text = "0";
            this.butZero.UseVisualStyleBackColor = true;
            this.butZero.Click += new System.EventHandler(this.butZero_Click);
            // 
            // butPoint
            // 
            this.butPoint.Location = new System.Drawing.Point(95, 416);
            this.butPoint.Name = "butPoint";
            this.butPoint.Size = new System.Drawing.Size(58, 56);
            this.butPoint.TabIndex = 17;
            this.butPoint.Text = ".";
            this.butPoint.UseVisualStyleBackColor = true;
            this.butPoint.Click += new System.EventHandler(this.butPoint_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(258, 416);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(58, 56);
            this.butClear.TabIndex = 18;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butEqual
            // 
            this.butEqual.Location = new System.Drawing.Point(177, 416);
            this.butEqual.Name = "butEqual";
            this.butEqual.Size = new System.Drawing.Size(58, 56);
            this.butEqual.TabIndex = 19;
            this.butEqual.Text = "=";
            this.butEqual.UseVisualStyleBackColor = true;
            this.butEqual.Click += new System.EventHandler(this.butEqual_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(338, 416);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(58, 56);
            this.butExit.TabIndex = 20;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butOn
            // 
            this.butOn.Location = new System.Drawing.Point(12, 115);
            this.butOn.Name = "butOn";
            this.butOn.Size = new System.Drawing.Size(94, 34);
            this.butOn.TabIndex = 21;
            this.butOn.Text = "On";
            this.butOn.UseVisualStyleBackColor = true;
            this.butOn.Click += new System.EventHandler(this.butOn_Click);
            // 
            // butOff
            // 
            this.butOff.Location = new System.Drawing.Point(302, 115);
            this.butOff.Name = "butOff";
            this.butOff.Size = new System.Drawing.Size(94, 34);
            this.butOff.TabIndex = 22;
            this.butOff.Text = "Off";
            this.butOff.UseVisualStyleBackColor = true;
            this.butOff.Click += new System.EventHandler(this.butOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 484);
            this.Controls.Add(this.butOff);
            this.Controls.Add(this.butOn);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butEqual);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butPoint);
            this.Controls.Add(this.butZero);
            this.Controls.Add(this.butSubtract);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.butThree);
            this.Controls.Add(this.butTwo);
            this.Controls.Add(this.butOne);
            this.Controls.Add(this.butDivide);
            this.Controls.Add(this.butMultiply);
            this.Controls.Add(this.butSix);
            this.Controls.Add(this.butFive);
            this.Controls.Add(this.butFour);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butNine);
            this.Controls.Add(this.butEight);
            this.Controls.Add(this.butSeven);
            this.Controls.Add(this.tbScreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbScreen;
        private System.Windows.Forms.Button butSeven;
        private System.Windows.Forms.Button butEight;
        private System.Windows.Forms.Button butNine;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button butFour;
        private System.Windows.Forms.Button butFive;
        private System.Windows.Forms.Button butSix;
        private System.Windows.Forms.Button butMultiply;
        private System.Windows.Forms.Button butDivide;
        private System.Windows.Forms.Button butOne;
        private System.Windows.Forms.Button butTwo;
        private System.Windows.Forms.Button butThree;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button butSubtract;
        private System.Windows.Forms.Button butZero;
        private System.Windows.Forms.Button butPoint;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butEqual;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butOn;
        private System.Windows.Forms.Button butOff;
    }
}

