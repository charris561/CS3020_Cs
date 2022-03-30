using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsMyDude
{
    public class Chef
    {

        public string name;

        public void OnOrderReceived(object sender, KitchenEventArgs e)
        {

            foreach (var item in e.OrderItems)
            {
                if (name.Equals("Idiot Sandwich") && item.Contains("Soup"))
                {
                    Console.WriteLine($"Chef {name} qietly curses, then makes {item}.");
                }
                else 
                {
                    Console.WriteLine($"Chef {name} quietly curses, then makes {item}");
                }
            }

        }

    }
}