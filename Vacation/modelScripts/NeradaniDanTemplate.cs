using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class NeradaniDanTemplate
    {
        private int _id;
        private string _naziv, _dan, _mjesec, _tipId;

        public int Id { get => _id; set => _id = value; }
        public string TipId { get => _tipId; set => _tipId = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string Dan { get => _dan; set => _dan = value; }
        public string Mjesec { get => _mjesec; set => _mjesec = value; }

        public NeradaniDanTemplate()
        {
        }

        private NeradaniDanTemplate(DataRow pRow)
        {        
            Id = int.Parse(pRow["Id"].ToString());
            
            Dan = ( !string.IsNullOrWhiteSpace(pRow["Dan"].ToString()) &&
                        int.Parse(pRow["Dan"].ToString()) < 10) ? "0" + pRow["Dan"].ToString() : pRow["Dan"].ToString();
            Mjesec = (!string.IsNullOrWhiteSpace(pRow["Mjesec"].ToString()) && 
                        int.Parse(pRow["Mjesec"].ToString()) < 10) ? "0" + pRow["Mjesec"].ToString() : pRow["Mjesec"].ToString();
            TipId = pRow["TipId"].ToString();
            Naziv = pRow["Naziv"].ToString();
        }

        public NeradaniDanTemplate(int pId, string pDan, string pMjesec, string pTipId, string pNaziv)
        {
            Id = pId;
            Dan = (!string.IsNullOrWhiteSpace(pDan) && int.Parse(pDan) < 10) ? "0" + pDan : pDan;
            Mjesec = (!string.IsNullOrWhiteSpace(pMjesec) && int.Parse(pMjesec) < 10) ? "0" + pMjesec : pMjesec;
            TipId = pTipId;
            Naziv = pNaziv;
        }

        public void Spremi()
        {
            string sqlUpit = "";
            if (Id == 0)
            {
                sqlUpit = "INSERT INTO NeradniDaniTemplate(Naziv, Dan, Mjesec, TipId) " +
                            "VALUES('" + Naziv + "', " + Dan + ", " + Mjesec + "," + TipId + ")";
            }
            else
            {
                sqlUpit = "UPDATE NeradniDaniTemplate SET Naziv = '" + Naziv
                            + "', Dan = " + Dan
                            + ", Mjesec = " + Mjesec
                            + ", TipId = " + TipId
                            + " WHERE Id = " + Id;
            }
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public void Deaktiviraj()
        {
            string sqlUpit = "UPDATE NeradniDaniTemplate SET Aktivan = 0 WHERE Id = " + Id;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }

        public DataTable DohvatiPodatke()
        {
            string sqlUpit = "SELECT * FROM NeradniDaniTemplate WHERE Aktivan = 1";      
            return DatabaseConnection.Instance.DohvatiPodatke(sqlUpit);
        }

        public List<NeradaniDanTemplate> DajListu()
        {
            List<NeradaniDanTemplate> lista = new List<NeradaniDanTemplate>();
            foreach (DataRow row in DohvatiPodatke().Rows)
            {
                NeradaniDanTemplate template = new NeradaniDanTemplate(row);
                lista.Add(template);
            }
            return lista;
        }
    }
}
