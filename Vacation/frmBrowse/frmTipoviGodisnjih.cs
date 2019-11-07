using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacation.frmBrowse
{
    public partial class frmTipoviGodisnjih : Form
    {
        private static frmTipoviGodisnjih _instance = null;
        private frmTipoviGodisnjih()
        {
            InitializeComponent();
        }
        public static frmTipoviGodisnjih Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new frmTipoviGodisnjih();
                }
                return _instance;
            }
        }

        private void frmTipoviGodisnjih_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        public void UcitajPodatke()
        {
            dataGridView1.Rows.Clear();
            TipNeradnihDana tip = new TipNeradnihDana();
            foreach (var item in tip.DajListu())
            {
                dataGridView1.Rows.Add(
                                    item.Id,
                                    item.Naziv,
                                    item.Boja
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

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            _instance = null;
            this.Close();
        }

        /*private void NoviClick(object sender, EventArgs e)
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
        }*/
    }
}
