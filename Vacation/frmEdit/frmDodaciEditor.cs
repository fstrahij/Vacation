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
    public partial class frmDodaciEditor : Form
    {
        private int _id;
        private string _naziv, _brojDana, _godinaPrava;
        public frmDodaciEditor(frmDodaci pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText; 
            Id = 0;
            Naziv = BrojDana = GodinaPrava = "";
        }

        public int Id { get => _id; set => _id = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string BrojDana { get => _brojDana; set => _brojDana = value; }
        public string GodinaPrava { get => _godinaPrava; set => _godinaPrava = value; }
        private frmDodaci Forma { get; set; }

        private void frmDodaciEditor_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Naziv;
            txtBrojDana.Text = BrojDana;
            txtGodinaPrava.Text = GodinaPrava;
        }


        private bool IsValidInputs()
        {
            if (!string.IsNullOrWhiteSpace(txtNaziv.Text)
                && !string.IsNullOrWhiteSpace(txtBrojDana.Text)
                && !string.IsNullOrWhiteSpace(txtGodinaPrava.Text))
            {
                return true;
            }
            return false;
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            DialogResult dr;
            if (IsValidInputs())
            {
                dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Dodatak dodatak = new Dodatak(Id,
                                                txtNaziv.Text,
                                                txtBrojDana.Text,
                                                txtGodinaPrava.Text
                                                );
                    dodatak.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
            else
            {
                string poruka = "Neispravan unos u polje Naziv, Broj dana ili Godina prava";
                dr = MessageBox.Show(poruka);
            }
        }
    }
}
