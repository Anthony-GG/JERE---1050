using System;

namespace Worksheet_7
{
    class Program
    {
        //3 There is a condo in Manhattan
        static void Main(string[] args)
        {
            Time Clock = new Time();
            Clock.SetTime(42, 69);
            Clock.SetTime(4, 20);

            Person Bamble_Hampton = new Person();
            Bamble_Hampton.SetName("Bamble_Hampton");

            Console.WriteLine(Bamble_Hampton.Name);
        }
    }
}
