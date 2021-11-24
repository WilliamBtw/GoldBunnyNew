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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Page
    {

        public Order()
        {
            GoldBunnyEntities bd_gold = new GoldBunnyEntities();
            InitializeComponent();
            LvOrder.ItemsSource = bd_gold.Order.ToList();
        }    
        private void LvOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EdditOrder_Click(object sender, RoutedEventArgs e)
        {
            basedata.Order orderSave = new basedata.Order();
            orderSave = (basedata.Order)LvOrder.SelectedItem;
            if (LvOrder.SelectedValue != null)
            {
                AppData.orderSave.IDOrder = orderSave.IDOrder;
                AppData.orderSave.ServiceID = orderSave.ServiceID;
                AppData.orderSave.Date = orderSave.Date;
                AppData.orderSave.ClientID = orderSave.ClientID;
                AppData.orderSave.StaffID = orderSave.StaffID;
                AppData.orderSave.PetID = orderSave.PetID;
            }
            else
            {
                MessageBox.Show("Pls select somth.\n Try Again", "Not Relesed Function", MessageBoxButton.OK);
            }
        }

        private void DeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            basedata.Order orderSave = new basedata.Order();
            if (LvOrder.SelectedValue != null)
            {
                orderSave = (basedata.Order)LvOrder.SelectedItem;
                var item = AppData.bd_gold.Order.Find(orderSave.IDOrder);

                AppData.bd_gold.Order.Remove(item);
                AppData.bd_gold.SaveChanges();
                MessageBox.Show("Successfully created order", "Not Relesed Function", MessageBoxButton.OK);
                LvOrder.ItemsSource = AppData.bd_gold.Order.ToList();

            }
        }
    }
}
