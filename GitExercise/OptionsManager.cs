using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "pow - Power",
            "log - Logarithm",
            "fact - Factoriel"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }

        public static void Log(double a, double b)
        {
            Console.WriteLine($"Log of {a}. Base: {b} = {Math.Log(a, b)}");
        }

        public static void Fact(double a, double b)
        {
            long aFact = CalckFact((int) a),
                bFact = CalckFact((int) b);
            
            Console.WriteLine($"{a}! + {b}! = {aFact} + {bFact}");
        }

        private static long CalckFact(int sub)
        {
            long res = 0;
            for (int i = sub - 1; i >= 1; i--)
                res *= i;

            return res;
        }
    }
}
