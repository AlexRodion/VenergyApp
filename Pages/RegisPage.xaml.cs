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
using VenergyApp.AppData;
using VenergyApp.Pages;

namespace VenergyApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisPage.xaml
    /// </summary>
    public partial class RegisPage : Page
    {
        public RegisPage()
        {
            InitializeComponent();
            Cmbxreg.ItemsSource = new string[] { "Пользователь", "Админ" };
        }

        private void regisbtn_Click(object sender, RoutedEventArgs e)
        {
            var login = lgntxt.Text;
            var password = Pswrdtxt.Password ;
            var repassword = rptpswrdtxt.Password;
            string haslog;
            string haspass;
            if (login == string.Empty || password == string.Empty || repassword == string.Empty || password != repassword)
            {
                MessageBox.Show("Проверьте заполнены ли поля верно.", "Ошибка");
                return;
            }
            else
            {
                Nav.MainFrame.Navigate(new MainPage());
            }
        }
    }
}
