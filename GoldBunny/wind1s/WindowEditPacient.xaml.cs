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
    /// Логика взаимодействия для WindowEditPacient.xaml
    /// </summary>
    public partial class WindowEditPacient : Window
    {
        public WindowEditPacient()
        {
            InitializeComponent();
            cmbNamePet.ItemsSource = AppData.bd_gold.Pet.Select(i => i.NamePet).ToList();
            cmbRole.ItemsSource = AppData.bd_gold.Role.Select(i => i.NameRole).ToList();

            var pc = AppData.bd_gold.Client.Where(i => i.IDClient == AppData.IDClientSave).FirstOrDefault();
            cmbNamePet.SelectedItem = AppData.bd_gold.Client.Where(i => i.PetID == pc.PetID).Select(i => i.Pet.NamePet).FirstOrDefault();
            cmbRole.SelectedItem = AppData.bd_gold.Client.Where(i => i.RoleID == pc.RoleID).Select(i => i.Role.NameRole).FirstOrDefault();
            
            JoinDateDatePicker.Text = pc.Birthday.ToString();
            txtFirstName.Text = pc.FirstName;
            txtLastName.Text = pc.LastName;
            txtPatronymic.Text = pc.Patronymic;
            txtEmail.Text = pc.Email;
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
                var pc = AppData.bd_gold.Client.Where(i => i.IDClient == AppData.IDClientSave).FirstOrDefault();
                pc.FirstName = txtFirstName.Text;
                pc.LastName = txtLastName.Text;
                pc.Patronymic = txtPatronymic.Text;
                pc.Email = txtEmail.Text;
                pc.Birthday = JoinDateDatePicker.SelectedDate.Value;
                pc.RoleID = AppData.bd_gold.Role.Where(i => i.NameRole == cmbRole.SelectedItem.ToString()).Select(i => i.IDRole).FirstOrDefault();
                pc.PetID = AppData.bd_gold.Pet.Where(i => i.NamePet == cmbNamePet.SelectedItem.ToString()).Select(i => i.IDPet).FirstOrDefault();
                AppData.bd_gold.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void btnCancelPacient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
