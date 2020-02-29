using System;

namespace CSharp_Buch_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name = "Peter";
            peter.Alter = 34;

            peter.Laufen();


            Console.WriteLine(peter.Name);
            Console.ReadKey();
        }
    }


}
