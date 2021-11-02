using System;

namespace NeljännetHarjotukset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä1(Tehtävä6)");
            Console.WriteLine("Anna kaksi lukua niin kone laskee ne yhteen");
            Console.WriteLine("Anna ensimmäinen luku :");
            int ykkonen = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku :");
            int kakkonen = int.Parse(Console.ReadLine());
            int tulos = ykkonen + kakkonen;
            Console.WriteLine("Annoit luvut " + ykkonen + " ja " + kakkonen + ", ja niiden yhteenlaskettu arvo on " + tulos);
        
            Console.WriteLine("Tehtävä2(Tehtävä7)");
            Console.WriteLine("Anna jokin lämpötila Celsiuksina niin kone muuttaa sen Fahrenheiteiksi");
            Console.WriteLine("Anna lämpötila(Älä laita luvun perään celsius-merkkiä) :");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("Annoit celsius-lämpötilan " + celsius + ", se on fahrenheittinä " + fahrenheit);

            Console.WriteLine("Tehtävä3(Tehtävä8)");
            Console.WriteLine("Anna kaksi lukua niin kone tekee niille kaikki neljä peruslaskutoimitusta");
            Console.WriteLine("Anna luku :");
            int luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku :");
            int luku2 = int.Parse(Console.ReadLine());
            int summa = luku + luku2;
            int vahennos = luku - luku2;
            int kerto = luku * luku2;
            int jako = luku / luku2;
            Console.WriteLine("Annoit luvut " + luku + " ja " + luku2 + ", ja niiden summa on " + summa + ", ja niiden vähennös on " + vahennos + ", ja niiden tulo on " + kerto + ", ja niiden osamäärä on " + jako);

            Console.WriteLine("Tehtävä4(Tehtävä9)");
            Console.WriteLine("Anna kaksi lukua niin kone tekee niiden välille jakojäännöksen");
            Console.WriteLine("Anna ensimmäinen luku :");
            int eka = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku :");
            int toka = int.Parse(Console.ReadLine());
            int jjaannos = eka % toka;
            Console.WriteLine("Annoit luvut " + eka + " ja " + toka + ", ja niiden jakojäännös on " + jjaannos);
        }
    }
}
