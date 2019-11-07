using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.customScripts;
using Vacation.modelScripts;

namespace Vacation.frmBrowse
{
    public partial class frmGodisnjiStatistika : Form
    {
        private static frmGodisnjiStatistika _instance = null;
        private frmGodisnjiStatistika()
        {
            InitializeComponent();
        }

        public static frmGodisnjiStatistika Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmGodisnjiStatistika();
                }
                return _instance;
            }
        }

        private void GodisnjiStatistika_Load(object sender, EventArgs e)
        {
            IzracunajGodisnje();
        }

        private void IzracunajGodisnje() 
        {
            GodisnjaStatistika gs = new GodisnjaStatistika();
            DateTime DatumOd, DatumDo;
            foreach (DataRow row in Upit.DajGodisnji().Rows)
            {
                DatumOd = DateTime.ParseExact(row["DatumOd"].ToString(), "d.M.yyyy. H:mm:ss", null);
                DatumDo = DateTime.ParseExact(row["DatumDo"].ToString(), "d.M.yyyy. H:mm:ss", null);
                gs.IzracunajDane(DatumOd, DatumDo);
            }
            foreach (var item in gs.Mjeseci)
            {
                chartGodisnji.Series["Mjesec"].Points.AddXY(item.Key, item.Value);
            }
        }
    }
}
