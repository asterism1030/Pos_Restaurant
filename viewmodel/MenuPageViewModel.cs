using Pos_Client.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Client.viewmodel
{
    public class MenuPageViewModel
    {
        public MenuPageViewModel()
        {
            MenuItemCollectionList menuList = new MenuItemCollectionList();

            menuList.Add(new MenuItem("우동"));
            menuList.Add(new MenuItem("돈까스"));
            menuList.Add(new MenuItem("덮밥"));
            menuList.Add(new MenuItem("사이드"));
            menuList.Add(new MenuItem("주류"));

            MenuList = menuList;
        }


        public MenuItemCollectionList MenuList { get; set; }

    }
}

