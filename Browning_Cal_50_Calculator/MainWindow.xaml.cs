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

namespace Browning_Cal_50_Calculator
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

        private void buttPlus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbRes.Content = double.Parse(numTb1.Text) + double.Parse(numTb2.Text);
            }
            catch (FormatException) 
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttKlee_Click(object sender, RoutedEventArgs e)
        {
            numTb1.Clear();
            numTb2.Clear();
            lbRes.Content = "0";
        }

        private void buttMinus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbRes.Content = double.Parse(numTb1.Text) - double.Parse(numTb2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttX_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbRes.Content = double.Parse(numTb1.Text) * double.Parse(numTb2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttDiv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            lbRes.Content = double.Parse(numTb1.Text) / double.Parse(numTb2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttPer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            lbRes.Content = double.Parse(numTb1.Text)/100;
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttSin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbRes.Content = Math.Sin(double.Parse(numTb1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttCos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            lbRes.Content = Math.Cos(double.Parse(numTb1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttLoh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            lbRes.Content = Math.Log(double.Parse(numTb1.Text), double.Parse(numTb2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttPow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            lbRes.Content = Math.Pow(double.Parse(numTb1.Text), 2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttPowN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            lbRes.Content = Math.Pow(double.Parse(numTb1.Text), double.Parse(numTb2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }

        private void buttSqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            lbRes.Content = Math.Sqrt(double.Parse(numTb1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Убедительная просьба вводить только числа!");
            }
        }
    }
}
