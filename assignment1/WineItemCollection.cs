using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        //backing field
        string[] wineItems = new string[400];
        int count;

        //Constructor
        public WineItemCollection(string[] WineArray)
        {
            WineArray = wineItems;
        }
        //Methods
        public void PrintWineItems()
        {
            while (count < wineItems.Length)
            {
                Console.WriteLine(wineItems[count]);
                count++;
            }
        }

    }
}
