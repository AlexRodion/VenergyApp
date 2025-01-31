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

namespace VenergyApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new RegisPage());
        }

        private void entrbtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new EnterPage());
        }
    }
}
