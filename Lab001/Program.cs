using System;

namespace Lab001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("reco");
        }

        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
