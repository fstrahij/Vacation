using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation.modelScripts
{
    class Spol
    {
        private int _id;
        private string _naziv;

        public int Id { get => _id; set => _id = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }

        public Spol(DataRow pRow)
        {
            Id = int.Parse(pRow["Id"].ToString());
            Naziv = pRow["Naziv"].ToString();
        }
    }
}
