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
            chartGodisnji.Series.Add("Sijecanj");
            chartGodisnji.Series.Add("Veljaca");
            chartGodisnji.Series.Add("Ozujak");
            chartGodisnji.Series.Add("Travanj");
            chartGodisnji.Series.Add("Svibanj");
            chartGodisnji.Series.Add("Lipanj");
            chartGodisnji.Series.Add("Srpanj");
            chartGodisnji.Series.Add("Kolovoz");
            chartGodisnji.Series.Add("Rujan");
            chartGodisnji.Series.Add("Listopad");
            chartGodisnji.Series.Add("Studeni");
            chartGodisnji.Series.Add("Prosinac");
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

            chartGodisnji.Series["Sijecanj"].Points.AddY(gs.Sijecanj);
            chartGodisnji.Series["Veljaca"].Points.AddY(gs.Veljaca);
            chartGodisnji.Series["Ozujak"].Points.AddY(gs.Ozujak);
            chartGodisnji.Series["Travanj"].Points.AddY(gs.Travanj);
            chartGodisnji.Series["Svibanj"].Points.AddY(gs.Svibanj);
            chartGodisnji.Series["Lipanj"].Points.AddY(gs.Lipanj);
            chartGodisnji.Series["Srpanj"].Points.AddY(gs.Srpanj);
            chartGodisnji.Series["Kolovoz"].Points.AddY(gs.Kolovoz);
            chartGodisnji.Series["Rujan"].Points.AddY(gs.Rujan);
            chartGodisnji.Series["Listopad"].Points.AddY(gs.Listopad);
            chartGodisnji.Series["Studeni"].Points.AddY(gs.Studeni);
            chartGodisnji.Series["Prosinac"].Points.AddY(gs.Prosinac);
        }
    }
}
