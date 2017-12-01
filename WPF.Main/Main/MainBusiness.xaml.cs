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
using WPF.Themes;

namespace WPF.Main.Main
{
    /// <summary>
    /// Interaction logic for MainBusiness.xaml
    /// </summary>
    public partial class MainBusiness : Window
    {
        public MainBusiness()
        {
            InitializeComponent();
            CBthemes.ItemsSource = ThemeManager.GetThemes();
        }
        private void CBthemes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                string theme = e.AddedItems[0].ToString();

                // Window Level
               this.ApplyTheme(theme);

                // Application Level
                // Application.Current.ApplyTheme(theme);
            }
        }
    }
}
