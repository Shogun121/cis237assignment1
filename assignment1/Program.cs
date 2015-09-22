//https://msdn.microsoft.com/en-us/library/aa288453(v=vs.71).aspx resource
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            CSVProcessor csvProcessor = new CSVProcessor();
            //WineItemCollection WineitemCollection = new WineItemCollection(CSVProcessor(string[400] WineArray));


            userInterface.MenuOptions();    //Displays user options
            userInterface.Choices();        //Allows user to select an option
        }
    }
}
