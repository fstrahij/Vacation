using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.customScripts
{
    class Kalendar
    {
        private int _pocetniX, _zavrsniX, _pocetniY;

        public int PocetniX { get => _pocetniX; set => _pocetniX = value; }
        public int ZavrsniX { get => _zavrsniX; set => _zavrsniX = value; }
        public int PocetniY { get => _pocetniY; set => _pocetniY = value; }

        public Kalendar()
        {
        }

        public Tuple<int, int> DajPocetneKoordinate(DateTime pDatum) 
        {
            PostaviMjesec(pDatum.Month);
            int dan = 0;
            for (int i = PocetniX; i <= ZavrsniX; i++)
            {
                if (pDatum.DayOfWeek.ToString() == ((DayOfWeek) dan).ToString())
                {
                    if (dan == 0)
                    {
                        return Tuple.Create(PocetniY, ZavrsniX + 1);
                    }
                    return Tuple.Create(PocetniY, i);
                }
                dan++;
            }
            return Tuple.Create(-1, -1);
        }

        private void PostaviMjesec(int mjesec) 
        {
            switch (mjesec)
            {
                case 1: Sijecanj(); break;
                case 2: Veljaca(); break;
                case 3: Ozujak(); break;
                case 4: Travanj(); break;
                case 5: Svibanj(); break;
                case 6: Lipanj(); break;
                case 7: Srpanj(); break;
                case 8: Kolovoz(); break;
                case 9: Rujan(); break;
                case 10: Listopad(); break;
                case 11: Studeni(); break;
                case 12: Prosinac(); break;
                default:
                    break;
            }
        }

        private void Sijecanj() 
        {
            PocetniX = 0;
            PocetniY = 2;
            ZavrsniX = PocetniX + 6;
        }

        private void Veljaca()
        {
            PocetniX = 8;
            PocetniY = 2;
            ZavrsniX = PocetniX + 6;
        }

        private void Ozujak()
        {
            PocetniX = 16;
            PocetniY = 2;
            ZavrsniX = PocetniX + 6;
        }

        private void Travanj()
        {
            PocetniX = 24;
            PocetniY = 2;
            ZavrsniX = PocetniX + 6;
        }
        private void Svibanj()
        {
            Sijecanj();
            PocetniY = 10;
        }

        private void Lipanj()
        {
            Veljaca();
            PocetniY = 10;
        }

        private void Srpanj()
        {
            Ozujak();
            PocetniY = 10;
        }
        private void Kolovoz()
        {
            Travanj();
            PocetniY = 10;
        }
        private void Rujan()
        {
            Sijecanj();
            PocetniY = 18;
        }
        private void Listopad()
        {
            Veljaca();
            PocetniY = 18;
        }

        private void Studeni()
        {
            Ozujak();
            PocetniY = 18;
        }
        private void Prosinac()
        {
            Travanj();
            PocetniY = 18;
        }
    }
}
