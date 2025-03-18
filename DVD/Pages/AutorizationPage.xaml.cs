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
using DVD.Connection;
using System.Net.Security;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public static Sotrudnik sotrudnik;

        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void Vhodbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCapcha());
        }


        private void Regesrtxb_MouseDown(object sender, MouseButtonEventArgs e)
        {  NavigationService.Navigate(new RegisrtationPage());
            int login = Convert.ToInt32(((TextBox)sender).Text.Trim());
            string password = Parolpsw.Password.Trim();
            sotrudnik= Autorization.AuthorisationSotr (login,password);
            
            if (sotrudnik !=null)
            {
                MessageBox.Show("Ура");

            }
            else
            {
                MessageBox.Show("неверный логин или пароль", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Regesrtxb_MouseEnter(object sender, MouseEventArgs e)
        {
            Regesrtxb.Foreground = new SolidColorBrush(Colors.White);

        }

        private void Regesrtxb_MouseLeave(object sender, MouseEventArgs e)
        {
            Regesrtxb.Foreground = new SolidColorBrush(Colors.DeepPink);
        }
    }
}
