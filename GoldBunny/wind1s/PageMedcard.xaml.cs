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
    /// Логика взаимодействия для PageMedcard.xaml
    /// </summary>
    public partial class PageMedcard : Page
    {
        public PageMedcard()
        {
            GoldBunnyEntities bd_gold = new GoldBunnyEntities();
            InitializeComponent();
            var medcard = AppData.bd_gold.Pet.Where(i => i.IDPet == AppData.IDPetSave).FirstOrDefault();
            LvPet.ItemsSource = bd_gold.Pet.ToList();
        }

        private void txbDiagnosis_TextChanged(object sender, TextChangedEventArgs e)
        {
            var diagg = AppData.bd_gold.Pet.ToList();
            LvPet.ItemsSource = diagg.Where(i => i.NamePet.ToLower().Contains(txtNamePet.Text.ToLower()));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WindowAddMedcard winaddmed = new WindowAddMedcard();
            winaddmed.ShowDialog();
            LvPet.ItemsSource = AppData.bd_gold.Pet.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var somth = AppData.bd_gold;
            if (LvPet.SelectedItem is Pet pet
                )
            {
                AppData.IDPetSave = pet.IDPet;
                WindowEditMedcard winedmed = new WindowEditMedcard();
                winedmed.ShowDialog();
                LvPet.ItemsSource = AppData.bd_gold.Pet.ToList();
            }
            else
            {
                MessageBox.Show("Выберите питомца из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить питомца?",
               "Удаление питомца", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var result2 = MessageBox.Show("Точно?", "Удаление питомца", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result2 == MessageBoxResult.Yes)
                {
                    if (LvPet.SelectedItem is Pet pet)
                    {
                        AppData.bd_gold.Pet.Remove(AppData.bd_gold.Pet.Where(i => i.IDPet == pet.IDPet).FirstOrDefault());
                        AppData.bd_gold.SaveChanges();
                        MessageBox.Show("Питомец успешно удален!", "Удаление питомца", MessageBoxButton.OK, MessageBoxImage.Information);
                        LvPet.ItemsSource = AppData.bd_gold.Pet.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Выберите питомца из списка!", "Удаление питомца", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        private void LvPet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
