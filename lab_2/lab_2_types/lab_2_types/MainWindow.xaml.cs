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

namespace lab_2_types
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> lst_types_from = new List<string>();
        List<string> lst_types_to = new List<string>();

        string[] i_types_name = new string[]{ // неявное преобразование, имена
            "byte",
            "sbyte",
            "short",
            "ushort",
            "int",
            "long",
            "ulong",
            "float",
            "char",
        };
        string[] i_convert_to = new string[] // массив с именами других типов
        {
            "short, ushort, int, uint, long, ulong, float, double, decimal",
            "short, int, long, float, double, decimal",
            "int, long, float, double, decimal",
            "int, uint, long, ulong, float, double, decimal",
            "long, float, double, decimal",
            "float, double, decimal",
            "float, double, decimal",
            "double",
            "ushort, int, uint, long, ulong, float, double, decimal"
        };

        int indexOfArr, indexNextType, explicitOfArray, explicitIndexType;


        public MainWindow()
        {
            InitializeComponent();

            lst_types_from.AddRange(i_types_name); // заполняем первый лист
            lst_types_to.AddRange(i_convert_to); // заполняем лист с преобразованиями в другие типы

            for (int i = 0; i < lst_types_from.Count; i++) // заполняем первый комбобокс
                typesArray.Items.Add(lst_types_from[i]);

            for (int j = 0; j < lst_types_to.Count; j++) // заполняем второй комбобокс
                toNextType.Items.Add(lst_types_to[j]);

        }
       private string makeConvertion(int first_index) // функция, делающая неявные преобразования
        {
            switch (first_index)
            {
                case 0:
                    {
                        byte source; byte.TryParse(tb_InsertText.Text, out source);
                        short a = source;
                        ushort b = source;
                        int c = source;
                        uint d = source;
                        long e = source;
                        ulong f = source;
                        float g = source;
                        double h = source;
                        decimal i = source;
                        //форматируем строку
                        return string.Format("short: {0}, ushort:{1}, int: {2}, uint: {3}, long: {4}, ulong: {5}, float: {6}, double: {7}, decimal: {8} - неявное приведение типов успешно произведено.", a, b, c, d, e, f, g, h, i);
                        
                        
                    }
                case 1:
                    {

                        sbyte source; sbyte.TryParse(tb_InsertText.Text, out source);
                        short a = source;
                        int b = source;
                        long c = source;
                        float d = source;
                        double e = source;
                        decimal f = source;
                        return string.Format("short: {0}, int: {1}, long: {2}, float: {3}, double: {4}, decimal: {5} - неявное приведение типов успешно произведено.", a,b,c,d,e,f);
                        
                    }
                case 2:
                    {
                        short source; short.TryParse(tb_InsertText.Text, out source);
                        int a = source;
                        long b = source;
                        float c = source;
                        double d = source;
                        decimal e = source;
                        return string.Format("int: {0}, long: {1}, float: {2}, double: {3}, decimal: {4} - неявное приведение типов успешно произведено.", a,b,c,d,e);
                         
                    }
                case 3:
                    {
                        ushort source; ushort.TryParse(tb_InsertText.Text, out source);
                        int a = source;
                        uint b = source;
                        long c = source;
                        ulong d = source;
                        float e = source;
                        double f = source;
                        decimal g = source;
                        return string.Format("int: {0}, uint: {1}, long: {2}, ulong: {3}, float: {4}, double: {5}, decimal: {6} - неявное приведение типов успешно произведено.", a,b,c,d,e,f,g);
                         
                    }
                case 4:
                    {
                        int source; int.TryParse(tb_InsertText.Text, out source);
                        long a = source;
                        float b = source; 
                        double c = source;
                        decimal d = source;
                        return string.Format("long: {0}, float: {1}, double: {2}, decimal: {3} - неявное приведение типов успешно произведено.", a, b, c, d);
                         
                    }
                case 5:
                    {
                        long source; long.TryParse(tb_InsertText.Text, out source);
                        float a = source;
                        double b = source;
                        decimal c = source;
                        return string.Format("float: {0}, double: {1}, decimal: {2}", a, b, c);
                    }
                case 6:
                    {
                        ulong source; ulong.TryParse(tb_InsertText.Text, out source);
                        float a = source;
                        double b = source;
                        decimal c = source;
                        return string.Format("float: {0}, double: {1}, decimal: {2}", a, b, c);
                         
                    }
                case 7:
                    {
                        float source; float.TryParse(tb_InsertText.Text, out source);
                        double a = source;
                        return string.Format("double: {0}", a);
                         
                    }
                case 8:
                    {
                        char source; char.TryParse(tb_InsertText.Text, out source);
                        ushort a = source;
                        int b = source;
                        uint c = source;
                        long d = source;
                        ulong e = source;
                        float f = source;
                        double g = source;
                        decimal h = source;
                        return string.Format("ushort: {0}, int: {1}, uint: {2}, long: {3}, ulong: {4}, float: {5}, double: {6}, decimal: {7}", a,b,c,d,e,f,g,h);
                        
                    }
            }
            return null;
        }

        private void bDoOperation_Click(object sender, RoutedEventArgs e)
        {
            if (indexOfArr != indexNextType) 
                MessageBox.Show("Неявное преобразование возможно только для одинаковых строк\nПример: \n byte -> short, ushort, int, uint, long, ulong, float, double, deceminal", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else 
                resultBox.Text = makeConvertion(indexOfArr);
        }

        private void typesArray_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexOfArr = typesArray.SelectedIndex;
        }
        private void toNextType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexNextType = toNextType.SelectedIndex;
        }

        private void explicitType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            explicitOfArray = 0;
        }
        private void explicitNextType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            explicitIndexType = 1;
        }
        ///<summary>
        /// Неявное преобразование типов.
        /// </summary>


    }
}

/*
 * 
 * Неявное
 byte -> short, ushort, int, uint, long, ulong, float, double, deceminal  - добавлять по таким пунктам в комбобокс и просто подряд преобразовывать
sbyte -> short, int, long, float, double, deceminal
short -> int, long, float, double, deceminal
ushort -> int, uint, long, ulong, float, double, deceminal
int -> long, float, double, deceminal
long -> float, double, deceminal
ulong -> float, double, deceminal
float -> double
char -> ushort, int, uint, long, ulong, float, double, deceminal
 
 
 */
