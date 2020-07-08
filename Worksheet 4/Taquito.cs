using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Worksheet_4
{
    class Taquito
    {
        public List<string> toppings = new List<string>();
        private int calories;

        public Taquito(int Calories, List<string> Toppings)
        {
            calories = Calories;
            toppings = Toppings;
        }

        public void addTopping(string toppingType)
        {
           toppings.Add(toppingType);
        }


        public void printToppings()
        {
            foreach (string food in toppings)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine(" ");
        }


        public int GetCalories()
        {
            return calories;   
        }



    }
}
