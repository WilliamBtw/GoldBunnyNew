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
    /// Логика взаимодействия для WindowEditMedcard.xaml
    /// </summary>
    public partial class WindowEditMedcard : Window
    {
        public WindowEditMedcard()
        {
            GoldBunnyEntities bd_gold = new GoldBunnyEntities();
            InitializeComponent();
            cmbTypePet.ItemsSource = AppData.bd_gold.TypePet.Select(i => i.NameTypePet).ToList();
            cmbGender.ItemsSource = AppData.bd_gold.Gender.Select(i => i.NameGender).ToList();

            var pa = AppData.bd_gold.Pet.Where(i => i.IDPet == AppData.IDPetSave).FirstOrDefault();
            cmbTypePet.SelectedItem = AppData.bd_gold.Pet.Where(i => i.TypePetID == pa.TypePetID).Select(i => i.TypePet.NameTypePet).FirstOrDefault();
            cmbGender.SelectedItem = AppData.bd_gold.Pet.Where(i => i.GenderID == pa.GenderID).Select(i => i.Gender.NameGender).FirstOrDefault();

            JoinDateDatePicker.Text = pa.Birthday.ToString();
            txtNamePet.Text = pa.NamePet;
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
                var pc = AppData.bd_gold.Pet.Where(i => i.IDPet == AppData.IDPetSave).FirstOrDefault();
                pc.NamePet = txtNamePet.Text;
                pc.Birthday = JoinDateDatePicker.SelectedDate.Value;
                pc.TypePetID = AppData.bd_gold.TypePet.Where(i => i.NameTypePet == cmbTypePet.SelectedItem.ToString()).Select(i => i.IDTypePet).FirstOrDefault();
                pc.GenderID = AppData.bd_gold.Gender.Where(i => i.NameGender == cmbGender.SelectedItem.ToString()).Select(i => i.IDGender).FirstOrDefault();
                AppData.bd_gold.SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
        }

        private void btnCancelMedcard_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
