using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Pos_Client.view
{
    /// <summary>
    /// AdPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AdPage : Page
    {
        public AdPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/view/MenuPage.xaml", UriKind.Relative));
        }
    }
}
