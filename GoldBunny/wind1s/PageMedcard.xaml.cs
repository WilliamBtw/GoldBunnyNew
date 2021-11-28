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
            var medcard = AppData.bd_gold.Medcard.Where(i => i.IDMedcard == AppData.IDMedcardSave).FirstOrDefault();
            LvMedcard.ItemsSource = bd_gold.Medcard.ToList();
        }

        private void LvMedcard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txbDiagnosis_TextChanged(object sender, TextChangedEventArgs e)
        {
            var diagg = AppData.bd_gold.Diagnosis.ToList();
            LvMedcard.ItemsSource = diagg.Where(i => i.NameDiagnosis.ToLower().Contains(txbDiagnosis.Text.ToLower()));
        }

        private void txbRecipeList_TextChanged(object sender, TextChangedEventArgs e)
        {
            var reclist = AppData.bd_gold.RecipeList.ToList();
            LvMedcard.ItemsSource = reclist.Where(i => i.NameRecipe.ToLower().Contains(txbRecipeList.Text.ToLower()));
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WindowAddMedcard winaddmed = new WindowAddMedcard();
            winaddmed.ShowDialog();
            LvMedcard.ItemsSource = AppData.bd_gold.Medcard.ToList();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var somth = AppData.bd_gold;
            if (LvMedcard.SelectedItem is Medcard medcard)
            {
                AppData.IDMedcardSave = medcard.IDMedcard;
                WindowEditMedcard winedmed = new WindowEditMedcard();
                winedmed.ShowDialog();
                LvMedcard.ItemsSource = AppData.bd_gold.Medcard.ToList();
            }
            else
            {
                MessageBox.Show("Выберите мед.карту из списка!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить мед.карту?",
               "Удаление мед.карты", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var result2 = MessageBox.Show("Точно?", "Удаление мед.карты", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result2 == MessageBoxResult.Yes)
                {
                    if (LvMedcard.SelectedItem is Medcard medcard)
                    {
                        AppData.bd_gold.Medcard.Remove(AppData.bd_gold.Medcard.Where(i => i.IDMedcard == medcard.IDMedcard).FirstOrDefault());
                        AppData.bd_gold.SaveChanges();
                        MessageBox.Show("Мед.карта успешно удалена!", "Удаление мед.карты", MessageBoxButton.OK, MessageBoxImage.Information);
                        LvMedcard.ItemsSource = AppData.bd_gold.Medcard.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Выберите мед.карту из списка!", "Удаление мед.карты", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }
    }
}
