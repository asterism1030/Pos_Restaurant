using Pos_Client.etc.usercontrol;
using Pos_Client.model;
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

namespace Pos_Client.view
{
    /// <summary>
    /// MenuMainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuMainPage : Page
    {
        //TODO) 임시 ---> viewmodel 로 부리
        public List<MenuButton> menus = new List<MenuButton>();


        public MenuMainPage()
        {
            InitializeComponent();

            //menus.Add(new MenuButton("/esset/menu_img/udon_1.PNG", "터진콜라1", "탄산때문에 터진 콜라", 1));
            //menus.Add(new MenuButton("/esset/menu_img/udon_1.PNG", "터진콜라2", "탄산때문에 터진 콜라", 1));
            //menus.Add(new MenuButton("/esset/menu_img/udon_1.PNG", "터진콜라3", "탄산때문에 터진 콜라", 1));
            //menus.Add(new MenuButton("/esset/menu_img/udon_1.PNG", "터진콜라4", "탄산때문에 터진 콜라", 1));


            //menu_1.menu_img.Source = new BitmapImage(new Uri("/esset/menu_img/udon_1.PNG", UriKind.Relative));
            menu_1.menu_name.Text = "테스트";
        }
    }
}
