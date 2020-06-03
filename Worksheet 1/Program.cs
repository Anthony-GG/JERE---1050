using System;
using System.Security.Cryptography.X509Certificates;

namespace Worksheet_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Part 1
            
            int taquitoCount = 15;

            Console.WriteLine("How many Empanadas are there?");
            int empanadaCount = Convert.ToInt32(Console.ReadLine());

            bool checkFood(int taquito, int empanada)
            {
                if (taquitoCount > 0 && empanada > 0)
                {
                    return true;
                }

                return false;
            }
            checkFood(taquitoCount, empanadaCount);


            //Part 2
            void eatPlate()
            {
             if(checkFood(taquitoCount, empanadaCount))
                {
                    taquitoCount--;
                    empanadaCount--;

                    Console.WriteLine("Taquitos Left: " + taquitoCount);
                    Console.WriteLine("Empanadas Left: " + empanadaCount);
                }    
            }

            eatPlate();


        }
    }
}
