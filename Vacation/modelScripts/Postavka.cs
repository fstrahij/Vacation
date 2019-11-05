using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class Postavka
    {
        private string _kljuc, _naziv, _vrijednost;

        public string Kljuc { get => _kljuc; set => _kljuc = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string Vrijednost { get => _vrijednost; set => _vrijednost = value; }

        public Postavka()
        {
        }
        private Postavka(DataRow pRow)
        {
            Kljuc = pRow["Kljuc"].ToString();
            Naziv = pRow["Naziv"].ToString();
            Vrijednost = pRow["Vrijednost"].ToString();
        }

        public Postavka(string pKljuc, string pNaziv, string pVrijednost)
        {
            Kljuc = pKljuc;
            Naziv = pNaziv;
            Vrijednost = pVrijednost;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            
            sqlUpit = "UPDATE Postavke SET Naziv = '" + Naziv
                        + "', Vrijednost = '" + Vrijednost
                        + "' WHERE Kljuc = '" + Kljuc + "'";
          
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        private DataTable DohvatiPodatke()
        {
            string sqlUpit = "SELECT * FROM Postavke";
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public List<Postavka> DajListu()
        {
            List<Postavka> lista = new List<Postavka>();
            foreach (DataRow row in DohvatiPodatke().Rows)
            {
                lista.Add(new Postavka(row));
            }
            return lista;
        }
    }
}
