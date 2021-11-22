using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine
{
    public class GumballMachine
    {
        private static int SOLD_OUT = 0;
        private static int NO_QUARTER = 1;
        private static int HAS_QUARTER = 2;
        private static int SOLD = 3;

        private int state = SOLD_OUT;
        private int count = 0;

        public GumballMachine( int count)
        {
            this.count = count;
            if(count> 0)
                state = NO_QUARTER;
        }

        public void InsertQuarter()
        {
            if (state == SOLD_OUT)
                Console.WriteLine("All are sold out, you can't insert a quarter");
            else if(state == NO_QUARTER)
            {
                state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter");
            }
            else if (state == HAS_QUARTER)
                Console.WriteLine("A quarter is already inserted and hence you can't insert a another quarter");
            else if(state == SOLD)
                Console.WriteLine("Please wait, we are in the process of giving you a quarter");
        }

        public void EjectQuarter()
        {
            if (state == SOLD_OUT)
                Console.WriteLine("You can't eject because you haven't inserted a quarter yet");
            else if (state == NO_QUARTER)
                Console.WriteLine("You haven't inserted a quarter yet");
            else if (state == HAS_QUARTER)
            {
                state = NO_QUARTER;
                Console.WriteLine("Quarter returned");
            }
            else if (state == SOLD)
                Console.WriteLine("Sorry, You already turned the crank");
        }

        public void TurnCrank()
        {
            if (state == SOLD_OUT)
                Console.WriteLine("You turned, but there is no Gumballs");
            else if (state == NO_QUARTER)
                Console.WriteLine("You turned, but there is no Quarter");
            else if (state == HAS_QUARTER)
            {
                state = SOLD;
                Console.WriteLine("You turned");
                Dispense();
            }
            else if (state == SOLD)
                Console.WriteLine("Truning twice doesn't get you another Gumball");
        }

        public void Dispense()
        {
            if (state == SOLD_OUT)
                Console.WriteLine("No Gumball dispensed");
            else if (state == NO_QUARTER)
                Console.WriteLine("You need to pay first");
            else if (state == HAS_QUARTER)
            {
                Console.WriteLine("No Gumball dispensed");
            }
            else if (state == SOLD)
            {
                count = count - 1;
                Console.WriteLine("A Gumball comes rolling out the slot");
                state = count == 0 ? SOLD_OUT : NO_QUARTER;
            }
        }

        //other methods such as Refill and so on

    }
}
