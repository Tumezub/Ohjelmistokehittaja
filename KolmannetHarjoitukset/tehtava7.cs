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
