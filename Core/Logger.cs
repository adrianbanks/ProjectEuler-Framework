using System;

namespace ProjectEuler.Core
{
    public static class Logger
    {
        public static void Clear()
        {
            Console.Clear();
        }

        public static void Write(ConsoleColor colour, object obj)
        {
            Write(colour, obj.ToString());
        }

        public static void Write(ConsoleColor colour, string text, params object[] args)
        {
            Log(false, colour, text, args);
        }

        public static void WriteLine()
        {
            Console.WriteLine();
        }

        public static void WriteLine(ConsoleColor colour, object obj)
        {
            WriteLine(colour, obj.ToString());
        }

        public static void WriteLine(ConsoleColor colour, string text, params object[] args)
        {
            Log(true, colour, text, args);
        }

        private static void Log(bool newLine, ConsoleColor colour, string text, params object[] args)
        {
            if (args != null && args.Length > 0)
            {
                text = string.Format(text, args);
            }

            ConsoleColor originalColour = Console.ForegroundColor;
            Console.ForegroundColor = colour;

            if (newLine)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.Write(text);
            }

            Console.ForegroundColor = originalColour;
        }
    }
}
