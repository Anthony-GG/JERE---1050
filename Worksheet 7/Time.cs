using System;
using System.Collections.Generic;
using System.Text;

namespace Worksheet_7
{
    class Time
    {

        //2 It was That's What I Like

        private int _hour;
        private int _minute;


        public int Hour
        {
            get => _hour;
            set
            {
                if (Hour > 0 && Hour <= 24)
                {
                    _hour = Hour;
                }
            }

        }
        public int Minute
        {
            get => _minute;
            set
            {
                if (Minute > 0 && Minute <= 60)
                {
                    _minute = Minute;
                }
            }
        }



       public void SetTime(int input, int input2)
        {
            Hour = input;
            Minute = input2;
        }

    }
