using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacation
{
    public partial class TipEditor : Form
    {
        private int _id;
        private string _naziv, _boja;

        public TipEditor(TipoviNeradnihDanaForm pForma, string pGbText)
        {
            InitializeComponent();
            Forma = pForma;
            groupBox1.Text = pGbText;
        }

        public int Id { get => _id; set => _id = value; }
        public string Naziv { get => _naziv; set => _naziv = value; }
        public string Boja { get => _boja; set => _boja = value; }

        public TipoviNeradnihDanaForm Forma  { get; set; }

        private void TipEditor_Load(object sender, EventArgs e)
        {
            txtNaziv.Text = Naziv;
            txtBoja.Text = Boja;                     
        }

        private void SpremiClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    TipNeradnihDana tip = new TipNeradnihDana(Id, txtNaziv.Text, txtBoja.Text);
                    tip.Spremi();
                    Forma.UcitajPodatke();
                    this.Close();
                    
                }
            }
        }
    }
}
