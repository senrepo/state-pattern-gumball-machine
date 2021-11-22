using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternGumballMachine
{
    public class HasQuarterState : IState
    {
        StatePatternGumballMachine gumballMachine;
        Random randomWinner = new Random();

        public HasQuarterState(StatePatternGumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("A quarter is already inserted and hence you can't insert a another quarter");
        }

        public void EjectQuarter()
        {
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
            Console.WriteLine("Quarter returned");
        }

        public void TrunkCrank()
        {
            //change request 1
            int winner = randomWinner.Next(1,10);
            if(winner == 5 && gumballMachine.GetBallsCount()> 1)
                gumballMachine.SetState(gumballMachine.GetRandomWinnerState());
            else
                gumballMachine.SetState(gumballMachine.GetSoldState());
            
            Console.WriteLine("You turned");
        }

        public void Dispense()
        {
            Console.WriteLine("No Gumball dispensed");
        }

    }
}
