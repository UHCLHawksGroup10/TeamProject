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
            for (string input; (input = Console.ReadLine().ToUpper()) != "Q";) ;
        }        
           
        static class multiplication
        {

        } 


    }
}

