using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class TipNeradnihDana
    {
        private int _id;
        private string _naziv, _boja;
        private bool _aktivan;

        public int Id { get => _id; set => _id = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string Boja { get => _boja; set => _boja = value; }
        public bool Aktivan { get => _aktivan; set => _aktivan = value; }

        public TipNeradnihDana()
        {
        }

        private TipNeradnihDana(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            Naziv = pRow["Naziv"].ToString();
            Boja = pRow["Boja"].ToString();
        }

        public TipNeradnihDana(int pId, string pNaziv, string pBoja)
        {
            Id = pId;
            Naziv = pNaziv;
            Boja = pBoja;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO TipoviNeradnihDana(Naziv, Boja) " +
                            "VALUES('" + Naziv + "','" + Boja + "')";
            }
            else
            {
                sqlUpit = "UPDATE TipoviNeradnihDana SET Naziv = '" + Naziv
                            + "', Boja = '" + Boja
                            + "' WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE TipoviNeradnihDana SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        private DataTable DohvatiPodatke()
        {
            string sqlUpit = "SELECT * FROM TipoviNeradnihDana WHERE Aktivan = 1";
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);            
        }

        public List<TipNeradnihDana> DajListu()
        {
            List<TipNeradnihDana> lista = new List<TipNeradnihDana>();
            foreach (DataRow row in DohvatiPodatke().Rows)
            {
                TipNeradnihDana tipNeradnihDana = new TipNeradnihDana(row);
                lista.Add(tipNeradnihDana);
            }
            return lista;
        }

        public string DajNazivTipa(string pId)
        {
            if (!string.IsNullOrWhiteSpace(pId))
            {  foreach (var item in DajListu())
                {
                    if (item.Id == int.Parse(pId))
                    {
                        return item.Naziv;
                    }
                }
            }
            return null;
        }

        public string DajBojuTipa(string pId)
        {
            if (!string.IsNullOrWhiteSpace(pId))
            {
                foreach (var item in DajListu())
                {
                    if (item.Id == int.Parse(pId))
                    {
                        return item.Boja;
                    }
                }
            }
            return null;
        }
    }
}
