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
    /// Логика взаимодействия для PageOrder.xaml
    /// </summary>
    public partial class PageOrder : Page
    {

        public PageOrder()
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
            WindowAddOrder winadd = new WindowAddOrder();
            winadd.ShowDialog();
            LvOrder.ItemsSource = AppData.bd_gold.Order.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var somth = AppData.bd_gold;
            if (LvOrder.SelectedItem is Order order)
            {
                AppData.iDOrder = order.IDOrder;
                WindowEditOrder winEd = new WindowEditOrder();
                winEd.ShowDialog();
                LvOrder.ItemsSource = AppData.bd_gold.Order.ToList();
            }
            else
            {
                MessageBox.Show("Выберите заказ из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить запись?",
                "Удаление заказа", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var result2 = MessageBox.Show("Точно?","Удаление клиента",MessageBoxButton.YesNo,MessageBoxImage.Question);
                if (result2 == MessageBoxResult.Yes)
                {
                    if (LvOrder.SelectedItem is Order order)
                    {
                        AppData.bd_gold.Order.Remove(AppData.bd_gold.Order.Where(i => i.IDOrder == order.IDOrder).FirstOrDefault());
                        AppData.bd_gold.SaveChanges();
                        MessageBox.Show("Запись успешно удалена!", "Удаление заказа", MessageBoxButton.OK, MessageBoxImage.Information);
                        LvOrder.ItemsSource = AppData.bd_gold.Order.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Выберите заказ из списка!", "Удаление заказа", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
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
