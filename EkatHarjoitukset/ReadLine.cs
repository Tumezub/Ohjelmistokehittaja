using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita nimesi seuraavalle riville");
            string Nimi = Console.ReadLine();
            Console.WriteLine("Hei " + Nimi);
        }
    }
}
