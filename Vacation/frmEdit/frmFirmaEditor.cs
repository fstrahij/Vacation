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
    public partial class frmFirmaEditor : Form
    {
        private int _id;
        private string _naziv, _zaposlenikId;
        private DateTime? _datumOd, _datumDo;

        public frmFirmaEditor(frmFirme pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText;
            Id = 0;
            Naziv = "";
            DatumOd = DateTime.Today;
            DatumDo = DateTime.Today.AddDays(1);
        }

        public int Id { get => _id; set => _id = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public DateTime? DatumOd { get => _datumOd; set => _datumOd = value; }
        public DateTime? DatumDo { get => _datumDo; set => _datumDo = value; }
        public string ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        private frmFirme Forma { get; set; }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value.AddDays(1);
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value.AddDays(1);
            dtpDatumDo.Value = dtpDatumDo.MinDate;
        }

        private void chbDatumDo_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumDo.Enabled = chbDatumDo.Checked;
        }

        private void frmFirmaEditor_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Naziv;
            if (DatumOd != null)
            {
                dtpDatumOd.Value = (DateTime) DatumOd;
            }
            if (DatumDo != null)
            {
                chbDatumDo.Checked = true;
                dtpDatumDo.Value = (DateTime) DatumDo;
            }
            else
            {
                dtpDatumDo.Value = DateTime.Today;
            }
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    DatumOd = dtpDatumOd.Value;
                    if (dtpDatumDo.Enabled)
                    {
                        DatumDo = dtpDatumDo.Value;
                    }
                    else
                    {
                        DatumDo = null;
                    }                    
                    Firma firma = new Firma(Id, ZaposlenikId, txtNaziv.Text, (DateTime) DatumOd, DatumDo);
                    firma.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
        }
    }
}
