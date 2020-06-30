using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Worksheet_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part 1 - Listy Lists

             List<int> ListyList = new List<int>();

             int[] array = { 15, 16, 17, 18, 19 };



            //Part 2 - Listy Processing

            ListyList.Add(4);
            ListyList.Add(15);

            ListyList.InsertRange(1, array);

            //list<int> array2 = array.tolist();
            //foreach (int value in array2)
            //{
            //    listylist.insert(1, value);
            //}

            ListyList.Remove(15);

            foreach (int value in ListyList)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(" ");

            ListyList.Count();

            //Part 4 - I lied, this is Suffering

            Dictionary<String, FillableFood> Calories = new Dictionary<string, FillableFood>();

            FillableFood chickenTaquito = new FillableFood { filling = FillingType.Chicken, calories = 150, wrapped = true };

            Calories.Add("Taquito", chickenTaquito);


            FillableFood beefEmpanadas = new FillableFood { filling = FillingType.Beef, calories = 200, wrapped = true };

            Calories.Add("Empanadas", beefEmpanadas);


            FillableFood porkChurros = new FillableFood { filling = FillingType.Pork, calories = 220, wrapped = true };

            Calories.Add("Churros", porkChurros);


            FillableFood vealBurritos = new FillableFood { filling = FillingType.Veal, calories = 120, wrapped = true };

            Calories.Add("Burritos", vealBurritos);


            FillableFood hamSushi = new FillableFood { filling = FillingType.Ham, calories = 154, wrapped = true };

            Calories.Add("Sushi", hamSushi);


            FillableFood muttonFruitByTheFoot = new FillableFood { filling = FillingType.Mutton, calories = 8, wrapped = true };

            Calories.Add("Fruit By The Foot", muttonFruitByTheFoot);

            //Part 5 - I originally wasn't going to add this part but :)

            foreach (KeyValuePair<string, FillableFood> food in Calories)
            {
                switch(food.Value.filling)
                {
                    case FillingType.Chicken:
                    Console.WriteLine("Chicken Taquitos tastes amazing!");
                    break;

                    case FillingType.Beef:
                        Console.WriteLine("Beef Empanadas tastes pretty good!");
                        break;

                    case FillingType.Pork:
                        Console.WriteLine("Pork Churros taste awful!");
                        break;

                    case FillingType.Veal:
                        Console.WriteLine("Those are baby cows ya know...");
                        break;

                    case FillingType.Ham:
                        Console.WriteLine("Ham Sushi is certainly interesting...");
                        break;

                    case FillingType.Mutton:
                        Console.WriteLine("Mutton Fruit By The Foot huh? What's wrong with you?!");
                        break;
                }
            }


        }
        //Part 3 - Suffering

        public enum FillingType { Chicken, Beef, Pork, Veal, Ham, Mutton }

        public struct FillableFood
        {
            public FillingType filling;
            public int calories;
            public bool wrapped;
        }
    }
}
