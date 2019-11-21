using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class Bolovanje
    {
        private int _id;
        private string _zaposlenikId, _brojDana, _opis;
        private DateTime _datumOd, _datumDo;

        public int Id { get => _id; set => _id = value; }
        public string ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        public string Opis { get => _opis; set => _opis = value; }
        public DateTime DatumOd { get => _datumOd; set => _datumOd = value; }
        public DateTime DatumDo { get => _datumDo; set => _datumDo = value; }
        private string Format { get => "d.M.yyyy. H:mm:ss"; }

        private Bolovanje(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            ZaposlenikId = pRow["ZaposlenikId"].ToString();
            DatumOd = DateTime.ParseExact(pRow["DatumOd"].ToString(), Format, null);
            DatumDo = DateTime.ParseExact(pRow["DatumDo"].ToString(), Format, null);
            BrojDana = pRow["BrojDana"].ToString();
            Opis = pRow["Opis"].ToString();
        }

        public Bolovanje()
        {
        }

        public Bolovanje(int pId, string pZaposlenikId, string pBrojDana, string pOpis, DateTime pDatumOd, DateTime pDatumDo)
        {
            Id = pId;
            ZaposlenikId = pZaposlenikId;
            DatumOd = pDatumOd;
            DatumDo = pDatumDo;
            BrojDana = pBrojDana;
            Opis = pOpis;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO Bolovanja(ZaposlenikId, BrojDana, Opis, DatumOd, DatumDo) " +
                            "VALUES(" + ZaposlenikId + ", "
                                        + BrojDana + ", '"
                                        + Opis + "', '"
                                        + DatumOd.ToString("MM-dd-yyyy") + "', '"
                                        + DatumDo.Date.ToString("MM-dd-yyyy") + "')";
            }
            else
            {
                sqlUpit = "UPDATE Bolovanja SET ZaposlenikId = " + ZaposlenikId
                            + ", BrojDana = " + BrojDana
                            + ", Opis = '" + Opis
                            + "', DatumOd = '" + DatumOd.ToString("MM-dd-yyyy")
                            + "', DatumDo = '" + DatumDo.ToString("MM-dd-yyyy")
                            + "' WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE Bolovanja SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public DataTable DohvatiPodatke(int pZaposelenikId, int pGodina)
        {
            string sqlUpit = "SELECT * FROM Bolovanja WHERE Aktivan = 1";
            if (pZaposelenikId > 0)
            {
                sqlUpit += " AND ZaposlenikId = " + pZaposelenikId;
            }
            if (pGodina > 0)
            {
                sqlUpit += " AND YEAR(DatumOd) = " + pGodina;
            }

            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public List<Bolovanje> DajListu(int pZaposelenikId, int pGodina)
        {
            List<Bolovanje> lista = new List<Bolovanje>();
            foreach (DataRow row in DohvatiPodatke(pZaposelenikId, pGodina).Rows)
            {
                lista.Add(new Bolovanje(row));
            }
            return lista;
        }
    }
}
