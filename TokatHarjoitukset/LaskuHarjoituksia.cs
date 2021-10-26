using System;

namespace LaskuHarjoituksia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna luku");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku2 + 3));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku2 - 2));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku2 * 5));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 / luku2));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 % luku2));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 += luku2));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 -= luku2));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 *= luku2 * 5));
            Console.WriteLine("Anna luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (luku1 /= luku2));
        }
    }
}
