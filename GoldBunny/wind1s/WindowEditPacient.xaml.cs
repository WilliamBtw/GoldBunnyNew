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
            cmbTypePet.ItemsSource = AppData.bd_gold.TypePet.Select(i => i.NameTypePet).ToList();
            cmbGender.ItemsSource = AppData.bd_gold.Gender.Select(i => i.NameGender).ToList();

            var pc = AppData.bd_gold.Pet.Where(i => i.IDPet == AppData.IDPacientSave).FirstOrDefault();
            cmbNamePet.SelectedItem = AppData.bd_gold.Pet.Where(i => i.IDPet == pc.IDPet).Select(i => i.NamePet).FirstOrDefault();
            cmbTypePet.SelectedItem = AppData.bd_gold.TypePet.Where(i => i.IDTypePet == pc.TypePetID).Select(i => i.NameTypePet).FirstOrDefault();
            cmbGender.SelectedItem = AppData.bd_gold.Gender.Where(i => i.IDGender == pc.GenderID).Select(i => i.NameGender).FirstOrDefault();
            
            txtMedcard.Text = pc.IDMedcard.ToString();
            txbPetBirthday.Text = pc.Birthday.ToString();
        }

        private void btnSavePacient_Click(object sender, RoutedEventArgs e)
        {
            var pc = AppData.bd_gold.Pet.Where(i => i.IDPet == AppData.IDPacientSave).FirstOrDefault();
                pc.IDPet = AppData.bd_gold.Pet.Where(i => i.NamePet == cmbNamePet.SelectedItem.ToString()).Select(i => i.IDPet).FirstOrDefault();
                pc.TypePetID = AppData.bd_gold.TypePet.Where(i => i.NameTypePet == cmbTypePet.SelectedItem.ToString()).Select(i => i.IDTypePet).FirstOrDefault();
                pc.GenderID = AppData.bd_gold.Gender.Where(i => i.NameGender == cmbGender.SelectedItem.ToString()).Select(i => i.IDGender).FirstOrDefault();
                pc.Birthday = DateTime.Parse(txbPetBirthday.Text);
                pc.IDMedcard = int.Parse(txtMedcard.Text);
            AppData.bd_gold.SaveChanges();
            MessageBox.Show("Данные успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void btnCancelPacient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
