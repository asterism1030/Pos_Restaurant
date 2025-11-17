using Pos_Client.model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Pos_Client.viewmodel
{
    public class MenuViewModel //: INotifyPropertyChanged
    {
        /*
        private string _newMenuTitle;
        public string NewMenuTitle
        {
            get { return _newMenuTitle; }
            set
            {
                _newMenuTitle = value;
                OnPropertyChanged(nameof(NewMenuTitle));
            }
        }
        */

        public MenuViewModel()
        {
            MenuItemCollectionList menuList = new MenuItemCollectionList();

            menuList.Add(new MenuItem("덮밥"));
            menuList.Add(new MenuItem("주류"));
            menuList.Add(new MenuItem("사이드"));

            MenuList = menuList;
        }


        public MenuItemCollectionList MenuList { get; set; }

        /*
        #region Interface
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        */
    }

}
