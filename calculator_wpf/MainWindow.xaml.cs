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

namespace calculator_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Calculator calc = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickDigit(object sender, RoutedEventArgs e)
        {
            calc.Digit((sender as Button).Content.ToString());
            TextInput.Text = calc.Value;
        }
        private void ClickOperations(object sender, RoutedEventArgs e)
        {
            calc.Operations((sender as Button).Content.ToString());
            TextInput.Text = calc.Value;
        }
        private void ClickEqual(object sender, RoutedEventArgs e)
        {
            calc.Equal();
            TextOutput.Text = "";
            TextInput.Text = calc.Value;
        }
        private void ClickErase(object sender, RoutedEventArgs e)
        {
            calc.Erase();
            TextInput.Text = calc.Value;
        }
        private void ClickMemorySave(object sender, RoutedEventArgs e)
        {
            var m = new Label();
            /*m.Width = 30;
            m.Height = 30;
            m.Content = "M";
            MainGrid.Children.Add(m);*/
        }
        public void ClickMemoryDel(object sender, RoutedEventArgs e)
        {

        }
        public void ClickMemoryPlus(object sender, RoutedEventArgs e)
        {

        }
        public void ClickMemoryMinus(object sender, RoutedEventArgs e)
        {

        }
        public void ClickMemoryR(object sender, RoutedEventArgs e)
        {

        }


    }
}
