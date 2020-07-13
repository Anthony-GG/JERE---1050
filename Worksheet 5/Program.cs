using System;
using System.Collections.Generic;

namespace Worksheet_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part 4 - You guys remember BrainSurge?
            List<Food> AwesomeList = new List<Food>();
            List<string> taquitoList = new List<string>();
            List<string> empanadaList = new List<string>();

            Taquito John = new Taquito(250, taquitoList);
            Empanada Arnold = new Empanada(299, empanadaList);

            John.addTopping("pepperoni");
            Arnold.addTopping("cheddar");

            AwesomeList.Add(John);
            AwesomeList.Add(Arnold);
        }
    }
}
