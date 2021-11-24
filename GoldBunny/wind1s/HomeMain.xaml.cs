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

namespace GoldBunny.wind1s
{
    /// <summary>
    /// Логика взаимодействия для HomeMain.xaml
    /// </summary>
    public partial class HomeMain : Window
    {
        public GoldBunnyEntities bd_gold = new GoldBunnyEntities();
        public Config config = new Config();
        public LoginClass loginClass = new LoginClass(9);
        public int svWiewPage = 0;
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
            frmHomeMain.Navigate(new wind1s.MedCardPage());
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

        private void radiButton(object sender, RoutedEventArgs e)
        {
            RadioButton li = (sender as RadioButton);

            if(li.Name == "R1_1")
            {
                Grup.Visibility = Visibility.Visible;
                Grup1.Visibility = Visibility.Visible;
            }
            else
            {
                Grup.Visibility = Visibility.Collapsed;
                Grup1.Visibility = Visibility.Collapsed;
            }
        }
        private void Click_check1(object sender, RoutedEventArgs e)
        {
            frmHomeMain.Refresh();
        }
        private void ProfileBut_Click(object sender, RoutedEventArgs e)
        {
            //в разработке
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
