using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternGumballMachine
{
    public class RandomWinnerState : IState
    {
        StatePatternGumballMachine gumballMachine;

        public RandomWinnerState(StatePatternGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            throw new NotSupportedException();
        }

        public void EjectQuarter()
        {
            throw new NotSupportedException();
        }

        public void TrunkCrank()
        {
            throw new NotSupportedException();
        }

        public void Dispense()
        {
            Console.WriteLine("You are a WINNER, You get a two gumballs for a quarter");

            for(var i=0; i<2; i++)
            {
                if (this.gumballMachine.ReleaseBall())
                    Console.WriteLine("A Gumball comes rolling out the slot");
                else
                {
                    Console.WriteLine("Oops!, Out of gumballs");
                    break;
                }
            }
            this.gumballMachine.SetState(this.gumballMachine.GetBallsCount() == 0 ? this.gumballMachine.GetSoldOutState() : this.gumballMachine.GetNoQuarterState());
        }
    }
}
