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
using Vacation.frmBrowse;
using Vacation.modelScripts;

namespace Vacation.frmEdit
{
    public partial class frmGodisnjiEditor : Form
    {
        private int _id, _raspoloziviBrojDana, _brojDana, _zaposlenikGodisnjiId, _godina;
        private string _datum, _zaposlenikId;

        public frmGodisnjiEditor(frmGodisnji pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox2.Text = pGbText;
            Id = BrojDana = 0;
            ZaposlenikId = Datum = "";            
        }

        public int Id { get => _id; set => _id = value; }
        public string Datum { get => _datum; set => _datum = value; }
        public int BrojDana { get => _brojDana; set => _brojDana = value; }
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
            comboBoxZaposlenici.SelectedValue = 0;        
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            PostaviGodinu();
            while (IsNeradniDan(dtpDatumOd.Value.Date))
            {
                dtpDatumOd.Value = dtpDatumOd.Value.AddDays(1);
            }
            dtpDatumDo.MinDate = dtpDatumOd.Value;
            dtpDatumDo.MaxDate = dtpDatumOd.MaxDate;
            dtpDatumDo.Value = dtpDatumOd.Value;
            IzracunajBrojDana();            
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            IzracunajBrojDana();
        }

        private bool ValidateInputs()
        {
            int brojDana = 0;
            if (!string.IsNullOrWhiteSpace(ZaposlenikId)
                && !string.IsNullOrWhiteSpace(txtBrojDana.Text)
                && int.TryParse(txtBrojDana.Text, out brojDana)
                && brojDana <= RaspoloziviBrojDana
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
                DateTime DatumDo = dtpDatumOd.Value.AddDays(int.Parse(txtBrojDana.Text));
                string FormatedDatumDo = DatumDo.Month +"-"+ DatumDo.Day +"-"+ DatumDo.Year;
                if (dr == DialogResult.Yes)
                {
                    Godisnji godisnji = new Godisnji(Id,
                                            ZaposlenikGodisnjiId.ToString(),
                                            dtpDatumOd.Value.Date.ToString("MM-dd-yyyy"),
                                            dtpDatumDo.Value.Date.ToString("MM-dd-yyyy"),
                                            txtBrojDana.Text
                        );
                    godisnji.Spremi();
                    Forma.UcitajPodatke(int.Parse(ZaposlenikId));
                    this.Close();
                }
            }
        }        

        private void txtBrojDana_TextChanged(object sender, EventArgs e)
        {
            int raspoloziviBrojDana = RaspoloziviBrojDana;
            raspoloziviBrojDana -= BrojDana; 
            txtRaspoloziviBrojDana.Text = raspoloziviBrojDana.ToString();
        }

        private void ZaposlenikSelected(object sender, EventArgs e)
        {
            ZaposlenikId = comboBoxZaposlenici.SelectedValue.ToString();
            IzracunajRapoloziviBrojDana();
            txtRaspoloziviBrojDana.Text = RaspoloziviBrojDana.ToString();
            PostaviGodinu();
            dtpDatumOd.Enabled = true;
            dtpDatumDo.Enabled = true;
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

            foreach (var lista in godisnji.DajListu(int.Parse(ZaposlenikId), Godina))
            {
                RaspoloziviBrojDana -= int.Parse(lista.BrojDana);
            }
        }

        private void IzracunajBrojDana()
        {
            BrojDana = 0;
            int raspoloziviBrojDana = RaspoloziviBrojDana;
            DateTime pocetniDatum = dtpDatumOd.Value;
            if (pocetniDatum.Date.CompareTo(dtpDatumDo.Value.Date) == 0 && BrojDana < raspoloziviBrojDana)
            {
                BrojDana = IsNeradniDan(pocetniDatum) ? 0 : 1;
            }
            else
            {
                while (pocetniDatum.Date.CompareTo(dtpDatumDo.Value.Date) < 0 && BrojDana < raspoloziviBrojDana)
                {
                    BrojDana = IsNeradniDan(pocetniDatum) ? BrojDana : BrojDana + 1;                    
                    pocetniDatum = pocetniDatum.AddDays(1);                    
                }
                
            }
            dtpDatumDo.Value = pocetniDatum.Date;
            txtBrojDana.Text = BrojDana.ToString();
        }

        private bool IsNeradniDan(DateTime pocetniDatum)
        {
            NeradniDan dani = new NeradniDan();
            DateTime dan = new DateTime();
            string format = "d.M.yyyy. H:mm:ss";
            foreach (var d in dani.DajListu(Godina))
            {
                dan = DateTime.ParseExact(d.Datum, format, null, DateTimeStyles.None);
                if (DateTime.Compare(pocetniDatum.Date, dan.Date) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void PostaviGodinu()
        {
            DateTime min = new DateTime(Godina, 1, 1);
            DateTime max = new DateTime(Godina, 12, 31);
            if (DateTime.Compare(min, dtpDatumOd.MaxDate) > 0)
            {
                dtpDatumOd.MaxDate = max;
                dtpDatumOd.MinDate = min;
            }
            else
            {
                dtpDatumOd.MinDate = min;
                dtpDatumOd.MaxDate = max;
            }
        }
    }
}
