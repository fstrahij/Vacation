using System;
using System.Windows.Forms;

namespace Vacation.frmEdit
{
    public partial class frmTemplateEditor : Form
    {
        private int _id;
        private string _naziv, _dan, _mjesec, _tipId;

        public frmTemplateEditor(TemplateEditorForm pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText;
        }

        public int Id { get => _id; set => _id = value; }        
        public string TipId { get => _tipId; set => _tipId = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string Dan { get => _dan; set => _dan = value; }
        public string Mjesec { get => _mjesec; set => _mjesec = value; }
        private TemplateEditorForm Forma { get; set; }

        private void frmTemplateEditor_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Naziv;
            txtDan.Text = Dan;
            txtMjesec.Text = Mjesec;
            TipNeradnihDana tip = new TipNeradnihDana();
            comboBoxTip.DataSource = tip.DajListu();
            comboBoxTip.DisplayMember = "Naziv";
            comboBoxTip.ValueMember = "Id";
            comboBoxTip.SelectedValue = !string.IsNullOrWhiteSpace(TipId) ? int.Parse(TipId.ToString()) : 0;
        }

        private void SetInputs()
        {            
            string nullValue = "null";
            TipId = (comboBoxTip.SelectedIndex >= 0) ? comboBoxTip.SelectedValue.ToString() : nullValue;
            Dan= !string.IsNullOrEmpty(txtDan.Text) ? txtDan.Text : nullValue;
            Mjesec = !string.IsNullOrEmpty(txtMjesec.Text) ? txtMjesec.Text : nullValue;
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            DialogResult dr;
            if (!string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                SetInputs();
                dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {                                        
                    NeradaniDanTemplate template = new NeradaniDanTemplate(Id,  
                                                                            Dan,
                                                                            Mjesec,
                                                                            TipId,
                                                                            txtNaziv.Text
                                                                            );
                    template.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                }
            }
            else
            {
                dr = MessageBox.Show("Neispravan unos u polje Naziv");
            }
        }
    }
}
