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
            if (sender is Button button)
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
            backSpace();
        }
        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {
            CurrentTextField.Text = Convert.ToInt32("-3") + "";
        }
        private void Button_Click_Multiplication(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {

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
        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {

        }



        // Calculator class

        // Constructor
        protected void constructor()
        {
            // this.CurrentTextField = CurrentTextField
            this.CurrentTextField = CurrentTextField;

            // this.PreviousTextField = PreviousTextField
            this.PreviousTextField = PreviousTextField;
            // clear()
            clear();
        }

        // clear()
        protected void clear()
        {
            // this.CurrentTextField = ""
            this.CurrentTextField.Text = string.Empty;
            // this.PreviousTextField = ""
            this.PreviousTextField.Text = string.Empty; ;
            // this.operation = null
        }


        /** A method for delete the last charachter
         */
        private void backSpace()
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
        protected void appendNumber()
        {
            // If CurrentTextField === '.' & CurrentTextField contains '.' so just return nothing
            // Get the CurrentTextField = CurrentTextField to string + CurrentTextField(button.content) to string

        }


        // choose operation
        protected void chooseOperation()
        {
            // If CurrentTextField === '' then just return
            if (CurrentTextField.Text == string.Empty)
            {
                return;
            }
            // If PreviousTextField !== '' then Compute()
            if (PreviousTextField.Text != string.Empty)
            {
                compute();
            }
            
        }



        // Compute
        protected void compute()
        {
            // var computation
            float computation;
            // Var prevNumber = parseFloat(PreviousTextField)
            float prevNumber = float.Parse(PreviousTextField.Text);
            // Var currentNumber =  parseFloat(CurrentTextField)
            float currentNumber = float.Parse(CurrentTextField.Text);
            // if prevNumber != a number || currentNumber != a number so just return
            if (double.IsNaN(prevNumber) || double.IsNaN(currentNumber)) return;
            // Switch (theOperation)

            // case + 
            // prevNumber + currentNumber
            // .
            // .
            // .
            // CurrentTextField = computation
            CurrentTextField.Text = "" + computation;
            // operation = undefind
            // PreviousTextField = ''
        }

        // Update display
        protected void updateDisplay()
        {
            // CurrentTextField = CurrentTextField
            this.CurrentTextField.Text = CurrentTextField.Text;

            // PreviousTextField = PreviousTextField
            this.CurrentTextField.Text = CurrentTextField.Text;
        }

        // Calculator class
    }


}
