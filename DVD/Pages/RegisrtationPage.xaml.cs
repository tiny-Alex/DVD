using DVD.Functions;
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
using DVD.Functions;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegisrtationPage.xaml
    /// </summary>
    public partial class RegisrtationPage : Page
    {
        public RegisrtationPage()
        {
            InitializeComponent();
        }

        private void RegesrtRegbtn_Click(object sender, RoutedEventArgs e)
        {
            string fio = tbFIO.Text.Trim();
            string fio = tbFIO.Text.Trim();
            if(tbFIO != null && tbPass != null)
            {
                ClassAutorization.RegistrationSotr(fio, phone, pass);
                System.Windows.MessageBox.Show("регистрация прошла ");
                NavigationService.Navigate(new AutorizationPage());
            }
            else
            {
                MessageBox.Show("Укажите фио и пароль нормис");
            }
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AutorizationPage());
        }
    }
}
