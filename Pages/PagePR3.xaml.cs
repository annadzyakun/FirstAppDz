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
    /// Логика взаимодействия для PagePR3.xaml
    /// </summary>
    public partial class PagePR3 : Page
    {
        public PagePR3()
        {
            InitializeComponent();
        }
        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            double x0 = Convert.ToDouble(TxtX.Text);
            double xk = Convert.ToDouble(TxtXk.Text);
            double dx = Convert.ToDouble(TxtDx.Text);
            double b = Convert.ToDouble(TxtB.Text);

            LstResult.Items.Clear();

            for (double x = x0; x <= xk; x += dx)
            {
                double y = Math.Pow(x, 2) + Math.Tan(5 * x + b / x);
                LstResult.Items.Add($"x = {x}, y = {y}");
            }
        }
    }
}

