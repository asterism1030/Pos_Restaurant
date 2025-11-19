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

namespace Pos_Client.etc.usercontrol
{
    public partial class MenuButton : UserControl
    {
        // TODO) 이미지 추가
        // private img Img = null;

        private int amount = 0;
        public int Amount { get; protected set; }

        public string Menu_Name = "";

        public MenuButton(string menuName)
        {
            InitializeComponent();

            menu_name.Text = menuName;
            Menu_Name = menuName;
        }


    }
}
