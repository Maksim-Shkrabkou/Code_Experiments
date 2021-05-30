using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var experiments = new Experiments("Maksim");
            Experiments.Reflection();
            experiments.Name = "Anya";
        }
    }

    public class Experiments
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Experiments(string name)
        {
            _name = name;
        }

        public static void Reflection()
        {
            var reflection = typeof(Experiments);
            var reflectionMemberTypes = reflection.MemberType;
        }
    }
}