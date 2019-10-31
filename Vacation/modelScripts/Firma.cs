using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class Firma
    {
        private int _id;
        private string _zaposlenikId, _naziv;
        private DateTime _datumOd, _datumDo;

        private string Format { get => "d.M.yyyy. H:mm:ss"; }
        public int Id { get => _id; set => _id = value; }
        public string ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public DateTime DatumOd { get => _datumOd; set => _datumOd = value; }
        public DateTime DatumDo { get => _datumDo; set => _datumDo = value; }

        public Firma()
        {
        }

        private Firma(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            ZaposlenikId = pRow["ZaposlenikId"].ToString();
            Naziv = pRow["Naziv"].ToString();
            DatumOd = DateTime.ParseExact(pRow["DatumOd"].ToString(), Format, null);
            DatumDo = DateTime.ParseExact(pRow["DatumDo"].ToString(), Format, null);
        }

        public Firma(int pId, string pZaposlenikId, string pNaziv, DateTime pDatumOd, DateTime pDatumDo)
        {
            Id = pId;
            ZaposlenikId = pZaposlenikId;
            Naziv = pNaziv;
            DatumOd = pDatumOd;
            DatumDo = pDatumDo;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO Firme(ZaposlenikId, Naziv, DatumOd, DatumDo) " +
                            "VALUES(" + ZaposlenikId + ", '"
                                        + Naziv + "', '"
                                        + DatumOd.ToString("MM-dd-yyyy") + "', '"
                                        + DatumDo.ToString("MM-dd-yyyy") + "') ";
            }
            else
            {
                sqlUpit = "UPDATE Firme SET ZaposlenikId = " + ZaposlenikId
                            + ", Naziv = '" + Naziv
                            + "', DatumOd = '" + DatumOd.ToString("MM-dd-yyyy")
                            + "', DatumDo = '" + DatumDo.ToString("MM-dd-yyyy")
                            + "' WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE Firme SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        private DataTable DohvatiPodatke(int pZaposelenikId)
        {
            string sqlUpit = "SELECT * FROM Firme WHERE Firme.Aktivan = 1 AND Firme.ZaposlenikId = " + pZaposelenikId + " ORDER BY DatumOd, DatumDo";
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public List<Firma> DajListu(int pZaposelenikId)
        {
            List<Firma> lista = new List<Firma>();
            foreach (DataRow row in DohvatiPodatke(pZaposelenikId).Rows)
            {
                lista.Add(new Firma(row));
            }
            return lista;
        }
    }
}
