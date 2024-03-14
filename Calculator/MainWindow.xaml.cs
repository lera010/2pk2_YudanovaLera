using System.Text;
using System.Text.RegularExpressions;
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

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "0";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "9";
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            string expression = inputTextBlock.Text;
            inputTextBlock.Text = Calculation(expression).ToString();
        }

        private double Calculation(string expression)
        {
            string pattern = @"([-+]?\d*\.?\d+)\s*([-+*/])\s*([-+]?\d*\.?\d+)";
            Match match = Regex.Match(expression, pattern);

            // Если удалось получить соответствие с регулярным выражением
            if (match.Success)
            {
                double operand1 = double.Parse(match.Groups[1].Value);
                string operation = match.Groups[2].Value;
                double operand2 = double.Parse(match.Groups[3].Value);

                // Выполняем логику подсчета итогового результата
                switch (operation)
                {
                    case "+":
                        return operand1 + operand2;
                    case "-":
                        return operand1 - operand2;
                    case "*":
                        return operand1 * operand2;
                    case "/":
                        if (operand2 != 0)
                            return operand1 / operand2;
                        else
                            throw new DivideByZeroException("Cannot divide by zero");
                    default:
                        throw new ArgumentException("Invalid operation: " + operation);
                }
            }
            else
            {
                throw new ArgumentException("Invalid expression format");
            }

        }

        private void delenie_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "/";
        }

        private void prois_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
        }
    }
}