﻿using System;

    class Example5
    {
        class Z
        { public int y; }
        static void Main(String[] args)
        {
        Console.WriteLine("Example5....");
            Z myZ = new Z();
            myZ.y = 42;
            Console.WriteLine(myZ.y);
            B(ref myZ);
            Console.WriteLine(myZ.y);

            Console.ReadKey();
        }
        static void B(ref Z x)
        {
            x = new Z();
            x.y = 1;
            Console.WriteLine(x.y);
        }

    }


