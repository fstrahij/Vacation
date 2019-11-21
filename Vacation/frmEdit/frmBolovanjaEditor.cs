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
using Vacation.frmBrowse;
using Vacation.modelScripts;

namespace Vacation.frmEdit
{
    public partial class frmBolovanjaEditor : Form
    {
        private int _id, _zaposlenikId, _brojDana;
        private string _opis;
        private DateTime? _datumOd, _datumDo;

        public int Id { get => _id; set => _id = value; }
        public int ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }        
        public int BrojDana { get => _brojDana; set => _brojDana = value; }
        public string Opis { get => _opis; set => _opis = value; }
        private frmBolovanja Forma { get; set; }
        public DateTime? DatumOd { get => _datumOd; set => _datumOd = value; }
        public DateTime? DatumDo { get => _datumDo; set => _datumDo = value; }

        public frmBolovanjaEditor(frmBolovanja pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox2.Text = pGbText;
            Id = ZaposlenikId = BrojDana = 0;
            Opis = "";
        }

        private void frmBolovanjaEditor_Load(object sender, EventArgs e)
        {
            PostaviGodinu();
            if (DatumOd != null && DatumDo != null)
            {
                dtpDatumOd.Value = (DateTime)DatumOd;
                dtpDatumDo.Value = (DateTime)DatumDo;
            }
            txtBrojDana.Text = BrojDana.ToString();
            txtOpis.Text = Opis;
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            while (BolovanjaPomocniBrojac.IsNeradniDan(dtpDatumOd.Value.Date))
            {
                dtpDatumOd.Value = dtpDatumOd.Value.AddDays(1);
            }
            dtpDatumDo.Value = dtpDatumOd.Value;
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            while (BolovanjaPomocniBrojac.IsNeradniDan(dtpDatumDo.Value.Date))
            {
                dtpDatumDo.Value = dtpDatumDo.Value.AddDays(1);
            }
            int brojDana = BolovanjaPomocniBrojac.IzracunajBrojDana(dtpDatumOd.Value, dtpDatumDo.Value);
            dtpDatumDo.Value = BolovanjaPomocniBrojac.DtpDatumDo;
            txtBrojDana.Text = brojDana.ToString();
        }
        

        private void PostaviGodinu()
        {
            DateTime min = new DateTime(BolovanjaPomocniBrojac.Godina, 1, 1);
            DateTime max = new DateTime(BolovanjaPomocniBrojac.Godina, 12, 31);
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
            DialogResult dr;
            if (ValidateInputs())
            {
                dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string brojDana = Trimmer.TrimString(txtBrojDana.Text);
                    string opis = Trimmer.TrimString(txtOpis.Text);
                    Bolovanje bolovanje = new Bolovanje(Id,
                                            ZaposlenikId.ToString(),
                                            brojDana,
                                            opis,
                                            dtpDatumOd.Value.Date,
                                            dtpDatumDo.Value.Date
                                            );
                    bolovanje.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
            else
            {
                dr = MessageBox.Show("Neispravan unos u polje broj dana ili opis!");
            }
        }
    }
}
