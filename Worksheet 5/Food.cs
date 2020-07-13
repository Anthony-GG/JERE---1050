using System;
using System.Collections.Generic;
using System.Text;

namespace Worksheet_5
{
    public abstract class Food
    {
        //Part 1 - I want Purple Place Cakes
        public List<string> toppings;
        public int calories;

        protected Food(int value)
        {

            calories = value;

        }

        public void addTopping(string toppingName)
        {
            toppings.Add(toppingName);
        }

        public override string ToString()
        {
            return "Make it say whatever idc";
        }

        public abstract int FoodRating();


    }
}
