using Pos_Client.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Pos_Client.viewmodel
{
    public class MenuPageUdonViewModel : INotifyPropertyChanged
    {
        


        public MenuPageUdonViewModel()
        {

        }


        // string imgUri, string name, string info, int quantity

        private MenuButtonItem menuButtonItme1 = new MenuButtonItem("/asset/menu_img/tmp.PNG", "일반 우동", "기본 메뉴", 0);
        public MenuButtonItem MenuButtonItme1 { get; set; }

        private MenuButtonItem menuButtonItme2 = new MenuButtonItem("/asset/menu_img/tmp.PNG", "일반 우동", "기본 메뉴", 0);
        public MenuButtonItem MenuButtonItme2 { get; set; }

        private MenuButtonItem menuButtonItme3 = new MenuButtonItem("/asset/menu_img/tmp.PNG", "일반 우동", "기본 메뉴", 0);
        public MenuButtonItem MenuButtonItme3 { get; set; }

        private MenuButtonItem menuButtonItme4 = new MenuButtonItem("/asset/menu_img/tmp.PNG", "일반 우동", "기본 메뉴", 0);
        public MenuButtonItem MenuButtonItme4 { get; set; }

        private MenuButtonItem menuButtonItme5 = new MenuButtonItem("/asset/menu_img/tmp.PNG", "일반 우동", "기본 메뉴", 0);
        public MenuButtonItem MenuButtonItme5 { get; set; }

        private MenuButtonItem menuButtonItme6 = new MenuButtonItem("/asset/menu_img/tmp.PNG", "일반 우동", "기본 메뉴", 0);
        public MenuButtonItem MenuButtonItme6 { get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
