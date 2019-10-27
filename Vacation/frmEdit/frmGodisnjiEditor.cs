using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.frmBrowse;
using Vacation.modelScripts;

namespace Vacation.frmEdit
{
    public partial class frmGodisnjiEditor : Form
    {
        private int _id, _raspoloziviBrojDana, _zaposlenikGodisnjiId, _godina;
        private string _datum, _brojDana, _zaposlenikId;

        public frmGodisnjiEditor(frmGodisnji pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox2.Text = pGbText;
            Id = 0;
            ZaposlenikId = Datum = BrojDana = "";            
        }

        public int Id { get => _id; set => _id = value; }
        public string Datum { get => _datum; set => _datum = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        private string ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        private int RaspoloziviBrojDana { get => _raspoloziviBrojDana; set => _raspoloziviBrojDana = value; }
        private int ZaposlenikGodisnjiId { get => _zaposlenikGodisnjiId; set => _zaposlenikGodisnjiId = value; }
        private frmGodisnji Forma { get; set; }
        private int Godina { get => _godina; set => _godina = value; }

        private void frmGodisnjiEditor_Load(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            ZaposlenikGodisnji zaposleniciGodisnji = new ZaposlenikGodisnji();
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
            foreach (var item in zaposlenik.DajListu())
            {
                if (zaposleniciGodisnji.DajListu().FindIndex(x => x.ZaposlenikId == item.Id.ToString()) >= 0)
                {
                    zaposlenici.Add(item);
                }
            }
            comboBoxZaposlenici.DataSource = zaposlenici;
            comboBoxZaposlenici.DisplayMember = "ImePrezime";
            comboBoxZaposlenici.ValueMember = "Id";            
        }

        private bool ValidateInputs()
        {
            int brojDana = 0;
            if (!string.IsNullOrWhiteSpace(ZaposlenikId)
                && !string.IsNullOrWhiteSpace(txtBrojDana.Text)
                && int.TryParse(txtBrojDana.Text, out brojDana)
                && brojDana <= RaspoloziviBrojDana
                )
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
                DateTime DatumDo = dtpDatum.Value.AddDays(int.Parse(txtBrojDana.Text));
                string FormatedDatumDo = DatumDo.Month +"-"+ DatumDo.Day +"-"+ DatumDo.Year;
                if (dr == DialogResult.Yes)
                {
                    Godisnji godisnji = new Godisnji(Id,
                                            ZaposlenikGodisnjiId.ToString(),
                                            dtpDatum.Value.Date.ToString("MM-dd-yyyy"),
                                            FormatedDatumDo,
                                            txtBrojDana.Text
                        );
                    godisnji.Spremi();
                    Forma.UcitajPodatke(int.Parse(ZaposlenikId));
                    this.Close();
                }
            }
        }

        private void ZaposlenikSelected(object sender, EventArgs e)
        {
            Godisnji godisnji = new Godisnji();
                        
            ZaposlenikId = comboBoxZaposlenici.SelectedValue.ToString();
            int id = 0;
            if (int.TryParse(ZaposlenikId, out id))
            {
                IzracunajRapoloziviBrojDana();
                txtRaspoloziviBrojDana.Text = RaspoloziviBrojDana.ToString();
                dtpDatum.MinDate = DateTime.Today;
                dtpDatum.MaxDate = new DateTime(Godina, 12, 31);
            }
        }

        private void IzracunajRapoloziviBrojDana()
        {
            Godisnji godisnji = new Godisnji();
            ZaposlenikGodisnji zaposlenikGodisnji = new ZaposlenikGodisnji();
            Godina = 0;
            int novaGodina = 0;
            RaspoloziviBrojDana = 0;
            foreach (var item in zaposlenikGodisnji.DajListu())
            {
                if (item.ZaposlenikId == ZaposlenikId)
                {
                    novaGodina = int.Parse(item.Godina);
                    if (Godina < novaGodina)
                    {
                        Godina = novaGodina;
                        RaspoloziviBrojDana = int.Parse(item.BrojDana);
                        ZaposlenikGodisnjiId = item.Id;
                    }
                }
            }

            foreach (var lista in godisnji.DajListu(int.Parse(ZaposlenikId)))
            {
                RaspoloziviBrojDana -= int.Parse(lista.BrojDana);                
            }
        }
    }
}
