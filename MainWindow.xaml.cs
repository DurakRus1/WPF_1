using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vari7
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
        int firstNumber = 0;

        private int getNumber()
        {
            string[] stringNumbers = TextBoxNumbers.Text.Split(' ');
            try
            {
                firstNumber = int.Parse(stringNumbers[0]);

            }
            catch
            {
                MessageBox.Show("Числа не введены");
                return 0;
            }
            return 1;
        }

        private int getSum()
        {
            return firstNumber + firstNumber + firstNumber + firstNumber;
        }

        private int getMulti()
        {
            return firstNumber * firstNumber;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (getNumber() == 1)
            {
                GridResult.Visibility = Visibility.Visible;
                LabelResult1.Content = $"периметр: {getSum()}";

                LabelResult.Content = $"площадь: {getMulti()}";
            }
            this.Cursor = null;
        }
    }
}

