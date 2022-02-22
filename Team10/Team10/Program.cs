using System;
using System.Collections.Generic;

namespace team10
{

    // Create a class to represent a Math problem
    class MathProblem
    {
        private string description;
        private double answer;
        private string solution;

        public MathProblem(string desc, double ans, string sol)
        {
            description = desc;
            answer = ans;
            solution = sol;
        }

        public string getDescription() { return description; }
        public double getAnswer() { return answer; }
        public bool checkAnswer(double ans)
        {
            return answer == ans;
        }
        public string getSolution() { return solution; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of math problems with answers and solutions
            List<MathProblem> problems = new List<MathProblem>();
            problems.Add(new MathProblem("Solve: 2 * 11", 22, "Solution: 2 * 11 = 22"));
            problems.Add(new MathProblem("Solve: 7 * 7", 49, "Solution: 7 * 7 = 49"));
            problems.Add(new MathProblem("Solve: 22 * 3", 66, "Solution: 22 * 3 = 66"));
            problems.Add(new MathProblem("Solve: 50 / 5", 10, "Solution: 50 / 5 = 10"));
            problems.Add(new MathProblem("Solve: 27 / 3", 9, "Solution: 27 / 3 = 9"));
            problems.Add(new MathProblem("Solve: 4 / 2", 2, "Solution: 4 / 2 = 2"));
            problems.Add(new MathProblem("Solve: 3 * 4 / 2", 6, "Solution: 3 * 4 = 12 / 2 = 6"));
            problems.Add(new MathProblem("Solve: 20 / 10 * 2", 4, "Solution: 20 / 10 = 2 * 2 = 4"));
            problems.Add(new MathProblem("Solve: 1 * 2 / 2", 1, "Solution: 1 * 2 = 2 / 2 = 1"));


            display_menu(problems);

            // Get option from user
            int option = getMenuOption(1, 9); // between 1 and 9 because we have 9 problems

            // Display problem again:
            Console.WriteLine(problems[option - 1].getDescription());
            Console.Write("Answer = ");
            // Now, ask for answer
            double answer = Convert.ToDouble(Console.ReadLine());

            // Check if it is correct
            bool correct = problems[option - 1].checkAnswer(answer);
            if (correct)
            {
                Console.WriteLine("That is correct!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not correct.");
                Console.WriteLine(problems[option - 1].getSolution());
            }

            Console.Read();
        }


        // Create a function to display the Math problems (Menu)
        static void display_menu(List<MathProblem> problems)
        {

            Console.WriteLine("Please select a math problem: (Problem 1 - 3 is multiplication, Problem 4 - 6 is Division, Problem 7 - 9 is Mixed)");
            // Loop through problems and prints them
            int i = 1;
            foreach (MathProblem p in problems)
            {
                Console.WriteLine(i.ToString() + ") " + p.getDescription());
                i += 1;
            }
        }

        // Create a function that requests the user enter an a valid option
        static int getMenuOption(int lower, int upper)
        {
            int option;

            // Create a while-loop that will keep requesting user for an option until s/he enters a valid option
            while (true)
            {
                Console.Write("Enter option: ");
                option = Convert.ToInt32(Console.ReadLine());
                if (option >= lower && option <= upper)
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option between " + lower.ToString() + " and " + upper.ToString() + ".");
                }
            }
        }
    }
}