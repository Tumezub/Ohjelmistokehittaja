using System;

namespace KolmannetHarjoitukset
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 1:");
            Console.WriteLine("Anna kaksi kokonaislukua");
            Console.WriteLine("Anna ensimmäinen luku :");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku :");
            int luku2 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                Console.WriteLine("Antamasi luvut suuruusjärjestyksessä : " + luku1 + ", " + luku2 + ".");
            }
            else if (luku2 > luku1)
            {
                Console.WriteLine("Antamasi luvut suuruusjärjestyksessä : " + luku2 + ", " + luku1 + ".");
            }
            else
            {
                Console.WriteLine("Syötteessä virhe. Annoithan varmasti kaksi kokonaislukua?");
            }
            Console.WriteLine("Tehtävä 2:");
            Console.WriteLine("Anna kolme lukua.");
            Console.WriteLine("Anna ensimmäinen luku :");
            int eka = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku :");
            int toka = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku :");
            int kolmas = int.Parse(Console.ReadLine());
            if (eka > toka && kolmas)
            {
                Console.WriteLine("Suurin antamasi luku on " + eka);
            }
            else if (toka > eka && kolmas)
            {
                Console.WriteLine("Suurin antamasi luku on " + toka);
            }
            else if (kolmas > eka && toka)
            {
                Console.WriteLine("Suurin antamasi luku on " + kolmas);
            }
            else
            {
                Console.WriteLine("Virhe syötteessä. Annoithan varmasti kolme lukua?");
            }
        }
    }
}