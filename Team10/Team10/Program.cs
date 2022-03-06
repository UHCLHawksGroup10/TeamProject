using System;
using System.Collections.Generic;

namespace team10
{
    // Create a class to represent the Main menu
    class Menu
    {
        private int menuItem;
        private string menuDescription;

        public Menu(int mItem, string mDescription)
        {
            menuItem = mItem;
            menuDescription = mDescription;
        }

        public int getMenuItem() { return menuItem; }
        public string getMenuDescription() { return menuDescription; }
        public bool checkMenuItem(int mItem)
        {
            return menuItem == mItem;
        }
    }
    // Create a class to represent a Math problem
    class MathProblem
    {
        private string description;
        private double answer;
        private string solution;
        private int points;

        public MathProblem(string desc, double ans, string sol, int pts)
        {
            description = desc;
            answer = ans;
            solution = sol;
            points = pts;
        }

        public string getDescription() { return description; }
        public double getAnswer() { return answer; }
        public bool checkAnswer(double ans)
        {
            return answer == ans;
        }
        public string getSolution() { return solution; }
        public int getPoints() { return points; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // A list of Main menu options
            List<Menu> menus = new List<Menu>();
            menus.Add(new Menu(1, "Work on Math Problems"));
            menus.Add(new Menu(2, "Check my total score"));
            menus.Add(new Menu(3, "Review incorrect problems"));
            menus.Add(new Menu(4, "Useful links"));
            menus.Add(new Menu(5, "Exit"));

            // Create a list of math problems with answers and solutions
            List<MathProblem> problems = new List<MathProblem>();
            problems.Add(new MathProblem("Solve: 2 * 11", 22, "Solution: 2 * 11 = 22", 10));
            problems.Add(new MathProblem("Solve: 7 * 7", 49, "Solution: 7 * 7 = 49", 20));
            problems.Add(new MathProblem("Solve: 22 * 3", 66, "Solution: 22 * 3 = 66", 30));
            problems.Add(new MathProblem("Solve: 4 / 2", 2, "Solution: 4 / 2 = 2", 10));
            problems.Add(new MathProblem("Solve: 27 / 3", 9, "Solution: 27 / 3 = 9", 20));
            problems.Add(new MathProblem("Solve: 50 / 5", 10, "Solution: 50 / 5 = 10", 30));
            problems.Add(new MathProblem("Solve: 1 * 2 / 2", 1, "Solution: 1 * 2 = 2 / 2 = 1", 10));
            problems.Add(new MathProblem("Solve: 3 * 4 / 2", 6, "Solution: 3 * 4 = 12 / 2 = 6", 20));
            problems.Add(new MathProblem("Solve: 20 / 10 * 2", 4, "Solution: 20 / 10 = 2 * 2 = 4", 30));            

            // Show the main menu
            display_menu(menus);
            int menu_option = getMenuOption(1, 5); //between 1 and 5 because we have 5 options

            var incorrectProbs = new List<string>();
            var userScore = 0;

            if(menu_option == 1)
            {
                char problemChoice = 'y';
                while (problemChoice == 'y')
                {
                    display_problems(problems);

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
                        userScore = userScore + problems[option - 1].getPoints();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is not correct.");
                        Console.WriteLine(problems[option - 1].getSolution());
                        incorrectProbs.Add(problems[option - 1].getDescription());
                    }
                    Console.WriteLine("Would you like to continue? (Enter y/n)");
                    problemChoice = Convert.ToChar(Console.ReadLine());
                }
                display_menu(menus);
                menu_option = getMenuOption(1, 5);
            }
            if(menu_option == 2)
            {
                Console.Clear();
                Console.WriteLine("Your total score is: " + userScore);
            }
            if(menu_option == 3)
            {
                Console.Clear();
                foreach (var probs in incorrectProbs)
                {
                    Console.WriteLine("These are that problems that you missed: " + probs);
                }         
            }
            if(menu_option == 4)
            {
                Console.Clear();
                Console.WriteLine("You may visit these websites to practice more problems: ");
                Console.WriteLine("https://www.ixl.com/math/grade-6");
                Console.WriteLine("https://www.khanacademy.org/math/cc-sixth-grade-math");
                Console.WriteLine("https://www.mathgames.com/grade6");
            }
            if(menu_option == 5)
            {
                Console.WriteLine("Remember to continue practicing!");
            }
        }

        // Create a function to display the Main menu
        static void display_menu(List<Menu> menus)
        {
            Console.Clear();
            Console.WriteLine("Please select an option: ");
            // Loop through menu items and prints them
            int i = 1;
            foreach (Menu p in menus)
            {
                Console.WriteLine(i.ToString() + ") " + p.getMenuDescription());
                i += 1;
            }
        }

        // Create a function to display the Math problems
        static void display_problems(List<MathProblem> problems)
        {
            Console.Clear();
            Console.WriteLine("Please select a math problem: (Problem 1 - 3 is multiplication, Problem 4 - 6 is Division, Problem 7 - 9 is Mixed)");
            Console.WriteLine("Enter 0 to quit.");
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