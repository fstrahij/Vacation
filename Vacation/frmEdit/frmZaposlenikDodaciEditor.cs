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
    public partial class frmZaposlenikDodaciEditor : Form
    {
        private int  _zaposlenikId, _dodatakId;
        public frmZaposlenikDodaciEditor(frmZaposlenikDodaci pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText;
            ZaposlenikId = DodatakId = 0;
        }

        public int ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        public int DodatakId { get => _dodatakId; set => _dodatakId = value; }

        private void UcitajPodatke() 
        {
            Dodatak dodatak = new Dodatak();
            dodatak = dodatak.DajListu().Find(x => x.Id == DodatakId);
            txtBrojDana.Text = dodatak.BrojDana;
            txtGodinaPrava.Text = dodatak.GodinaPrava;
        }

        private void comboBoxDodatak_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dodatakId = 0;
            if (int.TryParse(comboBoxDodatak.SelectedValue.ToString(), out dodatakId))
            {
                DodatakId = dodatakId;
                UcitajPodatke();
            }
        }

        private frmZaposlenikDodaci Forma { get; set; }

        private void frmZaposlenikDodaciEditor_Load(object sender, EventArgs e)
        {
            Dodatak dodatak = new Dodatak();
            comboBoxDodatak.DataSource = dodatak.DajListu();
            comboBoxDodatak.DisplayMember = "Naziv";
            comboBoxDodatak.ValueMember = "Id";
            comboBoxDodatak.SelectedItem = null;
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            DialogResult dr;
            if (comboBoxDodatak.SelectedItem != null)
            {
                dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    Upit.SpremiZaposlenikDodaci(ZaposlenikId, DodatakId);
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
            else
            {
                dr = MessageBox.Show("Nije odabran dodatak!");
            }
        }
    }
}
