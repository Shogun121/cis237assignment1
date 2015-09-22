//switch statements https://msdn.microsoft.com/en-us/library/06tc147t.aspx
//user input http://stackoverflow.com/questions/7280591/read-user-input-from-console
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //backing fields
        private int userInputKey;   //key used to store user input
        private bool exitButton = false;    //bool used to determine
        private bool fileRead = false;      //determines if file has already been read.
        CSVProcessor csvProcessor = new CSVProcessor();


        //Constructor

        //Properties

        //Methods
        public void Choices()
        {
            while (!exitButton)
            {
                userInputKey = (int)Console.Read();
                switch (userInputKey)
                {
                    case 1:
                        Option1();
                        break;
                    case 2:
                        //Option2();
                        break;
                    case 3:
                        //UserInterface.Option3();
                        break;
                    case 4:
                        //UserInterface.Option4();
                        break;
                    case 5:
                        Option5();
                        break;
                    //default:
                    //    Console.WriteLine("Enter a number between "+
                    //                      "1 and 5");
                    //    break;                
                }
            }
        }
        public void MenuOptions()
        {
            Console.WriteLine("Enter the number of the function you wish" +
                                  "to be performed");
            Console.WriteLine("1).....Load Wine List"); //future idea to store lines
            Console.WriteLine("2).....Print Wine List");//in an array and loop onto
            Console.WriteLine("3).....Search for Wine Item");//screen to facilitate
            Console.WriteLine("4).....Add a new item to Wine List");//edits to display.
            Console.WriteLine("5).....Exit");
        }
        public void Option1()
        {
                if(!fileRead)
                {
                    CSVProcessor csvProcessor = new CSVProcessor();
                    Console.WriteLine("Hello");

                }
                else
                {
                    Console.WriteLine("The file has already been loaded.");
                }
        }
        public void Option5()   //exits program.
        {
            exitButton = true;
        }
        public void Option2()   //prints a list of the wine items in the array.
        {
            //WineItemCollection WineitemCollection = new WineItemCollection(string[] WineArray);
            //WineItemCollection.PrintWineItems();
        }
        public void Option3()   //search for an item using the Id in the array.
        {                       //Return the item if found, error message if not.

        }
    } 
}
