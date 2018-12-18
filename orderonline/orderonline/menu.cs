using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderonline
{
    class Menu
    {
        public string ItemName;
        public int ItemNo;
        public int ItemCost;
        public List<Menu> Items = new List<Menu>
        {
        new Menu { ItemNo = 01, ItemName = "Idli", ItemCost = 20},
        new Menu { ItemNo = 02, ItemName = "Dosa", ItemCost = 30},
        new Menu { ItemNo = 03, ItemName = "Parata", ItemCost = 35},
        new Menu { ItemNo = 04, ItemName = "Chapathi", ItemCost = 40 },
        };

    }
    
}

