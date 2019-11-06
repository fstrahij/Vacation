using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacation.modelScripts;

namespace Vacation.customScripts
{
    class PomocniBrojac
    {
        private static int _brojDana, _raspoloziviBrojDana, _godina, _zaposlenikGodisnjiId, _stariGodisnji, _noviGodisnji;
        private static DateTime _dtpDatumDo;

        private static int ZaposlenikId { get; set; }
        public static int BrojDana { get => _brojDana; private set => _brojDana = value; }
        public static int RaspoloziviBrojDana { get => _raspoloziviBrojDana; private set => _raspoloziviBrojDana = value; }
        public static int Godina { get => _godina; private set => _godina = value; }
        public static int ZaposlenikGodisnjiId { get => _zaposlenikGodisnjiId; private set => _zaposlenikGodisnjiId = value; }
        public static int StariGodisnji { get => _stariGodisnji; set => _stariGodisnji = value; }
        public static int NoviGodisnji { get => _noviGodisnji; set => _noviGodisnji = value; }
        public static DateTime DtpDatumDo { get => _dtpDatumDo; private set => _dtpDatumDo = value; }


        public static void IzracunajRapoloziviBrojDana(int pZaposlenikId)
        {            
            ZaposlenikGodisnji zaposlenikGodisnji = new ZaposlenikGodisnji();
            ZaposlenikId = pZaposlenikId;
            Godina = RaspoloziviBrojDana = StariGodisnji = 0;
            NoviGodisnji = int.Parse(zaposlenikGodisnji.DajPodatkePoZaposleniku(ZaposlenikId).BrojDana);

            PostaviPodatke(zaposlenikGodisnji);

            UmanjiZaGodisnji();            
        }

        public static Tuple<int, int> IzracunajBrojDana(DateTime pDtpDatumOd, DateTime pDtpDatumDo)
        {
            BrojDana = 0;
            DateTime postavke = DajGranicniDatum();  //new DateTime(Godina, 6, 30);
            int stariGodisnji = StariGodisnji;
            int noviGodisnji = NoviGodisnji;
            int brojac = noviGodisnji;

            while (pDtpDatumOd.Date.CompareTo(pDtpDatumDo.Date) <= 0 && BrojDana < brojac)
            {
                if (!IsNeradniDan(pDtpDatumOd))
                {
                    if (pDtpDatumOd.Date.CompareTo(postavke.Date) <= 0 && stariGodisnji > 0)
                    {
                        stariGodisnji--;
                        brojac++;
                    }
                    else noviGodisnji--;                    
                    BrojDana++;
                }
                pDtpDatumOd = pDtpDatumOd.AddDays(1);
            }
            DtpDatumDo = pDtpDatumOd.Date.AddDays(-1);
            return Tuple.Create(noviGodisnji, stariGodisnji);
        }

        public static bool IsNeradniDan(DateTime pocetniDatum)
        {
            NeradniDan dani = new NeradniDan();
            foreach (var dan in dani.DajListu(Godina))
            {
                if (DateTime.Compare(pocetniDatum.Date, dan.Datum.Date) == 0)
                {
                    return true;
                }
            }
            return false;
        }        

        private static void PostaviPodatke(ZaposlenikGodisnji zaposlenikGodisnji)
        {
            int novaGodina = 0;
            foreach (var item in zaposlenikGodisnji.DajListu())
            {
                if (int.Parse(item.ZaposlenikId) == ZaposlenikId)
                {
                    novaGodina = int.Parse(item.Godina);
                    if (Godina < novaGodina)
                    {
                        Godina = novaGodina;
                        RaspoloziviBrojDana = int.Parse(item.BrojDana);
                        ZaposlenikGodisnjiId = item.Id;
                    }
                }
            }
        }

        private static void UmanjiZaGodisnji()
        {
            Godisnji godisnji = new Godisnji();            
            DateTime postavke = DajGranicniDatum();
            int index = godisnji.DajListu(ZaposlenikId, Godina).Count;
            if (index > 0)
            {
                StariGodisnji = int.Parse(godisnji.DajListu(ZaposlenikId, Godina)[index-1].OstaloStariBrojDana);
                NoviGodisnji = int.Parse(godisnji.DajListu(ZaposlenikId, Godina)[index-1].OstaloNoviBrojDana);
                return;
            }
            if (DateTime.Today.Date.CompareTo(postavke.Date) < 0)
            {
                index = godisnji.DajListu(ZaposlenikId, Godina - 1).Count;
                StariGodisnji = int.Parse(godisnji.DajListu(ZaposlenikId, Godina - 1)[index - 1].OstaloNoviBrojDana);
            }
            else
            {
                RaspoloziviBrojDana = NoviGodisnji;
            }
        }

        private static DateTime DajGranicniDatum()
        {
            Postavka postavka = new Postavka();
            string GranicniDatum = "GranicniDatum";
            string datum = Godina + "." + postavka.DajListu().Find(x => x.Kljuc == GranicniDatum).Vrijednost;
            string format = "yyyy.dd.MM.";
            DateTime postavke;
            DateTime.TryParseExact(datum, format, null, System.Globalization.DateTimeStyles.None, out postavke);
            return postavke;
        }

    }
}
