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
    public partial class frmZaposlenikGodisnjiEditor : Form
    {
        private int _id;
        private string _godina, _brojDana, _zaposlenikId;

        public frmZaposlenikGodisnjiEditor(frmZaposlenikGodisnji pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox2.Text = pGbText;
            Id = 0;
            ZaposlenikId = Godina = BrojDana = "";
        }

        public int Id { get => _id; set => _id = value; }
        public string Godina { get => _godina; set => _godina = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        private string ZaposlenikId { get => _zaposlenikId; set => _zaposlenikId = value; }
        private frmZaposlenikGodisnji Forma { get; set; }

        private void frmZaposlenikGodisnjiEditor_Load(object sender, EventArgs e)
        {
            Zaposlenik zaposlenici = new Zaposlenik();
            comboBoxZaposlenici.DataSource = zaposlenici.DajListu();
            comboBoxZaposlenici.DisplayMember = "ImePrezime";
            comboBoxZaposlenici.ValueMember = "Id";
            comboBoxZaposlenici.SelectedItem = null;
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            DialogResult dr;
            if (!string.IsNullOrWhiteSpace(txtBrojDana.Text) && !string.IsNullOrWhiteSpace(ZaposlenikId))
            {
                dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ZaposlenikGodisnji zapGod = new ZaposlenikGodisnji( Id,
                                            ZaposlenikId,
                                            txtGodina.Text,
                                            txtBrojDana.Text
                        );
                    zapGod.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
            else
            {
                dr = MessageBox.Show("Neispravan unos u polje Broj dana ili nije odabran zaposlenik!");
            }
        }

        private void ZaposlenikSelected(object sender, EventArgs e)
        {
            ZaposlenikGodisnji zapGod = new ZaposlenikGodisnji();
            ZaposlenikId = comboBoxZaposlenici.SelectedValue.ToString();
            int id = 0;
            if (int.TryParse(ZaposlenikId, out id))
            {
                txtGodina.Text = zapGod.DajSljedecuGodinu(id);
                txtBrojDana.Text = zapGod.IzracunajBrojaDana(id);
            }
        }
    }
}
