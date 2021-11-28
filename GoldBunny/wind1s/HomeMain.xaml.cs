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
using GoldBunny.basedata;
using GoldBunny.wind1s;

namespace GoldBunny.wind1s
{
    /// <summary>
    /// Логика взаимодействия для HomeMain.xaml
    /// </summary>
    public partial class HomeMain : Window
    {
        public GoldBunnyEntities bd_gold = new GoldBunnyEntities();
        public HomeMain()
        {
            InitializeComponent();
        }

        private void Pacient_Click(object sender, RoutedEventArgs e)
        {
            frmHomeMain.Navigate(new wind1s.Pacient());
        }

        private void MedCard_Click(object sender, RoutedEventArgs e)
        {
            frmHomeMain.Navigate(new wind1s.PageMedcard());
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            frmHomeMain.Navigate(new wind1s.PageOrder());
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
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
