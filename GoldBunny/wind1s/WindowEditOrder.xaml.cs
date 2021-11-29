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
    /// Логика взаимодействия для WindowEditOrder.xaml
    /// </summary>
    public partial class WindowEditOrder : Window
    {
        public WindowEditOrder()
        {
            InitializeComponent();
            cmbClientName.ItemsSource = AppData.bd_gold.Client.Select(i => i.FirstName).ToList();
            cmbNamePet.ItemsSource = AppData.bd_gold.Pet.Select(i => i.NamePet).ToList();
            cmbServiceNameService.ItemsSource = AppData.bd_gold.Service.Select(i => i.NameService).ToList();
            cmbStaffNameStaff.ItemsSource = AppData.bd_gold.Staff.Select(i => i.LastName).ToList();
            
            var order = AppData.bd_gold.Order.Where(i=>i.IDOrder == AppData.iDOrder).FirstOrDefault();
            cmbClientName.SelectedItem = AppData.bd_gold.Client.Where(i => i.IDClient == order.ClientID).Select(i => i.FirstName).FirstOrDefault();
            cmbNamePet.SelectedItem = AppData.bd_gold.Pet.Where(i => i.IDPet == order.PetID).Select(i => i.NamePet).FirstOrDefault();
            cmbServiceNameService.SelectedItem = AppData.bd_gold.Service.Where(i => i.IDService == order.ServiceID).Select(i => i.NameService).FirstOrDefault();
            cmbStaffNameStaff.SelectedItem = AppData.bd_gold.Staff.Where(i => i.IDStaff == order.StaffID).Select(i => i.LastName).FirstOrDefault();
            
            JoinDateDatePicker.Text = order.Date.ToString();
        }

        private void btnCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEditOrder_Click(object sender, RoutedEventArgs e)
        {
            DateTime check;
            if (cmbClientName.SelectedItem == null || cmbNamePet.SelectedItem == null
                || JoinDateDatePicker.SelectedDate == null || cmbServiceNameService.SelectedItem == null || cmbStaffNameStaff.SelectedItem == null)
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка 2", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (DateTime.TryParse(JoinDateDatePicker.Text, out check) && check > DateTime.Now)
            {
                MessageBox.Show("Вы ввели слишком большое значение", "Ошибка 3", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var order = AppData.bd_gold.Order.Where(i => i.IDOrder == AppData.iDOrder).FirstOrDefault();
                order.ClientID = AppData.bd_gold.Client.Where(i => i.FirstName == cmbClientName.SelectedItem.ToString()).Select(i => i.IDClient).FirstOrDefault();
                order.PetID = AppData.bd_gold.Pet.Where(i => i.NamePet == cmbNamePet.SelectedItem.ToString()).Select(i => i.IDPet).FirstOrDefault();
                order.ServiceID = AppData.bd_gold.Service.Where(i => i.NameService == cmbServiceNameService.SelectedItem.ToString()).Select(i => i.IDService).FirstOrDefault();
                order.StaffID = AppData.bd_gold.Staff.Where(i => i.LastName == cmbStaffNameStaff.SelectedItem.ToString()).Select(i => i.IDStaff).FirstOrDefault();
                order.Date = JoinDateDatePicker.SelectedDate.Value;
                AppData.bd_gold.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
