using Pos_Client.etc.usercontrol;
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

            menus.Add(new MenuButton("터진콜라"));
            menus.Add(new MenuButton("웃긴콜라"));
            menus.Add(new MenuButton("바보콜라"));
            menus.Add(new MenuButton("시간 넘치는 콜라"));
            menus.Add(new MenuButton("한가한 콜라"));

            //menu_list.ItemsSource = menus;
            //menu_array
        }
    }
}
