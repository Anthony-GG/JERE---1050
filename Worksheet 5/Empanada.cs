using System;
using System.Collections.Generic;
using System.Text;

namespace Worksheet_5
{
    class Empanada : Food
    {
       //Part 3 - EEEE
        public override int FoodRating()
        {
            return 064;
        }

        public Empanada(int eCalories, List<string> eToppings) : base(2)
        {
            calories = eCalories;
            toppings = eToppings;
        }


        public void printToppings()
        {
         foreach (string value in toppings)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(" ");
        }

        int Calories;

    }
}
