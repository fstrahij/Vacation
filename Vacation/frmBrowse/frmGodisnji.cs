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
    public partial class frmGodisnji : Form
    {
        private int _zaposlenikID;

        public int ZaposlenikID { get => _zaposlenikID; set => _zaposlenikID = value; }

        public frmGodisnji()
        {
            InitializeComponent();
            PostaviAlignHeader();
        }

        private void PostaviAlignHeader()
        {
            for (int i = 3; i <= 8; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            Godisnji godisnji = new Godisnji();
            ZaposlenikGodisnji zaposleniciGodisnji = new ZaposlenikGodisnji();
            Zaposlenik zaposlenik = new Zaposlenik();
            zaposlenik = zaposleniciGodisnji.Zaposlenici.DajListu().Find(x => x.Id == ZaposlenikID);

            txtAdresa.Text = zaposlenik.Adresa;
            txtOib.Text = zaposlenik.Oib;
            txtSpol.Text = zaposlenik.DajNazivSpola(int.Parse(zaposlenik.SpolId));
            foreach (var lista in godisnji.DajListu(ZaposlenikID, 0))
            {               
                dataGridView1.Rows.Add(lista.Id,
                                        ZaposlenikID,
                                        lista.ZaposlenikGodisnjiId,
                                        lista.DatumOd.ToString("dd.MM.yyyy."),
                                        lista.DatumDo.ToString("dd.MM.yyyy."),
                                        lista.BrojDana,
                                        lista.OstaloNoviBrojDana,
                                        lista.OstaloStariBrojDana, 
                                        zaposleniciGodisnji.DajGodinu(int.Parse(lista.ZaposlenikGodisnjiId))
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

        private void frmGodisnji_Load(object sender, EventArgs e)
        {
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

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoviClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                using (var forma = new frmGodisnjiEditor(this, btnNovi.Text))
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
                using (var forma = new frmGodisnjiEditor(this, btnUredi.Text))
                {
                    int posljedniRed = dataGridView1.Rows.Count - 1;
                    forma.Id = int.Parse(dataGridView1.Rows[posljedniRed].Cells[0].Value.ToString());
                    forma.ZaposlenikId = ZaposlenikID;
                    forma.DatumOd = DateTime.Parse(dataGridView1.Rows[posljedniRed].Cells[3].Value.ToString());
                    forma.DatumDo = DateTime.Parse(dataGridView1.Rows[posljedniRed].Cells[4].Value.ToString());
                    forma.NoviGodisnji = int.Parse(dataGridView1.Rows[posljedniRed - 1].Cells[6].Value.ToString());
                    forma.StariGodisnji = int.Parse(dataGridView1.Rows[posljedniRed - 1].Cells[7].Value.ToString());
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
                    Godisnji godisnji = new Godisnji();
                    int posljedniRed = dataGridView1.Rows.Count - 1;
                    godisnji.Id = int.Parse(dataGridView1.Rows[posljedniRed].Cells[0].Value.ToString());
                    godisnji.Deaktiviraj();
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
                DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Godisnji godisnji = new Godisnji();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        godisnji.Id = int.Parse(row.Cells[0].Value.ToString());
                        godisnji.Deaktiviraj();
                    }
                    UcitajPodatke();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Nije odabran zaposlenik!");
            }
        }

    }
}
