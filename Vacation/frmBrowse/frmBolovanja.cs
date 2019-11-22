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
    public partial class frmBolovanja : Form
    {
        private static frmBolovanja _instance = null;
        private int _zaposlenikID;

        public int ZaposlenikID { get => _zaposlenikID; set => _zaposlenikID = value; }

        private frmBolovanja()
        {
            InitializeComponent();
        }

        public static frmBolovanja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmBolovanja();
                }
                return _instance;
            }
        }


        private void frmBolovanja_Load(object sender, EventArgs e)
        {
            PostaviAlignHeader();
            Zaposlenik zaposlenik = new Zaposlenik();
            ZaposlenikGodisnji zaposleniciGodisnji = new ZaposlenikGodisnji();
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
            foreach (var item in zaposlenik.DajListu())
            {
                if (zaposleniciGodisnji.DajListu().FindIndex(x => x.ZaposlenikId == item.Id.ToString()) >= 0)
                {
                    zaposlenici.Add(item);
                }
            }
            comboBoxZaposlenici.DataSource = zaposlenici;
            comboBoxZaposlenici.DisplayMember = "ImePrezime";
            comboBoxZaposlenici.ValueMember = "Id";
            comboBoxZaposlenici.SelectedValue = 0;
        }

        private void ZaposlenikSelected(object sender, EventArgs e)
        {
            int zaposlenikId = 0;
            int.TryParse(comboBoxZaposlenici.SelectedValue.ToString(), out zaposlenikId);
            ZaposlenikID = zaposlenikId;
            UcitajPodatke();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            Bolovanje bolovanje = new Bolovanje();
            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik = zaposlenik.DajListu().Find(x => x.Id == ZaposlenikID);

            txtAdresa.Text = zaposlenik.Adresa;
            txtOib.Text = zaposlenik.Oib;
            txtSpol.Text = zaposlenik.DajNazivSpola(int.Parse(zaposlenik.SpolId));
            int ukupanBrojDana = 0;
            foreach (var lista in bolovanje.DajListu(ZaposlenikID, 0))
            {
                ukupanBrojDana += int.Parse(lista.BrojDana);
                dataGridView1.Rows.Add(lista.Id,
                                        lista.DatumOd.ToString("dd.MM.yyyy."),
                                        lista.DatumDo.ToString("dd.MM.yyyy."),
                                        lista.BrojDana,
                                        lista.Opis,
                                        ukupanBrojDana
                                        );
            }
            if (dataGridView1.Rows.Count > 0)
            {
                int posljednjiRed = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[0].Selected = false;
                dataGridView1.Rows[posljednjiRed].Selected = true;
            }
            HasRows();
        }

        private void PostaviAlignHeader()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void HasRows()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = btnUredi.Enabled = true;
            }
            else
            {
                btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = btnUredi.Enabled = false;
            }
        }

        private void NoviClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                using (var forma = new frmBolovanjaEditor(this, btnNovi.Text))
                {
                    forma.ZaposlenikId = ZaposlenikID;
                    forma.ShowDialog();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Nije odabran zaposlenik!");
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                using (var forma = new frmBolovanjaEditor(this, btnUredi.Text))
                {
                    forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    forma.ZaposlenikId = ZaposlenikID;
                    forma.DatumOd = DateTime.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    forma.DatumDo = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    forma.BrojDana = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    forma.Opis = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    forma.ShowDialog();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Nije odabran zaposlenik!");
            }
        }

        private void DeaktivirajClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Bolovanje bolovanje = new Bolovanje();
                    int posljedniRed = dataGridView1.Rows.Count - 1;
                    bolovanje.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    bolovanje.Deaktiviraj();
                    UcitajPodatke();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Nije odabran zaposlenik!");
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                DialogResult dr = MessageBox.Show("Jeste li sigurni da želite obrisati SVE?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Bolovanje bolovanje = new Bolovanje();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        bolovanje.Id = int.Parse(row.Cells[0].Value.ToString());
                        bolovanje.Deaktiviraj();
                    }
                    UcitajPodatke();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Nije odabran zaposlenik!");
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBolovanja_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
            GlavniMeni.Instance.PostaviListuOtvorenihProzora();
        }
    }
}
