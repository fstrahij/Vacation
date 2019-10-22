using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class ZaposlenikGodisnji
    {
        private int _id;
        private string _zaposlenikId, _godina, _brojDana;
        private List<Zaposlenik> _zaposlenici;

        public int Id { get => _id; set => _id = value; }
        public string ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        public string Godina { get => _godina; set => _godina = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        internal List<Zaposlenik> Zaposlenici { get => _zaposlenici; set => _zaposlenici = value; }


    }
}
