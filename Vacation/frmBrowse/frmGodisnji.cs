using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vacation.modelScripts;

namespace Vacation.frmBrowse
{
    public partial class frmGodisnji : Form
    {
        public frmGodisnji()
        {
            InitializeComponent();
        }

        public void UcitajPodatke(int pZaposlenikId)
        {
            dataGridView1.Rows.Clear();
            Godisnji godisnji = new Godisnji();
            ZaposlenikGodisnji zaposleniciGodisnji = new ZaposlenikGodisnji();
            Zaposlenik zaposlenik = new Zaposlenik();
            int preostaloDana = int.Parse(zaposleniciGodisnji.DajListu().Find(x => x.ZaposlenikId == pZaposlenikId.ToString()).BrojDana);

            foreach (var lista in godisnji.DajListu(pZaposlenikId))
            {
                preostaloDana -= int.Parse(lista.BrojDana);
                zaposlenik = zaposleniciGodisnji.Zaposlenici.DajListu().Find(x => x.Id == pZaposlenikId);
                dataGridView1.Rows.Add(lista.Id,
                                        pZaposlenikId,
                                        lista.ZaposlenikGodisnjiId,
                                        zaposlenik.Adresa,
                                        zaposlenik.Oib,
                                        zaposlenik.DajNazivSpola(int.Parse(zaposlenik.SpolId)),
                                        lista.DatumOd,
                                        lista.DatumDo,
                                        lista.BrojDana,
                                        preostaloDana,
                                        zaposleniciGodisnji.DajGodinu(int.Parse(lista.ZaposlenikGodisnjiId))
                                        );
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
            Zaposlenik zaposlenici = new Zaposlenik();
            string naziv = "";
            foreach (var item in zaposlenici.DajListu())
            {
                naziv = item.Ime + " " + item.Prezime;
                comboBoxZaposlenici.Items.Add(naziv);
                comboBoxZaposleniciId.Items.Add(item.Id);
            }
        }

        private void ZaposlenikSelected(object sender, EventArgs e)
        {
            int zaposlenikId = int.Parse(comboBoxZaposleniciId.Items[comboBoxZaposlenici.SelectedIndex].ToString());
            UcitajPodatke(zaposlenikId);
        }
    }
}
