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
    public partial class frmIzvjestaj : Form
    {
        private static frmIzvjestaj _instance = null;
        private List<Tuple<string, Zaposlenik>> _lista;

        internal List<Tuple<string, Zaposlenik>> Lista { get => _lista; set => _lista = value; }

        private frmIzvjestaj()
        {
            InitializeComponent();
            Lista = new List<Tuple<string, Zaposlenik>>();
        }

        public static frmIzvjestaj Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmIzvjestaj();
                }
                return _instance;
            }
        }

        private void PostaviAlignHeader()
        {
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                                        Lista[i].Item2.Adresa,
                                        Lista[i].Item2.Oib,
                                        zaposlenik.DajNazivSpola(int.Parse(Lista[i].Item2.SpolId))
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
            PostaviAlignHeader();
            UcitajPodatke();
        }

        private void Pretrazi()
        {
            PostaviSveVidljivo();
            string trazeniText = Trimmer.TrimString(txtPretrazi.Text);
            if (!string.IsNullOrWhiteSpace(trazeniText))
            {
                bool pronadjen;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    pronadjen = false;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value.ToString() == trazeniText)
                        {
                            pronadjen = true;
                            break;
                        }
                    }
                    row.Visible = pronadjen;
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            Pretrazi();      
        }

        private void PostaviSveVidljivo()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrikazZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }

        private void txtPretrazi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pretrazi();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
