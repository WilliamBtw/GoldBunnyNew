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
    /// Логика взаимодействия для WindowAddMedcard.xaml
    /// </summary>
    public partial class WindowAddMedcard : Window
    {
        public WindowAddMedcard()
        {
            InitializeComponent();
            cmbTypePet.ItemsSource = AppData.bd_gold.TypePet.Select(i => i.NameTypePet).ToList();
            cmbGender.ItemsSource = AppData.bd_gold.Gender.Select(i => i.NameGender).ToList();
        }

        private void btnSaveMedcard_Click(object sender, RoutedEventArgs e)
        {
            DateTime check;
            if (txtNamePet.Text == "" || cmbTypePet.SelectedItem == null || cmbGender.SelectedItem == null
                || JoinDateDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка 2", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (DateTime.TryParse(JoinDateDatePicker.Text, out check) && check > DateTime.Now)
                {
                MessageBox.Show("Вы ввели слишком большое значение", "Ошибка 3", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            else
            {
                AppData.bd_gold.Pet.Add(new basedata.Pet
                {
                    NamePet = txtNamePet.Text,
                    TypePetID = AppData.bd_gold.TypePet.Where(i => i.NameTypePet == cmbTypePet.SelectedItem.ToString()).Select(i => i.IDTypePet).FirstOrDefault(),
                    Birthday = JoinDateDatePicker.SelectedDate.Value,
                    GenderID = AppData.bd_gold.Gender.Where(i => i.NameGender == cmbGender.SelectedItem.ToString()).Select(i => i.IDGender).FirstOrDefault()
                });
                AppData.bd_gold.SaveChanges();
                MessageBox.Show($"Питомец {txtNamePet.Text} успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void btnCancelMedcard_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
