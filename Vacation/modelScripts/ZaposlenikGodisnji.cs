using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class ZaposlenikGodisnji
    {
        private int _id;
        private string _zaposlenikId, _godina, _brojDana;
        private Zaposlenik _zaposlenici;

        public int Id { get => _id; set => _id = value; }
        public string ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        public string Godina { get => _godina; set => _godina = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        public Zaposlenik Zaposlenici { get => _zaposlenici; set => _zaposlenici = value; }


        private ZaposlenikGodisnji(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            ZaposlenikId = pRow["ZaposlenikId"].ToString();            
            Godina = pRow["Godina"].ToString();
            BrojDana = pRow["BrojDana"].ToString();
        }

        public ZaposlenikGodisnji()
        {
            Zaposlenici = new Zaposlenik();
        }

        public ZaposlenikGodisnji(int id, string zaposlenikId, string godina, string brojDana)
        {
            Id = id;
            ZaposlenikId = zaposlenikId;
            Godina = godina;
            BrojDana = brojDana;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO ZaposlenikGodisnji(ZaposlenikId, Godina, BrojDana) " +
                            "VALUES(" + ZaposlenikId + ", " + Godina + ", " + BrojDana + ")";
            }
            else
            {
                sqlUpit = "UPDATE ZaposlenikGodisnji SET ZaposlenikId = " + ZaposlenikId
                            + ", Godina = " + Godina
                            + ", BrojDana = " + BrojDana
                            + " WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE ZaposlenikGodisnji SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public DataTable DohvatiPodatke()
        {
            string sqlUpit = "SELECT * FROM ZaposlenikGodisnji WHERE Aktivan = 1";
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public ZaposlenikGodisnji DajPodatkePoZaposleniku(int pZaposlenikId)
        {
            string sqlUpit = "SELECT TOP 1 * FROM ZaposlenikGodisnji WHERE Aktivan = 1 AND ZaposlenikId = " + pZaposlenikId + " ORDER BY Godina DESC";

            ZaposlenikGodisnji zaposlenikGodisnji;
            foreach (DataRow row in DatabaseConnection.Instance.DohvatiPodatke(sqlUpit).Rows)
            {
                zaposlenikGodisnji = new ZaposlenikGodisnji(row);
                return zaposlenikGodisnji;
            }
            return null;
        }

        public List<ZaposlenikGodisnji> DajListu()
        {
            List<ZaposlenikGodisnji> lista = new List<ZaposlenikGodisnji>();
            foreach (DataRow row in DohvatiPodatke().Rows)
            {
                lista.Add(new ZaposlenikGodisnji(row));
            }
            return lista;
        }

        public string DajGodinu(int pId)
        {
            string godina ="";
            foreach (DataRow row in DohvatiPodatke().Rows)
            {
                if (int.Parse(row["Id"].ToString()) == pId)
                {
                    godina = row["Godina"].ToString();
                    return godina;
                }
            }
            return null;
        }

        public string DajSljedecuGodinu(int pId)
        {
            string sqlUpit = "SELECT MAX(Godina) + 1 as Godina FROM ZaposlenikGodisnji WHERE Aktivan = 1 AND ZaposlenikId = " + pId;
            DataTable dt = DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);

            string godina = "";
            foreach (DataRow row in dt.Rows)
            {
                godina = row["Godina"].ToString();
                if (!string.IsNullOrEmpty(godina))
                {
                    return godina;
                }
            }
            return DateTime.Now.Year.ToString();
        }

        public string IzracunajBrojaDana(int pId)
        {
            string sqlUpit = "SELECT dbo.IzracunajBrojDana(" + pId + ") as BrojDana";
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
