using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderonline
{
    class TakeOrder
    {
        int orderedItemId;
        List<Item> Menu = new List<Item>
            {
        new Item { Id = 01, Name = "Idly", Price = 20},
        new Item { Id = 02, Name = "Dosa",  Price= 30},
        new Item { Id = 03, Name = "Parata", Price = 35},
        new Item { Id = 04, Name = "Chapathi", Price = 40 }
            };
        public int PlaceOrder()
        {
            foreach (Item item in Menu)
            {
                Console.WriteLine(item.Id + "  " + item.Name + "  " + item.Price);
            }
            Console.WriteLine("Please select the item from the menu");
            orderedItemId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(orderedItemId);
            Console.WriteLine("Please enter the quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(quantity);
            int cost = Menu[orderedItemId - 1].Price * quantity;
            Console.WriteLine("The amount to be paid is " + cost);
            Console.WriteLine("Do you wish to order more? If yes press 1, if no press 2");
            int continuePermission = Convert.ToInt32(Console.ReadLine());
            return continuePermission;
        }


    }
}
