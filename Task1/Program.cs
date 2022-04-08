using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();
                try
                {
                    Console.WriteLine(line[0]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The line was empty.");
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
        }
    }
}