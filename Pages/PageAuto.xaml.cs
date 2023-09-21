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
    /// Логика взаимодействия для PageAuto.xaml
    /// </summary>
    public partial class PageAuto : Page
    {
        public PageAuto()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            //ввод данных из текстовых полей
            string CorrectLogin = "Студент";
            string CorrectPassword = "1";
            string login = TxtLogin.Text;
            string password = PsbPassword.Password;
            if (CorrectLogin == login)
            {
                if (password == CorrectPassword)
                {
                    MessageBox.Show("Вход выполнен");
                    Classes.ClassFrame.frmObj.Navigate(new Pages.PagePR1());

                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Вход не выполнен");
            }


        }
    }
}
