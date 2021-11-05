using System;

namespace testi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Tehtävä 1:");
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


            /*
            Console.WriteLine("Tehtävä 2:");
            Console.WriteLine("Anna kolme lukua.");
            Console.WriteLine("Anna ensimmäinen luku :");
            int eka = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku :");
            int toka = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku :");
            int kolmas = int.Parse(Console.ReadLine());
            int x;
            if (eka > toka)
            {
                x = eka;
            }
            else
            {
                x = toka;
            }
            if (x > kolmas)
            {
                Console.WriteLine("Suurin luku on " + x);
            } 
            else
            {
                Console.WriteLine("Suurin luku on " + kolmas);
            }
            */



            /*Console.WriteLine("Tehtävä 3");
            Console.WriteLine("Anna luku 0-9 :");
            string luku = (Console.ReadLine());
            switch (luku)
            {
                case "0":
                    Console.WriteLine("Annoit luvun Nolla");
                    break;
                case "1":
                    Console.WriteLine("Annoit luvun Yksi");
                    break;
                case "2":
                    Console.WriteLine("Annoit luvun Kaksi");
                    break;
                case "3":
                    Console.WriteLine("Annoit luvun Kolme");
                    break;
                case "4":
                    Console.WriteLine("Annoit luvun Neljä");
                    break;
                case "5":
                    Console.WriteLine("Annoit luvun Viisi");
                    break;
                case "6":
                    Console.WriteLine("Annoit luvun Kuusi");
                    break;
                case "7":
                    Console.WriteLine("Annoit luvun Seitsemän");
                    break;
                case "8":
                    Console.WriteLine("Annoit luvun Kahdeksan");
                    break;
                case "9":
                    Console.WriteLine("Annoit luvun Yhdeksän");
                    break;
                default:
                    Console.WriteLine("Virhe syötteessä. Annoithan varmasti luvun 0-9?");
                    break;*/



            /*Console.WriteLine("Tehtävä 4");
            Console.WriteLine("Anna viisi kokonaislukua");
            Console.WriteLine("Anna ensimmäinen luku :");
            int yksi = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku :");
            int kaksi = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku :");
            int kolme = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna neljäs luku :");
            int neljä = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna viides luku :");
            int viisi = int.Parse(Console.ReadLine());
            int q;
            if (yksi > kaksi)
            {
                q = yksi;
            }
            else
            {
                q = kaksi;
            }
            int w;
            if (kolme > neljä)
            {
                w = kolme;
            }
            else
            {
                w = neljä;
            }
            int e;
            if (q > w)
            {
                e = q;
            }
            else
            {
                e = w;
            }
            if (e > viisi)
            {
                Console.WriteLine("Suurin luku on " + e);
            }
            else
            {
                Console.WriteLine("Suurin luku on " + viisi);
            }*/



            /*Console.WriteLine("Tehtävä 5");
            Console.WriteLine("Haluatko syöttää 1.kokonaisluvun 2.double-luvun vai 3.merkkijonon? (Kirjoita seuraavalle riville numero 1, 2 tai 3 riippuen vastauksestasi)");
            var vastaus = Console.ReadLine();
            switch (vastaus)
            {
                case "1":
                case "kokonaisluku":
                    Console.WriteLine("Anna kokonaisluku :");
                    var kluku = int.Parse(Console.ReadLine());
                    kluku = kluku + 1;
                    Console.WriteLine("Vastaus on " + kluku);
                    break;
                case "2":
                case "double-luku":
                    Console.WriteLine("Anna double-luku (Desimaalierotin on ,) :");
                    var dluku = double.Parse(Console.ReadLine());
                    dluku = dluku + 1;
                    Console.WriteLine("Vastaus on " + dluku);
                    break;
                case "3":
                case "merkkijono":
                    Console.WriteLine("Anna merkkijono :");
                    var mjono = Console.ReadLine();
                    Console.WriteLine("Vastaus on " + mjono + "*");
                    break;
                default:
                    Console.WriteLine("Virhe syötteessä. Annoithan varmasti vastaukseksi numeron 1, 2 tai 3?");
                    break;
            }*/



            /*Console.WriteLine("Tehtävä 6");
            Console.WriteLine("Anna bonuspisteitä 1-9 :");
            int pisteet = int.Parse(Console.ReadLine());
            int lopullinen;
            switch (pisteet)
            {
                case 1:
                case 2:
                case 3:
                    lopullinen = pisteet * 10;
                    Console.WriteLine("Antamasi bonuspisteet kerrottiin kymmenellä. Lopulliset bonuspisteet ovat " + lopullinen);
                    break;
                case 4:
                case 5:
                case 6:
                    lopullinen = pisteet * 100;
                    Console.WriteLine("Antamasi bonuspisteet kerrottiin sadalla. Lopulliset bonuspisteet ovat " + lopullinen);
                    break;
                case 7:
                case 8:
                case 9:
                    lopullinen = pisteet * 1000;
                    Console.WriteLine("Antamasi bonuspisteet kerrottiin tuhannella. Lopulliset bonuspisteet ovat " + lopullinen);
                    break;
                default:
                    Console.WriteLine("Syötteessä virhe. Annoithan varmasti pisteet lukujen 1-9 väliltä.");
                    break;
            }*/



            Console.WriteLine("Tehtävä 7");
            Console.WriteLine("Anna numero 0-999");
            string nro = Console.ReadLine();
            int maara = nro.Length;
            string lause = "";
            if (maara == 3)
            {
                lause += Sadat(nro[0]);
                if (nro[1] == '1')
                {
                    lause += Poikkeukset(nro[2]);
                }
                else
                {
                    lause += Kymmenet(nro[1]);
                    lause += Ykkoset(nro[2]);
                }
            }
            else if (maara == 2)
            {
                Console.WriteLine("Nro[0] = " + nro[0]);
                if (nro[0] == '1')
                {
                    lause += Poikkeukset(nro[1]);
                }
                else
                {
                    lause += Kymmenet(nro[0]);
                    lause += Ykkoset(nro[1]);
                }
            }
            else
            {
                lause += Ykkoset(nro[0]);
            }
            Console.WriteLine(lause);
            static string Sadat(int luku)
            {
                switch (luku)
                {
                    case '9':
                        return "yhdeksänsataa";
                    case '8':
                        return "kahdeksansataa";
                    case '7':
                        return "seitsemänsataa";
                    case '6':
                        return "kuusisataa";
                    case '5':
                        return "viisisataa";
                    case '4':
                        return "neljäsataa";
                    case '3':
                        return "kolmesataa";
                    case '2':
                        return "kaksisataa";
                    case '1':
                        return "sata";
                    default:
                        return "virhe";
                }
            }
            static string Kymmenet(int luku2)
            {
                switch (luku2)
                {
                    case '9':
                        return "yhdeksänkymmentä";
                    case '8':
                        return "kahdeksankymmentä";
                    case '7':
                        return "seitsemänkymmentä";
                    case '6':
                        return "kuusikymmentä";
                    case '5':
                        return "viisikymmentä";
                    case '4':
                        return "neljäkymmentä";
                    case '3':
                        return "kolmekymmentä";
                    case '2':
                        return "kaksikymmentä";
                    default:
                        return "virhe";
                }
            }
            static string Ykkoset(int luku3)
            {
                switch (luku3)
                {
                    case '9':
                        return "yhdeksän";
                    case '8':
                        return "kahdeksan";
                    case '7':
                        return "seitsemän";
                    case '6':
                        return "kuusi";
                    case '5':
                        return "viisi";
                    case '4':
                        return "neljä";
                    case '3':
                        return "kolme";
                    case '2':
                        return "kaksi";
                    case '1':
                        return "yksi";
                    default:
                        return "virhe";
                }
            }
            static string Poikkeukset(int luku4)
            {
                switch (luku4)
                {
                    case '9':
                        return "yhdeksäntoista";
                    case '8':
                        return "kahdeksantoista";
                    case '7':
                        return "seitsemäntoista";
                    case '6':
                        return "kuusitoista";
                    case '5':
                        return "viisitoista";
                    case '4':
                        return "neljätoista";
                    case '3':
                        return "kolmetoista";
                    case '2':
                        return "kaksitoista";
                    case '1':
                        return "kymmenen";
                    default:
                        return "virhe";
                }

            }
    }
}  
