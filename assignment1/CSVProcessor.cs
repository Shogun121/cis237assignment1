using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        //backing fields
        StreamReader inputFile = File.OpenText("WineList");
        //private bool fileRead = false;  //used to determine if the file has been read.
        private int counter;            //used to count items in the array.
        private string itemRead;        //used to store file read segment.
        string[] WineList = new string[400];

        //Methods
        public void ReadFile()
        {
            while (!inputFile.EndOfStream)
            {
                itemRead = inputFile.ReadLine();
                WineList[counter] = itemRead;
                counter++;
            }
        }

    }
}
