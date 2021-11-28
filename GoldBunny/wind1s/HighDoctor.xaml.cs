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
    /// Логика взаимодействия для HighDoctor.xaml
    /// </summary>
    public partial class HighDoctor : Window
    {
        public HighDoctor()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Pacient_Click(object sender, RoutedEventArgs e)
        {
            frmHighDoctor.Navigate(new wind1s.PagePacientDoctor());
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            frmHighDoctor.Navigate(new wind1s.PageOrderDoctor());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }   

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            wind1s.Auth auth = new wind1s.Auth();
            auth.Show();
            this.Close();
        }
    }
}
