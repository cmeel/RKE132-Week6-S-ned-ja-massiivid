﻿using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses 4-ga

            string doPa = "Don't Panic";

            doPa = doPa.Replace('o', '0');
            doPa = doPa.Replace('a', '4');
            Console.WriteLine(doPa);
        }
    }
}
