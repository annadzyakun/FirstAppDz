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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace FirstAppDz.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePR22.xaml
    /// </summary>
    public partial class PagePR22 : Page
    {
        public PagePR22()
        {
            InitializeComponent();
        }
        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {

            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);
            _ = double.Parse(txtZ.Text);

            //  f(x) = x^2
            double fx = Math.Pow(x, 2);


            double solution;
            if (x / y > 0)
            {
                solution = Math.Log(Math.Abs(fx / y)) + Math.Pow(fx + y, 3);
            }
            else if (x / y < 0)
            {
                solution = Math.Pow(fx + y, 3) - Math.Log(Math.Abs(fx / y));
            }
            else if (x == 0 && y == 0)
            {
                solution = 0;
            }
            else
            {
                solution = Math.Pow(fx, 2) + Math.Pow(y, 3);
            }


            lstResult.Items.Clear();
            lstResult.Items.Add($"f(x) = {fx}");
            lstResult.Items.Add($"Solution: {solution}");
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {

            txtX.Text = "";
            txtY.Text = "";
            txtZ.Text = "";
            lstResult.Items.Clear();
        }
    }
}


