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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void TranslateButton_Clickk(object sender, RoutedEventArgs e)
        {
            int userInput = Convert.ToInt32(InputTextBox.Text);
            if (userInput >= 0 && userInput < 15)
            {
                lb.Text = "[0 - 14]";
            }
            else if (userInput > 14 && userInput < 36)
            {
                lb.Text = "[15 - 35]";
            }
            else if (userInput > 35 && userInput < 51)
            {
                lb.Text = "[36 - 50]";
            }
            else if (userInput > 50 && userInput < 101)
            {
                lb.Text = "[50 - 100]";
            }
            else
            {
                lb.Text = "Указаное число не попадает в промежуток";
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
