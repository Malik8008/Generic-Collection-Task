using System;
using System.Collections;

namespace Generic_Collection_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sortlist = new SortedList();

            sortlist.Add(1995, "PHP");
            sortlist.Add(1966, "JOSS");
            sortlist.Add(1978, "SQL");
            sortlist.Add(1970, "PASCAL");
            sortlist.Add(1980, "C++");

            foreach (DictionaryEntry collec in sortlist)
            {
                Console.WriteLine(collec.Key +" "+ collec.Value);
            }



        }
    }
}
