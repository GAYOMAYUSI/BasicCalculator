using CalculatorPrivateAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            var operations = new List<string> { "+", "-", "*", "/" };

            foreach (var operation in operations) cbOperation.Items.Add(operation);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = Convert.ToInt32(tbInput1.Text);
                var num2 = Convert.ToInt32(tbInput2.Text);
                var operation = cbOperation.SelectedItem.ToString();
                var result = "None";

               switch (operation)
{
    case "+":
        result = Convert.ToString(BasicComputation.Addition(num1, num2));
        break;
    case "-":
        result = Convert.ToString(BasicComputation.Subtraction(num1, num2));
        break;
    case "*":
        result = Convert.ToString(BasicComputation.Division(num1, num2));
        break;
    case "/":
        result = Convert.ToString(BasicComputation.Multiplication(num1, num2));
        break;
}

                MessageBox.Show($"Result: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
