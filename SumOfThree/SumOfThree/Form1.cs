using System;
using System.Text;
using System.Windows.Forms;

namespace SumOfThree
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string firstOperand = textBox1.Text;
            string secondOperand = textBox2.Text;
            string thirdOperand = textBox3.Text;


            try
            {
                var newSum = new SumAlgorithm();
                newSum.calculateSum(Int32.Parse(firstOperand),
                    Int32.Parse(secondOperand), Int32.Parse(thirdOperand));
            }
            catch
            {
                MessageBox.Show("Invalid input.");
            }
        }



        public void viewResult(int num1, int num2, int num3)
        {
            StringBuilder resultMessage = new StringBuilder();
            resultMessage.Append(num1.ToString());
            resultMessage.Append(num2.ToString());
            resultMessage.Append(num3.ToString());
            MessageBox.Show(resultMessage.ToString());

        }

    }
}
