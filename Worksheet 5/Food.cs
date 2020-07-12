using System;
using System.Collections.Generic;
using System.Text;

namespace Worksheet_5
{
    public abstract class Food
    {

        public List<string> toppings { get; set; }
        public int calories { get; set; }

        protected Food(int value)
        {

            calories = value;

        }

        public void addTopping(string toppingValue)
        {
            toppings.Add(toppingValue);
        }

        public override string ToString()
        {
            return "Make it say whatever idc";
        }

        public abstract int FoodRating();


    }
}
