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
    public partial class frmPrikazZaposlenika : Form
    {
        private List<Zaposlenik> _zaposlenici;

        private frmKalendar Forma { get; set; }
        internal List<Zaposlenik> Zaposlenici { get => _zaposlenici; set => _zaposlenici = value; }

        public frmPrikazZaposlenika(frmKalendar pForma, string pGbText)
        {
            InitializeComponent();
            groupBox1.Text = pGbText;
            Zaposlenici = new List<Zaposlenik>();
        }

        private void UcitajPodatke()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            for (int i = 0; i < Zaposlenici.Count; i++)
            {
                dataGridView1.Rows.Add(Zaposlenici[i].Ime,
                                        Zaposlenici[i].Prezime,
                                        zaposlenik.DajNazivSpola(int.Parse(Zaposlenici[i].SpolId)),
                                        Zaposlenici[i].Adresa,
                                        Zaposlenici[i].Oib
                                        );
                if ((i + 1) % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
                }
            }
        }

        private void frmPrikazZaposlenika_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
