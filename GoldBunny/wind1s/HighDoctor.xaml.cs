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

        private void Menu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pacient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Staff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
