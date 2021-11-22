using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternGumballMachine
{
    public class SoldState : IState
    {
        StatePatternGumballMachine gumballMachine;

        public SoldState(StatePatternGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we are in the process of giving you a quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, You already turned the crank");
        }

        public void TrunkCrank()
        {
            Console.WriteLine("Truning twice doesn't get you another Gumball");
        }

        public void Dispense()
        {
            if(this.gumballMachine.ReleaseBall())
            {
                Console.WriteLine("A Gumball comes rolling out the slot");
                this.gumballMachine.SetState(this.gumballMachine.GetBallsCount() == 0 ? this.gumballMachine.GetSoldOutState() : this.gumballMachine.GetNoQuarterState());
            }
            else
            {
                this.gumballMachine.SetState(this.gumballMachine.GetSoldOutState());
                Console.WriteLine("Oops!, Out of gumballs");
            }
        }

    }
}
