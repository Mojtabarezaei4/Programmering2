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
            if(sender is Button button)
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
                        TextFied.Text += button.Content;
                        break;
                }
            }
        }

        private void Button_Click_CE(object sender, RoutedEventArgs e)
        {
            TextFied.Text = String.Empty;
        }
        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            TextFied.Text = String.Empty;
        }
        private void Button_Click_BackSpace(object sender, RoutedEventArgs e)
        {
            backSpace();
        }
        private void Button_Click_Division(object sender, RoutedEventArgs e)
        {

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

        }
        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {

        }

        /** A method for delete the last charachter
         */
        private void backSpace()
        {
            string text = TextFied.Text;

            if(text.Length > 1)
            {
                text = text.Substring(0, text.Length - 1);
            }
            else
            {
                text = "";
            }
            TextFied.Text = text;
        }

    }


}
