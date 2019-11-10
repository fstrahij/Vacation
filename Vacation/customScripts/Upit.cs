﻿using System;
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

        public static DataTable DajGodisnji() 
        {
            List<Godisnji> lista = new List<Godisnji>();
            Godisnji godisnji = new Godisnji();
            SqlUpit = "SELECT DatumOd, DatumDo FROM Godisnji WHERE Aktivan = 1";
            /*foreach (DataRow row in DatabaseConnection.Instance.DohvatiPodatke(SqlUpit).Rows)
            {
                godisnji.Id = int.Parse(row["Id"].ToString());
                godisnji.ZaposlenikGodisnjiId = row["ZaposlenikGodisnjiId"].ToString();
                godisnji.DatumOd = DateTime.ParseExact(row["DatumOd"].ToString(), Format, null);
                godisnji.DatumDo = DateTime.ParseExact(row["DatumDo"].ToString(), Format, null);
                godisnji.BrojDana = row["BrojDana"].ToString();
                godisnji.OstaloNoviBrojDana = row["OstaloNoviBrojDana"].ToString();
                godisnji.OstaloStariBrojDana = row["OstaloStariBrojDana"].ToString();
                lista.Add(godisnji);
            }*/
            return DatabaseConnection.Instance.DohvatiPodatke(SqlUpit);
        }
    }
}