using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class QuantityButton : UserControl, INotifyPropertyChanged
    {
        private int val = 0;

        public int Val { 
            get
            {
                return val;
            }
            protected set   // 외부에서 값 변경 방지
            {
                val = value;
                OnPropertyChanged("quantity");
            }
        }

        public QuantityButton()
        {
            InitializeComponent();
            

            quantity.Text = val.ToString();
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (val == 0)
                return;

            val--;
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            val++;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
