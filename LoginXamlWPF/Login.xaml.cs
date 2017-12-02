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
using WPF.ClassLibrary.Models;
using WPF.Themes;
using WPF.Main.Main;

namespace LoginXamlWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            themes.ItemsSource = ThemeManager.GetThemes();
        }
        private void themes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string theme = e.AddedItems[0].ToString();

                // Window Level
                // this.ApplyTheme(theme);

                // Application Level
                // Application.Current.ApplyTheme(theme);
            }
        }

        private void StartAuthentication_Click(object sender, RoutedEventArgs e)
        {
            UserModel user = new UserModel();
            user.NameUser = TxtUser.Text;
            user.Password = TxtPassword.Text;
            LoginLayer.Visibility = Authentication.Authenticate(user) ? Visibility.Visible : Visibility.Collapsed;
            //var win = new MainBusiness();
            //win.Show();
           
            

        }
    }
}
