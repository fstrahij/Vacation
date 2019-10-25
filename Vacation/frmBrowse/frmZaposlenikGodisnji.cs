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
    public partial class frmZaposlenikGodisnji : Form
    {
        public frmZaposlenikGodisnji()
        {
            InitializeComponent();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            ZaposlenikGodisnji zaposleniciGodisnji = new ZaposlenikGodisnji();
            Zaposlenik zaposlenik = new Zaposlenik();
            
            foreach (var lista in zaposleniciGodisnji.DajListu())
            {
                zaposlenik = zaposleniciGodisnji.Zaposlenici.DajListu().Find(x => x.Id == int.Parse(lista.ZaposlenikId));
                dataGridView1.Rows.Add(lista.Id,
                                        lista.ZaposlenikId,
                                        zaposlenik.Ime,
                                        zaposlenik.Prezime,
                                        zaposlenik.Adresa,
                                        zaposlenik.Oib,
                                        zaposlenik.DajNazivSpola(int.Parse(zaposlenik.SpolId)),
                                        lista.Godina,
                                        lista.BrojDana
                                        );
            }
            HasRows();  
        }

        private void HasRows()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = true;
            }
            else
            {
                btnDeaktivirajSve.Enabled = btnDeaktiviraj.Enabled = false;
            }
        }
        
        private void frmZaposlenikGodisnji_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ZaposlenikGodisnji zapGod = new ZaposlenikGodisnji(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                                                                    dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                                                    dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(),
                                                                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()
                                                                    );
                zapGod.Spremi();
            }
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new frmZaposlenikGodisnjiEditor(this, btnNovi.Text))
            {
                forma.ShowDialog();
            }
        }
        
        /*
private void NoviClick(object sender, EventArgs e)
{
using (var forma = new frmZaposlenikEditor(this, btnNovi.Text))
{
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
}*/
    }
}
