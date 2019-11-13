using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.frmEdit;
using Vacation.modelScripts;

namespace Vacation.frmBrowse
{
    public partial class frmZaposlenici : Form
    {
        private static frmZaposlenici _instance = null;
        private frmZaposlenici()
        {
            InitializeComponent();
        }
        public static frmZaposlenici Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmZaposlenici();
                }
                return _instance;
            }
        }
        private void PostaviAlignHeader()
        {
           dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            Zaposlenik zaposlenici = new Zaposlenik();
            foreach (var lista in zaposlenici.DajListu())
            {
                dataGridView1.Rows.Add(lista.Id,
                                        lista.SpolId,
                                        lista.Ime,
                                        lista.Prezime,
                                        lista.Adresa,
                                        lista.Oib,
                                        zaposlenici.DajNazivSpola(int.Parse(lista.SpolId))
                                        );
            }
            HasRows();
        }

        private void HasRows()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnZaposlenja.Enabled = btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = btnUredi.Enabled = true;
            }
            else
            {
                btnZaposlenja.Enabled = btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = btnUredi.Enabled = false;
            }
        }

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            PostaviAlignHeader();
            UcitajPodatke();
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new frmZaposlenikEditor(this, btnNovi.Text))
            {                
                forma.ShowDialog();
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            using (var forma = new frmZaposlenikEditor(this, btnUredi.Text))
            {
                forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                forma.SpolId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forma.Ime = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forma.Prezime = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                forma.Adresa = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                forma.Oib = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                forma.ShowDialog();
            }
        }
        private void DeaktivirajClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Zaposlenik zaposlenik = new Zaposlenik();
                zaposlenik.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                zaposlenik.Deaktiviraj();
                UcitajPodatke();
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Zaposlenik zaposlenik = new Zaposlenik();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    zaposlenik.Id = int.Parse(row.Cells[0].Value.ToString());
                    zaposlenik.Deaktiviraj();
                }
                UcitajPodatke();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmZaposlenici_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }

        private void ZaposlenjaClick(object sender, EventArgs e)
        {
            frmFirme forma = frmFirme.Instance;
            forma.ZaposlenikID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            forma.MdiParent = GlavniMeni.Instance;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }
    }
}
