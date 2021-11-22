using System;
using System.Collections.Generic;
using System.Text;

namespace StatePatternGumballMachine
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TrunkCrank();
        void Dispense();
    }
}
