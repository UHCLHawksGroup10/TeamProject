using System;

namespace team10
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to SWEN5236 - Group 10 GRE Math project. \nThis " +
                "program's purpose is to teach 6th grade math while using the GRE algorithm.");
            Console.WriteLine("\nTo start, please select one of the following math problem options: (Enter 'q' to quit)");
            Console.WriteLine("A.Multiplication \nB.Division \nC.Mixed Operations");
            for (string input; (input = Console.ReadLine().ToUpper()) != "Q";)
            {
                if (input == "A")
                {
                    Console.WriteLine("You've selected Muliplication");
                }
                else if (input == "B")
                {
                    Console.WriteLine("You've selected Division");
                }
                else if (input == "C")
                {
                    Console.WriteLine("You've selected Mixed Operations");
                }
                else
                {
                    Console.WriteLine("Please select A, B, C, or Q to quit");
                }
            }
           
        }

        Tuple<string, int, string>[] multiplicationProblems =
        {
            new Tuple<string, int, string>("6 x 5", 30, "Hard"),
            new Tuple<string, int, string>("1 x 1", 1, "Easy"),
            new Tuple<string, int, string>("2 x 2", 4, "Medium")
        };

        Tuple<string, int, string>[] divisionProblems =
        {
            new Tuple<string, int, string>("30 / 3", 10, "Hard"),
            new Tuple<string, int, string>("2 / 2", 1, "Easy"),
            new Tuple<string, int, string>("10 / 5", 2, "Medium")
        };

        Tuple<string, int, string>[] mixedProblems =
        {
            new Tuple<string, int, string>("6 x 5 / 2", 15, "Hard"),
            new Tuple<string, int, string>("3 x 1 / 1", 3, "Easy"),
            new Tuple<string, int, string>("4 x 2 / 4", 2, "Medium")
        };
        private static multiplication()
        {
            
        }
        private static division()
        {

        }
        private static mixedOperation()
        {

        }
    }
}

