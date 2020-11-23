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
                        if (PreviousTextField.Text != string.Empty && CurrentTextField.Text == string.Empty)
                        {
                            PreviousTextField.Text += button.Content;
                        }
                        if (CurrentTextField.Text == string.Empty) return;
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
        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            CurrentTextField.Text = String.Empty;
        }
        private void Button_Click_BackSpace(object sender, RoutedEventArgs e)
        {
            BackSpace();
        }
        private void Button_Click_Plus_Minus(object sender, RoutedEventArgs e)
        {
            NegativePositiveMaker();
        }

        // Make the number negative or positive
        protected void NegativePositiveMaker()
        {
            if (CurrentTextField.Text.Contains('-'))
            {
                double positiveNumber = Convert.ToDouble(CurrentTextField.Text) * -1;
                CurrentTextField.Text = Convert.ToString(positiveNumber);

            }
            else
            {
                double negativeNumber = Convert.ToDouble(CurrentTextField.Text) * -1;
                CurrentTextField.Text = Convert.ToString(negativeNumber);
            }
        }
        
        // A method for delete the last charachter
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
            if (CurrentTextField.Text.Contains(".")) return;
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

            string[] numOne;
            numOne = PreviousTextField.Text.Split('+', '−', '✕', '÷');

            double prevNumber = Convert.ToDouble(numOne[0]);
            double currentNumber = Convert.ToDouble(CurrentTextField.Text);

            if (double.IsNaN(prevNumber) || double.IsNaN(currentNumber)) return;

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
            this.CurrentTextField.Text = Convert.ToString(Math.Round(computation,4));
            PreviousTextField.Text = string.Empty;

        }
        
    }


}
