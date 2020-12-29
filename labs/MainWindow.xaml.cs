using System;
using System.Collections;
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
using Microsoft.Win32;
using System.Windows.Forms.DataVisualization.Charting;

namespace labs
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
            lbElements.Items.Clear();
            try
            {
                int n = Convert.ToInt32(countElements.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    hest Hist = new hest();
                    Hist.CreatingHistogram(Coll);
                    Hist.Show();
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                lbElements.Items.Clear();
                int n = Convert.ToInt32(countElements.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    int j = 0;
                    lbElements.Items.Add("Кол-во чисел меньших своих соседей");
                    for (int i = 1; i < n - 1; i++)
                    {
                        if ((int)Coll[i] < (int)Coll[i - 1] && (int)Coll[i] < (int)Coll[i + 1])
                        {
                            j++;
                        }
                    }
                    if ((int)Coll[0] < (int)Coll[1] && (int)Coll[0] < (int)Coll[n - 1])
                    {
                        j++;
                    }
                    if ((int)Coll[n - 1] < (int)Coll[n - 2] && (int)Coll[n - 1] < (int)Coll[0])
                    {
                        j++;
                    }
                    lbElements.Items.Add(j);
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lbElements.Items.Clear();
            try
            {
                int n = Convert.ToInt32(countElements.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    lbElements.Items.Add("Кол-во элементов массива составляющих со своими\nсоседями упорядоченную последовательность:");
                    lbElements.Items.Add(AllFunc.broi(Coll));

                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lbElements.Items.Clear();
            try
            {
                int n = Convert.ToInt32(countElements.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    ArrayList buffer = new ArrayList();
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    lbElements.Items.Add(" элементов массива составляют со своими соседями и их соседями\n (от i-2 до i+2, где i - индекс позиция текущего элемента )\n упорядоченную последовательность:");
                    int count = 0;
                    buffer.Add(Coll[n - 2]);
                    buffer.Add(Coll[n - 1]);
                    for (int i = 0; i < n; i++) {
                        buffer.Add(Coll[i]);        
                    }
                    buffer.Add(Coll[0]);
                    buffer.Add(Coll[1]);

                    for (int i = 2; i < n + 2; i++) {
                        if (((int)buffer[i - 2] > (int)buffer[i - 1] && (int)buffer[i - 1] > (int)buffer[i] && (int)buffer[i] > (int)buffer[i + 1] && (int)buffer[i + 1] > (int)buffer[i + 2])
                            || ((int)buffer[i - 2] < (int)buffer[i - 1] && (int)buffer[i - 1] < (int)buffer[i] && (int)buffer[i] < (int)buffer[i + 1] && (int)buffer[i + 1] < (int)buffer[i + 2])) {
                            count++;    
                        }
                    }
                    lbElements.Items.Add(count);
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
