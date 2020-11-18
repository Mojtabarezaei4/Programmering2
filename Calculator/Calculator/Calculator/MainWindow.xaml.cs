using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                switch (button.Content)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        CurrentTextField.Text += button.Content;
                        break;
                    case "÷":
                    case "✕":
                    case "−":
                    case "+":
                        PreviousTextField.Text = CurrentTextField.Text + button.Content;
                        CurrentTextField.Text = string.Empty;
                        break;
                    case "=":
                        ChooseOperation(button.Content);
                        break;
                    case ".":
                        AppendNumber(button.Content);
                        break;
                }
            }
        }

        //Done
        private void Button_Click_AC(object sender, RoutedEventArgs e)
        {
            CurrentTextField.Text = String.Empty;
            PreviousTextField.Text = String.Empty;
        }
        //Done
        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            CurrentTextField.Text = String.Empty;
        }
        //Done
        private void Button_Click_BackSpace(object sender, RoutedEventArgs e)
        {
            BackSpace();
        }
        private void Button_Click_Plus_Minus(object sender, RoutedEventArgs e)
        {
            if (CurrentTextField.Text.Contains('-'))
            {


            }
            else
            {
                CurrentTextField.Text = '-' + CurrentTextField.Text;
            }
        }

        // Calculator class

        // Constructor
        protected void Constructor()
        {
            // this.CurrentTextField = CurrentTextField
            this.CurrentTextField = CurrentTextField;

            // this.PreviousTextField = PreviousTextField
            this.PreviousTextField = PreviousTextField;
            // clear()
            Clear();
        }

        // clear()
        protected void Clear()
        {
            // this.CurrentTextField = ""
            this.CurrentTextField.Text = string.Empty;
            // this.PreviousTextField = ""
            this.PreviousTextField.Text = string.Empty;
            // this.operation = null
        }


        /** A method for delete the last charachter
         */
        private void BackSpace()
        {
            string text = CurrentTextField.Text;

            if (text.Length > 1)
            {
                text = text.Substring(0, text.Length - 1);
            }
            else
            {
                text = "";
            }
            CurrentTextField.Text = text;
        }

        // appendNumber
        protected void AppendNumber(object buttonContent)
        {
            // If CurrentTextField === '.' & CurrentTextField contains '.' so just return nothing
            if (CurrentTextField.Text.Contains(".")) return;
            // Get the CurrentTextField = CurrentTextField to string + CurrentTextField(button.content) to string
            this.CurrentTextField.Text = CurrentTextField.Text + buttonContent;

        }

        // choose operation
        protected void ChooseOperation(object operation)
        {
            // If CurrentTextField === '' then just return
            if (CurrentTextField.Text == string.Empty) return;
            // If PreviousTextField !== '' then Compute()
            if (PreviousTextField.Text != string.Empty)
            {
                Compute();
            }
            this.PreviousTextField.Text = this.CurrentTextField.Text;
            CurrentTextField.Text = string.Empty;
            
        }

        // Compute
        protected void Compute()
        {
            double computation = 0;
            // Var prevNumber = parseFloat(PreviousTextField)
            string[] numOne;
            numOne = PreviousTextField.Text.Split('+', '−', '✕', '÷');
            double prevNumber = Convert.ToDouble(numOne[0]);
            // Var currentNumber =  parseFloat(CurrentTextField)
            double currentNumber = Convert.ToDouble(CurrentTextField.Text);
            // if prevNumber != a number || currentNumber != a number so just return
            if (double.IsNaN(prevNumber) || double.IsNaN(currentNumber)) return;
            
            // Switch (theOperation)
            // case + 
            // prevNumber + currentNumber
            // .
            // .
            // .
            if (PreviousTextField.Text.Contains("+"))
            {
                computation = prevNumber + currentNumber;
            }
            if (PreviousTextField.Text.Contains("−"))
            {
                computation = prevNumber - currentNumber;
            }
            if (PreviousTextField.Text.Contains("✕"))
            {
                computation = prevNumber * currentNumber;
            }
            if (PreviousTextField.Text.Contains("÷"))
            {
                computation = prevNumber / currentNumber;
            }
            // CurrentTextField = computation
            this.CurrentTextField.Text = Convert.ToString(computation);
            // operation = undefind
            // PreviousTextField = ''
            PreviousTextField.Text = string.Empty;

            UpdateDisplay();
        }

        // Update display
        protected void UpdateDisplay()
        {
            // CurrentTextField = CurrentTextField
            this.CurrentTextField.Text = this.CurrentTextField.Text;

            // PreviousTextField = PreviousTextField
            this.CurrentTextField.Text = this.CurrentTextField.Text;
        }

        // Calculator class
    }


}
