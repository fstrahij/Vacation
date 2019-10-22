using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class Godisnji
    {
        private int _id;
        private string _zaposlenikGodisnjiId, _datumOd, _datumDo, _brojDana;
        private List<ZaposlenikGodisnji> _zaposlenikGodisnji;

        public int Id { get => _id; set => _id = value; }
        public string ZaposlenikGodisnjiId { get => _zaposlenikGodisnjiId; set => _zaposlenikGodisnjiId = value; }
        public string DatumOd { get => _datumOd; set => _datumOd = value; }
        public string DatumDo { get => _datumDo; set => _datumDo = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        internal List<ZaposlenikGodisnji> ZaposlenikGodisnji { get => _zaposlenikGodisnji; set => _zaposlenikGodisnji = value; }
    }
}
