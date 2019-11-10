using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.customScripts
{
    class Statistika
    {
        private int _sijecanj, _veljaca, _ozujak, _travanj, _svibanj, _lipanj, _srpanj, _kolovoz, _rujan, _listopad, _studeni, _prosinac;
        private int _godina;
        private Dictionary<string, int> _mjeseci;

        public int Sijecanj { get => _sijecanj; private set => _sijecanj = value; }
        public int Veljaca { get => _veljaca; private set => _veljaca = value; }
        public int Ozujak { get => _ozujak; private set => _ozujak = value; }
        public int Travanj { get => _travanj; private set => _travanj = value; }
        public int Svibanj { get => _svibanj; private set => _svibanj = value; }
        public int Lipanj { get => _lipanj; private set => _lipanj = value; }
        public int Srpanj { get => _srpanj; private set => _srpanj = value; }
        public int Kolovoz { get => _kolovoz; private set => _kolovoz = value; }
        public int Rujan { get => _rujan; private set => _rujan = value; }
        public int Listopad { get => _listopad; private set => _listopad = value; }
        public int Studeni { get => _studeni; private set => _studeni = value; }
        public int Prosinac { get => _prosinac; private set => _prosinac = value; }
        public Dictionary<string, int> Mjeseci { get => _mjeseci; set => _mjeseci = value; }
        public int Godina { get => _godina; set => _godina = value; }

        public Statistika() 
        {
            Sijecanj = Veljaca = Ozujak = Travanj = Svibanj = Lipanj = Srpanj = Kolovoz = Listopad = Studeni = Prosinac = 0;
        }
        private void DodajMjesec(int mjesec)
        {
            switch (mjesec)
            {
                case 1: Sijecanj++;break;
                case 2: Veljaca++; break;
                case 3: Ozujak++; break;
                case 4: Travanj++; break;
                case 5: Svibanj++; break;
                case 6: Lipanj++; break;
                case 7: Srpanj++; break;
                case 8: Kolovoz++; break;
                case 9: Rujan++; break;
                case 10: Listopad++; break;
                case 11: Studeni++; break;
                case 12: Prosinac++; break;
                default:
                    break;
            }
        }

        private void PostaviMjesece()
        {
            Mjeseci = new Dictionary<string, int>();
            if (Sijecanj > 0)
                Mjeseci.Add("Siječanj", Sijecanj);
            if (Veljaca > 0)
                Mjeseci.Add("Siječanj", Veljaca);
            if (Ozujak > 0)
                Mjeseci.Add("Ozujak", Ozujak);
            if (Travanj > 0)
                Mjeseci.Add("Travanj", Travanj);
            if (Svibanj > 0)
                Mjeseci.Add("Svibanj", Svibanj);
            if (Lipanj > 0)
                Mjeseci.Add("Lipanj", Lipanj);
            if (Srpanj > 0)
                Mjeseci.Add("Srpanj", Srpanj);
            if (Kolovoz > 0)
                Mjeseci.Add("Kolovoz", Kolovoz);
            if (Rujan > 0)
                Mjeseci.Add("Rujan", Rujan);
            if (Listopad > 0)
                Mjeseci.Add("Listopad", Listopad);
            if (Studeni > 0)
                Mjeseci.Add("Studeni", Studeni);
            if (Prosinac > 0)
                Mjeseci.Add("Prosinac", Prosinac);
        }

        public void IzracunajDane(DateTime pDatumOd, DateTime pDatumDo) 
        {
            int dan = 31;
            int mjesec = 12;
            int godina = Godina;
            DateTime granicniDatum = new DateTime(godina, mjesec, dan);
            while (DateTime.Compare(pDatumOd, pDatumDo) <= 0 && DateTime.Compare(pDatumOd, granicniDatum) <= 0)
            {
                if (!PomocniBrojac.IsNeradniDan(pDatumOd))
                {
                    DodajMjesec(pDatumOd.Month);
                }                
                pDatumOd = pDatumOd.AddDays(1);
            }
            PostaviMjesece();
        }

    }
}
