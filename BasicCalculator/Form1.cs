using System.Diagnostics;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool operationPending = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void divideButton(object sender, EventArgs e)
        {
            if (operationPending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;


        }
        private void MinusButton(object sender, EventArgs e)
        {
            if (operationPending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void plusButton(object sender, EventArgs e)
        {

            if (operationPending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }


        private void timesButton(object sender, EventArgs e)
        {
            if (operationPending)
            {
                evaluate();
            }
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void buttonOne(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void buttonTwo(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void buttonThree(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }





        private void buttonEight(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void buttonFour(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void buttonFive(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        private void buttonSix(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        private void buttonSeven(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
        private void buttonNine(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

     

        void evaluate()
        {
            if (operationPending)
            {

                double secondNumber = double.Parse(currentInput);
                switch (operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result /= secondNumber;

                        }
                        else
                        {
                            textBox1.Text = "undefined";
                            return;
                        }
                        break;
                                        }
            }
                textBox1.Text = result.ToString();
                currentInput = "";
                operationPending = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            currentInput = "";
            result = 0;
            operation = "";
            operationPending = false;
            textBox1.Text = "";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            evaluate();
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }
    }
}
