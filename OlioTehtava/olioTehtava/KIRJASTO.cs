using System;
using System.Collections.Generic;
using System.Text;

namespace olioTehtava
{
    class KIRJASTO
    {
        public string kirjanNimi;
        public string kirjailija;
        public int sivuMaara;
        public string lainassa;

        public string KirjanNimi
        {
            get { return kirjanNimi; }
            set
            {
                kirjanNimi = value;
            }
        }
        public string Kirjailija
        {
            get { return kirjailija; }
            set
            {
                kirjailija = value;
            }
        }
        public int SivuMaara
        {
            get { return sivuMaara; }
            set
            {
                sivuMaara = value;
            }
        }
        public void lainaa()
        {
            lainassa = "Kyllä";
        }
        public void palauta()
        {
            lainassa = "Ei";
        }
    }
}
