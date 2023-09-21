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
    /// Логика взаимодействия для PagePR1.xaml
    /// </summary>
    public partial class PagePR1 : Page
    {
        public PagePR1()
        {
            InitializeComponent();
        }

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(TxtX.Text);
            double y = Convert.ToDouble(TxtY.Text);
            double z = Convert.ToDouble(TxtZ.Text);

            double B = Math.Sqrt(10 * (Math.Pow(x, 1 / 3) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));

            LstResult.Items.Add("Пр№1 ИСП21.2А Дзякун");
            LstResult.Items.Add($"x={x}");
            LstResult.Items.Add($"y={y}");
            LstResult.Items.Add($"z={z}");
            LstResult.Items.Add($"Результат B={B}");

        }
    }
}
