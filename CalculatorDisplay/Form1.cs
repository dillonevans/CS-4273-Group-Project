using Calculations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDisplay
{
    public partial class Form1 : Form
    {
        private Stack<double> _results;
        private bool _lastEnteredWasDigit = false, _isInErrorMode = false;
        private int currentDigitCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void NumericButtonHandler(object sender, EventArgs e)
        {
            Debug.WriteLine($"Current digit count: {currentDigitCount}");
            Button currentButton = (Button)sender;
            string text = currentButton.Text;

            if (DisplayBox.Text == "0") { DisplayBox.Text = ""; }

            if (currentDigitCount <= 8 && !_isInErrorMode)
            {
                DisplayBox.Text += text;

                PlusButton.Enabled = true;
                MinusButton.Enabled = true;
                MultiplicationButton.Enabled = true;
                DivisionButton.Enabled = true;
                EqualsButton.Enabled = true;
                _lastEnteredWasDigit = true;
                currentDigitCount++;

            }
        }

        private void EnterErrorMode()
        {
            PlusButton.Enabled = false;
            MinusButton.Enabled = false;
            MultiplicationButton.Enabled = false;
            DivisionButton.Enabled = false;
            NegationButton.Enabled = false;
            EqualsButton.Enabled = false;
            DecimalButton.Enabled = false;
            _lastEnteredWasDigit = false;
            _isInErrorMode = true;
            DisplayBox.Text = "ERROR";
            currentDigitCount = 0;

        }

        private void EqualsButtonClicked(object sender, EventArgs e)
        {
            Debug.WriteLine(DisplayBox.Text);
            var result = Calculator.Calculate(DisplayBox.Text);
            var resultString = result.ToString();

            if (resultString.Length < 8)
            {
                _results.Push(result);
                DisplayBox.Text = resultString;
                currentDigitCount = resultString.Length;
                NegationButton.Enabled = true;
            }
            else
            {
                EnterErrorMode();
            }

        }

        private void ArithmeticButtonClicked(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            string text = currentButton.Text;
            DisplayBox.Text += " " + text + " ";

            PlusButton.Enabled = false;
            MinusButton.Enabled = false;
            MultiplicationButton.Enabled = false;
            DivisionButton.Enabled = false;
            NegationButton.Enabled = false;
            EqualsButton.Enabled = false;
            DecimalButton.Enabled = true;
            _lastEnteredWasDigit = false;
            currentDigitCount = 0;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            _results = new Stack<double>();
        }

        private void AllClearButton_Click(object sender, EventArgs e)
        {
            _results.Clear();
            DisplayBox.Text = "0";

            PlusButton.Enabled = false;
            MinusButton.Enabled = false;
            MultiplicationButton.Enabled = false;
            DivisionButton.Enabled = false;
            DecimalButton.Enabled = true;
            _isInErrorMode = false;
            currentDigitCount = 0;


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (_results.Any())
            {
                var resultString = _results.Pop().ToString();
                currentDigitCount = resultString.Length;
                DisplayBox.Text = resultString;
            }
            else
            {
                DisplayBox.Text = "0";
                DecimalButton.Enabled = true;
                currentDigitCount = 0;
            }

            PlusButton.Enabled = true;
            MinusButton.Enabled = true;
            MultiplicationButton.Enabled = true;
            DivisionButton.Enabled = true;
            _isInErrorMode = false;

        }

        private void NegationButton_Click(object sender, EventArgs e)
        {
            double.TryParse(DisplayBox.Text, out double value);

            if (_results.Any())
                _results.Push(_results.Pop() * -1);
            DisplayBox.Text = (-1 * value).ToString();

        }

        private void DecimalButton_Click(object sender, EventArgs e)
        { 
            if (_lastEnteredWasDigit)
            {
                DisplayBox.Text += ".";
            }
            else
            {
                DisplayBox.Text += "0.";
                currentDigitCount++;
            }
            DecimalButton.Enabled = false;
        }
    }
}
