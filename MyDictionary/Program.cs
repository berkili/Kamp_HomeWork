using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Alper");
            myDictionary.Add(2, "Oğuzhan");
            myDictionary.Add(3, "Faruk");
            myDictionary.Add(4, "Erkin");
            myDictionary.Add(5, "Berkay");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
