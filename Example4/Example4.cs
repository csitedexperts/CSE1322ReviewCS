using System;

namespace Example4
{
    class Example4
    {
        class Z { public int y; }
        static void Main(String[] args)
        {
            Console.WriteLine("Example4 .....");
            Z myZ = new Z();
            myZ.y = 42;
            Console.WriteLine(myZ.y);
            B(myZ);
            Console.WriteLine(myZ.y);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void B(Z x)
        {
            x.y += 9;
            Console.WriteLine(x.y);
        }
    }
}
