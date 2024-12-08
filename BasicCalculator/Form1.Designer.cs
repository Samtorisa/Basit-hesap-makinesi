namespace BasicCalculator
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
            numberOne = new Button();
            numberTwo = new Button();
            numberThree = new Button();
            numberFour = new Button();
            numberFive = new Button();
            numberSix = new Button();
            numberSeven = new Button();
            numberEight = new Button();
            numberNine = new Button();
            groupBox1 = new GroupBox();
            buttonClear = new Button();
            buttonTimes = new Button();
            buttonMinus = new Button();
            buttonCalculate = new Button();
            buttonDivide = new Button();
            buttonPlus = new Button();
            numberZero = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numberOne
            // 
            numberOne.Location = new Point(32, 26);
            numberOne.Name = "numberOne";
            numberOne.Size = new Size(75, 45);
            numberOne.TabIndex = 0;
            numberOne.Text = "1";
            numberOne.UseVisualStyleBackColor = true;
            numberOne.Click += numberClick;
            // 
            // numberTwo
            // 
            numberTwo.Location = new Point(122, 26);
            numberTwo.Name = "numberTwo";
            numberTwo.Size = new Size(75, 45);
            numberTwo.TabIndex = 1;
            numberTwo.Text = "2";
            numberTwo.UseVisualStyleBackColor = true;
            numberTwo.Click += numberClick;
            // 
            // numberThree
            // 
            numberThree.Location = new Point(215, 26);
            numberThree.Name = "numberThree";
            numberThree.Size = new Size(75, 45);
            numberThree.TabIndex = 2;
            numberThree.Text = "3";
            numberThree.UseVisualStyleBackColor = true;
            numberThree.Click += numberClick;
            // 
            // numberFour
            // 
            numberFour.Location = new Point(32, 100);
            numberFour.Name = "numberFour";
            numberFour.Size = new Size(75, 45);
            numberFour.TabIndex = 3;
            numberFour.Text = "4";
            numberFour.UseVisualStyleBackColor = true;
            numberFour.Click += numberClick;
            // 
            // numberFive
            // 
            numberFive.Location = new Point(122, 100);
            numberFive.Name = "numberFive";
            numberFive.Size = new Size(75, 45);
            numberFive.TabIndex = 4;
            numberFive.Text = "5";
            numberFive.UseVisualStyleBackColor = true;
            numberFive.Click += numberClick;
            // 
            // numberSix
            // 
            numberSix.Location = new Point(215, 100);
            numberSix.Name = "numberSix";
            numberSix.Size = new Size(75, 45);
            numberSix.TabIndex = 5;
            numberSix.Text = "6";
            numberSix.UseVisualStyleBackColor = true;
            numberSix.Click += numberClick;
            // 
            // numberSeven
            // 
            numberSeven.Location = new Point(32, 172);
            numberSeven.Name = "numberSeven";
            numberSeven.Size = new Size(75, 45);
            numberSeven.TabIndex = 6;
            numberSeven.Text = "7";
            numberSeven.UseVisualStyleBackColor = true;
            numberSeven.Click += numberClick;
            // 
            // numberEight
            // 
            numberEight.Location = new Point(122, 172);
            numberEight.Name = "numberEight";
            numberEight.Size = new Size(75, 45);
            numberEight.TabIndex = 7;
            numberEight.Text = "8";
            numberEight.UseVisualStyleBackColor = true;
            numberEight.Click += numberClick;
            // 
            // numberNine
            // 
            numberNine.Location = new Point(215, 172);
            numberNine.Name = "numberNine";
            numberNine.Size = new Size(75, 45);
            numberNine.TabIndex = 8;
            numberNine.Text = "9";
            numberNine.UseVisualStyleBackColor = true;
            numberNine.Click += numberClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonTimes);
            groupBox1.Controls.Add(buttonMinus);
            groupBox1.Controls.Add(buttonCalculate);
            groupBox1.Controls.Add(buttonDivide);
            groupBox1.Controls.Add(buttonPlus);
            groupBox1.Controls.Add(numberZero);
            groupBox1.Controls.Add(numberNine);
            groupBox1.Controls.Add(numberEight);
            groupBox1.Controls.Add(numberSeven);
            groupBox1.Controls.Add(numberSix);
            groupBox1.Controls.Add(numberFive);
            groupBox1.Controls.Add(numberFour);
            groupBox1.Controls.Add(numberThree);
            groupBox1.Controls.Add(numberTwo);
            groupBox1.Controls.Add(numberOne);
            groupBox1.Location = new Point(79, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 310);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(305, 26);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 45);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "CLEAR";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += clearButton;
            // 
            // buttonTimes
            // 
            buttonTimes.Font = new Font("Segoe UI", 20F);
            buttonTimes.Location = new Point(305, 236);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new Size(75, 45);
            buttonTimes.TabIndex = 11;
            buttonTimes.Text = "*";
            buttonTimes.UseVisualStyleBackColor = true;
            buttonTimes.Click += numberClick;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(32, 236);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 45);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += numberClick;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Segoe UI", 20F);
            buttonCalculate.Location = new Point(215, 236);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 45);
            buttonCalculate.TabIndex = 13;
            buttonCalculate.Text = "=";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonEquals;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(305, 100);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 45);
            buttonDivide.TabIndex = 11;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += numberClick;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(305, 172);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 45);
            buttonPlus.TabIndex = 10;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += numberClick;
            // 
            // numberZero
            // 
            numberZero.Location = new Point(122, 236);
            numberZero.Name = "numberZero";
            numberZero.Size = new Size(75, 45);
            numberZero.TabIndex = 9;
            numberZero.Text = "0";
            numberZero.UseVisualStyleBackColor = true;
            numberZero.Click += numberClick;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(79, 111);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 55);
            textBox1.TabIndex = 10;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(506, 488);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += numberClick;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button numberOne;
        private Button numberTwo;
        private Button numberThree;
        private Button numberFour;
        private Button numberFive;
        private Button numberSix;
        private Button numberSeven;
        private Button numberEight;
        private Button numberNine;
        private GroupBox groupBox1;
        private Button buttonMinus;
        private Button buttonCalculate;
        private Button buttonDivide;
        private Button buttonPlus;
        private Button numberZero;
        private TextBox textBox1;
        private Button buttonTimes;
        private Button buttonClear;
    }
}
