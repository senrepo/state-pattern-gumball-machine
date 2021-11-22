using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternGumballMachine
{
    public class SoldOutState : IState
    {
        StatePatternGumballMachine gumballMachine;

        public SoldOutState(StatePatternGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("All are sold out, you can't insert a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject because you haven't inserted a quarter yet");
        }

        public void TrunkCrank()
        {
            Console.WriteLine("You turned, but there is no Gumballs");
        }
        public void Dispense()
        {
            Console.WriteLine("No Gumball dispensed");
        }

    }
}
