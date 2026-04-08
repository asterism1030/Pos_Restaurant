using Pos_Client.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Pos_Client.viewmodel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string uri_udon = "/view/MenuPageUdon.xaml";

        public MainPageViewModel()
        {
            MenuCollectionList menuList = new MenuCollectionList();

            // TODO) ViewModel 로 이동하거나 (미리보기 화면을 위한) 구조 변경..?
            menuList.Add(new MenuClassification("우동"));
            menuList.Add(new MenuClassification("돈까스"));
            menuList.Add(new MenuClassification("덮밥"));
            menuList.Add(new MenuClassification("사이드"));
            menuList.Add(new MenuClassification("주류"));

            MenuList = menuList;
        }


        public void Navigate()
        {
            
            switch (SelectedListBoxIndex)
            {
                case -1:
                    MenuPageUri = "/view/MenuMainPage.xaml";
                    break;
                case 0:
                    MenuPageUri = "/view/MenuPageUdon.xaml";
                    break;
            }

        }


        public MenuCollectionList MenuList { get; set; }


        private int _selectedListBoxIndex = -1;
        public int SelectedListBoxIndex
        { 
            get => _selectedListBoxIndex; 
            set
            {
                _selectedListBoxIndex = value;
                OnPropertyChanged(nameof(SelectedListBoxIndex));
                Navigate();
            }
        }


        private string _menuPageUri = "/view/MenuMainPage.xaml";
        public string MenuPageUri 
        {
            get => _menuPageUri; 
            set
            {
                _menuPageUri = value;
                OnPropertyChanged(nameof(MenuPageUri));
            }
        }

       



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

