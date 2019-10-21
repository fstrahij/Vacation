using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacation
{
    public partial class TipoviNeradnihDanaForm : Form
    {
        public TipoviNeradnihDanaForm()
        {
            InitializeComponent();
        }

        public void UcitajPodatke()
        {
            TipNeradnihDana tip = new TipNeradnihDana();
            BindingSource binding = new BindingSource();
            binding.DataSource = tip.DajListu();
            dataGridView1.DataSource = binding;
            dataGridView1.Columns[0].Visible = dataGridView1.Columns[3].Visible = false;
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

        private void TipoviNeradnihDanaForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void NoviClick(object sender, EventArgs e)
        {
            using (var forma = new TipEditor(this, btnNovi.Text))
            {
                forma.Id = 0;
                forma.Naziv = forma.Boja = "";
                forma.ShowDialog();
            }
        }

        private void UrediClick(object sender, EventArgs e)
        {
            using (var forma = new TipEditor(this, btnUredi.Text))
            {
                forma.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                forma.Naziv = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                forma.Boja = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                forma.ShowDialog();
            }
        }

        private void DeaktivirajClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                TipNeradnihDana tip = new TipNeradnihDana();
                tip.Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                tip.Deaktiviraj();
                UcitajPodatke();
            }
        }

        private void DeaktivirajSveClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Jeste li sigurni?", "Provjera", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                TipNeradnihDana tip = new TipNeradnihDana();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    tip.Id = int.Parse(row.Cells[0].Value.ToString());
                    tip.Deaktiviraj();
                }
                UcitajPodatke();
            }
        }

    }
}
