using Pos_Client.etc.usercontrol;
using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace Pos_Client.model
{
    public class MenuButtonItem
    {
        public string imgUri;
        public string name;
        public string info;
        private int quantity;


        #region getter/setter
        public int Quantity {
            get {
                return quantity;
            }

            set {
                if (value < 0)
                {
                    quantity = 0;
                }
                else
                {
                    quantity = value;
                }
            }
        }

        #endregion


        public MenuButtonItem() {

        }
    }
}
