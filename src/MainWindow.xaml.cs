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

namespace Practic2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 firstWindow = new Window1();
            firstWindow.Show();
            this.Close();
        }
        private void SecondWindow_Click(object sender, RoutedEventArgs e)
        {
            Window2 secondWindow = new Window2();
            secondWindow.Show();
            this.Close();
        }
        private void ThirdWindow_Click(object sender, RoutedEventArgs e)
        {
            Window3 thirdWindow = new Window3();
            thirdWindow.Show();
            this.Close();
        }
        private void FourWindow_Click(object sender, RoutedEventArgs e)
        {
            Window4 thirdWindow = new Window4();
            thirdWindow.Show();
            this.Close();
        }
    }
}
