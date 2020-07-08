using System;
using System.Collections.Generic;

namespace Worksheet_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part 1 - :sunglasses:

            //List<string> depression = new List<string>();

            //Taquito tacky = new Taquito(274, depression);

            //tacky.addTopping("beans");

            //tacky.addTopping("apples");

            //tacky.addTopping("blood of the innocent");

            //tacky.addTopping("sleep");

            //tacky.printToppings();

            ////Part 2 - Clalories
            //tacky.GetCalories();

            ////Part 3 - Loop-de-loops

            List<Taquito> sadness = new List<Taquito>();
            for (int i = 0; i > 10; i++)
            {
                List<string> argh = new List<string>();
                Taquito tacky2 = new Taquito(i * 10, argh);
                sadness.Add(tacky2);
            }
            


        }
    }
}


