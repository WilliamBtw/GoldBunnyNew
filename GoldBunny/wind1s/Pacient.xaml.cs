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
            LvPacient.ItemsSource = bd_gold.Pet.ToList();
        }
        private void lvPacient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            

        }

            private void Edit_Click(object sender, RoutedEventArgs e)
            {
            basedata.Pet petSave = new basedata.Pet();
            petSave = (basedata.Pet)LvPacient.SelectedItem;
            if (LvPacient.SelectedValue != null)
            {
                AppData.petSave.IDPet = petSave.IDPet;
                AppData.petSave.NamePet = petSave.NamePet;
                AppData.petSave.TypePetID = petSave.TypePetID;
                AppData.petSave.Birthday = petSave.Birthday;
                AppData.petSave.GenderID = petSave.GenderID;
                AppData.petSave.IDMedcard = petSave.IDMedcard;
            }
            else
            {
                MessageBox.Show("Pls select somth.\n Try Again", "Not Relesed Function", MessageBoxButton.OK);
            }
             }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
