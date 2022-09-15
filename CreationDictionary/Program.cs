using System;

namespace CreationDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryClass<int, string> numberPlateCity = new DictionaryClass<int, string>();
            numberPlateCity.Add(1,"Adana");
            numberPlateCity.ShowList(); //MyDictionary completed....
        }
    }
}
