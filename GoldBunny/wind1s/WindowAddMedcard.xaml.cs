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
            cmbDiagnosis.ItemsSource = AppData.bd_gold.Diagnosis.Select(i => i.NameDiagnosis).ToList();
            cmbRecipeList.ItemsSource = AppData.bd_gold.RecipeList.Select(i => i.NameRecipe).ToList();            
        }

        private void btnSaveMedcard_Click(object sender, RoutedEventArgs e)
        {
            AppData.bd_gold.Medcard.Add(new basedata.Medcard
            {
                IDMedcard = AppData.bd_gold.Medcard.Where(i => i.Diagnosis.NameDiagnosis == cmbDiagnosis.SelectedItem.ToString()).Select(i => i.IDMedcard).FirstOrDefault(),
                RecipeListID = AppData.bd_gold.Medcard.Where(i => i.RecipeList.NameRecipe == cmbRecipeList.SelectedItem.ToString()).Select(i => i.IDMedcard).FirstOrDefault(),
                StartIlness = DateTime.Parse(txtStartIlness.Text),
                EndIlness = DateTime.Parse(txtEndIlness.Text)
            });
            AppData.bd_gold.SaveChanges();
            MessageBox.Show($"Мед.карта {cmbDiagnosis} успешно добавлена!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }

        private void btnCancelMedcard_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
