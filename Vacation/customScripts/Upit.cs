using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacation.modelScripts;

namespace Vacation.customScripts
{
    class Upit
    {
        private static string _sqlUpit;
        private static string SqlUpit { get => _sqlUpit; set => _sqlUpit = value; }
        private static string Format { get => "d.M.yyyy. H:mm:ss"; }
        public static List<int> DajGodineGodisnjeg() 
        {
            List<int> lista = new List<int>();
            SqlUpit = "SELECT YEAR(DatumOd) as godina FROM Godisnji WHERE Aktivan = 1 INTERSECT " + 
                    "SELECT YEAR(DatumDo) as godina FROM Godisnji WHERE Aktivan = 1 GROUP BY YEAR(DatumOd),YEAR(DatumDo)  ORDER BY godina ";
            foreach (DataRow row in DatabaseConnection.Instance.DohvatiPodatke(SqlUpit).Rows)
            {
                lista.Add(int.Parse(row["godina"].ToString()));
            }
            return lista;
        }

        public static DataTable DajZaposlenike(int pGodina, List<string> pDatumi)
        {
            if (pDatumi.Count < 1)
            {
                return null;
            }
            string datumi = "";
            foreach (var datum in pDatumi)
            {
                datumi += " AND Godisnji.DatumOd <= '" + datum + "' AND Godisnji.DatumDo >= '" + datum + "'";
            }
            SqlUpit = "SELECT Zaposlenici.Id, Ime, Prezime, SpolId, Adresa, Oib FROM Zaposlenici, ZaposlenikGodisnji, Godisnji" +
                " WHERE Zaposlenici.Id = ZaposlenikGodisnji.ZaposlenikId AND ZaposlenikGodisnji.Id = Godisnji.ZaposlenikGodisnjiId" +
                " AND Zaposlenici.Aktivan = 1 AND ZaposlenikGodisnji.Aktivan = 1 AND Godisnji.Aktivan = 1" +
                " AND YEAR(DatumOd) = " + pGodina + datumi;
            Console.WriteLine(SqlUpit);
            return DatabaseConnection.Instance.DohvatiPodatke(SqlUpit);
        }

        public static DataTable DajSveGodisnje() 
        {
            SqlUpit = "SELECT DatumOd, DatumDo FROM Godisnji WHERE Aktivan = 1";
            return DatabaseConnection.Instance.DohvatiPodatke(SqlUpit);
        }

        public static DataTable DajGodisnjiPoZaposlenikuIGodini(int pZaposlenikId, int pGodina)
        {            
            SqlUpit = "SELECT DatumOd, DatumDo FROM Godisnji, ZaposlenikGodisnji " +
            "WHERE ZaposlenikGodisnji.Id = Godisnji.ZaposlenikGodisnjiId " +
            "AND ZaposlenikGodisnji.Aktivan = 1 AND Godisnji.Aktivan = 1 " +
            "AND ZaposlenikGodisnji.ZaposlenikId = " + pZaposlenikId + " AND YEAR(DatumOd) = " + pGodina;
            
            if (pZaposlenikId == -1)
            {
                SqlUpit = "SELECT DatumOd, DatumDo FROM Godisnji, ZaposlenikGodisnji " +
                "WHERE ZaposlenikGodisnji.Id = Godisnji.ZaposlenikGodisnjiId " +
                "AND ZaposlenikGodisnji.Aktivan = 1 AND Godisnji.Aktivan = 1 " +
                " AND YEAR(DatumOd) = " + pGodina;
            }
                        
            return DatabaseConnection.Instance.DohvatiPodatke(SqlUpit);
        }

        public static List<int> DajGodineGodisnjegZaposlenika(int pZaposlenikId)
        {
            List<int> lista = new List<int>();
           
            SqlUpit = "SELECT YEAR(DatumOd) as godina FROM Godisnji, ZaposlenikGodisnji WHERE ZaposlenikGodisnji.Id = Godisnji.ZaposlenikGodisnjiId " +
            "AND ZaposlenikGodisnji.Aktivan = 1 AND Godisnji.Aktivan = 1 AND ZaposlenikGodisnji.ZaposlenikId = " + pZaposlenikId + " GROUP BY YEAR(DatumOd)";
            
            if (pZaposlenikId == -1)
            {
                SqlUpit = "SELECT YEAR(DatumOd) as godina FROM Godisnji, ZaposlenikGodisnji WHERE ZaposlenikGodisnji.Id = Godisnji.ZaposlenikGodisnjiId " +
                    "AND ZaposlenikGodisnji.Aktivan = 1 AND Godisnji.Aktivan = 1 GROUP BY YEAR(DatumOd)";                
            }
            foreach (DataRow row in DatabaseConnection.Instance.DohvatiPodatke(SqlUpit).Rows)
            {
                lista.Add(int.Parse(row["godina"].ToString()));
            }
            return lista;
        }

        public static DataTable DajDodatkeZaposlenika(int pZaposlenikId)
        {
            SqlUpit = "SELECT ZaposlenikDodaci.Id, DodatakId, Naziv, BrojDana, GodinaPrava FROM Dodaci, ZaposlenikDodaci " +
                "WHERE ZaposlenikDodaci.DodatakId = Dodaci.Id AND ZaposlenikDodaci.Aktivan = 1 AND Dodaci.Aktivan = 1 AND ZaposlenikId = " + pZaposlenikId;
            return DatabaseConnection.Instance.DohvatiPodatke(SqlUpit);
        }

        public static void SpremiZaposlenikDodaci(int pZaposlenikId, int pDodatakId)
        {
            SqlUpit = "INSERT INTO ZaposlenikDodaci(ZaposlenikId, DodatakId) " +
                            "VALUES(" + pZaposlenikId + ", "
                                        + pDodatakId + ")";
            DatabaseConnection.Instance.IzvrsiUpit(SqlUpit);
        }

        public static void DeaktivirajZaposlenikDodaci(int pId)
        {
            string sqlUpit = "UPDATE ZaposlenikDodaci SET Aktivan = 0 WHERE Id = " + pId;
            DatabaseConnection.Instance.IzvrsiUpit(sqlUpit);
        }
    }
}
