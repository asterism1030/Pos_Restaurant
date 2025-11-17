using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_Client.model
{
    public class MenuItem
    {
        public string Title { get; set; }

        public MenuItem(string title)
        {
            Title = title;
        }
    }
}
