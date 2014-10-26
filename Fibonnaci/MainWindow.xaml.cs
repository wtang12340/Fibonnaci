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

namespace Fibonnaci
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(NBox.Text);
                string s = "";
                for (int i = 0; i < n; i++)
                {
                    s += Fibonacci(i).ToString() + " ";
                }
                OutBox.Text = s;
            }
            catch (FormatException ex)
            {
                OutBox.Text = "Invalid Input";
            }


        }


        public int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


    }
}
