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
        private List<Tuple<string, Zaposlenik>> _lista;

        private frmKalendar Forma { get; set; }
        internal List<Tuple<string, Zaposlenik>> Lista { get => _lista; set => _lista = value; }

        public frmPrikazZaposlenika(frmKalendar pForma, string pGbText)
        {
            InitializeComponent();
            groupBox1.Text = pGbText;
            Lista = new List<Tuple<string, Zaposlenik>>();
        }

        private Color PostaviBoju(Color boja)
        {
            if (boja == Color.White)
            {
                return Color.Gainsboro;
            }
            else
            {
                return Color.White;
            }
        }

        private void UcitajPodatke()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            string datum = (Lista[0].Item1 != null) ? Lista[0].Item1 : "";
            Color boja = Color.White;
            for (int i = 0; i < Lista.Count; i++)
            {
                dataGridView1.Rows.Add(Lista[i].Item1,
                                        Lista[i].Item2.Ime,
                                        Lista[i].Item2.Prezime,
                                        zaposlenik.DajNazivSpola(int.Parse(Lista[i].Item2.SpolId)),
                                        Lista[i].Item2.Adresa,
                                        Lista[i].Item2.Oib
                                        );
                if (datum != Lista[i].Item1)
                {
                    datum = Lista[i].Item1;
                    boja = PostaviBoju(boja);
                }
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = boja;
            }
        }

        private void frmPrikazZaposlenika_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            UcitajPodatke();
            if (!string.IsNullOrWhiteSpace(txtPretrazi.Text))
            {
                bool pronadjen;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    pronadjen = false;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value.ToString() == txtPretrazi.Text)
                        {
                            pronadjen = true;
                            break;
                        }
                    }
                    row.Visible = pronadjen;
                }
            }
            
        }
    }
}
