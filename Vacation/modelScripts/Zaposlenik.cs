using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class Zaposlenik
    {
        private int _id;
        private string _ime, _prezime, _spolId, _adresa, _oib;
        private List<Spol> _spolovi;

        public int Id { get => _id; set => _id = value; }
        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        public string SpolId { get => _spolId; set => _spolId = value; }
        public string Adresa { get => _adresa; set => _adresa = value; }
        public string Oib { get => _oib; set => _oib = value; }
        internal List<Spol> Spolovi { get => _spolovi; set => _spolovi = value; }

        public Zaposlenik()
        {
            DohvatiSpolove();
        }

        private Zaposlenik(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            Ime = pRow["Ime"].ToString();
            Prezime = pRow["Prezime"].ToString();
            SpolId = pRow["SpolId"].ToString();
            Adresa = pRow["Adresa"].ToString();
            Oib = pRow["Oib"].ToString();
        }

        public Zaposlenik(int pId, string pIme, string pPrezime, string pSpol, string pAdresa, string pOib)
        {
            Id = pId;
            Ime = pIme;
            Prezime = pPrezime;
            SpolId = pSpol;
            Adresa = pAdresa;
            Oib = pOib;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO Zaposlenici(Ime, Prezime, SpolId, Adresa, Oib) " +
                            "VALUES('" + Ime + "', '" + Prezime + "', " + SpolId + ", '" + Adresa + "', " + Oib + ")";
            }
            else
            {
                sqlUpit = "UPDATE Zaposlenici SET Ime = '" + Ime
                            + "', Prezime = '" + Prezime
                            + "', SpolId = " + SpolId
                            + ", Adresa = '" + Adresa
                            + "', Oib = " + Oib
                            + " WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE Zaposlenici SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public DataTable DohvatiPodatke()
        {
            string sqlUpit = "SELECT * FROM Zaposlenici WHERE Aktivan = 1";
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        private void DohvatiSpolove()
        {
            string sqlUpit = "SELECT * FROM Spolovi";
            DataTable spolovi = DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
            Spolovi = new List<Spol>();
            foreach (DataRow row in spolovi.Rows)
            {
                Spolovi.Add(new Spol(row));
            }
        }

        public String DajNazivSpola(int pSpolId)
        {
            foreach (var row in Spolovi)
            {
                if (row.Id == pSpolId)
                {
                    return row.Naziv;
                }                
            }
            return null;
        }

        public List<Zaposlenik> DajListu()
        {
            List<Zaposlenik> lista = new List<Zaposlenik>();
            foreach (DataRow row in DohvatiPodatke().Rows)
            {
                lista.Add(new Zaposlenik(row));
            }
            return lista;
        }
    }
}
