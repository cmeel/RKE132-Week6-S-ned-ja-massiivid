using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi

            
            string hwLause = "Hello, World!";

            for (int i = hwLause.Length-1; i >= 0; i--)
            {
                Console.Write(hwLause[i]);
            }
        }
    }
}
