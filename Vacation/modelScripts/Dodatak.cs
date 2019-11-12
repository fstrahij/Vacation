using System.Collections.Generic;
using System.Data;

namespace Vacation.modelScripts
{
    class Dodatak
    {
        private int _id;
        private string _naziv, _brojDana, _godinaPrava;

        public int Id { get => _id; set => _id = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        public string GodinaPrava { get => _godinaPrava; set => _godinaPrava = value; }

        private Dodatak(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            Naziv = pRow["Naziv"].ToString();
            BrojDana = pRow["BrojDana"].ToString();
            GodinaPrava = pRow["GodinaPrava"].ToString();
        }
        public Dodatak()
        {
        }

        public Dodatak(int pId, string pNaziv, string pBrojDana, string pGodinaPrava)
        {
            Id = pId;
            Naziv = pNaziv;
            BrojDana = pBrojDana;
            GodinaPrava = pGodinaPrava;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO Dodaci(Naziv, BrojDana, GodinaPrava) " +
                            "VALUES('" + Naziv + "', "
                                        + BrojDana + ", "
                                        + GodinaPrava + ")";
            }
            else
            {
                sqlUpit = "UPDATE Dodaci SET Naziv = '" + Naziv
                            + "', BrojDana = " + BrojDana
                            + ", GodinaPrava = " + GodinaPrava
                            + " WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE Dodaci SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public DataTable DohvatiPodatke()
        {
            string sqlUpit = "SELECT * FROM Dodaci WHERE Aktivan = 1";
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public List<Dodatak> DajListu()
        {
            List<Dodatak> lista = new List<Dodatak>();
            foreach (DataRow row in DohvatiPodatke().Rows)
            {
                lista.Add(new Dodatak(row));
            }
            return lista;
        }
    }
}
