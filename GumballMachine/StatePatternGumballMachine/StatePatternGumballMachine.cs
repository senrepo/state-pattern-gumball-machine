using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternGumballMachine
{
    public class StatePatternGumballMachine
    {
        private IState soldOutState;
        private IState noQuarterState;
        private IState hasQuarterState;
        private IState soldState;
        private IState randomWinnerState; //change request 1
       
        private IState state;
        private int count = 0;

        public StatePatternGumballMachine(int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            randomWinnerState = new RandomWinnerState(this);

            state = soldOutState;

            this.count = count;
            if (count > 0)
                state = noQuarterState;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TrunkCrank();
            state.Dispense();
        }

        public bool ReleaseBall()
        {
            if(count > 0)
            {
                count = count - 1;
                return true;
            }
            return false;
        }

        public int GetBallsCount()
        {
            return count;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetSoldOutState()
        {
            return soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState GetSoldState()
        {
            return soldState;
        }

        //change request 1
        public IState GetRandomWinnerState()
        {
            return randomWinnerState;
        }


    }
}
