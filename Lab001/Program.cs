using System;

namespace Lab001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayEngHello("reco");
            SayChnHello("reco");
        }

        public static void SayChnHello(string name)
        {
            Console.WriteLine($"哈囉, {name}");
        }

        public static void SayEngHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        public static void SayJPHello(string name)
        {
            Console.WriteLine($"こんにちは, {name}");
        }
    }
}
