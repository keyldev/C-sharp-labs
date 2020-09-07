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

namespace lab_2_wpf_task_2
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

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            int i;
            if (int.TryParse(inputTextBox.Text, out i))
            {
                if (i >= 0)
                {
                    int remainder = 0;
                    StringBuilder binary = new StringBuilder();
                    do
                    {
                        
                        remainder = i % 2;
                        i /= 2;
                        binary.Insert(0, remainder);
                    }
                    while (i > 0);
                    binaryLabel.Content = binary.ToString();
                }
                else MessageBox.Show("Variable 'i' must be positive or zero");
            }
            else MessageBox.Show("TextBox does not contain an integer");
        }
    }
}
