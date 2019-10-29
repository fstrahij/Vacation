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
    public partial class NeradniDaniForm : Form
    {
        private int _godina;

        private int Godina { get => _godina; set => _godina = value; }

        public NeradniDaniForm()
        {
            InitializeComponent();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            NeradniDan dan = new NeradniDan();
            TipNeradnihDana tip = new TipNeradnihDana();
            foreach (var lista in dan.DajListu(Godina))
            {
                dataGridView1.Rows.Add(lista.Id,
                                        lista.TipId,
                                        lista.Naziv,
                                        lista.Datum.ToString("dd.MM.yyyy."),
                                        tip.DajNazivTipa(lista.TipId)
                                        );
            }
            HasRows();
            PostaviBoju(tip);
        }

        private void PostaviBoju(TipNeradnihDana tip)
        {
            string boja = "";
            string id = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                id = row.Cells["TipId"].Value.ToString();
                boja = tip.DajBojuTipa(id);
                if (!string.IsNullOrWhiteSpace(boja))
                {
                    row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(boja);
                }
            }
        }

        public void UcitajGodine()
        {
            NeradniDan dan = new NeradniDan();
            comboBoxGodine.Items.Clear();
            foreach (var item in dan.DajGodine())
            {
                comboBoxGodine.Items.Add(item);
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

        private void NeradniDaniForm_Load(object sender, EventArgs e)
        {
            UcitajGodine();
            HasRows();
        }

        private void OdabirGodineSelected(object sender, EventArgs e)
        {
            Godina = int.Parse(comboBoxGodine.SelectedItem.ToString());
            UcitajPodatke();
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new frmNeradniDaniEditor(this, btnNovi.Text))
            {
                forma.ShowDialog();
            }
        }
        private void UrediClick(object sender, EventArgs e)
        {
            string format = "dd.MM.yyyy.";
            using (var forma = new frmNeradniDaniEditor(this, btnUredi.Text))
            {
                forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                forma.TipId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forma.Naziv = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forma.Datum = DateTime.ParseExact(dataGridView1.CurrentRow.Cells[3].Value.ToString(), format, null);
                forma.ShowDialog();
            }
        }
        private void DeaktivirajClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NeradniDan dan = new NeradniDan();
                dan.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dan.Deaktiviraj();
                UcitajGodine();
                UcitajPodatke();
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NeradniDan dan = new NeradniDan();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dan.Id = int.Parse(row.Cells[0].Value.ToString());
                    dan.Deaktiviraj();
                }
                UcitajGodine();
                UcitajPodatke();
            }
        }
    }
}
