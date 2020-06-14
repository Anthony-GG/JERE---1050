using System;

namespace Worksheet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1

            int taquitoCount = 15;

            Console.WriteLine("How many Empanadas are there?");
            int empanadaCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("There are 15 Taquitos in total!");
            Console.WriteLine ("There are " + empanadaCount +" Empanadas in total!");

            Console.WriteLine(" ");

            Console.WriteLine("How many Taquitos and Empanadas would you like to eat? ex #,#");
            var foods = Console.ReadLine();
            var amount = foods.Split(',');
            int taquitosLiked = int.Parse(amount[0]);
            int empanadasLiked = int.Parse(amount[1]);

            Console.WriteLine(" ");

            Console.WriteLine("I would like to eat {0} taquitos!",taquitosLiked);
            Console.WriteLine("I would like to eat {0} empanadas!",empanadasLiked);


            bool checkFood(int taquito, int empanada)
            {
                if (taquito > 0 && empanada > 0)
                {
                    return true;
                }

                return false;
            }
            checkFood(taquitoCount, empanadaCount);


            //Part 2

            Console.WriteLine(" ");

            Console.WriteLine("Press Enter to Eat! :)");

            Console.ReadKey();

            for (int i = 0; i < taquitosLiked; i++)
            {
                if (checkFood(taquitoCount, 15))
                {
                    taquitoCount--;
                    Console.WriteLine(" ");
                }

            }



            for (int j = 0; j < empanadasLiked; j++)
            {
                if (checkFood(15, empanadaCount))
                {
                    empanadaCount--;
                }
            }



            Console.WriteLine("Taquitos Left: " + taquitoCount);
            Console.WriteLine("Empanada Left: " + empanadaCount);

            //Part 3

            Console.WriteLine(" ");

            Console.WriteLine("Still hungry?");

            Console.WriteLine(" ");

            Console.WriteLine("Press Enter to Finish Those Bad Boys Off!");

            Console.ReadKey();


            void eatAll()
            {
                while(taquitoCount > 0)
                {
                    taquitoCount--;
                }

                while(empanadaCount > 0)
                {
                    empanadaCount--;
                }
            }

            eatAll();

            Console.WriteLine(" ");

            Console.WriteLine("Taquitos Left: " + taquitoCount);
            Console.WriteLine("Empanada Left: " + empanadaCount);




        }
    }
}
