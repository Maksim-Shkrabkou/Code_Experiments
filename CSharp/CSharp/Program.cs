using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Experiments.Reflection();
        }
    }

    public class Experiments
    {
        public static void Reflection()
        {
            var reflection = typeof(Experiments);
            Console.WriteLine();
        }
    }
}