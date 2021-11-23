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
using System.Windows.Shapes;

namespace GoldBunny.wind1s
{
    /// <summary>
    /// Логика взаимодействия для HomeMain.xaml
    /// </summary>
    public partial class HomeMain : Window
    {
        public HomeMain()
        {
            InitializeComponent();
        }

        private void Pacient_Click(object sender, RoutedEventArgs e)
        {
            frmHomeMain.Navigate(new wind1s.Pacient());
        }

        private void Graphics_Click(object sender, RoutedEventArgs e)
        {
            frmHomeMain.Navigate(new wind1s.Graphics());
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            frmHomeMain.Navigate(new wind1s.Order());
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            wind1s.Auth auth = new wind1s.Auth();
            auth.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
