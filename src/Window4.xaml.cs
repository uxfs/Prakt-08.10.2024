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
using System.Windows.Shapes;

namespace Practic2
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        string password = "12345";
        private void TranslateButton_Clickk(object sender, RoutedEventArgs e)
        {
            string userInput = InputTextBox.Text;
            if (userInput == "qwerty")
            {
                lb.Text = "Ты лучший!";
            }
            else lb.Text = "Неправильный пароль";
        }
        private void TranslateButton_Click22(object sender, RoutedEventArgs e)
        {
            MainWindow Window = new MainWindow();
            Window.Show();
            this.Close();
        }
    }
}
