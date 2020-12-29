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
            try
            {
                lbElements.Items.Clear();
                int n = Convert.ToInt32(countElements.Text);
                int i;
                int sum = 0;
                int r = 201;
                int l = 0;
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
                    lbElements.Items.Add("Номер наименьшего значения, большего среднего значения массива");
                    for (i = 0; i < n; i++)
                    {
                        sum = sum + (int)Coll[i];
                    }
                    sum = sum / n;
                    for (i = 0; i < n; i++)
                    {
                        if ((int)Coll[i] > sum)
                        {
                            if ((int)Coll[i] < r)
                            {
                                r = (int)Coll[i];
                                l = i;
                            }
                        }
                    }
                    lbElements.Items.Add(l + 1);
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
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    lbElements.Items.Add("Отклонения от среднего значения элементов массива:");
                    double sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += (int)Coll[i];
                    }
                    sum = Math.Round(sum, 1) / n;
                    for (int i = 0; i < n; i++)
                    {
                        lbElements.Items.Add(Coll[i] + " - " + sum + " = " + (Coll[i] = (int)Coll[i] - sum));
                    }
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
            lbElements.Items.Clear();
            try
            {
                int n = Convert.ToInt32(countElements.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    double sum = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += (double)((int)Coll[i]);
                    }
                    sum /= (double)n;
                    lbElements.Items.Add("Среднее значение в массиве: " + Math.Round(sum, 1));
                    double[] m = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        m[i] = (double)((int)Coll[i]) - sum;
                    }
                    double p = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        p += m[i] * m[i];
                    }
                    p /= n;
                    p = Math.Sqrt(p);
                    lbElements.Items.Add("Среднее отклонение в массиве: " + Math.Round(p, 1));
                    for (int i = 0; i < n; i++)
                    {
                        if (m[i] > p / 2)
                        {
                            Coll[i] = sum;
                        }
                    }
                    lbElements.Items.Add("Преобразованный массив: ");
                    for (int i = 0; i < n; i++)
                    {
                        lbElements.Items.Add(Coll[i]);
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lbElements.Items.Clear();
            try
            {
                int n = Convert.ToInt32(countElements.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    double sum = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += (double)((int)Coll[i]);
                    }
                    sum /= (double)n;
                    lbElements.Items.Add("Среднее значение в массиве: " + Math.Round(sum, 1));
                    double[] m = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        m[i] = (double)((int)Coll[i]) - sum;
                    }
                    double p = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        p += m[i] * m[i];
                    }
                    p /= n;
                    p = Math.Sqrt(p);
                    lbElements.Items.Add("Среднее отклонение в массиве: " + Math.Round(p, 1));
                    for (int i = 0; i < n; i++)
                    {
                        if (m[i] > p / 2)
                        {
                            Coll[i] = 0.75 * sum;
                        }
                    }
                    lbElements.Items.Add("Преобразованный массив: ");
                    for (int i = 0; i < n; i++)
                    {
                        lbElements.Items.Add(Coll[i]);
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            lbElements.Items.Clear();
            try
            {
                int n = Convert.ToInt32(countElements.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbElements.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbElements);
                    double sum = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += (double)((int)Coll[i]);
                    }
                    sum /= (double)n;
                    lbElements.Items.Add("Среднее значение в массиве: " + Math.Round(sum, 1));
                    double[] m = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        m[i] = (double)((int)Coll[i]) - sum;
                    }
                    double p = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        p += m[i] * m[i];
                    }
                    p /= n;
                    p = Math.Sqrt(p);
                    lbElements.Items.Add("Среднее отклонение в массиве: " + Math.Round(p, 1));
                    for (int i = 0; i < n; i++)
                    {
                        if (m[i] > p / 2)
                        {
                            Coll[i] = 1.25 * sum;
                        }
                    }
                    lbElements.Items.Add("Преобразованный массив: ");
                    for (int i = 0; i < n; i++)
                    {
                        lbElements.Items.Add(Coll[i]);
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
