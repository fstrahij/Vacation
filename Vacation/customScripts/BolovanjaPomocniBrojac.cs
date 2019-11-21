using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacation.modelScripts;

namespace Vacation.customScripts
{
    class BolovanjaPomocniBrojac
    {
        private static DateTime _dtpDatumDo;

        public static int Godina { get => DateTime.Today.Year; }
        public static DateTime DtpDatumDo { get => _dtpDatumDo; private set => _dtpDatumDo = value; }

        public static int IzracunajBrojDana(DateTime pDtpDatumOd, DateTime pDtpDatumDo)
        {
            int brojDana = 0;

            while (pDtpDatumOd.Date.CompareTo(pDtpDatumDo.Date) <= 0)
            {
                if (!IsNeradniDan(pDtpDatumOd))
                {
                    brojDana++;
                }
                pDtpDatumOd = pDtpDatumOd.AddDays(1);
            }
            DtpDatumDo = pDtpDatumOd.Date.AddDays(-1);
            return brojDana;
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
    }
}
