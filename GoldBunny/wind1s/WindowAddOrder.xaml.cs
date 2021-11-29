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
    /// Логика взаимодействия для WindowAddOrder.xaml
    /// </summary>
    public partial class WindowAddOrder : Window
    {
        public WindowAddOrder()
        {
            InitializeComponent();
            cmbClientName.ItemsSource = AppData.bd_gold.Client.Select(i => i.FirstName).ToList();
            cmbNamePet.ItemsSource = AppData.bd_gold.Pet.Select(i => i.NamePet).ToList();
            cmbServiceNameService.ItemsSource = AppData.bd_gold.Service.Select(i => i.NameService).ToList();
            cmbStaffNameStaff.ItemsSource = AppData.bd_gold.Staff.Select(i => i.LastName).ToList();
            
        }

        private void btnCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveOrder_Click(object sender, RoutedEventArgs e)
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
                AppData.bd_gold.Order.Add(new basedata.Order
                {
                    ServiceID = AppData.bd_gold.Service.Where(i => i.NameService == cmbServiceNameService.SelectedItem.ToString()).Select(i => i.IDService).FirstOrDefault(),
                    PetID = AppData.bd_gold.Pet.Where(i => i.NamePet == cmbNamePet.SelectedItem.ToString()).Select(i => i.IDPet).FirstOrDefault(),
                    ClientID = AppData.bd_gold.Client.Where(i => i.FirstName == cmbClientName.SelectedItem.ToString()).Select(i => i.IDClient).FirstOrDefault(),
                    Date = JoinDateDatePicker.SelectedDate.Value,
                    StaffID = AppData.bd_gold.Staff.Where(i => i.LastName == cmbStaffNameStaff.SelectedItem.ToString()).Select(i => i.IDStaff).FirstOrDefault()
                });
                AppData.bd_gold.SaveChanges();
                MessageBox.Show($"Заказ {cmbServiceNameService} успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }
    }
}
