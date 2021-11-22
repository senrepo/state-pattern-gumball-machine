using System;

namespace StatePatternGumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            StatePatternGumballMachine gumballMachine = new StatePatternGumballMachine(3);

            Console.WriteLine("Test#1");
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("Test#2");
            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("Test#3");
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine("Test#4");
            gumballMachine.InsertQuarter();

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();



            /*  Busienss Change Request 1: 
             *      a) We think that by turning the gumball buying into a game, we can significantly increase our sales.
             *      b) We are going to put the stickers on every machine "Be a winner one in 10% of the people, get a FREE Gumball"
             *  
             */


        }
    }
}
