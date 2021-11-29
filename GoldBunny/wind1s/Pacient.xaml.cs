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
            var client = AppData.bd_gold.Client.Where(i => i.IDClient == AppData.IDClientSave).FirstOrDefault();
            LvClient.ItemsSource = bd_gold.Client.ToList();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить клиента?",
                "Удаление клиента", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var result2 = MessageBox.Show("Точно?", "Удаление клиента", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result2 == MessageBoxResult.Yes)
                {
                    if (LvClient.SelectedItem is Client client)
                    {
                        AppData.bd_gold.Client.Remove(AppData.bd_gold.Client.Where(i => i.IDClient == client.IDClient).FirstOrDefault());
                        AppData.bd_gold.SaveChanges();
                        MessageBox.Show("Клиент успешно удалён!", "Удаление клиента", MessageBoxButton.OK, MessageBoxImage.Information);
                        LvClient.ItemsSource = AppData.bd_gold.Client.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Выберите клиента из списка!", "Удаление клиента", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var somth = AppData.bd_gold;
            if (LvClient.SelectedItem is Client client)
            {
                AppData.IDClientSave = client.IDClient;
                WindowEditPacient winPc = new WindowEditPacient(); 
                winPc.ShowDialog();
                LvClient.ItemsSource = AppData.bd_gold.Client.ToList();
            }
            else
            {
                MessageBox.Show("Выберите клиента из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WindowAddPacient winaddpa = new WindowAddPacient();
            winaddpa.ShowDialog();
            LvClient.ItemsSource = AppData.bd_gold.Client.ToList();
        }

        private void txbPetName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var nmPt = AppData.bd_gold.Client.ToList();
            LvClient.ItemsSource = nmPt.Where(i => i.FirstName.ToLower().Contains(txbPetName.Text.ToLower()));
        }

        private void txbTypePet_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tpPt = AppData.bd_gold.Client.ToList();
            LvClient.ItemsSource = tpPt.Where(i => i.LastName.ToLower().Contains(txbTypePet.Text.ToLower()));
        }

        private void txbGender_TextChanged(object sender, TextChangedEventArgs e)
        {
            var gndr = AppData.bd_gold.Client.ToList();
            LvClient.ItemsSource = gndr.Where(i => i.Patronymic.ToLower().Contains(txbGender.Text.ToLower()));
        }

        private void LvClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
