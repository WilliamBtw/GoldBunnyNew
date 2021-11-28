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
using GoldBunny.basedata;

namespace GoldBunny.wind1s
{
    /// <summary>
    /// Логика взаимодействия для PageOrderDoctor.xaml
    /// </summary>
    public partial class PageOrderDoctor : Page
    {

        public PageOrderDoctor()
        {
            GoldBunnyEntities bd_gold = new GoldBunnyEntities();
            InitializeComponent();
            var order = AppData.bd_gold.Order.Where(i => i.IDOrder == AppData.iDOrder).FirstOrDefault();
            LvOrder.ItemsSource = bd_gold.Order.ToList();
        }
        private void LvOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зайдите от Модератора или Главного врача, чтобы воспользоваться этой функцией!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зайдите от Модератора или Главного врача, чтобы воспользоваться этой функцией!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зайдите от Модератора или Главного врача, чтобы воспользоваться этой функцией!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //public void Filter()
        //{
        //    var fltr = AppData.bd_gold.Order.Where(i => i.Service.NameService.ToLower().Contains(txbNameService.Text.ToLower()))
        //                                    .Where(i => i.Client.FirstName.Contains(txbNameClient.Text))
        //                                    .Where(i => i.Staff.LastName.ToLower().Contains(txbLastNameDoctor.Text.ToLower()))
        //                                    .Where(i => i.Pet.NamePet.ToLower().Contains(txbNamePet.Text.ToLower()));
        //    LvOrder.ItemsSource = fltr;
        //}

        private void txbNameService_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nmSr = AppData.bd_gold.Order.ToList();
            LvOrder.ItemsSource = nmSr.Where(i => i.Service.NameService.ToLower().Contains(txbNameService.Text.ToLower()));
            //Filter();
        }

        private void txbNameClient_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nmCl = AppData.bd_gold.Order.ToList();
            LvOrder.ItemsSource = nmCl.Where(i => i.Client.FirstName.ToLower().Contains(txbNameClient.Text.ToLower()));
            //Filter();
        }

        private void txbLastNameDoctor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nmDc = AppData.bd_gold.Order.ToList();
            LvOrder.ItemsSource = nmDc.Where(i => i.Staff.LastName.ToLower().Contains(txbLastNameDoctor.Text.ToLower()));
            //Filter();
        }

        private void txbNamePet_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nmPt = AppData.bd_gold.Order.ToList();
            LvOrder.ItemsSource = nmPt.Where(i => i.Pet.NamePet.ToLower().Contains(txbNamePet.Text.ToLower()));
            //Filter();
        }
    }
}
