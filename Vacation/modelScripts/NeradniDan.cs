using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class NeradniDan
    {
        private int _id;
        private string _naziv, _datum, _tipId;

        public int Id { get => _id; set => _id = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string Datum { get => _datum; set => _datum = value; }
        public string TipId { get => _tipId; set => _tipId = value; }

        public NeradniDan()
        {
        }

        private NeradniDan(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            Naziv = pRow["Naziv"].ToString();
            Datum = pRow["Datum"].ToString();
            TipId = pRow["TipId"].ToString();
        }

        public NeradniDan(int pId, string pNaziv, string pDatum, string pTemplateId)
        {
            Id = pId;
            Naziv = pNaziv;
            Datum = pDatum;
            TipId = pTemplateId;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO NeradniDani(Naziv, Datum, TipId) " +
                            "VALUES('" + Naziv + "', '" + Datum + "', " + TipId + ")";
            }
            else
            {
                sqlUpit = "UPDATE NeradniDani SET Naziv = '" + Naziv
                            + "', Datum = '" + Datum
                            + "', TipId = " + TipId
                            + " WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE NeradniDani SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public DataTable DohvatiPodatke(int pGodina)
        {
            string sqlUpit = "SELECT * FROM NeradniDani WHERE Aktivan = 1 AND YEAR(Datum) = " + pGodina;
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public DataTable DohvatiGodine()
        {
            string sqlUpit = "SELECT DATEPART(YYYY, Datum) as godina FROM NeradniDani WHERE Aktivan = 1 GROUP BY DATEPART(YYYY, Datum) ORDER BY godina";
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public List<NeradniDan> DajListu(int pGodina)
        {
            List<NeradniDan> lista = new List<NeradniDan>();
            foreach (DataRow row in DohvatiPodatke(pGodina).Rows)
            {
                lista.Add(new NeradniDan(row));
            }
            return lista;
        }

        public List<string> DajGodine()
        {
            List<string> lista = new List<string>();
            string godina = "";
            foreach (DataRow row in DohvatiGodine().Rows)
            {
                godina= row["godina"].ToString();
                lista.Add(godina);
            }
            return lista;
        }
    }
}
