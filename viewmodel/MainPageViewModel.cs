using Pos_Client.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Client.viewmodel
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            MenuCollectionList menuList = new MenuCollectionList();

            menuList.Add(new Menu("우동"));
            menuList.Add(new Menu("돈까스"));
            menuList.Add(new Menu("덮밥"));
            menuList.Add(new Menu("사이드"));
            menuList.Add(new Menu("주류"));

            MenuList = menuList;
        }


        public MenuCollectionList MenuList { get; set; }

    }
}

