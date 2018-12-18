using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderonline
{
    class Hotel
    {
        static void Main(string[] args)
        {

            try
            {
                int continuePermission;
                TakeOrder order = new TakeOrder();
                
                Console.WriteLine(" Welcome to Hotel Breakfast");

               // order.PlaceOrder();

                
                /*--created a Menu with list of Items--*/
                do
                {
                    continuePermission = order.PlaceOrder();

                    
                } while (continuePermission == 1);

                Console.WriteLine(" Thank you!");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
            Console.ReadLine();
        }
    }
}
