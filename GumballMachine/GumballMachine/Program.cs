using System;

namespace GumballMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            GumballMachine gumballMachine = new GumballMachine(3);

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


            /*  Busienss Change Request: 
             *      a) We think that by turning the gumball buying into a game, we can significantly increase our sales.
             *      b) We are going to put the stickers on every machine "Be a winner on in Ten, get a FREE Gumball"
             *  
             * By implementing this change request is not easy with the existing implememntion. 
             * Also the change will affect many methods and logic look very messy.
             * 
             * There is no open closed priciple followed, Not encapsulated anything that varies here. Further additions are likely to cause bugs in working code.
             */

        }
    }
}
