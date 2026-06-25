namespace ConsoleApp2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments provided.");
            }
            else
            {
                Console.WriteLine("Arguments provided:");
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
