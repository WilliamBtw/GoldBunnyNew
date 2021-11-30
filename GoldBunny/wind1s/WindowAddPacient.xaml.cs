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
    /// Логика взаимодействия для WindowAddPacient.xaml
    /// </summary>
    public partial class WindowAddPacient : Window
    {
        public WindowAddPacient()
        {
            InitializeComponent();
            cmbNamePet.ItemsSource = AppData.bd_gold.Pet.Select(i => i.NamePet).ToList();
            cmbRole.ItemsSource = AppData.bd_gold.Role.Select(i => i.NameRole).ToList();
        }

        private void btnSavePacient_Click(object sender, RoutedEventArgs e)
        {
            DateTime check;
            if (txtFirstName.Text == "" || txtLastName.Text == ""
                || txtPatronymic.Text == "" || txtEmail.Text == "" || cmbNamePet.SelectedItem == null || cmbRole.SelectedItem == null || JoinDateDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка 2", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (DateTime.TryParse(JoinDateDatePicker.Text, out check) && check > DateTime.Now)
            {
                MessageBox.Show("Вы ввели слишком большое значение", "Ошибка 3", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                AppData.bd_gold.Client.Add(new basedata.Client
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Patronymic = txtPatronymic.Text,
                    Birthday = JoinDateDatePicker.SelectedDate.Value,
                    Email = txtEmail.Text,
                    PetID = AppData.bd_gold.Pet.Where(i => i.NamePet == cmbNamePet.SelectedItem.ToString()).Select(i => i.IDPet).FirstOrDefault(),
                    RoleID = AppData.bd_gold.Role.Where(i => i.NameRole == cmbRole.SelectedItem.ToString()).Select(i => i.IDRole).FirstOrDefault()
                });
                AppData.bd_gold.SaveChanges();
                MessageBox.Show($"Клиент {txtFirstName.Text} успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void btnCancelPacient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
