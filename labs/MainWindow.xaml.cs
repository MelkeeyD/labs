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
    }
}
