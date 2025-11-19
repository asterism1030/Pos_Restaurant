using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// <summary>
    /// MenuArray.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuArray : UserControl //, INotifyCollectionChanged
    {
        // TODO) 접근자 관련 리팩토링
        public List<MenuButton> menus = new List<MenuButton> ();

        public MenuArray()
        {
            InitializeComponent();
        }

        //public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
