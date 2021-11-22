using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternGumballMachine
{
    public class NoQuarterState : IState
    {
        StatePatternGumballMachine gumballMachine;

        public NoQuarterState(StatePatternGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
            Console.WriteLine("You inserted a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted any quarter");
        }

        public void TrunkCrank()
        {
            Console.WriteLine("You turned, but there is no Quarter");
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

    }
}
