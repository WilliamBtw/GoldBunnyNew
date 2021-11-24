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
    /// Логика взаимодействия для PageAddOrder.xaml
    /// </summary>
    public partial class PageAddOrder : Page
    {
        List<basedata.Order> orderList = new List<basedata.Order>();
        public PageAddOrder()
        {
            GoldBunnyEntities bd_gold = new GoldBunnyEntities();
            InitializeComponent();
            var service = AppData.bd_gold.Order.ToList();
            
        }
        private void btnSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnCancelOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
