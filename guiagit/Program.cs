using System;

namespace guiagit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplying  {a} * {b} equals {Multiplyingnumbers(a,b)}");
        }
        static int Multiplyingnumbers(int a, int b)
        {
            return a*b;
        }
    }
}
