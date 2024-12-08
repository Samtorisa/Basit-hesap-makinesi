using System.Diagnostics;
using System.Data;
using System.Security.AccessControl;
using System.Windows.Forms.VisualStyles;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        
        string currentInput = "";


        private void numberClick(object sender, EventArgs e) { 
       Button button= (Button) sender;

            currentInput += button.Text;
            textBox1.Text = currentInput;

        
        }

        private void buttonEquals(object sender, EventArgs e) 
        {
            string conclusion=currentInput.ToString();
            try
            {
                textBox1.Text = new DataTable().Compute(conclusion,null).ToString();
                currentInput = textBox1.Text;   

            }catch(Exception ex)
            {
                textBox1.Text="ERROR";
                currentInput = "";
            
            }
        
        }
        private void clearButton(object sender,EventArgs args)
        {
            textBox1.Text = "0";
            currentInput = "";

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
