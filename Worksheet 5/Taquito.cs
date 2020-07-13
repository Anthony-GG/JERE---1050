using System;
using System.Collections.Generic;
using System.Text;

namespace Worksheet_5
{
    class Taquito : Food
    {
        //Part 2 - T
        public Taquito(int tCalories, List<string> tToppings) : base (1)
        {
            calories = tCalories;
            toppings = tToppings;
        }


        public override int FoodRating()
        {
            return toppings.Count * calories;
        }
       
    }
}
