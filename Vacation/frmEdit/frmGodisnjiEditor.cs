using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.customScripts;
using Vacation.frmBrowse;
using Vacation.modelScripts;

namespace Vacation.frmEdit
{
    public partial class frmGodisnjiEditor : Form
    {
        private int _id, _zaposlenikId, _noviGodisnji, stariGodisnji;
        private DateTime? _datumOd, _datumDo;

        public frmGodisnjiEditor(frmGodisnji pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox2.Text = pGbText;
            Id = ZaposlenikId = NoviGodisnji = StariGodisnji = 0;
        }

        public int Id { get => _id; set => _id = value; }
        public int ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        private frmGodisnji Forma { get; set; }
        public DateTime? DatumOd { get => _datumOd; set => _datumOd = value; }
        public DateTime? DatumDo { get => _datumDo; set => _datumDo = value; }
        public int NoviGodisnji { get => _noviGodisnji; set => _noviGodisnji = value; }
        public int StariGodisnji { get => stariGodisnji; set => stariGodisnji = value; }

        private void frmGodisnjiEditor_Load(object sender, EventArgs e)
        {           
            PomocniBrojac.IzracunajRapoloziviBrojDana(ZaposlenikId);            
            PostaviGodinu();
            InicijalizirajVrijednostiTextBoxova();
            if (DatumOd != null && DatumDo != null)
            {
                dtpDatumOd.Value = (DateTime) DatumOd;
                dtpDatumDo.Value = (DateTime) DatumDo;
            }
        }

        private void InicijalizirajVrijednostiTextBoxova()
        {
            ZaposlenikGodisnji zaposlenikGodisnji = new ZaposlenikGodisnji();
            Godisnji godisnji = new Godisnji();
            Tuple<int, int> vrstaGodisnji = PomocniBrojac.IzracunajBrojDana(dtpDatumOd.Value, dtpDatumDo.Value);
            
            if (NoviGodisnji > 0 && StariGodisnji  > 0)
            {
                txtNoviGodisnji.Text = NoviGodisnji.ToString();
                txtStariGodisnji.Text = StariGodisnji.ToString();
            }
            else
            {
                txtNoviGodisnji.Text = vrstaGodisnji.Item1.ToString();
                txtStariGodisnji.Text = vrstaGodisnji.Item2.ToString();
            }

            txtBrojDana.Text = PomocniBrojac.BrojDana.ToString();
            txtUkupnoNovi.Text = zaposlenikGodisnji.DajPodatkePoZaposleniku(ZaposlenikId).BrojDana;
            int godina = PomocniBrojac.Godina;
            int index = godisnji.DajListu(ZaposlenikId, godina).Count;
            txtUkupnoStari.Text = (index > 0) ? godisnji.DajListu(ZaposlenikId, godina)[0].OstaloStariBrojDana : 0.ToString();
            if (vrstaGodisnji.Item2 > 0)
            {
                int neiskoristeniStari = vrstaGodisnji.Item2 + 1;
                txtNeiskoristenoNovi.Text = vrstaGodisnji.Item1.ToString();
                txtNeiskoristenoStari.Text = neiskoristeniStari.ToString();
            }
            else if (vrstaGodisnji.Item2 == 0)
            {
                int neiskoristeniNovi = vrstaGodisnji.Item1 + 1;
                txtNeiskoristenoNovi.Text = neiskoristeniNovi.ToString();
                txtNeiskoristenoStari.Text = vrstaGodisnji.Item2.ToString();
            }
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            while (PomocniBrojac.IsNeradniDan(dtpDatumOd.Value.Date))
            {
                dtpDatumOd.Value = dtpDatumOd.Value.AddDays(1);
            }
            dtpDatumDo.Value = dtpDatumOd.Value;          
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            while (PomocniBrojac.IsNeradniDan(dtpDatumDo.Value.Date))
            {
                dtpDatumDo.Value = dtpDatumDo.Value.AddDays(1);
            }
            Tuple<int, int> godisnji = PomocniBrojac.IzracunajBrojDana(dtpDatumOd.Value, dtpDatumDo.Value);
            dtpDatumDo.Value = PomocniBrojac.DtpDatumDo;
            txtNoviGodisnji.Text = godisnji.Item1.ToString();
            txtStariGodisnji.Text = godisnji.Item2.ToString();
            txtBrojDana.Text = PomocniBrojac.BrojDana.ToString();
        }        

        private void PostaviGodinu()
        {
            DateTime min = new DateTime(PomocniBrojac.Godina, 1, 1);
            DateTime max = new DateTime(PomocniBrojac.Godina, 12, 31);
            dtpDatumDo.MinDate = dtpDatumOd.MinDate = min;
            dtpDatumDo.MaxDate = dtpDatumOd.MaxDate = max;
            
        }

        private bool ValidateInputs()
        {
            int brojDana = 0;
            if (!string.IsNullOrWhiteSpace(txtBrojDana.Text)
                && int.TryParse(txtBrojDana.Text, out brojDana)
                && brojDana > 0)
            {
                return true;
            }
            return false;
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Godisnji godisnji = new Godisnji(Id,
                                            PomocniBrojac.ZaposlenikGodisnjiId.ToString(),
                                            dtpDatumOd.Value.Date,
                                            dtpDatumDo.Value.Date,
                                            txtBrojDana.Text,
                                            txtNoviGodisnji.Text,
                                            txtStariGodisnji.Text
                        );
                    godisnji.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
        }
    }
}
