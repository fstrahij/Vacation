using System;
using System.Windows.Forms;
using Vacation.frmBrowse;
using Vacation.modelScripts;

namespace Vacation.frmEdit
{
    public partial class frmNeradniDaniEditor : Form
    {
        private int _id;
        private string _naziv, _datum, _tipId;


        public frmNeradniDaniEditor(NeradniDaniForm pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText;
            Id = 0;
            Naziv = Datum = TipId = "";
        }

        public int Id { get => _id; set => _id = value; }
        public string TipId { get => _tipId; set => _tipId = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string Datum { get => _datum; set => _datum = value; }
        private NeradniDaniForm Forma { get; set; }

        private void frmNeradniDaniEditor_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Naziv;
            TipNeradnihDana tip = new TipNeradnihDana();
            foreach (var item in tip.DajListu())
            {
                comboBoxTip.Items.Add(item.Naziv);
                if (!string.IsNullOrWhiteSpace(TipId) && item.Id == int.Parse(TipId))
                {
                    comboBoxTip.SelectedText = item.Naziv;
                }
            }
        }

        private void SetInputs()
        {
            string nullValue = "null";
            TipId = (comboBoxTip.SelectedIndex >= 0) ? (comboBoxTip.SelectedIndex + 1).ToString() : nullValue;
            Datum = !string.IsNullOrEmpty(dtpDatum.Value.ToString()) ? dtpDatum.Value.ToString("MM-dd-yyyy") : nullValue;            
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                SetInputs();
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    NeradniDan dan = new NeradniDan(Id,
                                                    txtNaziv.Text,
                                                    Datum,
                                                    TipId
                                                    );
                    dan.Spremi();
                    Forma.UcitajGodine();
                    this.Close();
                }
            }
        }
    }
}
