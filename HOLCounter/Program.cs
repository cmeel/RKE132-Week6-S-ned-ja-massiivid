using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'o' ja 'l' tähte on on lauses "Hello World!"

            
            string sentenceHW = "Hello World!".ToLower();

            int hCounter = 0;

            for (int i = 0; i < sentenceHW.Length; i++)
            {
                if (sentenceHW [i] == 'h')
                {
                    hCounter++;
                }
            }
            if (hCounter == 1)
            {
                Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' täht.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' tähte.");
            }

            int oCounter = 0;

            for (int i = 0; i < sentenceHW.Length; i++)
            {
                if (sentenceHW [i] == 'o')
                {
                    oCounter++;
                }
            }
            if (oCounter == 1)
            {
                Console.WriteLine($"Lauses Hello World! on {oCounter} 'o' täht.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World! on {oCounter} 'o' tähte.");
            }

            int lCounter = 0;

            for (int i = 0; i < sentenceHW.Length; i++)
            {
                if (sentenceHW[i] == 'l')
                {
                    lCounter++;
                }
            }
            if (lCounter == 1)
            {
                Console.WriteLine($"Lauses Hello World! on {lCounter} 'l' täht.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World! on {lCounter} 'l' tähte.");
            }
        }
    }
}
