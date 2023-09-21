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

namespace FirstAppDz.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR7.xaml
    /// </summary>
    public partial class PagePR7 : Page
    {
        public PagePR7()
        {
            InitializeComponent();
            CalculateValues();
        }

        private void CalculateValues()
        {
            double[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            List<DataPoint> dataPoints = new List<DataPoint>();

            foreach (double xi in X)
            {
                double di = (Math.Exp(xi) + 2 * Math.Exp(-xi)) / (Math.Sqrt(5) + Math.Sin(xi));

                if (di > 0.1)
                {
                    dataPoints.Add(new DataPoint { X = xi, D = di });
                }
            }

            dataGrid.ItemsSource = dataPoints;
        }
    }

    public class DataPoint
    {
        public double X { get; set; }
        public double D { get; set; }
    }
}
