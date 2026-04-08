using Pos_Client.model;
using Pos_Client.viewmodel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Pos_Client.etc.usercontrol
{
    public partial class MenuButton : UserControl
    {

        #region Constructor
        public MenuButton()
        {
            InitializeComponent();
            DataContext = new MenuButtonViewModel();


            menuButtonItem = new MenuButtonItem();
        }


        public MenuButton(string imgUri, string name, string info, int quantity)
        {
            InitializeComponent();
            DataContext = new MenuButtonViewModel();

            menuButtonItem = new MenuButtonItem();

            menuButtonItem.imgUri = imgUri;
            menuButtonItem.name = name;
            menuButtonItem.info = info;
            menuButtonItem.Quantity = quantity;

            menu_img_uri.UriSource = new Uri(imgUri, UriKind.Relative);
            menu_name.Text = name;
            menu_info.Text = info;

            // 0 이하인 경우 0 출력
            if (quantity < 0)
            {
                menuButtonItem.Quantity = 0;
                quantity_btn.quantity.Text = quantity.ToString();
            }
        }


        public MenuButton(MenuButtonItem menuButtonItem)
        {
            InitializeComponent();
            DataContext = new MenuButtonViewModel();

            this.menuButtonItem = menuButtonItem;

            menu_img_uri.UriSource = new Uri(menuButtonItem.imgUri, UriKind.Relative);
            menu_name.Text = menuButtonItem.name;
            menu_info.Text = menuButtonItem.info;

            // 0 이하인 경우 0 출력
            if (menuButtonItem.Quantity < 0)
            {
                menuButtonItem.Quantity = 0;
                quantity_btn.quantity.Text = menuButtonItem.Quantity.ToString();
            }
        }
        #endregion


        private void menu_img_Click(object sender, RoutedEventArgs e)
        {
            menuButtonItem.Quantity += 1;
        }


        public MenuButtonItem menuButtonItem { get; set; }
    }
}
