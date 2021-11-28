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
    /// Логика взаимодействия для PagePacientDoctor.xaml
    /// </summary>
    public partial class PagePacientDoctor : Page
    { 
        public PagePacientDoctor()
        {
            GoldBunnyEntities bd_gold = new GoldBunnyEntities();
            InitializeComponent();
            var order = AppData.bd_gold.Pet.Where(i => i.IDPet == AppData.IDPacientSave).FirstOrDefault();
            LvPacient.ItemsSource = bd_gold.Pet.ToList();
        }
        private void lvPacient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зайдите от Модератора или Главного врача, чтобы воспользоваться этой функцией!","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зайдите от Модератора или Главного врача, чтобы воспользоваться этой функцией!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Зайдите от Модератора или Главного врача, чтобы воспользоваться этой функцией!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void txbPetName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nmPt = AppData.bd_gold.Pet.ToList();
            LvPacient.ItemsSource = nmPt.Where(i => i.NamePet.ToLower().Contains(txbPetName.Text.ToLower()));
        }

        private void txbTypePet_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tpPt = AppData.bd_gold.Pet.ToList();
            LvPacient.ItemsSource = tpPt.Where(i => i.TypePet.NameTypePet.ToLower().Contains(txbTypePet.Text.ToLower()));
        }

        private void txbGender_TextChanged(object sender, TextChangedEventArgs e)
        {
            var gndr = AppData.bd_gold.Pet.ToList();
            LvPacient.ItemsSource = gndr.Where(i => i.Gender.NameGender.ToLower().Contains(txbGender.Text.ToLower()));
    }
}
}
