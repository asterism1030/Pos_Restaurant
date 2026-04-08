using Pos_Client.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Client.viewmodel
{
    public class MenuButtonViewModel : INotifyPropertyChanged
    {
        public MenuButtonViewModel() { }

        public MenuButtonViewModel(MenuButtonItem menuButtonItem)
        {
            this.menuButtonItem = menuButtonItem;

            imgUri = menuButtonItem.imgUri;
            name = menuButtonItem.name;
            info = menuButtonItem.info;
            //quantity = menuButtonItem.Quantity;
        }

        // TODO) 접근 제어자 private 로 변경시 binding 여부 확인
        public MenuButtonItem menuButtonItem;

        public string imgUri = "/asset/menu_img/tmp.PNG";
        public string name = "메뉴명";
        public string info = "설명";
        //public int quantity = 0;


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
