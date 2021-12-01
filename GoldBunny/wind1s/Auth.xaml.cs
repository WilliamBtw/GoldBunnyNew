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
using GoldBunny.wind1s;

namespace GoldBunny.wind1s
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            GoldBunny.basedata.GoldBunnyEntities db = new basedata.GoldBunnyEntities();
            var staffAuth = db.Staff.Where(i => i.Email == txtLog.Text && i.Password == psbPass.Password).FirstOrDefault();

            if (staffAuth != null)
            {
                AppData.staffSave = staffAuth;

                switch (staffAuth.RoleID)
                {
                    case 1:
                        {
                            ModeratorMain mM = new ModeratorMain();
                            mM.Show();
                            Application.Current.MainWindow.Close();
                            this.Close();
                            break;
                        }
                    case 2:
                        {
                            HighDoctor hD = new HighDoctor();
                            hD.Show();
                            Application.Current.MainWindow.Close();
                            this.Close();
                            break;
                        }
                    case 3:
                        {
                            HomeMain hM = new HomeMain();
                            hM.Show();
                            Application.Current.MainWindow.Close();
                            this.Close();
                            break;
                        }
                        default:
                        break;
                }    
            }
            else
            {
                MessageBox.Show("Пользователь не найден... Упс!", "Ошибка");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}