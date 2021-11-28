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
    /// Логика взаимодействия для Pacient.xaml
    /// </summary>
    public partial class Pacient : Page
    {
        public Pacient()
        {
            GoldBunnyEntities bd_gold = new GoldBunnyEntities();
            InitializeComponent();
            var pacient = AppData.bd_gold.Pet.Where(i => i.IDPet == AppData.IDPacientSave).FirstOrDefault();
            LvPacient.ItemsSource = bd_gold.Pet.ToList();
        }
        private void lvPacient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить пациента?",
                "Удаление заказа", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var result2 = MessageBox.Show("Точно?", "Удаление пациента", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result2 == MessageBoxResult.Yes)
                {
                    if (LvPacient.SelectedItem is Pet pacient)
                    {
                        AppData.bd_gold.Pet.Remove(AppData.bd_gold.Pet.Where(i => i.IDPet == pacient.IDPet).FirstOrDefault());
                        AppData.bd_gold.SaveChanges();
                        MessageBox.Show("Пациент успешно удалён!", "Удаление пациента", MessageBoxButton.OK, MessageBoxImage.Information);
                        LvPacient.ItemsSource = AppData.bd_gold.Pet.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Выберите пациента из списка!", "Удаление пациента", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var somth = AppData.bd_gold;
            if (LvPacient.SelectedItem is Pet pacient)
            {
                AppData.IDPacientSave = pacient.IDPet;
                WindowEditPacient winPc = new WindowEditPacient(); 
                winPc.ShowDialog();
                LvPacient.ItemsSource = AppData.bd_gold.Pet.ToList();
            }
            else
            {
                MessageBox.Show("Выберите пациента из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPacient winaddpa = new WindowAddPacient();
            winaddpa.ShowDialog();
            LvPacient.ItemsSource = AppData.bd_gold.Pet.ToList();
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
