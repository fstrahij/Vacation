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
using Vacation.frmEdit;
using Vacation.modelScripts;

namespace Vacation.frmBrowse
{
    public partial class frmFirme : Form
    {
        private int _zaposlenikID;

        public int ZaposlenikID { get => _zaposlenikID; set => _zaposlenikID = value; }

        public frmFirme()
        {
            InitializeComponent();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            Firma firma = new Firma();            

            DatumParser.DanUkupno = DatumParser.MjesecUkupno = DatumParser.GodinaUkupno = 0;
            DateTime datumDo;
            foreach (var lista in firma.DajListu(ZaposlenikID))
            {
                datumDo = (lista.DatumDo != null) ? (DateTime)lista.DatumDo : DateTime.Today;
                DatumParser.Izracunaj(lista.DatumOd, datumDo);
                dataGridView1.Rows.Add(lista.Id,
                                        lista.Naziv,
                                        lista.DatumOd.ToString("dd.MM.yyyy."),
                                        datumDo.ToString("dd.MM.yyyy."),
                                        DatumParser.Godina,
                                        DatumParser.Mjesec,
                                        DatumParser.Dan,
                                        DatumParser.GodinaUkupno,
                                        DatumParser.MjesecUkupno,
                                        DatumParser.DanUkupno 
                                        );
            }
            PostaviPodatkeZaposlenika();
            HasRows();
        }

        private void PostaviPodatkeZaposlenika()
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik = zaposlenik.DajListu().Find(x => x.Id == ZaposlenikID);
            txtAdresa.Text = zaposlenik.Adresa;
            txtOib.Text = zaposlenik.Oib;
            txtSpol.Text = zaposlenik.DajNazivSpola(int.Parse(zaposlenik.SpolId));
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

        private void ZaposlenikSelected(object sender, EventArgs e)
        {
            int zaposlenikId = 0;
            if (int.TryParse(comboBoxZaposlenici.SelectedValue.ToString(), out zaposlenikId))
            {
                ZaposlenikID = zaposlenikId;
                UcitajPodatke();
            }            
        }        

        private void frmFirme_Load(object sender, EventArgs e)
        {
            Zaposlenik zaposlenik = new Zaposlenik();
            ZaposlenikGodisnji zaposleniciGodisnji = new ZaposlenikGodisnji();
            comboBoxZaposlenici.DataSource = zaposlenik.DajListu();
            comboBoxZaposlenici.DisplayMember = "ImePrezime";
            comboBoxZaposlenici.ValueMember = "Id";
        }

        private void NoviClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                using (var forma = new frmFirmaEditor(this, btnNovi.Text))
                {
                    forma.ZaposlenikId = ZaposlenikID.ToString();
                    forma.ShowDialog();
                }
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                using (var forma = new frmFirmaEditor(this, btnUredi.Text))
                {
                    forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    forma.ZaposlenikId = ZaposlenikID.ToString();
                    forma.Naziv = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    forma.DatumOd = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());

                    if (DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) < DateTime.Today)
                    {
                        forma.DatumDo = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    }
                    else
                    {
                        forma.DatumDo = null;
                    }
                    
                    forma.ShowDialog();
                }
            }
        }

        private void DeaktivirajClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Firma firma = new Firma();
                    firma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    firma.Deaktiviraj();
                    UcitajPodatke();
                }
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Firma firma = new Firma();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        firma.Id = int.Parse(row.Cells[0].Value.ToString());
                        firma.Deaktiviraj();
                    }
                    UcitajPodatke();
                }
            }
        }

        private void ZatvoriClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
