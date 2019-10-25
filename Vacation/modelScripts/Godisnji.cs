using System;
using System.Collections.Generic;
using System.Data;
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

        private Godisnji(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            ZaposlenikGodisnjiId = pRow["ZaposlenikGodisnjiId"].ToString();
            DatumOd = pRow["DatumOd"].ToString();
            DatumDo = pRow["DatumDo"].ToString();
            BrojDana = pRow["BrojDana"].ToString();
        }

        public Godisnji()
        {
        }

        public Godisnji(int id, string zaposlenikGodisnjiId, string datumOd, string datumDo, string brojDana)
        {
            Id = id;
            ZaposlenikGodisnjiId = zaposlenikGodisnjiId;
            DatumOd = datumOd;
            DatumDo = datumDo;
            BrojDana = brojDana;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO Godisnji(ZaposlenikGodisnjiId, DatumOd, DatumDo, BrojDana) " +
                            "VALUES(" + ZaposlenikGodisnjiId + ", '" + DatumOd + "', '" + DatumDo + "', " + BrojDana + ")";
            }
            else
            {
                sqlUpit = "UPDATE Godisnji SET ZaposlenikGodisnjiId = " + ZaposlenikGodisnjiId
                            + ", DatumOd = '" + DatumOd
                            + "', DatumDo = '" + DatumDo
                            + "', BrojDana = " + BrojDana
                            + " WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE Godisnji SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public DataTable DohvatiPodatke(int pZaposelenikId)
        {
            string sqlUpit = "SELECT Godisnji.Id, ZaposlenikGodisnjiId, DatumOd, DatumDo,Godisnji.BrojDana FROM Godisnji, ZaposlenikGodisnji";
            sqlUpit += " WHERE Godisnji.ZaposlenikGodisnjiId = ZaposlenikGodisnji.Id";
            sqlUpit += " AND Godisnji.Aktivan = 1 AND ZaposlenikGodisnji.Aktivan = 1";
            if (pZaposelenikId > 0)
            {
                sqlUpit += " AND ZaposlenikGodisnji.ZaposlenikId = " + pZaposelenikId;
            }
            
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public List<Godisnji> DajListu(int pZaposelenikId)
        {
            List<Godisnji> lista = new List<Godisnji>();
            foreach (DataRow row in DohvatiPodatke(pZaposelenikId).Rows)
            {
                lista.Add(new Godisnji(row));
            }
            return lista;
        }

        public string DajRaspoloziviBrojDana(int pId)
        {
            string sqlUpit = "SELECT dbo.RaspoloziviBrojDanaUGodini(" + pId + ") as BrojDana";
            DataTable dt = DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);

            string godina = "";
            foreach (DataRow row in dt.Rows)
            {
                godina = row["BrojDana"].ToString();
                return godina;
            }
            return null;
        }

        public string DajIskoristeniBrojDana(int pId)
        {
            string sqlUpit = "SELECT dbo.RaspoloziviBrojDanaUGodini(" + pId + ") as BrojDana";
            DataTable dt = DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);

            string godina = "";
            foreach (DataRow row in dt.Rows)
            {
                godina = row["BrojDana"].ToString();
                return godina;
            }
            return null;
        }
    }
}
