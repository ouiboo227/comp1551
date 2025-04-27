using System;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form2 : Form
    {
        private StringProcessing processor = new StringProcessing();
        private bool validInput = false;

// Constructor initializes the form and components
        public Form2()
        {
            InitializeComponent();
        }

// This method validates user inputs and updates notification label
        private bool ValidateForm()
        {
            string inputString = stringInput.Text.Trim();
            string inputN = numberInput.Text.Trim();

            if (string.IsNullOrEmpty(inputString) || string.IsNullOrEmpty(inputN))
            {
                notification.Text = "Please enter both string and number.";
                validInput = false;
                return false;
            }

            if (!int.TryParse(inputN, out int n))
            {
                notification.Text = "Please enter a valid integer.";
                validInput = false;
                return false;
            }

            processor.SetInput(inputString, n);
            int result = processor.ValidateInput();

            if (result == 7)
            {
                notification.Text = "Valid input.";
                validInput = true;
            }
            else
            {
                validInput = false;
                notification.Text = "";
                if ((result & 1) == 0) notification.Text += "Only A-Z characters allowed. ";
                if ((result & 2) == 0) notification.Text += "Length must be between 1 and 40. ";
                if ((result & 4) == 0) notification.Text += "Number must be between -25 and 25.";
            }
            return validInput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                EncodeResult.Text = processor.EncodeString();
        }

        private void print1Button_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                EncodeResult.Text = string.Join("; ", processor.GetAsciiValuesBeforeEncoding());
        }

        private void print2Button_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                EncodeResult.Text = string.Join("; ", processor.GetAsciiValuesAfterEncoding());
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                var sorted = processor.MergeSort(processor.GetAsciiValuesBeforeEncoding(), 0, processor.GetAsciiValuesBeforeEncoding().Length - 1);
                EncodeResult.Text = string.Join("; ", sorted);
            }
        }
    }
}