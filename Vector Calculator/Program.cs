using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(2, 7, 0);
            Vector test2 = new Vector(-4, 1, 0);
            
            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(test1, test2));

            Console.WriteLine(Vector.DotProduct(test1, test2));
            Console.WriteLine(test1.GetMagnitude());
            Console.WriteLine(test2.GetMagnitude());
            Console.WriteLine(Vector.AngleBetween(test1, test2));
        }
    }
}
