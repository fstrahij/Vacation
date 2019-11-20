using System;
using System.Windows.Forms;
using Vacation.customScripts;
using Vacation.frmBrowse;
using Vacation.modelScripts;

namespace Vacation.frmEdit
{
    public partial class frmNeradniDaniEditor : Form
    {
        private int _id;
        private string _naziv, _tipId;
        private DateTime _datum;

        public frmNeradniDaniEditor(NeradniDaniForm pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText;
            Id = 0;
            Naziv = TipId = "";
            Datum = DateTime.Today;
        }

        public int Id { get => _id; set => _id = value; }
        public string TipId { get => _tipId; set => _tipId = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public DateTime Datum { get => _datum; set => _datum = value; }
        private NeradniDaniForm Forma { get; set; }

        private void frmNeradniDaniEditor_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Naziv;
            dtpDatum.Value = Datum;
            TipNeradnihDana tip = new TipNeradnihDana();
            comboBoxTip.DataSource = tip.DajListu();
            comboBoxTip.DisplayMember = "Naziv";
            comboBoxTip.ValueMember = "Id";
            comboBoxTip.SelectedValue = !string.IsNullOrWhiteSpace(TipId)? int.Parse(TipId.ToString()) : 0;
        }

        private void SetInputs()
        {
            string nullValue = "null";
            TipId = (comboBoxTip.SelectedIndex >= 0) ? comboBoxTip.SelectedValue.ToString() : nullValue;           
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                SetInputs();
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string naziv = Trimmer.TrimString(txtNaziv.Text);
                    NeradniDan dan = new NeradniDan(Id,
                                                    naziv,
                                                    dtpDatum.Value,
                                                    TipId
                                                    );
                    dan.Spremi();
                    Forma.UcitajGodine();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
        }
    }
}
