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
            //int preostaloDana = int.Parse(zaposleniciGodisnji.DajListu().Find(x => x.ZaposlenikId == pZaposlenikId.ToString()).BrojDana);

            foreach (var lista in godisnji.DajListu(pZaposlenikId, 0))
            {
                //preostaloDana -= int.Parse(lista.BrojDana);
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
                                        //preostaloDana,
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
            
            UcitajPodatke(zaposlenikId);
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new frmGodisnjiEditor(this, btnNovi.Text))
            {
                forma.ShowDialog();
            }
        }
    }
}
