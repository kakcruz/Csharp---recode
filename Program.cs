﻿using System;

namespace VSCodeCSharp01
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Variaveis de impressão */


            int Var1 = 10;
            int Var2 = 20;
            int Var3 = 30;

            Console.WriteLine(Var1);
            Console.WriteLine(Var2);
            Console.WriteLine(Var3);

            Console.WriteLine(Var1 < Var2);
            Console.WriteLine(Var2 == Var3);

            Var1++;
            Var3--;

            Console.WriteLine(Var1);
            Console.WriteLine(Var3);
        }
    }

}            
