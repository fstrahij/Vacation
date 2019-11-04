﻿using System;
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
        }

        private void UrediClick(object sender, EventArgs e)
        {
            if (ZaposlenikID > 0)
            {
                using (var forma = new frmGodisnjiEditor(this, btnUredi.Text))
                {
                    forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    forma.ZaposlenikId = ZaposlenikID;
                    forma.DatumOd = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    forma.DatumDo = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    forma.NoviGodisnji = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index -1].Cells[6].Value.ToString());
                    forma.StariGodisnji = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[7].Value.ToString());
                    forma.ShowDialog();
                }
            }
        }
        /*
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
        }*/

    }
}
