using System;

namespace Example2
{

    public class Example2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Example2....");
            int a = 42;
            Console.WriteLine(a);
            B(ref a);
            Console.WriteLine(a);
            Console.ReadKey();
        }

        static void B(ref int x)
        {
            x += 9;
            Console.WriteLine(x);
        }

    }

}