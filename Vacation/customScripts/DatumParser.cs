using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.customScripts
{
    class DatumParser
    {
        private static int _dan, _mjesec, _godina;
        private static DateTime _datumOd, _datumDo;
        private static int _danUkupno = 0;
        private static int _mjesecUkupno = 0;
        private static int _godinaUkupno = 0;

        public static int Dan { get => _dan; set => _dan = value; }
        public static int Mjesec { get => _mjesec; set => _mjesec = value; }
        public static int Godina { get => _godina; set => _godina = value; }
        public static DateTime DatumOd { get => _datumOd; set => _datumOd = value; }
        public static DateTime DatumDo { get => _datumDo; set => _datumDo = value; }
        public static int DanUkupno { get => _danUkupno; set => _danUkupno = value; }
        public static int MjesecUkupno { get => _mjesecUkupno; set => _mjesecUkupno = value; }
        public static int GodinaUkupno { get => _godinaUkupno; set => _godinaUkupno = value; }

        public static void Izracunaj(DateTime pDatumOd, DateTime pDatumDo)
        {
            DatumOd = pDatumOd;
            DatumDo = pDatumDo;
            Godina = IzracunajGodinu();
            Mjesec = IzracunajMjesec();
            Dan = IzracunajDan();
            IzracunajKumulativ(Godina, Mjesec, Dan);
        }

        private static void IzracunajKumulativ(int pGodina, int pMjesec, int pDan)
        {
            GodinaUkupno += pGodina;
            MjesecUkupno += pMjesec;
            DanUkupno += pDan;
            int limitDan = 30;
            int limitMjesec = 12;
            if (DanUkupno >= limitDan)
            {
                MjesecUkupno++;
                DanUkupno = DanUkupno - limitDan;
            }
            if (MjesecUkupno >= limitMjesec)
            {
                GodinaUkupno++;
                MjesecUkupno = MjesecUkupno - limitMjesec;
            }
        }

        private static int IzracunajGodinu()
        {
            int razlikaGodina = DatumDo.Year - DatumOd.Year;
            int razlikaMjeseci = DatumDo.Month - DatumOd.Month;
            int razlikaDani = DatumDo.Day - DatumOd.Day;
            if (razlikaGodina == 0)
            {
                return 0;
            }
            razlikaGodina = (razlikaMjeseci < 0) ? razlikaGodina - 1 : razlikaGodina;
            razlikaGodina = (razlikaMjeseci == 0 && razlikaDani < 0) ? razlikaGodina - 1 : razlikaGodina;
            return razlikaGodina;
        }

        private static int IzracunajMjesec()
        {
            int razlikaGodina = DatumDo.Year - DatumOd.Year;
            int razlikaMjeseci = DatumDo.Month - DatumOd.Month;            
            int razlikaDani = DatumDo.Day - DatumOd.Day;
            int brojMjeseci = 12;
            razlikaMjeseci = (razlikaMjeseci < 0) ? razlikaMjeseci + brojMjeseci : razlikaMjeseci;
            if (razlikaGodina == 0 || razlikaDani == 0)
            { 
                return razlikaMjeseci;
            }
            if (razlikaGodina > 0 && razlikaMjeseci == 0)
            {
                razlikaMjeseci = 0;
            }
            //razlikaMjeseci = (razlikaMjeseci > 1 && razlikaDani < 0) ? razlikaMjeseci - 1 : razlikaMjeseci;
            return razlikaMjeseci;
        }

        private static int IzracunajDan()
        {
            int razlikaMjeseci = DatumDo.Month - DatumOd.Month;
            int razlikaDani = DatumDo.Day - DatumOd.Day;
            int brojDana = 30;
            if (razlikaDani < 0)
            {
                razlikaDani += brojDana;
                Mjesec--;
            }
            if (razlikaMjeseci == 0)
            {
                return razlikaDani;
            }
            if (razlikaMjeseci > 0 && razlikaDani == 0)
            {
                razlikaDani = 0;
            }
            if (razlikaMjeseci == 0 || razlikaDani < 0)
            {
                Mjesec++;
                razlikaDani = 0;
            }
            
            return razlikaDani;
        }
    }
}
