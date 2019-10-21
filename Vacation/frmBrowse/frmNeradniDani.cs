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

namespace Vacation
{
    public partial class NeradniDaniForm : Form
    {
        public NeradniDaniForm()
        {
            InitializeComponent();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            NeradniDan dan = new NeradniDan();
            TipNeradnihDana tip = new TipNeradnihDana();
            foreach (var lista in dan.DajListu())
            {
                dataGridView1.Rows.Add(lista.Id,
                                        TemplateId,
                                        lista.Naziv,
                                        lista.Datum,
                                        tip.DajNazivTipa(dan.TipId)
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

        private void NeradniDaniForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            NeradniDan dan = new NeradniDan();
            foreach (var item in dan.DajGodine())
            {
                comboBoxGodine.Items.Add(item);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new frmTemplateEditor(this, btnNovi.Text))
            {
                forma.Id = 0;
                forma.Naziv = forma.Dan = forma.Mjesec = forma.TipId = "";
                forma.ShowDialog();
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            using (var forma = new frmTemplateEditor(this, btnUredi.Text))
            {
                forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                forma.TipId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forma.Naziv = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forma.Dan = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                forma.Mjesec = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                forma.ShowDialog();
            }
        }

        private void DeaktivirajClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NeradaniDanTemplate template = new NeradaniDanTemplate();
                template.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                template.Deaktiviraj();
                UcitajPodatke();
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                NeradaniDanTemplate template = new NeradaniDanTemplate();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    template.Id = int.Parse(row.Cells[0].Value.ToString());
                    template.Deaktiviraj();
                }
                UcitajPodatke();
            }
        }*/
    }
}
