using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 90,
                Depth = 34,
                Stories = 29
            };

            Building Bank = new Building("100 Main Street")
            {
                Width = 142,
                Depth = 33,
                Stories = 4
            };

            Building Kroger = new Building("702 Food Way")
            {
                Width = 29,
                Depth = 331,
                Stories = 2
            };

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Happy Gilmore");

            Bank.Construct();
            Bank.Purchase("Bill Nye");

            Kroger.Construct();
            Kroger.Purchase("Bob Ross");

            FiveOneTwoEigth.Display();
            Bank.Display();
            Kroger.Display();
        }
    }
}
