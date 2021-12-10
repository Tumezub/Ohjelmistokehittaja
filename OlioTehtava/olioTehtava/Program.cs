using System;

namespace olioTehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            KIRJASTO kirjasto = new KIRJASTO();

            kirjasto.kirjanNimi = "Tuntematon Kimi Räikkönen";
            kirjasto.kirjailija = "Kari Hotakainen";
            kirjasto.sivuMaara = 269;
            kirjasto.lainassa = "Ei";
            string knimi = kirjasto.kirjanNimi;
            string kirjailija = kirjasto.kirjailija;
            int smaara = kirjasto.sivuMaara;
            string laina = kirjasto.lainassa;
            Console.WriteLine("Kirjan nimi: " + knimi);
            Console.WriteLine("Kirjailijan nimi: " + kirjailija);
            Console.WriteLine("Sivumäärä: " + smaara);
            HYPPY:
            Console.WriteLine("Onko kirja lainassa tällä hetkellä? " + laina);
            HYPPY2:
            Console.WriteLine("Mitä haluat tehdä kirjalle?(L = Lainata, P = Palauttaa, E = En mitään)");
            string vastaus = Console.ReadLine();
            if(vastaus == "L")
            {
                kirjasto.lainaa();
                laina = kirjasto.lainassa;
                goto HYPPY;
            }
            else if(vastaus == "P")
            {
                kirjasto.palauta();
                laina = kirjasto.lainassa;
                goto HYPPY;
            }
            else if(vastaus == "E")
            {
                Console.WriteLine("Hyvää päivän jatkoa!");
            }
            else
            {
                Console.WriteLine("Virhe syötteessä. Annoithan varmasti oikean kirjaimen isona?");
                goto HYPPY2;
            }
        }
    }
}
