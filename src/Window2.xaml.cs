using System;
using System.Windows;

namespace Practic2
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                double operand1 = double.Parse(Operand1TextBox.Text);
                double operand2 = double.Parse(Operand2TextBox.Text);
                string sign = SignTextBox.Text.Trim();

                double result;

                switch (sign)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        if (operand2 == 0)
                            throw new DivideByZeroException();
                        result = operand1 / operand2;
                        break;
                    default:
                        ResultTextBlock.Text = "Неизвестная операция.";
                        return;
                }

                ResultTextBlock.Text = $"Результат: {result}";
            }
            catch (DivideByZeroException)
            {
                ResultTextBlock.Text = "Ошибка: Деление на ноль.";
            }
            catch
            {
                ResultTextBlock.Text = "Ошибка: Некорректные данные.";
            }
        }
        private void TranslateButton_Click22(object sender, RoutedEventArgs e)
        {
            MainWindow Window = new MainWindow();
            Window.Show();
            this.Close();
        }
    }
}