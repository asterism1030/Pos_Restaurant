using Pos_Client.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Pos_Client.etc.usercontrol
{
    public partial class MenuButton : UserControl
    {
        
        public MenuButton()
        {
            InitializeComponent();

            menuButtonItem = new MenuButtonItem();
        }

        public MenuButton(string imgUri, string name, string info, int quantity)
        {
            InitializeComponent();

            menuButtonItem = new MenuButtonItem();

            menuButtonItem.imgUri = imgUri;
            menuButtonItem.name = name;
            menuButtonItem.info = info;
            menuButtonItem.Quantity = quantity;

            //menu_img.Source = new BitmapImage(new Uri(imgUri, UriKind.RelativeOrAbsolute));
            menu_name.Text = name;
            menu_info.Text = info;

            if (quantity < 0)
            {
                quantity_btn.quantity.Text = quantity.ToString();
            }
        }


        private void menu_img_Click(object sender, RoutedEventArgs e)
        {
            menuButtonItem.Quantity += 1;
        }


        public MenuButtonItem menuButtonItem { get; set; }
    }
}
