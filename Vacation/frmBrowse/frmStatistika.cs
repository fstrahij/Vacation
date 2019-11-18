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
    public partial class frmStatistika : Form
    {
        private int _godina;
        private static frmStatistika _instance = null;
        private frmStatistika()
        {
            InitializeComponent();
        }

        public static frmStatistika Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmStatistika();
                }
                return _instance;
            }
        }

        public int Godina { get => _godina; set => _godina = value; }

        private void GodisnjiStatistika_Load(object sender, EventArgs e)
        {
            DohvatiGodine();
        }

        private void DohvatiGodine()
        {
            comboBoxGodina.DataSource = Upit.DajGodineGodisnjeg();
        }

        private void UcitajPodatke() 
        {
            chartGodisnji.Series.Clear();
            chartGodisnji.Series.Add("Mjesec");
            Statistika statistika = new Statistika();
            DateTime DatumOd, DatumDo;
            statistika.Godina = Godina;
            foreach (DataRow row in Upit.DajSveGodisnje().Rows)
            {
                DatumOd = DateTime.ParseExact(row["DatumOd"].ToString(), "d.M.yyyy. H:mm:ss", null);
                DatumDo = DateTime.ParseExact(row["DatumDo"].ToString(), "d.M.yyyy. H:mm:ss", null);
                statistika.IzracunajDane(DatumOd, DatumDo);
            }
            foreach (var item in statistika.Mjeseci)
            {
                chartGodisnji.Series["Mjesec"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void comboBoxGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            int godina = 0;
            int.TryParse(comboBoxGodina.SelectedValue.ToString(), out godina);
            Godina = godina;
            UcitajPodatke();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStatistika_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }
    }
}
