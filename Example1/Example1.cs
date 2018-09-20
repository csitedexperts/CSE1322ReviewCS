using System;

namespace Example1
{

    class Example1
    {
        class Z
        {
            public int y;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Example1.....");
            int a = 42;
            Console.WriteLine(a);
            B(a);
            Console.WriteLine(a);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void B(int x)
        {
            x += 9;
            Console.WriteLine(x);
        }

    }
}