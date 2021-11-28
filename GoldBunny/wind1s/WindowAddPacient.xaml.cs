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
            cmbTypePet.ItemsSource = AppData.bd_gold.TypePet.Select(i => i.NameTypePet).ToList();
            cmbGender.ItemsSource = AppData.bd_gold.Gender.Select(i => i.NameGender).ToList();

        }

        private void btnSavePacient_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сначала убедитесь, что вы добавили медкарту!", "Уведомление", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            AppData.bd_gold.Pet.Add(new basedata.Pet
            {
                IDPet = AppData.bd_gold.Pet.Where(i => i.NamePet == cmbNamePet.SelectedItem.ToString()).Select(i => i.IDPet).FirstOrDefault(),
                TypePetID = AppData.bd_gold.TypePet.Where(i => i.NameTypePet == cmbTypePet.SelectedItem.ToString()).Select(i => i.IDTypePet).FirstOrDefault(),
                GenderID = AppData.bd_gold.Gender.Where(i => i.NameGender == cmbGender.SelectedItem.ToString()).Select(i => i.IDGender).FirstOrDefault(),
                IDMedcard = int.Parse(txtMedcard.Text),
                Birthday = DateTime.Parse(txbPetBirthday.Text)                
            });
            AppData.bd_gold.SaveChanges();
            MessageBox.Show($"Пациент {cmbNamePet} успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void btnCancelPacient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
