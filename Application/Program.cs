using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using ProjectEuler.Core;

namespace ProjectEuler
{
    internal sealed class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private static IDictionary<int, BaseProblem> problems;
        private static IDictionary<int, BaseSolution> solutions;
        private const ConsoleColor Yellow = ConsoleColor.Yellow;
        private const ConsoleColor White = ConsoleColor.White;
        private const ConsoleColor Red = ConsoleColor.Red;
        
        private enum SolutionType
        {
            C,
            F
        }
 
        internal static void Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth - 3, Console.LargestWindowHeight - 3);
            ShowWindow(GetConsoleWindow(), 3); //maximize

            ConsoleKeyInfo readKey;
            Console.WriteLine("C# or F# :>");

            do
            {
                readKey = Console.ReadKey(true);
            }
            while (readKey.Key != ConsoleKey.C && readKey.Key != ConsoleKey.F);

            SolutionType solutionType = (readKey.Key == ConsoleKey.C) ? SolutionType.C : SolutionType.F;
            LoadProblems(solutionType);

            do
            {
                Logger.Clear();
                Logger.WriteLine(Yellow, "Project Euler Solutions");
                Logger.WriteLine(Yellow, "  http://www.projecteuler.net");
                Logger.WriteLine();
                Logger.WriteLine(Yellow, "  Using {0}# solutions", solutionType);
                Logger.WriteLine();

                Logger.Write(White, "Enter problem number (l to list, c to check all): ");
                string str = Console.ReadLine();

                if (str == "l")
                {
                    ListProblems();
                }
                else if (str == "c")
                {
                    CheckSolutions();
                }
                else
                {
                    int problemNumber;
                    int.TryParse(str, out problemNumber);

                    BaseProblem problem = StartProblem(problemNumber);

                    Logger.Clear();
                    Logger.Write(Yellow, "Problem: ");
                    Logger.WriteLine(White, problem.Number);
                    Logger.WriteLine();
                    Logger.WriteLine(Yellow, "Date Set");
                    Logger.WriteLine(White, problem.DateSet.ToLongDateString());
                    Logger.WriteLine();
                    Logger.WriteLine(Yellow, "Title");
                    Logger.WriteLine(White, problem.Title);
                    Logger.WriteLine();
                    Logger.WriteLine(Yellow, "Description");
                    Logger.WriteLine(White, problem.Description);
                    Logger.WriteLine();
                    Logger.Write(Yellow, "Expected Answer: ");

                    if (problem.ExpectedAnswer != null)
                    {
                        Logger.WriteLine(White, problem.ExpectedAnswer.Value);
                    }
                    else
                    {
                        Logger.WriteLine(Red, "Unknown");
                    }

                    Logger.WriteLine();
                    TimerBlock timer = new TimerBlock();

                    BaseSolution solution;

                    if (solutions.TryGetValue(problem.Number, out solution))
                    {
                        long answer;
                    
                        using (timer.Time())
                        {
                            answer = solution.GetAnswer();
                        }

                        Logger.Write(Yellow, "Answer:          ");
                        Logger.WriteLine(White, answer);
                        Logger.WriteLine();
                        Logger.Write(Yellow, "Time Taken:      ");
                        Logger.WriteLine(White, timer.LastLap);
                    }
                    else
                    {
                        Logger.Write(Red, "No Solution Found");
                    }
                }

                Logger.WriteLine();
                Logger.WriteLine();
                Logger.WriteLine(ConsoleColor.Gray, "Press any key to continue...");
                readKey = Console.ReadKey();
            }
            while (readKey.Key != ConsoleKey.Escape);
        }

        private static void LoadProblems(SolutionType solutionType)
        {
            Assembly coreAssembly = Assembly.GetAssembly(typeof(Program));
            problems = LoadItemTypes<ProblemAttribute, BaseProblem>(coreAssembly);

            Assembly solutionAssembly = Assembly.Load(string.Format("ProjectEuler.{0}SharpSolutions", solutionType));
            solutions = LoadItemTypes<SolutionAttribute, BaseSolution>(solutionAssembly);
        }

        private static IDictionary<int, TItemType> LoadItemTypes<TAttribute, TItemType>(Assembly sourceAssembly)
            where TAttribute : Attribute
            where TItemType : IItemType
        {
            Dictionary<int, TItemType> items = new Dictionary<int, TItemType>();
            Type[] types = sourceAssembly.GetTypes();

            foreach (Type type in types)
            {
                TAttribute[] problemMarkups = (TAttribute[]) type.GetCustomAttributes(typeof(TAttribute), false);

                if (problemMarkups != null && problemMarkups.Length > 0)
                {
                    TItemType problem = (TItemType) Activator.CreateInstance(type);
                    items.Add(problem.Number, problem);
                }
            }

            return items;
        }

        private static BaseProblem StartProblem(int problemNumber)
        {
            if (problemNumber == 0)
            {
                Environment.Exit(0);
            }

            BaseProblem problem;

            if (!problems.TryGetValue(problemNumber, out problem))
            {
                throw new ApplicationException("Could not find problem number " + problemNumber);
            }

            return problem;
        }

        private static void ListProblems()
        {
            Logger.Clear();
            List<BaseProblem> probs = new List<BaseProblem>();
            probs.AddRange(problems.Values);
            probs.Sort();
            int numSolved = 0;
            int numNotSolved = 0;

            foreach (BaseProblem problem in probs)
            {
                Logger.Write(Yellow, "{0,-3} [", problem.Number);

                BaseSolution solution;
                solutions.TryGetValue(problem.Number, out solution);
                bool solved = solution != null && problem.ExpectedAnswer != null;

                if (solved)
                {
                    numSolved++;
                }
                else
                {
                    numNotSolved++;
                }

                ConsoleColor color = solved ? Yellow : Red;
                Logger.Write(color, "{0}", solved ? "+" : "-");
                Logger.Write(Yellow, "] ");
                Logger.WriteLine(White, "{0}", problem.Title);
            }

            Logger.WriteLine();
            Logger.WriteLine(ConsoleColor.White, "{0,-3} problems", numSolved + numNotSolved);
            Logger.WriteLine(ConsoleColor.White, "{0,-3} problems with a solution", numSolved);
            Logger.WriteLine(ConsoleColor.White, "{0,-3} problems without a solution", numNotSolved);
        }

        private static void CheckSolutions()
        {
            Logger.Clear();
            List<BaseProblem> probs = new List<BaseProblem>();
            probs.AddRange(problems.Values);
            probs.Sort();

            TimerBlock timer = new TimerBlock();

            foreach (BaseProblem problem in probs)
            {
                Logger.Write(Yellow, "{0,-3}: ", problem.Number);
                long? answer = null;
                BaseSolution solution;

                if (solutions.TryGetValue(problem.Number, out solution))
                {
                    using (timer.Time())
                    {
                        answer = solution.GetAnswer();
                    }
                }

                bool solved = (answer != null && answer == problem.ExpectedAnswer);
                ConsoleColor color = solved ? White : Red;
                string status = solved
                                    ? (answer == problem.ExpectedAnswer) ? "Passed" : "Failed"
                                    : "Unsolved";
                Logger.Write(color, "{0,-8}", status);

                if (answer != null)
                {
                    // only output a time if we calculated an answer
                    TimeSpan time = timer.LastLap;

                    // problems should not take longer than a minute to solve
                    color = (time > TimeSpan.FromMinutes(1.0)) ? Red : Yellow;
                    Logger.WriteLine(color, " [{0}]", time);
                }
                else
                {
                    Logger.WriteLine(color, "");
                }
            }

            Logger.WriteLine();
            Logger.Write(Yellow, "Time Taken:    ");
            Logger.WriteLine(White, timer.TotalTime);
        }
    }
}
